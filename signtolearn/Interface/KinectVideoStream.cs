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
        KinectSensor kinectSensor = null;
        String UserName;

        public KinectVideoStream(String username,Boolean Training)
        {
            InitializeComponent();
            PopulateAvailableSensors();
            Start();
            UserName = username;

            if (Training)
            {
                Train();
            }
            else
            {
                //testingStart
            }
        }


        private void Train()
        {
            this.LabelLetter.Text = String.Format("{0}",DAL.User.GetProgress(UserName));
            this.Text = "Training";

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
            this.Close();
        }
    }
}