namespace Interface
{
    partial class SignToLearn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignToLearn));
            this.buttonCreateProfile = new System.Windows.Forms.Button();
            this.buttonLoadProfile = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateProfile
            // 
            this.buttonCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateProfile.FlatAppearance.BorderSize = 0;
            this.buttonCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateProfile.Image")));
            this.buttonCreateProfile.Location = new System.Drawing.Point(376, 294);
            this.buttonCreateProfile.Name = "buttonCreateProfile";
            this.buttonCreateProfile.Size = new System.Drawing.Size(292, 82);
            this.buttonCreateProfile.TabIndex = 4;
            this.buttonCreateProfile.UseVisualStyleBackColor = true;
            // 
            // buttonLoadProfile
            // 
            this.buttonLoadProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadProfile.FlatAppearance.BorderSize = 0;
            this.buttonLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonLoadProfile.Image")));
            this.buttonLoadProfile.Location = new System.Drawing.Point(376, 191);
            this.buttonLoadProfile.Name = "buttonLoadProfile";
            this.buttonLoadProfile.Size = new System.Drawing.Size(292, 85);
            this.buttonLoadProfile.TabIndex = 3;
            this.buttonLoadProfile.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(-65, -76);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(519, 496);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // SignToLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 394);
            this.Controls.Add(this.buttonCreateProfile);
            this.Controls.Add(this.buttonLoadProfile);
            this.Controls.Add(this.PictureBox1);
            this.Name = "SignToLearn";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button buttonCreateProfile;
        internal System.Windows.Forms.Button buttonLoadProfile;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
}

