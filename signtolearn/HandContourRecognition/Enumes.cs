using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandContourRecognition.Enumes
{
    public enum ImageMode
    {
        Depth,
        RGB        
    }

    public enum HistogramMode
    {
        None,
        OpenNI
    }

    public struct RendererProperties
    {
        public ImageMode ImageMode{get;set;}
        public HistogramMode HistogramMode{get;set;}
    }

    public struct RendererProgress
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

    }

}
