using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        
        Thread t = null;

        // This delegate enables asynchronous calls for setting 
        // the text property on a TextBox control. 
        delegate void SetTextCallback(string text);

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
                t = new Thread(() => Train());
                t.Start();
                
             
            }
            else
            {
                //testingStart
            }
            
        }


        private void Train()
        {
            bool running = true;

            char CurrentLetter = DAL.User.GetProgress(UserName);
            SetTextLetter(String.Format("{0}",CurrentLetter));
            SetTitle("Training");

            AreaGrab AG = new AreaGrab(UserName, CurrentLetter);
            AG.Start();

            while (running)
            {
                if (AG.ReadyForSign)
                {
                            
                    SetTextInstruction(String.Format("Ready for sign, capturing in {0} seconds", WaitTime/1000));
                    Thread.Sleep(WaitTime);
                    CaptureSign(AG);
                    AG.Start();
                }
            }
             
        }
        private void CaptureSign(AreaGrab AG)
        {

            SetTextInstruction("Sign Captured");
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
            SetTextInstruction("Hold up an open hand in front of the kinect");
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

        private void SetTextInstruction(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.UserInstruction.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextInstruction);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.UserInstruction.Text = text;
            }
        }

        private void SetTextLetter(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.UserInstruction.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextLetter);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.LabelLetter.Text = text;
            }
        }

        private void SetTitle(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.UserInstruction.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTitle);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.Text = text;
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            try
            {t.Abort();}
            catch { }
            DeActivateSensor();
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}