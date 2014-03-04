<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateUser))
        Me.buttonConfirmCreateUser = New System.Windows.Forms.Button()
        Me.buttonCancelCreateUser = New System.Windows.Forms.Button()
        Me.textBoxUsername = New System.Windows.Forms.TextBox()
        Me.pictureBoxUsernameLabel = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBoxUsernameLabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonConfirmCreateUser
        '
        Me.buttonConfirmCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonConfirmCreateUser.FlatAppearance.BorderSize = 0
        Me.buttonConfirmCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonConfirmCreateUser.Image = CType(resources.GetObject("buttonConfirmCreateUser.Image"), System.Drawing.Image)
        Me.buttonConfirmCreateUser.Location = New System.Drawing.Point(266, 141)
        Me.buttonConfirmCreateUser.Name = "buttonConfirmCreateUser"
        Me.buttonConfirmCreateUser.Size = New System.Drawing.Size(193, 56)
        Me.buttonConfirmCreateUser.TabIndex = 0
        Me.buttonConfirmCreateUser.UseVisualStyleBackColor = True
        '
        'buttonCancelCreateUser
        '
        Me.buttonCancelCreateUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonCancelCreateUser.FlatAppearance.BorderSize = 0
        Me.buttonCancelCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCancelCreateUser.Image = CType(resources.GetObject("buttonCancelCreateUser.Image"), System.Drawing.Image)
        Me.buttonCancelCreateUser.Location = New System.Drawing.Point(30, 141)
        Me.buttonCancelCreateUser.Name = "buttonCancelCreateUser"
        Me.buttonCancelCreateUser.Size = New System.Drawing.Size(192, 56)
        Me.buttonCancelCreateUser.TabIndex = 1
        Me.buttonCancelCreateUser.UseVisualStyleBackColor = True
        '
        'textBoxUsername
        '
        Me.textBoxUsername.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.textBoxUsername.Font = New System.Drawing.Font("café & brewery", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxUsername.Location = New System.Drawing.Point(30, 73)
        Me.textBoxUsername.Name = "textBoxUsername"
        Me.textBoxUsername.Size = New System.Drawing.Size(429, 44)
        Me.textBoxUsername.TabIndex = 2
        '
        'pictureBoxUsernameLabel
        '
        Me.pictureBoxUsernameLabel.Image = CType(resources.GetObject("pictureBoxUsernameLabel.Image"), System.Drawing.Image)
        Me.pictureBoxUsernameLabel.Location = New System.Drawing.Point(11, 24)
        Me.pictureBoxUsernameLabel.Name = "pictureBoxUsernameLabel"
        Me.pictureBoxUsernameLabel.Size = New System.Drawing.Size(196, 50)
        Me.pictureBoxUsernameLabel.TabIndex = 3
        Me.pictureBoxUsernameLabel.TabStop = False
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(493, 228)
        Me.Controls.Add(Me.textBoxUsername)
        Me.Controls.Add(Me.buttonCancelCreateUser)
        Me.Controls.Add(Me.buttonConfirmCreateUser)
        Me.Controls.Add(Me.pictureBoxUsernameLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateUser"
        Me.Text = "Create User"
        CType(Me.pictureBoxUsernameLabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonConfirmCreateUser As System.Windows.Forms.Button
    Friend WithEvents buttonCancelCreateUser As System.Windows.Forms.Button
    Friend WithEvents textBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents pictureBoxUsernameLabel As System.Windows.Forms.PictureBox
End Class
