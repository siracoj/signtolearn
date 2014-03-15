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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KinectVideoStream));
            this.picVideoDisplay = new System.Windows.Forms.PictureBox();
            this.buttonSaveExit = new System.Windows.Forms.Button();
            this.LabelLetter = new System.Windows.Forms.Label();
            this.LabelShowMe = new System.Windows.Forms.Label();
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
            // buttonSaveExit
            // 
            this.buttonSaveExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveExit.FlatAppearance.BorderSize = 0;
            this.buttonSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveExit.Image")));
            this.buttonSaveExit.Location = new System.Drawing.Point(726, 438);
            this.buttonSaveExit.Name = "buttonSaveExit";
            this.buttonSaveExit.Size = new System.Drawing.Size(189, 54);
            this.buttonSaveExit.TabIndex = 6;
            this.buttonSaveExit.UseVisualStyleBackColor = true;
            this.buttonSaveExit.Click += new System.EventHandler(this.buttonSaveExit_Click);
            // 
            // LabelLetter
            // 
            this.LabelLetter.AutoSize = true;
            this.LabelLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 210F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLetter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLetter.Image = ((System.Drawing.Image)(resources.GetObject("LabelLetter.Image")));
            this.LabelLetter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LabelLetter.Location = new System.Drawing.Point(683, 106);
            this.LabelLetter.Name = "LabelLetter";
            this.LabelLetter.Size = new System.Drawing.Size(320, 317);
            this.LabelLetter.TabIndex = 7;
            this.LabelLetter.Text = "S";
            this.LabelLetter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LabelShowMe
            // 
            this.LabelShowMe.AutoSize = true;
            this.LabelShowMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelShowMe.Location = new System.Drawing.Point(705, 22);
            this.LabelShowMe.Name = "LabelShowMe";
            this.LabelShowMe.Size = new System.Drawing.Size(238, 55);
            this.LabelShowMe.TabIndex = 8;
            this.LabelShowMe.Text = "Show me:";
            // 
            // KinectVideoStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.LabelShowMe);
            this.Controls.Add(this.LabelLetter);
            this.Controls.Add(this.buttonSaveExit);
            this.Controls.Add(this.picVideoDisplay);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KinectVideoStream";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training";
            ((System.ComponentModel.ISupportInitialize)(this.picVideoDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picVideoDisplay;
        internal System.Windows.Forms.Button buttonSaveExit;
        internal System.Windows.Forms.Label LabelLetter;
        internal System.Windows.Forms.Label LabelShowMe;
    }
}

