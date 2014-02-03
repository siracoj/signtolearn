using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xn;
using System.Threading;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Imaging;
using HandContourRecognition.Enumes;
using xnv;
using HandContourRecognition.UserControls;
using Emgu.CV.Features2D;

namespace HandContourRecognition
{
    public partial class frmMain : Form
    {
        #region Private Members

        private Context senssorContext;

        private DepthGenerator depthGenerator;
        private ImageGenerator imageGenerator;        

        private ImageMetaData imageMetadata;
        private DepthMetaData depthMetadata;

        private SessionManager sessionManager;

        BackgroundWorker renderer;

        PointControl handPointTracker;
        int [] histogram = null;
        Point3D handPoint = new Point3D(0, 0, 0);
        Image<Rgb, Byte> im;

        #endregion

        #region Form Events

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            if (senssorContext != null)
            {
                if (renderer != null)
                {
                    renderer.CancelAsync();
                }
            }

            RendererProperties properties = new RendererProperties();
            properties.ImageMode = ucRecognitionOptions.ImageMode;
            properties.HistogramMode = ucRecognitionOptions.HistogramMode;

            renderer = new BackgroundWorker();
            renderer.WorkerSupportsCancellation = true;
            renderer.WorkerReportsProgress = true;
            renderer.DoWork += new DoWorkEventHandler(renderer_DoWork);
            renderer.ProgressChanged += new ProgressChangedEventHandler(renderer_ProgressChanged);
            renderer.RunWorkerAsync(properties);
        }          

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (renderer != null)
            {
                renderer.CancelAsync();
            }
            if (senssorContext != null)
            {
                senssorContext.Shutdown();
            }
        }

        #endregion

        Point3D prgsPoint;

        #region Image Creators

        void renderer_DoWork(object sender, DoWorkEventArgs e)
        {
            senssorContext = new Context(Properties.Settings.Default.SenssorConfigFileLocation);
            sessionManager = new xnv.SessionManager(senssorContext, "Wave", "RaiseHand");
            sessionManager.SessionStart += new SessionManager.SessionStartHandler(sessionManager_SessionStart);
            //sessionManager.SessionFocusProgress += new SessionManager.SessionFocusProgressHandler(sessionManager_SessionFocusProgress);

            handPointTracker = new HandPointTracker();
            handPointTracker.PointUpdate += new PointControl.PointUpdateHandler(handPointTracker_PointUpdate);
            sessionManager.AddListener(handPointTracker);
            ImageMode rendererType = ImageMode.Depth;

            switch (((RendererProperties)(e.Argument)).ImageMode)
            {
                case ImageMode.Depth:
                    depthGenerator = senssorContext.FindExistingNode(NodeType.Depth) as DepthGenerator;
                    histogram = new int[depthGenerator.GetDeviceMaxDepth()];
                    rendererType = ImageMode.Depth;
                    break;
                case ImageMode.RGB:
                    imageGenerator = senssorContext.FindExistingNode(NodeType.Image) as ImageGenerator;
                    //depthGenerator = senssorContext.FindExistingNode(NodeType.Depth) as DepthGenerator;                        
                    rendererType = ImageMode.RGB;
                    break;
            }

            
            while (!e.Cancel)
            {                
                switch (rendererType)
                {
                    case ImageMode.Depth :
                        RenderDepthImage();
                        break;
                    case ImageMode.RGB:
                        RenderRGBImage();
                        break;
                }
            }
        }

        void renderer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            RendererProgress progress = (RendererProgress)e.UserState;
            handPoint = depthGenerator.ConvertRealWorldToProjective(new Point3D(progress.X, progress.Y, progress.Z));
            lblHandPointX.Text = progress.X.ToString();
            lblHandPointY.Text = progress.Y.ToString();
            lblHandPointZ.Text = progress.Z.ToString();            
        }  

        private void RenderDepthImage()
        {
            senssorContext.WaitAndUpdateAll();            
            depthMetadata = depthGenerator.GetMetaData();
            sessionManager.Update(senssorContext);            
            Bitmap bmp = ConstractImage(depthMetadata);           
            im = new Image<Rgb, Byte>(bmp);
            if (handPoint.Z > 0)
            {
                im.DrawPolyline(new Point[] { new Point((int)handPoint.X, (int)handPoint.Y) }, true, new Rgb(0, 250, 250), 5);
                Image<Gray, Byte> grayFrame = im.Convert<Gray, Byte>();
                //Image<Gray, Byte> cannyFrame = grayFrame.Canny(new Gray(30), new Gray(25));
                IImage img = DepthImageAnalyser.DrawFingertipRectangles(grayFrame, im);
                imageViewer.Image = img;

            }
        }

        private void RenderRGBImage()
        {
            senssorContext.WaitAndUpdateAll();
            imageMetadata = imageGenerator.GetMetaData();
            sessionManager.Update(senssorContext);                   
            Bitmap bmp = ConstractImage(imageMetadata);            
            Image<Rgb, Byte> im = new Image<Rgb, Byte>(bmp);
            Image<Gray, Byte> grayFrame = im.Convert<Gray, Byte>();
            Image<Gray, Byte> cannyFrame = grayFrame.Canny(new Gray(80), new Gray(25));
            imageViewer.Image = cannyFrame;
        }    
       
        #endregion

        #region Constract Image

        private unsafe Bitmap ConstractImage(DepthMetaData depthMetadata)
        {
            Bitmap bmp = new Bitmap(depthMetadata.XRes, depthMetadata.YRes, System.Drawing.Imaging.PixelFormat.Format24bppRgb);            

            DepthImageAnalyser.CalculateNIHistogram(depthMetadata, ref histogram, handPoint);            
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            ushort* senssorImagePtr = (ushort*)depthMetadata.DepthMapPtr.ToPointer();

            byte* bmpImagePtr = (byte*)bmpData.Scan0;
            ushort maxDepthValue = depthGenerator.GetDeviceMaxDepth();

            if (handPoint.Z > 0)
            {
 
            }
            
            int k = 0;
            ushort handPointDistance = 0;

            if (handPoint.Z > 0)
            {
                handPointDistance = senssorImagePtr[(int)(handPoint.X * depthMetadata.XRes + handPoint.Y)];                
            }

            for (int j = 0; j < depthMetadata.YRes; j++) 
            {
                for (int i = 0; i < depthMetadata.XRes; i++)
                {
                    int pixelValue = (int)(*senssorImagePtr);                                        

                    if (handPoint.Z > 0)
                    {
                        if (pixelValue > handPoint.Z - 50 && pixelValue < handPoint.Z + 50
                            && i > handPoint.X - 150 && i < handPoint.X + 150
                            && j > handPoint.Y - 150 && j < handPoint.Y + 150)
                        {
                            bmpImagePtr[k + 1] = 100;
                        }
                        else
                        {
                            bmpImagePtr[k + 1] = 0;
                        }
                        bmpImagePtr[k] = 0;
                        bmpImagePtr[k + 2] = 0;
                    }                  
                    k += 3;
                    senssorImagePtr++;
                }
            }

            bmp.UnlockBits(bmpData);            

            return bmp;
        }

        private unsafe Bitmap ConstractImage(ImageMetaData imageMetadata)
        {
            Bitmap bmp = new Bitmap(imageMetadata.XRes, imageMetadata.YRes, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            byte * senssorImagePtr = (byte*)imageMetadata.ImageMapPtr.ToPointer();
            
            byte* bmpImagePtr = (byte*)bmpData.Scan0;            

            int j = 0;
            int k = 0;
            for (int i = 0; i < 3 * imageMetadata.XRes * imageMetadata.YRes-2; i+=3)
            {
                bmpImagePtr[i] = senssorImagePtr[i+2];
                bmpImagePtr[i+1] = senssorImagePtr[i+1];
                bmpImagePtr[i+2] = senssorImagePtr[i];
            }

            bmp.UnlockBits(bmpData);                       
            return bmp;
        }        

        #endregion

        #region Session Manager

        void sessionManager_SessionStart(ref xn.Point3D position)
        {
            RendererProgress progress = new RendererProgress();
            progress.X = position.X;
            progress.Y = position.Y;
            progress.Z = position.Z;

            if (renderer != null)
            {
                renderer.ReportProgress(0, progress);
            }            
        }

        void handPointTracker_PointUpdate(ref HandPointContext context)
        {

            prgsPoint = context.ptPosition;

            RendererProgress progress = new RendererProgress();
            progress.X = context.ptPosition.X;
            progress.Y = context.ptPosition.Y;
            progress.Z = context.ptPosition.Z;

            if (renderer != null)
            {
                renderer.ReportProgress(0, progress);
            }             
        }     

        #endregion        
    }
}
