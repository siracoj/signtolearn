using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xn;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.CvEnum;
using System.Threading;

namespace HandContourRecognition
{
    class DepthImageAnalyser
    {
        private static float convexAverage = 0.0025f;        

        /// <summary>
        /// Calculates Histomgram for Depth Map recevied from Kienct
        /// </summary>
        /// <param name="depthMD"></param>
        /// <param name="histogram"></param>
        /// <param name="handPoint"></param>
        public static unsafe void CalculateNIHistogram(DepthMetaData depthMD, ref int [] histogram, Point3D handPoint)
		{            			
			for (int i = 0; i < histogram.Length; ++i)
				histogram[i] = 0;

			ushort* pDepth = (ushort*)depthMD.DepthMapPtr.ToPointer();

			int points = 0;
            for (int y = 0; y < depthMD.YRes; ++y)
            {
                for (int x = 0; x < depthMD.XRes; ++x, ++pDepth)
                {
                    ushort depthVal = *pDepth;
                    if (depthVal != 0)
                    {
                        histogram[depthVal]++;
                        points++;
                    }
                }
            }          

            for (int i = 1; i < histogram.Length; i++)
            {
                histogram[i] += histogram[i - 1];
            }

			if (points > 0)
			{
				for (int i = 1; i < histogram.Length; i++)
				{
					histogram[i] = (int)(256 * (1.0f - (histogram[i] / (float)points)));
				}
			}
		}               

        /// <summary>
        /// Draws rectangle for founded fingertips
        /// </summary>
        /// <param name="skin">Image in gray mode</param>
        /// <param name="im">Original Image</param>
        /// <returns></returns>
        public static unsafe Image<Rgb, byte> DrawFingertipRectangles(Image<Gray, Byte> skin, Image<Rgb, Byte> im)
        {           
            try
            {
                Contour<Point> c;

                using (MemStorage storage = new MemStorage())
                {
                    Contour<Point> hNext = skin.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_LIST, storage);                    

                    Contour<Point> contour2 = null;
                    double area = 0.0;
                    double num2 = 0.0;
                    while (hNext != null)
                    {                        
                        area = hNext.Area;
                        if (area > num2)
                        {
                            num2 = area;
                            contour2 = hNext;
                        }
                        hNext = hNext.HNext;
                    }

                    if (contour2 != null)
                    {                        
                        c = contour2.ApproxPoly(contour2.Perimeter * convexAverage, storage);
                        im.Draw(c, new Rgb(Color.LimeGreen), 2);                       
                        Seq<Point> hull = c.GetConvexHull(ORIENTATION.CV_CLOCKWISE);                                         
                        foreach (Point p in hull.ToArray())
                        {
                            FilterBySiblingPoints(im, p);                            
                        }                        
                    }

                    return im;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// Filter contour points, based on count of hand points in the point`s rectangle
        /// </summary>
        /// <param name="image">Image to work on</param>
        /// <param name="p">Hand countour point</param>
        public static unsafe void FilterBySiblingPoints(Image<Rgb, Byte> image, Point p)
        {                              
            int sqareEdgeLength = 20;
            int handPointsCount = 0;
            int notHandPointsCount = 0;

            for (int i = -sqareEdgeLength; i <= sqareEdgeLength; i++)
            {
                for (int j = -sqareEdgeLength; j <= sqareEdgeLength; j++)
                {
                    if (p.X + i >= 0 && p.X + i <= image.Width &&
                        p.Y + j >= 0 && p.Y + j <= image.Height)
                    {

                        if (image[new Point(p.X + i, p.Y + j)].Green < 80)
                        {
                            notHandPointsCount++;
                        }
                        else
                        {
                            handPointsCount++;
                        }
                    }
                }
            }

            if (handPointsCount < notHandPointsCount * 0.4)
            {
                //CircleF circle = new CircleF(p, sqareEdgeLength);
                //image.Draw(circle, new Rgb(250, 0, 0), 1);
                Rectangle rec = new Rectangle(p.X - sqareEdgeLength, p.Y - sqareEdgeLength, 2 * sqareEdgeLength, 2 * sqareEdgeLength);
                image.Draw(rec, new Rgb(250, 0, 0), 1);
            }
        }
    }
}