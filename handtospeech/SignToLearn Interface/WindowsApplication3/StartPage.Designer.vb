<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.buttonLoadProfile = New System.Windows.Forms.Button()
        Me.buttonCreateProfile = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonLoadProfile
        '
        Me.buttonLoadProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonLoadProfile.FlatAppearance.BorderSize = 0
        Me.buttonLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonLoadProfile.Image = CType(resources.GetObject("buttonLoadProfile.Image"), System.Drawing.Image)
        Me.buttonLoadProfile.Location = New System.Drawing.Point(427, 221)
        Me.buttonLoadProfile.Name = "buttonLoadProfile"
        Me.buttonLoadProfile.Size = New System.Drawing.Size(292, 85)
        Me.buttonLoadProfile.TabIndex = 0
        Me.buttonLoadProfile.UseVisualStyleBackColor = True
        '
        'buttonCreateProfile
        '
        Me.buttonCreateProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonCreateProfile.FlatAppearance.BorderSize = 0
        Me.buttonCreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonCreateProfile.Image = CType(resources.GetObject("buttonCreateProfile.Image"), System.Drawing.Image)
        Me.buttonCreateProfile.Location = New System.Drawing.Point(427, 324)
        Me.buttonCreateProfile.Name = "buttonCreateProfile"
        Me.buttonCreateProfile.Size = New System.Drawing.Size(292, 82)
        Me.buttonCreateProfile.TabIndex = 1
        Me.buttonCreateProfile.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 496)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(743, 432)
        Me.Controls.Add(Me.buttonCreateProfile)
        Me.Controls.Add(Me.buttonLoadProfile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartPage"
        Me.Text = "Sign To Learn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonLoadProfile As System.Windows.Forms.Button
    Friend WithEvents buttonCreateProfile As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
