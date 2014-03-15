namespace Interface
{
    partial class KinectVideoStream
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picVideoDisplay = new System.Windows.Forms.PictureBox();
           ((System.ComponentModel.ISupportInitialize)(this.picVideoDisplay)).BeginInit();
            this.SuspendLayout();
            
            // 
            // picVideoDisplay
            // 
            this.picVideoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideoDisplay.Location = new System.Drawing.Point(12, 12);
            this.picVideoDisplay.Name = "picVideoDisplay";
            this.picVideoDisplay.Size = new System.Drawing.Size(640, 480);
            this.picVideoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVideoDisplay.TabIndex = 2;
            this.picVideoDisplay.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 580);
            this.Controls.Add(this.picVideoDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training";
            ((System.ComponentModel.ISupportInitialize)(this.picVideoDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picVideoDisplay;
    }
}

