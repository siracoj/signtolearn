//NUI Imports
using CCT.NUI.Core;
using CCT.NUI.HandTracking;
using CCT.NUI.KinectSDK;

//Solution Imports
using DAL;

//System Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandSigns
{

    class AreaGrab{
        //Properties 
        int numFingers;
        float signPercentage;
        float signArea;
        float signDistance;

        private char CurrentLetter;
        private String UserName;

        private float openHandArea = -1;
        private float openHandDistance;
        private IDataSourceFactory dataSourceFactory;
        private HandDataSource handDataSource;
        

        public void Start(String username, char currentletter)
        {
            UserName = username;
            CurrentLetter = currentletter;
            dataSourceFactory = new SDKDataSourceFactory();
            handDataSource = new HandDataSource(dataSourceFactory.CreateShapeDataSource(), new HandDataSourceSettings());

            //Handles the new data from the kinect
            handDataSource.NewDataAvailable += new NewDataHandler<HandCollection>(handDataSource_NewDataAvailable);
            handDataSource.Start();
            
        }

        public SignInfo getSign()
        {
            return new SignInfo(CurrentLetter, UserName, signPercentage, numFingers, signDistance, signArea);
        }

        public void Stop()
        {
            handDataSource.Stop();
            handDataSource.Dispose();
        }

        private void handDataSource_NewDataAvailable(HandCollection data)
        {

            for (int index = 0; index < data.Count; index++)
            {
                if(openHandArea == -1){
                    var hand = data.Hands[index];
                    IList<Point> points = hand.Contour.Points;
                    if (hand.FingerCount == 5)
                    { //Takes the area of an open hand(when five fingers are detected)
                        openHandArea = boundingBoxArea(points);
                    }
                }
                else
                {
                    
                }
            }
        }
        private float handArea(IList<Point> points) // Takes the points of the contour of the hand and finds its area
        {
            float area = 0;
            int j = points.Count - 1;
            for (int i = 0; i < points.Count; i++){
                area = area + (points[j].X + points[i].X) * (points[j].Y + points[i].Y);
                j = i;
            }
            return area / 2;
        }

        private float boundingBoxArea(IList<Point> points) //Gets the square around the users hand 
        {
            Point minX = points[0], minY = points[0], maxX = points[0], maxY = points[0];
            IList<Point> square = new List<Point>();

            for (int i = 1; i < points.Count; i++)
            {
                if (points[i].X < maxX.X)
                {
                    maxX = points[i];
                }
                if (points[i].X > minX.X)
                {
                    minX = points[i];
                }
                if (points[i].Y < maxY.Y)
                {
                    maxY = points[i];
                }
                if (points[i].Y > minY.Y)
                {
                    minY = points[i];
                }
            }
            square.Add(maxX);
            square.Add(maxY);
            square.Add(minX);
            square.Add(minY);

            return handArea(square);
        }
    }
}
