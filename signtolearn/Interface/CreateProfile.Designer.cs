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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonCancelCreateUser.Location = new System.Drawing.Point(18, 319);
            this.buttonCancelCreateUser.Name = "buttonCancelCreateUser";
            this.buttonCancelCreateUser.Size = new System.Drawing.Size(192, 56);
            this.buttonCancelCreateUser.TabIndex = 5;
            this.buttonCancelCreateUser.UseVisualStyleBackColor = true;
            this.buttonCancelCreateUser.Click += new System.EventHandler(this.buttonCancelCreateUser_Click);
            // 
            // buttonConfirmCreateUser
            // 
            this.buttonConfirmCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmCreateUser.FlatAppearance.BorderSize = 0;
            this.buttonConfirmCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmCreateUser.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfirmCreateUser.Image")));
            this.buttonConfirmCreateUser.Location = new System.Drawing.Point(254, 319);
            this.buttonConfirmCreateUser.Name = "buttonConfirmCreateUser";
            this.buttonConfirmCreateUser.Size = new System.Drawing.Size(193, 56);
            this.buttonConfirmCreateUser.TabIndex = 4;
            this.buttonConfirmCreateUser.UseVisualStyleBackColor = true;
            this.buttonConfirmCreateUser.Click += new System.EventHandler(this.buttonConfirmCreateUser_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(18, 162);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(429, 44);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(18, 263);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(429, 44);
            this.textBoxLastName.TabIndex = 10;
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Bebas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelUsername.Location = new System.Drawing.Point(8, 5);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(199, 53);
            this.LabelUsername.TabIndex = 30;
            this.LabelUsername.Text = "Username";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Bebas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFirstName.Location = new System.Drawing.Point(7, 107);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(219, 53);
            this.labelFirstName.TabIndex = 31;
            this.labelFirstName.Text = "First   Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Bebas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLastName.Location = new System.Drawing.Point(8, 208);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(210, 53);
            this.labelLastName.TabIndex = 32;
            this.labelLastName.Text = "Last   Name";
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(465, 393);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.buttonCancelCreateUser);
            this.Controls.Add(this.buttonConfirmCreateUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateProfile";
            this.Text = "CreateProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox textBoxUsername;
        internal System.Windows.Forms.Button buttonCancelCreateUser;
        internal System.Windows.Forms.Button buttonConfirmCreateUser;
        internal System.Windows.Forms.TextBox textBoxFirstName;
        internal System.Windows.Forms.TextBox textBoxLastName;
        internal System.Windows.Forms.Label LabelUsername;
        internal System.Windows.Forms.Label labelFirstName;
        internal System.Windows.Forms.Label labelLastName;
    }
}