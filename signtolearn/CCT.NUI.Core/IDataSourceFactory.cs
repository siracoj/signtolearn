using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCT.NUI.Core.Clustering;
using CCT.NUI.Core.Shape;


namespace CCT.NUI.Core
{
    public interface IDataSourceFactory : IDisposable
    {
        IClusterDataSource CreateClusterDataSource();

        IClusterDataSource CreateClusterDataSource(ClusterDataSourceSettings clusterDataSourceSettings);

        IShapeDataSource CreateShapeDataSource();

        IShapeDataSource CreateShapeDataSource(IClusterDataSource clusterdataSource);

        IShapeDataSource CreateShapeDataSource(IClusterDataSource clusterdataSource, ShapeDataSourceSettings shapeDataSourceSettings);

        IShapeDataSource CreateShapeDataSource(ClusterDataSourceSettings clusterDataSourceSettings, ShapeDataSourceSettings shapeDataSourceSettings);
    }
}
