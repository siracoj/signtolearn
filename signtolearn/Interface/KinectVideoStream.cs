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

using DAL;
using HandSigns;

namespace Interface
{
    public partial class KinectVideoStream : Form
    {      
        String UserName;
        char CurrentLetter;

        int WaitTime = 3000; // 3 seconds by default
        
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
                t = new Thread(() => Train());
                t.Start();
            }
            else
            {
                t = new Thread(() => Test());
                t.Start();
            }
            
        }
        private void Test()
        {
            char CurrentLetter = GetTestLetter();
            SetTextLetter(Char.ToString(CurrentLetter));
            SetTitle("Testing");

            AreaGrab AG = new AreaGrab(UserName, CurrentLetter);
            AG.Start();

            while (true)
            {
                if (AG.ReadyForSign)
                {
                    SetTextInstruction(String.Format("Ready for sign, capturing in {0} seconds", WaitTime / 1000));
                    Thread.Sleep(WaitTime);
                    TestSign(AG, CurrentLetter);
                }
            }
        }

        private void TestSign(AreaGrab AG, char CurrentLetter)
        {
            SignInfo sign = AG.getSign();
            SetTextInstruction("Sign Captured");

            if (sign.CheckSign())
            {
                MessageBox.Show("Correct!");
                Sign.AddSign(sign);          //adds correct signs to make it more accurate
            }
            else
            {
                MessageBox.Show("Incorrect");
            }


            SetTextInstruction("Hold up an open hand in front of the kinect");
        }

        private void Train()
        {  
            this.CurrentLetter =   User.GetProgress(UserName);
            SetTextLetter(Char.ToString(this.CurrentLetter));

            int currentLetterProgress =   Sign.GetSignInfo(UserName, this.CurrentLetter).Count;
            SetTitle("Training");

            AreaGrab AG = new AreaGrab(UserName, this.CurrentLetter);
            AG.Start();

            while (true)
            {
                if (AG.ReadyForSign)
                {
                    SetTextInstruction(String.Format("Ready for sign, capturing in {0} seconds", WaitTime/1000));
                    Thread.Sleep(WaitTime);
                    CaptureSign(AG, currentLetterProgress);

                }
            }
             
        }
        private void CaptureSign(AreaGrab AG, int currentLetterProgress)
        {
            SignInfo sign = AG.getSign();
            SetTextInstruction("Sign Captured");
            DialogResult dialogResult = MessageBox.Show("Store this sign?", "Sign Validation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Sign.AddSign(sign);
                currentLetterProgress++;
                if (currentLetterProgress >= 10) //checks if the current letter is complete
                {
                    if (this.CurrentLetter == 'Z')
                    {
                        MessageBox.Show("Training Complete!"); //ends training at Z
                        AG.reset();
                        this.Close();
                    }
                    else
                    {
                        this.CurrentLetter++;
                        User.SetProgress(UserName, this.CurrentLetter); //Updates user progress
                        SetTextLetter(Char.ToString(this.CurrentLetter));
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
            colorFrame.Dispose();

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

        private char GetTestLetter()
        {
            Random random = new Random();
            // This method returns a random lowercase letter
            // ... Between 'a' and 'z' inclusize.
            int num = random.Next(0, 26); // Zero to 25
            char let = (char)('A' + num);
            return let;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            DeActivateSensor();
        }

        private void buttonSaveExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}