<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLight = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAircon = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEntrance = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEscalator = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(95, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(548, 69)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "- Mall Automation -"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.btnLight)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnAircon)
        Me.GroupBox1.Controls.Add(Me.btnEntrance)
        Me.GroupBox1.Controls.Add(Me.btnEscalator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 521)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnLight
        '
        Me.btnLight.BorderRadius = 20
        Me.btnLight.CheckedState.Parent = Me.btnLight
        Me.btnLight.CustomImages.Parent = Me.btnLight
        Me.btnLight.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLight.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLight.ForeColor = System.Drawing.Color.White
        Me.btnLight.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnLight.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLight.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnLight.HoverState.Parent = Me.btnLight
        Me.btnLight.Location = New System.Drawing.Point(462, 376)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.ShadowDecoration.Parent = Me.btnLight
        Me.btnLight.Size = New System.Drawing.Size(135, 50)
        Me.btnLight.TabIndex = 12
        Me.btnLight.Text = "Light"
        '
        'btnExit
        '
        Me.btnExit.BorderRadius = 20
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.CustomImages.Parent = Me.btnExit
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnExit.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Location = New System.Drawing.Point(396, 443)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.ShadowDecoration.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(135, 50)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        '
        'btnAircon
        '
        Me.btnAircon.BorderRadius = 20
        Me.btnAircon.CheckedState.Parent = Me.btnAircon
        Me.btnAircon.CustomImages.Parent = Me.btnAircon
        Me.btnAircon.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAircon.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAircon.ForeColor = System.Drawing.Color.White
        Me.btnAircon.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnAircon.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAircon.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnAircon.HoverState.Parent = Me.btnAircon
        Me.btnAircon.Location = New System.Drawing.Point(229, 443)
        Me.btnAircon.Name = "btnAircon"
        Me.btnAircon.ShadowDecoration.Parent = Me.btnAircon
        Me.btnAircon.Size = New System.Drawing.Size(135, 50)
        Me.btnAircon.TabIndex = 10
        Me.btnAircon.Text = "Aircon"
        '
        'btnEntrance
        '
        Me.btnEntrance.BorderRadius = 20
        Me.btnEntrance.CheckedState.Parent = Me.btnEntrance
        Me.btnEntrance.CustomImages.Parent = Me.btnEntrance
        Me.btnEntrance.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEntrance.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrance.ForeColor = System.Drawing.Color.White
        Me.btnEntrance.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnEntrance.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrance.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnEntrance.HoverState.Parent = Me.btnEntrance
        Me.btnEntrance.Location = New System.Drawing.Point(148, 376)
        Me.btnEntrance.Name = "btnEntrance"
        Me.btnEntrance.ShadowDecoration.Parent = Me.btnEntrance
        Me.btnEntrance.Size = New System.Drawing.Size(135, 50)
        Me.btnEntrance.TabIndex = 9
        Me.btnEntrance.Text = "Entrance"
        '
        'btnEscalator
        '
        Me.btnEscalator.BorderRadius = 20
        Me.btnEscalator.CheckedState.Parent = Me.btnEscalator
        Me.btnEscalator.CustomImages.Parent = Me.btnEscalator
        Me.btnEscalator.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEscalator.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscalator.ForeColor = System.Drawing.Color.White
        Me.btnEscalator.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnEscalator.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscalator.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnEscalator.HoverState.Parent = Me.btnEscalator
        Me.btnEscalator.Location = New System.Drawing.Point(307, 376)
        Me.btnEscalator.Name = "btnEscalator"
        Me.btnEscalator.ShadowDecoration.Parent = Me.btnEscalator
        Me.btnEscalator.Size = New System.Drawing.Size(135, 50)
        Me.btnEscalator.TabIndex = 8
        Me.btnEscalator.Text = "Escalator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElevatorModule.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(210, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(331, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(803, 545)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLight As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAircon As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEntrance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEscalator As Guna.UI2.WinForms.Guna2Button
End Class
