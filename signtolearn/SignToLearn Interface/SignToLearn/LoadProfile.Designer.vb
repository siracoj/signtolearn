<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadProfile))
        Me.listBoxProfiles = New System.Windows.Forms.ListBox()
        Me.cancelLoadProfile = New System.Windows.Forms.Button()
        Me.buttonConfirmLoadProfile = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBoxProfiles
        '
        Me.listBoxProfiles.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.listBoxProfiles.Font = New System.Drawing.Font("café & brewery", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBoxProfiles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxProfiles.FormattingEnabled = True
        Me.listBoxProfiles.ItemHeight = 23
        Me.listBoxProfiles.Items.AddRange(New Object() {"Jared Wilhelm Siraco", "Garrett Lister", "Chou Geena Yang", "Chris Streeks", "Joe Biden", "Barack Obama", "Leslie Knope", "Ben Wyatt"})
        Me.listBoxProfiles.Location = New System.Drawing.Point(30, 28)
        Me.listBoxProfiles.Name = "listBoxProfiles"
        Me.listBoxProfiles.Size = New System.Drawing.Size(429, 96)
        Me.listBoxProfiles.TabIndex = 0
        '
        'cancelLoadProfile
        '
        Me.cancelLoadProfile.FlatAppearance.BorderSize = 0
        Me.cancelLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelLoadProfile.Image = CType(resources.GetObject("cancelLoadProfile.Image"), System.Drawing.Image)
        Me.cancelLoadProfile.Location = New System.Drawing.Point(30, 148)
        Me.cancelLoadProfile.Name = "cancelLoadProfile"
        Me.cancelLoadProfile.Size = New System.Drawing.Size(192, 51)
        Me.cancelLoadProfile.TabIndex = 1
        Me.cancelLoadProfile.UseVisualStyleBackColor = True
        '
        'buttonConfirmLoadProfile
        '
        Me.buttonConfirmLoadProfile.FlatAppearance.BorderSize = 0
        Me.buttonConfirmLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonConfirmLoadProfile.Image = CType(resources.GetObject("buttonConfirmLoadProfile.Image"), System.Drawing.Image)
        Me.buttonConfirmLoadProfile.Location = New System.Drawing.Point(266, 148)
        Me.buttonConfirmLoadProfile.Name = "buttonConfirmLoadProfile"
        Me.buttonConfirmLoadProfile.Size = New System.Drawing.Size(193, 51)
        Me.buttonConfirmLoadProfile.TabIndex = 2
        Me.buttonConfirmLoadProfile.UseVisualStyleBackColor = True
        '
        'LoadProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(493, 228)
        Me.Controls.Add(Me.buttonConfirmLoadProfile)
        Me.Controls.Add(Me.cancelLoadProfile)
        Me.Controls.Add(Me.listBoxProfiles)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoadProfile"
        Me.Text = "Load Profile"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listBoxProfiles As System.Windows.Forms.ListBox
    Friend WithEvents cancelLoadProfile As System.Windows.Forms.Button
    Friend WithEvents buttonConfirmLoadProfile As System.Windows.Forms.Button
End Class
