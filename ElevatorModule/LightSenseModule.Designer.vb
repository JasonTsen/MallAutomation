<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightSenseModule
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radManual = New System.Windows.Forms.RadioButton()
        Me.radAuto = New System.Windows.Forms.RadioButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLight = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStop = New Guna.UI2.WinForms.Guna2Button()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(77, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "- System Current Time -"
        '
        'radManual
        '
        Me.radManual.AutoSize = True
        Me.radManual.BackColor = System.Drawing.Color.Transparent
        Me.radManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radManual.Location = New System.Drawing.Point(468, 105)
        Me.radManual.Name = "radManual"
        Me.radManual.Size = New System.Drawing.Size(141, 24)
        Me.radManual.TabIndex = 20
        Me.radManual.TabStop = True
        Me.radManual.Text = "Manual Mode"
        Me.radManual.UseVisualStyleBackColor = False
        '
        'radAuto
        '
        Me.radAuto.AutoSize = True
        Me.radAuto.BackColor = System.Drawing.Color.Transparent
        Me.radAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radAuto.Location = New System.Drawing.Point(654, 106)
        Me.radAuto.Name = "radAuto"
        Me.radAuto.Size = New System.Drawing.Size(119, 24)
        Me.radAuto.TabIndex = 19
        Me.radAuto.TabStop = True
        Me.radAuto.Text = "Auto Mode"
        Me.radAuto.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblName.Location = New System.Drawing.Point(62, 105)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(260, 40)
        Me.lblName.TabIndex = 16
        '
        'lblLight
        '
        Me.lblLight.BackColor = System.Drawing.Color.Transparent
        Me.lblLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLight.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLight.Location = New System.Drawing.Point(62, 249)
        Me.lblLight.Name = "lblLight"
        Me.lblLight.Size = New System.Drawing.Size(260, 40)
        Me.lblLight.TabIndex = 14
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateTime.Location = New System.Drawing.Point(62, 339)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(260, 40)
        Me.lblDateTime.TabIndex = 13
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblMessage.Location = New System.Drawing.Point(62, 177)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(260, 40)
        Me.lblMessage.TabIndex = 12
        '
        'timer1
        '
        Me.timer1.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(37, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 55)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Light System"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ElevatorModule.My.Resources.Resources.nolight
        Me.PictureBox1.Location = New System.Drawing.Point(399, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(468, 309)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(950, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 55)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Light Report"
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 20
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(723, 25)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(135, 50)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        '
        'btnStart
        '
        Me.btnStart.BorderRadius = 20
        Me.btnStart.CheckedState.Parent = Me.btnStart
        Me.btnStart.CustomImages.Parent = Me.btnStart
        Me.btnStart.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnStart.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnStart.HoverState.Parent = Me.btnStart
        Me.btnStart.Location = New System.Drawing.Point(399, 25)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.ShadowDecoration.Parent = Me.btnStart
        Me.btnStart.Size = New System.Drawing.Size(135, 50)
        Me.btnStart.TabIndex = 24
        Me.btnStart.Text = "Start"
        '
        'btnStop
        '
        Me.btnStop.BorderRadius = 20
        Me.btnStop.CheckedState.Parent = Me.btnStop
        Me.btnStop.CustomImages.Parent = Me.btnStop
        Me.btnStop.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStop.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.White
        Me.btnStop.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnStop.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnStop.HoverState.Parent = Me.btnStop
        Me.btnStop.Location = New System.Drawing.Point(564, 25)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.ShadowDecoration.Parent = Me.btnStop
        Me.btnStop.Size = New System.Drawing.Size(135, 50)
        Me.btnStop.TabIndex = 26
        Me.btnStop.Text = "Stop"
        '
        'lblReport
        '
        Me.lblReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReport.Location = New System.Drawing.Point(865, 143)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(491, 285)
        Me.lblReport.TabIndex = 27
        Me.lblReport.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(867, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(500, 38)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Light ( 0 = Off / 1 = On)        Brightness        Date/Time"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LightSenseModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1368, 483)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radManual)
        Me.Controls.Add(Me.radAuto)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLight)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "LightSenseModule"
        Me.Text = "Light System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radManual As RadioButton
    Friend WithEvents radAuto As RadioButton
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLight As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStop As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblReport As Label
    Friend WithEvents Label4 As Label
End Class
