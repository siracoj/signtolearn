namespace Interface
{
    partial class LoadProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadProfile));
            this.buttonConfirmLoadProfile = new System.Windows.Forms.Button();
            this.cancelLoadProfile = new System.Windows.Forms.Button();
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonConfirmLoadProfile
            // 
            this.buttonConfirmLoadProfile.FlatAppearance.BorderSize = 0;
            this.buttonConfirmLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmLoadProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmLoadProfile.Image")));
            this.buttonConfirmLoadProfile.Location = new System.Drawing.Point(248, 132);
            this.buttonConfirmLoadProfile.Name = "buttonConfirmLoadProfile";
            this.buttonConfirmLoadProfile.Size = new System.Drawing.Size(193, 51);
            this.buttonConfirmLoadProfile.TabIndex = 5;
            this.buttonConfirmLoadProfile.UseVisualStyleBackColor = true;
            // 
            // cancelLoadProfile
            // 
            this.cancelLoadProfile.FlatAppearance.BorderSize = 0;
            this.cancelLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLoadProfile.Image = ((System.Drawing.Image)(resources.GetObject("cancelLoadProfile.Image")));
            this.cancelLoadProfile.Location = new System.Drawing.Point(12, 132);
            this.cancelLoadProfile.Name = "cancelLoadProfile";
            this.cancelLoadProfile.Size = new System.Drawing.Size(192, 51);
            this.cancelLoadProfile.TabIndex = 4;
            this.cancelLoadProfile.UseVisualStyleBackColor = true;
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxProfiles.Font = new System.Drawing.Font("café & brewery", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProfiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.ItemHeight = 23;
            this.listBoxProfiles.Items.AddRange(new object[] {
            "Jared Wilhelm Siraco",
            "Garrett Lister",
            "Chou Geena Yang",
            "Chris Streeks",
            "Joe Biden",
            "Barack Obama",
            "Leslie Knope",
            "Ben Wyatt"});
            this.listBoxProfiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.Size = new System.Drawing.Size(429, 96);
            this.listBoxProfiles.TabIndex = 3;
            // 
            // LoadProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(456, 199);
            this.Controls.Add(this.buttonConfirmLoadProfile);
            this.Controls.Add(this.cancelLoadProfile);
            this.Controls.Add(this.listBoxProfiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadProfile";
            this.Text = "LoadProfile";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button buttonConfirmLoadProfile;
        internal System.Windows.Forms.Button cancelLoadProfile;
        internal System.Windows.Forms.ListBox listBoxProfiles;
    }
}