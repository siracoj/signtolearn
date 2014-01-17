using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HandContourRecognition.Enumes;

namespace HandContourRecognition.UserControls
{
    public partial class UCRecognitionOptions : UserControl
    {
        public UCRecognitionOptions()
        {
            InitializeComponent();
        }

        private void UCRecognitionOptions_Load(object sender, EventArgs e)
        {
            comboBoxImageType.DataSource = Enum.GetValues(typeof(ImageMode));
            comboBoxHistogram.DataSource = Enum.GetValues(typeof(HistogramMode));
        }

        public ImageMode ImageMode
        {
            get
            {
                ImageMode mode = (ImageMode)comboBoxImageType.SelectedIndex;
                return mode;
            }
        }

        public HistogramMode HistogramMode
        {
            get
            {
                HistogramMode mode = (HistogramMode)comboBoxHistogram.SelectedIndex;
                return mode;
            }
        }
        
    }
}
