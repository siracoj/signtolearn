<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.LabelShowMe = New System.Windows.Forms.Label()
        Me.LabelLetter = New System.Windows.Forms.Label()
        Me.buttonSaveExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelShowMe
        '
        Me.LabelShowMe.AutoSize = True
        Me.LabelShowMe.Font = New System.Drawing.Font("Lakesight Personal Use Only", 75.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelShowMe.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelShowMe.Location = New System.Drawing.Point(840, -2)
        Me.LabelShowMe.Name = "LabelShowMe"
        Me.LabelShowMe.Size = New System.Drawing.Size(423, 127)
        Me.LabelShowMe.TabIndex = 0
        Me.LabelShowMe.Text = "Show me:"
        '
        'LabelLetter
        '
        Me.LabelLetter.AutoSize = True
        Me.LabelLetter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelLetter.Font = New System.Drawing.Font("Bebas", 210.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLetter.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelLetter.Image = CType(resources.GetObject("LabelLetter.Image"), System.Drawing.Image)
        Me.LabelLetter.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.LabelLetter.Location = New System.Drawing.Point(920, 111)
        Me.LabelLetter.Name = "LabelLetter"
        Me.LabelLetter.Size = New System.Drawing.Size(305, 371)
        Me.LabelLetter.TabIndex = 1
        Me.LabelLetter.Text = "S"
        Me.LabelLetter.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'buttonSaveExit
        '
        Me.buttonSaveExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSaveExit.FlatAppearance.BorderSize = 0
        Me.buttonSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSaveExit.Image = CType(resources.GetObject("buttonSaveExit.Image"), System.Drawing.Image)
        Me.buttonSaveExit.Location = New System.Drawing.Point(911, 537)
        Me.buttonSaveExit.Name = "buttonSaveExit"
        Me.buttonSaveExit.Size = New System.Drawing.Size(292, 85)
        Me.buttonSaveExit.TabIndex = 2
        Me.buttonSaveExit.UseVisualStyleBackColor = True
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1263, 651)
        Me.Controls.Add(Me.LabelLetter)
        Me.Controls.Add(Me.buttonSaveExit)
        Me.Controls.Add(Me.LabelShowMe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Test"
        Me.Text = "Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelShowMe As System.Windows.Forms.Label
    Friend WithEvents LabelLetter As System.Windows.Forms.Label
    Friend WithEvents buttonSaveExit As System.Windows.Forms.Button
End Class
