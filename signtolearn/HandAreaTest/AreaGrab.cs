//NUI Imports
using CCT.NUI.Core;
using CCT.NUI.KinectSDK;
using CCT.NUI.HandTracking;

//System Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandAreaTest
{
    class AreaGrab
    {

        static void Main(string[] args)
        {
            IDataSourceFactory dataSourceFactory = new SDKDataSourceFactory();
            var handDataSource = new HandDataSource(dataSourceFactory.CreateShapeDataSource(), new HandDataSourceSettings());

            handDataSource.NewDataAvailable += new NewDataHandler<HandCollection>(handDataSource_NewDataAvailable);
            handDataSource.Start();
            
        }

        static void handDataSource_NewDataAvailable(HandCollection data)
        {
            for (int index = 0; index < data.Count; index++)
            {
                var hand = data.Hands[index];
                IList<Point> points = hand.Contour.Points;
                float x = points[0].X;
            }
        }
    }
}
