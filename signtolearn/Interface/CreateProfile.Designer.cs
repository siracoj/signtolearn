namespace Interface
{
    partial class CreateProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateProfile));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonCancelCreateUser = new System.Windows.Forms.Button();
            this.buttonConfirmCreateUser = new System.Windows.Forms.Button();
            this.pictureBoxUsernameLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsernameLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.Font = new System.Drawing.Font("café & brewery", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(18, 61);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(429, 44);
            this.textBoxUsername.TabIndex = 6;
            // 
            // buttonCancelCreateUser
            // 
            this.buttonCancelCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelCreateUser.FlatAppearance.BorderSize = 0;
            this.buttonCancelCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonCancelCreateUser.Image")));
            this.buttonCancelCreateUser.Location = new System.Drawing.Point(18, 129);
            this.buttonCancelCreateUser.Name = "buttonCancelCreateUser";
            this.buttonCancelCreateUser.Size = new System.Drawing.Size(192, 56);
            this.buttonCancelCreateUser.TabIndex = 5;
            this.buttonCancelCreateUser.UseVisualStyleBackColor = true;
            // 
            // buttonConfirmCreateUser
            // 
            this.buttonConfirmCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmCreateUser.FlatAppearance.BorderSize = 0;
            this.buttonConfirmCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmCreateUser.Image")));
            this.buttonConfirmCreateUser.Location = new System.Drawing.Point(254, 129);
            this.buttonConfirmCreateUser.Name = "buttonConfirmCreateUser";
            this.buttonConfirmCreateUser.Size = new System.Drawing.Size(193, 56);
            this.buttonConfirmCreateUser.TabIndex = 4;
            this.buttonConfirmCreateUser.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUsernameLabel
            // 
            this.pictureBoxUsernameLabel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxUsernameLabel.Image")));
            this.pictureBoxUsernameLabel.Location = new System.Drawing.Point(-1, 12);
            this.pictureBoxUsernameLabel.Name = "pictureBoxUsernameLabel";
            this.pictureBoxUsernameLabel.Size = new System.Drawing.Size(196, 50);
            this.pictureBoxUsernameLabel.TabIndex = 7;
            this.pictureBoxUsernameLabel.TabStop = false;
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(469, 205);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonCancelCreateUser);
            this.Controls.Add(this.buttonConfirmCreateUser);
            this.Controls.Add(this.pictureBoxUsernameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateProfile";
            this.Text = "CreateProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsernameLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxUsername;
        internal System.Windows.Forms.Button buttonCancelCreateUser;
        internal System.Windows.Forms.Button buttonConfirmCreateUser;
        internal System.Windows.Forms.PictureBox pictureBoxUsernameLabel;
    }
}