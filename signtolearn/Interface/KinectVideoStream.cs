using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using HandSigns;

namespace Interface
{
    public partial class KinectVideoStream : Form
    {      
        String UserName;

        int WaitTime = 3000; // 3 seconds by default
        char currentLetter;
        int currentLetterProgress = 0; //Letter needs to be signed 10 times.

        KinectSensor kinectSensor = null;
        Timer timer = new Timer();
        AreaGrab AG;

        public KinectVideoStream(String username,Boolean Training)
        {
            InitializeComponent();
            PopulateAvailableSensors();
            Start();
            UserName = username;
           
            if (Training)
            {
                currentLetter = DAL.User.GetProgress(UserName);
                currentLetterProgress = DAL.Sign.GetSignInfo(UserName, currentLetter).Count;
                Train();
            }
            else
            {
                //testingStart
            }
        }


        private void Train()
        {
            char CurrentLetter = DAL.User.GetProgress(UserName);
            this.LabelLetter.Text = String.Format("{0}",CurrentLetter);
            this.Text = "Training";
            AG = new AreaGrab(UserName, CurrentLetter);
            AG.Start();

            while (AG.IsRunning)
            {

                if (AG.ReadyForSign)
                {
                    timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
                    timer.Interval = (WaitTime) * (1);              // Timer will tick evert second
                    timer.Enabled = true;                       // Enable the timer
                    timer.Start();           
                    this.UserInstruction.Text = String.Format("Ready for sign, capturing in {0} seconds", WaitTime);    
                }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.UserInstruction.Text = "Sign Captured";
            DialogResult dialogResult = MessageBox.Show("Store this sign?", "Sign Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DAL.Sign.AddSign(AG.getSign());
                currentLetterProgress++;
                if (currentLetterProgress >= 10) //checks if the current letter is complete
                {
                    if (currentLetter == 'Z')
                    {
                        MessageBox.Show("Training Complete!");
                        AG.Stop();
                        this.Close();
                    }
                    else
                    {
                        currentLetter++;
                        DAL.User.SetProgress(UserName, currentLetter);
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                timer.Start();
            }
            
            

        }
        private void PopulateAvailableSensors()
        {
            foreach (KinectSensor sensor in KinectSensor.KinectSensors)
            {
                kinectSensor = sensor;
            }
        }

        private void Start()
        {
            string sensorID = kinectSensor.UniqueKinectId.ToString();
            SetupSensorVideoInput();
        }

        private void SetupSensorVideoInput()
        {
            if (kinectSensor != null)
            {
                ColorImageFormat imageFormat = ColorImageFormat.RgbResolution640x480Fps30;
                kinectSensor.ColorStream.Enable(imageFormat);

                kinectSensor.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(kinectSensor_ColorFrameReady);
                kinectSensor.Start();
            }
        }

        private void DeActivateSensor()
        {
            if (kinectSensor != null)
            {
                kinectSensor.Stop();
                kinectSensor.ColorFrameReady -= new EventHandler<ColorImageFrameReadyEventArgs>(kinectSensor_ColorFrameReady);
                kinectSensor.Dispose();
            }
        }

        private void kinectSensor_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            ColorImageFrame colorFrame = e.OpenColorImageFrame();

            if (colorFrame == null)
            {
                return;
            }

            Bitmap bmpFrame = ColorImageFrameToBitmap(colorFrame);

            picVideoDisplay.Image = bmpFrame;
        }

        private static Bitmap ColorImageFrameToBitmap(ColorImageFrame colorFrame)
        {
            byte[] pixelBuffer = new byte[colorFrame.PixelDataLength];
            colorFrame.CopyPixelDataTo(pixelBuffer);

            Bitmap bitmapFrame = new Bitmap(colorFrame.Width, colorFrame.Height, PixelFormat.Format32bppRgb);
            BitmapData bitmapData = bitmapFrame.LockBits(new Rectangle(0, 0, colorFrame.Width, colorFrame.Height), ImageLockMode.WriteOnly, bitmapFrame.PixelFormat);

            IntPtr intPointer = bitmapData.Scan0;
            Marshal.Copy(pixelBuffer, 0, intPointer, colorFrame.PixelDataLength);

            bitmapFrame.UnlockBits(bitmapData);

            return bitmapFrame;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            DeActivateSensor();
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            AG.Stop();
            this.Close();
        }
    }
}