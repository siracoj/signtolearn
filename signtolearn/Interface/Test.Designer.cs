namespace Interface
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            this.LabelLetter = new System.Windows.Forms.Label();
            this.buttonSaveExit = new System.Windows.Forms.Button();
            this.LabelShowMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelLetter
            // 
            this.LabelLetter.AutoSize = true;
            this.LabelLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelLetter.Font = new System.Drawing.Font("Bebas", 210F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLetter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLetter.Image = ((System.Drawing.Image)(resources.GetObject("LabelLetter.Image")));
            this.LabelLetter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LabelLetter.Location = new System.Drawing.Point(827, 120);
            this.LabelLetter.Name = "LabelLetter";
            this.LabelLetter.Size = new System.Drawing.Size(305, 371);
            this.LabelLetter.TabIndex = 4;
            this.LabelLetter.Text = "S";
            this.LabelLetter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // buttonSaveExit
            // 
            this.buttonSaveExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveExit.FlatAppearance.BorderSize = 0;
            this.buttonSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveExit.Image")));
            this.buttonSaveExit.Location = new System.Drawing.Point(818, 546);
            this.buttonSaveExit.Name = "buttonSaveExit";
            this.buttonSaveExit.Size = new System.Drawing.Size(292, 85);
            this.buttonSaveExit.TabIndex = 5;
            this.buttonSaveExit.UseVisualStyleBackColor = true;
            // 
            // LabelShowMe
            // 
            this.LabelShowMe.AutoSize = true;
            this.LabelShowMe.Font = new System.Drawing.Font("Lakesight Personal Use Only", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShowMe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelShowMe.Location = new System.Drawing.Point(747, 7);
            this.LabelShowMe.Name = "LabelShowMe";
            this.LabelShowMe.Size = new System.Drawing.Size(423, 127);
            this.LabelShowMe.TabIndex = 3;
            this.LabelShowMe.Text = "Show me:";
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1167, 651);
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

        internal System.Windows.Forms.Label LabelLetter;
        internal System.Windows.Forms.Button buttonSaveExit;
        internal System.Windows.Forms.Label LabelShowMe;
    }
}