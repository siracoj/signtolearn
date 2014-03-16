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

    public class AreaGrab{
        public bool ReadyForSign = false;
        public bool IsRunning = false;

        //Properties 
        private char CurrentLetter;
        private String UserName;

        private float openHandArea = -1;
        private float openHandDistance = -1;
        private IDataSourceFactory dataSourceFactory;
        private HandDataSource handDataSource;
        private HandData hand;

        public AreaGrab(string _UserName, char _CurrentLetter)
        {
            UserName = _UserName;
            CurrentLetter = _CurrentLetter;
            dataSourceFactory = new SDKDataSourceFactory();
            handDataSource = new HandDataSource(dataSourceFactory.CreateShapeDataSource(), new HandDataSourceSettings());
        }
        
        public void Start()
        {
            //Handles the new data from the kinect
            handDataSource.NewDataAvailable += new NewDataHandler<HandCollection>(handDataSource_NewDataAvailable);
            handDataSource.Start();
            IsRunning = true;
        }

        public SignInfo getSign() // gets the sign
        {
            if (ReadyForSign)
            {
                this.Stop(); // Pause datastream while getting these numbers

                float signArea = handArea();
                float signDistance = ClosestPoint() - openHandDistance;
                int numFingers = hand.FingerCount;
                float signPercentage = signArea / openHandArea;

                this.reset(); // reset and restart
                
                return new SignInfo(CurrentLetter, UserName, signPercentage, numFingers, signDistance, signArea);
            }
            else //Don't try to get the sign data until the ready flag is true
            {
                return null;
            }
        }

        private void handDataSource_NewDataAvailable(HandCollection data)
        {

            for (int index = 0; index < data.Count; index++)
            {
                if(!ReadyForSign){
                    hand = data.Hands[index];
                    if (hand.FingerCount == 5)
                    { //Takes the area of an open hand(when five fingers are detected)
                        openHandArea = handArea();
                        openHandDistance = ClosestPoint();
                        ReadyForSign = true;
                    }
                }
            }
        }

        private float handArea() // Takes the points of the contour of the hand and finds its area
        {
            IList<Point> points = hand.Contour.Points;
            float area = 0;
            int j = points.Count - 1;
            for (int i = 0; i < points.Count; i++){
                area = area + (points[j].X + points[i].X) * (points[j].Y + points[i].Y);
                j = i;
            }
            return area / 2;
        }

        private float ClosestPoint()
        {
            IList<Point> points = hand.Contour.Points;
            float closest = points[0].Z;

            foreach (Point point in points)
            {
                if (closest > point.Z)
                {
                    closest = point.Z;
                }
            }

            return closest;
        }

        public void reset()
        {
            openHandArea = -1;
            openHandDistance = -1;
            ReadyForSign = false;
        }

        public void Stop()
        {
            IsRunning = false;
            ReadyForSign = false;
            handDataSource.Stop();
        }

        /*private float boundingBoxArea() //Gets the square around the users hand 
        {
            IList<Point> points = hand.Contour.Points;
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
        }*/
    }
}
