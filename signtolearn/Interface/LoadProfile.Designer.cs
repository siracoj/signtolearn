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
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConfirmLoadProfile
            // 
            this.buttonConfirmLoadProfile.FlatAppearance.BorderSize = 0;
            this.buttonConfirmLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmLoadProfile.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmLoadProfile.Image")));
            this.buttonConfirmLoadProfile.Location = new System.Drawing.Point(233, 124);
            this.buttonConfirmLoadProfile.Name = "buttonConfirmLoadProfile";
            this.buttonConfirmLoadProfile.Size = new System.Drawing.Size(193, 51);
            this.buttonConfirmLoadProfile.TabIndex = 5;
            this.buttonConfirmLoadProfile.UseVisualStyleBackColor = true;
            this.buttonConfirmLoadProfile.Click += new System.EventHandler(this.buttonConfirmLoadProfile_Click);
            // 
            // cancelLoadProfile
            // 
            this.cancelLoadProfile.FlatAppearance.BorderSize = 0;
            this.cancelLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelLoadProfile.Image = ((System.Drawing.Image)(resources.GetObject("cancelLoadProfile.Image")));
            this.cancelLoadProfile.Location = new System.Drawing.Point(12, 124);
            this.cancelLoadProfile.Name = "cancelLoadProfile";
            this.cancelLoadProfile.Size = new System.Drawing.Size(192, 51);
            this.cancelLoadProfile.TabIndex = 4;
            this.cancelLoadProfile.UseVisualStyleBackColor = true;
            this.cancelLoadProfile.Click += new System.EventHandler(this.cancelLoadProfile_Click);
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProfiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.ItemHeight = 24;
            this.listBoxProfiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.Size = new System.Drawing.Size(630, 76);
            this.listBoxProfiles.TabIndex = 3;
            // 
            // button1
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delete.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete.Location = new System.Drawing.Point(456, 124);
            this.Delete.Name = "button1";
            this.Delete.Size = new System.Drawing.Size(171, 51);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // LoadProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(656, 192);
            this.Controls.Add(this.Delete);
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
        private System.Windows.Forms.Button Delete;
    }
}