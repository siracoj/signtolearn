using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Kinect;
using CCT.NUI.Core;
using CCT.NUI.Core.Clustering;
using CCT.NUI.Core.Shape;

namespace CCT.NUI.Core
{
    public class SDKDataSourceFactory : IDataSourceFactory
    {
        private KinectSensor sensor;

        public SDKDataSourceFactory(bool useNearMode = true)
        {
            this.sensor = KinectSensor.KinectSensors.First();
            this.Adapter = new KinectSensorAdapter(this.sensor, useNearMode);
            this.sensor.Start();
            sensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);
            sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
        }

        private KinectSensorAdapter Adapter { get; set; }


      

        public IClusterDataSource CreateClusterDataSource(ClusterDataSourceSettings clusterDataSourceSettings)
        {
            var size = new IntSize(this.Adapter.DepthStreamWidth, this.Adapter.DepthStreamHeight);
            var clusterFactory = new KMeansClusterFactory(clusterDataSourceSettings, size);
            var filter = new ImageFrameDepthPointFilter(this.Adapter, size, clusterDataSourceSettings.MinimumDepthThreshold, clusterDataSourceSettings.MaximumDepthThreshold, clusterDataSourceSettings.LowerBorder);
            return new SDKClusterDataSource(this.Adapter, clusterFactory, filter);
        }

        public IClusterDataSource CreateClusterDataSource()
        {
            return this.CreateClusterDataSource(new ClusterDataSourceSettings());
        }

        public IShapeDataSource CreateShapeDataSource()
        {
            return new ClusterShapeDataSource(this.CreateClusterDataSource());
        }

        public IShapeDataSource CreateShapeDataSource(IClusterDataSource clusterdataSource)
        {
            return new ClusterShapeDataSource(clusterdataSource, new ShapeDataSourceSettings());
        }

        public IShapeDataSource CreateShapeDataSource(IClusterDataSource clusterdataSource, ShapeDataSourceSettings shapeDataSourceSettings)
        {
            return new ClusterShapeDataSource(clusterdataSource, shapeDataSourceSettings);
        }

        public IShapeDataSource CreateShapeDataSource(ClusterDataSourceSettings clusterDataSourceSettings, ShapeDataSourceSettings shapeDataSourceSettings)
        {
            return new ClusterShapeDataSource(this.CreateClusterDataSource(clusterDataSourceSettings), shapeDataSourceSettings);
        }

        public KinectSensor Sensor
        {
            get { return this.sensor; }
        }

        public void Dispose()
        {
            this.Adapter.Dispose();
            this.sensor.Dispose();
        }
    }
}
