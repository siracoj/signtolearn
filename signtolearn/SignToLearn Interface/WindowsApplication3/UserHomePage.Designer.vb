<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserHomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserHomePage))
        Me.buttonLoadProfile = New System.Windows.Forms.Button()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.buttonCreateProfile = New System.Windows.Forms.Button()
        Me.progressBarBody = New System.Windows.Forms.PictureBox()
        Me.labelProgress = New System.Windows.Forms.Label()
        Me.labelTrainingProgressPercentage = New System.Windows.Forms.Label()
        Me.labelBestScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.progressIncrement10 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement9 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement8 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement7 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement6 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement5 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement4 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement3 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement2 = New System.Windows.Forms.PictureBox()
        Me.progressIncrement1 = New System.Windows.Forms.PictureBox()
        CType(Me.progressBarBody, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.progressIncrement1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonLoadProfile
        '
        Me.buttonLoadProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonLoadProfile.FlatAppearance.BorderSize = 0
        Me.buttonLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonLoadProfile.Image = CType(resources.GetObject("buttonLoadProfile.Image"), System.Drawing.Image)
        Me.buttonLoadProfile.Location = New System.Drawing.Point(12, 77)
        Me.buttonLoadProfile.Name = "buttonLoadProfile"
        Me.buttonLoadProfile.Size = New System.Drawing.Size(292, 85)
        Me.buttonLoadProfile.TabIndex = 1
        Me.buttonLoadProfile.UseVisualStyleBackColor = True
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Bebas", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelUsername.Location = New System.Drawing.Point(9, 10)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(291, 53)
        Me.LabelUsername.TabIndex = 2
        Me.LabelUsername.Text = "Garrett   Lister"
        '
        'buttonCreateProfile
        '
        Me.buttonCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonCreateProfile.FlatAppearance.BorderSize = 0
        Me.buttonCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCreateProfile.Image = CType(resources.GetObject("buttonCreateProfile.Image"), System.Drawing.Image)
        Me.buttonCreateProfile.Location = New System.Drawing.Point(12, 286)
        Me.buttonCreateProfile.Name = "buttonCreateProfile"
        Me.buttonCreateProfile.Size = New System.Drawing.Size(292, 82)
        Me.buttonCreateProfile.TabIndex = 3
        Me.buttonCreateProfile.UseVisualStyleBackColor = True
        '
        'progressBarBody
        '
        Me.progressBarBody.BackgroundImage = CType(resources.GetObject("progressBarBody.BackgroundImage"), System.Drawing.Image)
        Me.progressBarBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressBarBody.Location = New System.Drawing.Point(351, 79)
        Me.progressBarBody.Name = "progressBarBody"
        Me.progressBarBody.Size = New System.Drawing.Size(405, 83)
        Me.progressBarBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.progressBarBody.TabIndex = 4
        Me.progressBarBody.TabStop = False
        '
        'labelProgress
        '
        Me.labelProgress.AutoSize = True
        Me.labelProgress.Font = New System.Drawing.Font("Bebas", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelProgress.Location = New System.Drawing.Point(344, 40)
        Me.labelProgress.Name = "labelProgress"
        Me.labelProgress.Size = New System.Drawing.Size(244, 36)
        Me.labelProgress.TabIndex = 5
        Me.labelProgress.Text = "Training   Progress:"
        '
        'labelTrainingProgressPercentage
        '
        Me.labelTrainingProgressPercentage.AutoSize = True
        Me.labelTrainingProgressPercentage.Font = New System.Drawing.Font("Bebas", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTrainingProgressPercentage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelTrainingProgressPercentage.Location = New System.Drawing.Point(345, 165)
        Me.labelTrainingProgressPercentage.Name = "labelTrainingProgressPercentage"
        Me.labelTrainingProgressPercentage.Size = New System.Drawing.Size(187, 36)
        Me.labelTrainingProgressPercentage.TabIndex = 6
        Me.labelTrainingProgressPercentage.Text = "100% Complete"
        '
        'labelBestScore
        '
        Me.labelBestScore.AutoSize = True
        Me.labelBestScore.Font = New System.Drawing.Font("Bebas", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBestScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelBestScore.Location = New System.Drawing.Point(345, 332)
        Me.labelBestScore.Name = "labelBestScore"
        Me.labelBestScore.Size = New System.Drawing.Size(156, 36)
        Me.labelBestScore.TabIndex = 7
        Me.labelBestScore.Text = "Best   Score:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(498, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 36)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "0"
        '
        'progressIncrement10
        '
        Me.progressIncrement10.BackgroundImage = CType(resources.GetObject("progressIncrement10.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement10.Location = New System.Drawing.Point(711, 90)
        Me.progressIncrement10.Name = "progressIncrement10"
        Me.progressIncrement10.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement10.TabIndex = 18
        Me.progressIncrement10.TabStop = False
        '
        'progressIncrement9
        '
        Me.progressIncrement9.BackgroundImage = CType(resources.GetObject("progressIncrement9.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement9.Location = New System.Drawing.Point(673, 90)
        Me.progressIncrement9.Name = "progressIncrement9"
        Me.progressIncrement9.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement9.TabIndex = 19
        Me.progressIncrement9.TabStop = False
        '
        'progressIncrement8
        '
        Me.progressIncrement8.BackgroundImage = CType(resources.GetObject("progressIncrement8.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement8.Location = New System.Drawing.Point(635, 90)
        Me.progressIncrement8.Name = "progressIncrement8"
        Me.progressIncrement8.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement8.TabIndex = 20
        Me.progressIncrement8.TabStop = False
        '
        'progressIncrement7
        '
        Me.progressIncrement7.BackgroundImage = CType(resources.GetObject("progressIncrement7.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement7.Location = New System.Drawing.Point(597, 90)
        Me.progressIncrement7.Name = "progressIncrement7"
        Me.progressIncrement7.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement7.TabIndex = 21
        Me.progressIncrement7.TabStop = False
        '
        'progressIncrement6
        '
        Me.progressIncrement6.BackgroundImage = CType(resources.GetObject("progressIncrement6.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement6.Location = New System.Drawing.Point(557, 90)
        Me.progressIncrement6.Name = "progressIncrement6"
        Me.progressIncrement6.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement6.TabIndex = 22
        Me.progressIncrement6.TabStop = False
        '
        'progressIncrement5
        '
        Me.progressIncrement5.BackgroundImage = CType(resources.GetObject("progressIncrement5.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement5.Location = New System.Drawing.Point(517, 90)
        Me.progressIncrement5.Name = "progressIncrement5"
        Me.progressIncrement5.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement5.TabIndex = 23
        Me.progressIncrement5.TabStop = False
        '
        'progressIncrement4
        '
        Me.progressIncrement4.BackgroundImage = CType(resources.GetObject("progressIncrement4.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement4.Location = New System.Drawing.Point(478, 90)
        Me.progressIncrement4.Name = "progressIncrement4"
        Me.progressIncrement4.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement4.TabIndex = 24
        Me.progressIncrement4.TabStop = False
        '
        'progressIncrement3
        '
        Me.progressIncrement3.BackgroundImage = CType(resources.GetObject("progressIncrement3.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement3.Location = New System.Drawing.Point(439, 90)
        Me.progressIncrement3.Name = "progressIncrement3"
        Me.progressIncrement3.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement3.TabIndex = 25
        Me.progressIncrement3.TabStop = False
        '
        'progressIncrement2
        '
        Me.progressIncrement2.BackgroundImage = CType(resources.GetObject("progressIncrement2.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement2.Location = New System.Drawing.Point(402, 90)
        Me.progressIncrement2.Name = "progressIncrement2"
        Me.progressIncrement2.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement2.TabIndex = 26
        Me.progressIncrement2.TabStop = False
        '
        'progressIncrement1
        '
        Me.progressIncrement1.BackgroundImage = CType(resources.GetObject("progressIncrement1.BackgroundImage"), System.Drawing.Image)
        Me.progressIncrement1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.progressIncrement1.Location = New System.Drawing.Point(365, 90)
        Me.progressIncrement1.Name = "progressIncrement1"
        Me.progressIncrement1.Size = New System.Drawing.Size(29, 61)
        Me.progressIncrement1.TabIndex = 27
        Me.progressIncrement1.TabStop = False
        '
        'UserHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(774, 385)
        Me.Controls.Add(Me.progressIncrement1)
        Me.Controls.Add(Me.progressIncrement2)
        Me.Controls.Add(Me.progressIncrement3)
        Me.Controls.Add(Me.progressIncrement4)
        Me.Controls.Add(Me.progressIncrement5)
        Me.Controls.Add(Me.progressIncrement6)
        Me.Controls.Add(Me.progressIncrement7)
        Me.Controls.Add(Me.progressIncrement8)
        Me.Controls.Add(Me.progressIncrement9)
        Me.Controls.Add(Me.progressIncrement10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelBestScore)
        Me.Controls.Add(Me.labelTrainingProgressPercentage)
        Me.Controls.Add(Me.labelProgress)
        Me.Controls.Add(Me.progressBarBody)
        Me.Controls.Add(Me.buttonCreateProfile)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.buttonLoadProfile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UserHomePage"
        Me.Text = "Home"
        CType(Me.progressBarBody, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.progressIncrement1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonLoadProfile As System.Windows.Forms.Button
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents buttonCreateProfile As System.Windows.Forms.Button
    Friend WithEvents progressBarBody As System.Windows.Forms.PictureBox
    Friend WithEvents labelProgress As System.Windows.Forms.Label
    Friend WithEvents labelTrainingProgressPercentage As System.Windows.Forms.Label
    Friend WithEvents labelBestScore As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents progressIncrement10 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement9 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement8 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement7 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement6 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement5 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement4 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement3 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement2 As System.Windows.Forms.PictureBox
    Friend WithEvents progressIncrement1 As System.Windows.Forms.PictureBox
End Class
