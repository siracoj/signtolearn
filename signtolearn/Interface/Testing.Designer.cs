namespace Interface
{
    partial class Testing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Testing));
            this.LabelShowMe = new System.Windows.Forms.Label();
            this.buttonSaveExit = new System.Windows.Forms.Button();
            this.LabelLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelShowMe
            // 
            this.LabelShowMe.AutoSize = true;
            this.LabelShowMe.Font = new System.Drawing.Font("Lakesight Personal Use Only", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelShowMe.Location = new System.Drawing.Point(747, 15);
            this.LabelShowMe.Name = "LabelShowMe";
            this.LabelShowMe.Size = new System.Drawing.Size(423, 127);
            this.LabelShowMe.TabIndex = 3;
            this.LabelShowMe.Text = "Show me:";
            // 
            // buttonSaveExit
            // 
            this.buttonSaveExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveExit.FlatAppearance.BorderSize = 0;
            this.buttonSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveExit.Image")));
            this.buttonSaveExit.Location = new System.Drawing.Point(875, 533);
            this.buttonSaveExit.Name = "buttonSaveExit";
            this.buttonSaveExit.Size = new System.Drawing.Size(189, 54);
            this.buttonSaveExit.TabIndex = 5;
            this.buttonSaveExit.UseVisualStyleBackColor = true;
            // 
            // LabelLetter
            // 
            this.LabelLetter.AutoSize = true;
            this.LabelLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLetter.Font = new System.Drawing.Font("Bebas", 210F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLetter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLetter.Image = ((System.Drawing.Image)(resources.GetObject("LabelLetter.Image")));
            this.LabelLetter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LabelLetter.Location = new System.Drawing.Point(827, 128);
            this.LabelLetter.Name = "LabelLetter";
            this.LabelLetter.Size = new System.Drawing.Size(305, 371);
            this.LabelLetter.TabIndex = 4;
            this.LabelLetter.Text = "S";
            this.LabelLetter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1166, 655);
            this.Controls.Add(this.LabelLetter);
            this.Controls.Add(this.buttonSaveExit);
            this.Controls.Add(this.LabelShowMe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LabelShowMe;
        internal System.Windows.Forms.Button buttonSaveExit;
        internal System.Windows.Forms.Label LabelLetter;


    }
}