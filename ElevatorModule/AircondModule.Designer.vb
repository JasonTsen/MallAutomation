<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AircondModule
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fanIcon = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOnOff = New System.Windows.Forms.Label()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.label = New System.Windows.Forms.Label()
        Me.btnOnOff = New Guna.UI2.WinForms.Guna2Button()
        Me.btnOFF = New Guna.UI2.WinForms.Guna2Button()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(356, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Air Conditioner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElevatorModule.My.Resources.Resources.icons8_air_conditioner_48
        Me.PictureBox1.Location = New System.Drawing.Point(345, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'fanIcon
        '
        Me.fanIcon.Image = Global.ElevatorModule.My.Resources.Resources.fan_gif
        Me.fanIcon.Location = New System.Drawing.Point(472, 95)
        Me.fanIcon.Name = "fanIcon"
        Me.fanIcon.Size = New System.Drawing.Size(53, 48)
        Me.fanIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fanIcon.TabIndex = 3
        Me.fanIcon.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 166)
        Me.Label2.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 30)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Temperature :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 216)
        Me.Label3.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 30)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Time :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.BackColor = System.Drawing.Color.DimGray
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.Location = New System.Drawing.Point(183, 166)
        Me.lblTemp.MinimumSize = New System.Drawing.Size(0, 30)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 30)
        Me.lblTemp.TabIndex = 6
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(114, 216)
        Me.lblTime.MinimumSize = New System.Drawing.Size(0, 30)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 30)
        Me.lblTime.TabIndex = 7
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 266)
        Me.Label4.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 30)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Status :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOnOff
        '
        Me.lblOnOff.AutoSize = True
        Me.lblOnOff.BackColor = System.Drawing.Color.Transparent
        Me.lblOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnOff.Location = New System.Drawing.Point(120, 266)
        Me.lblOnOff.MinimumSize = New System.Drawing.Size(0, 30)
        Me.lblOnOff.Name = "lblOnOff"
        Me.lblOnOff.Size = New System.Drawing.Size(0, 30)
        Me.lblOnOff.TabIndex = 12
        Me.lblOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.BackColor = System.Drawing.Color.Black
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.Location = New System.Drawing.Point(16, 37)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(0, 20)
        Me.lblReport.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.label)
        Me.Panel1.Controls.Add(Me.lblReport)
        Me.Panel1.Location = New System.Drawing.Point(373, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 281)
        Me.Panel1.TabIndex = 16
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(16, 3)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(310, 20)
        Me.label.TabIndex = 16
        Me.label.Text = "Temp      Status       Date and Time"
        Me.label.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOnOff
        '
        Me.btnOnOff.BorderRadius = 20
        Me.btnOnOff.CheckedState.Parent = Me.btnOnOff
        Me.btnOnOff.CustomImages.Parent = Me.btnOnOff
        Me.btnOnOff.FillColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnOnOff.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOff.ForeColor = System.Drawing.Color.White
        Me.btnOnOff.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnOnOff.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOnOff.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnOnOff.HoverState.Parent = Me.btnOnOff
        Me.btnOnOff.Location = New System.Drawing.Point(12, 363)
        Me.btnOnOff.Name = "btnOnOff"
        Me.btnOnOff.ShadowDecoration.Parent = Me.btnOnOff
        Me.btnOnOff.Size = New System.Drawing.Size(135, 50)
        Me.btnOnOff.TabIndex = 25
        Me.btnOnOff.Text = "Start"
        '
        'btnOFF
        '
        Me.btnOFF.BorderRadius = 20
        Me.btnOFF.CheckedState.Parent = Me.btnOFF
        Me.btnOFF.CustomImages.Parent = Me.btnOFF
        Me.btnOFF.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnOFF.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOFF.ForeColor = System.Drawing.Color.White
        Me.btnOFF.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnOFF.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOFF.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnOFF.HoverState.Parent = Me.btnOFF
        Me.btnOFF.Location = New System.Drawing.Point(153, 363)
        Me.btnOFF.Name = "btnOFF"
        Me.btnOFF.ShadowDecoration.Parent = Me.btnOFF
        Me.btnOFF.Size = New System.Drawing.Size(135, 50)
        Me.btnOFF.TabIndex = 27
        Me.btnOFF.Text = "Stop"
        '
        'btnExit
        '
        Me.btnExit.BorderRadius = 20
        Me.btnExit.CheckedState.Parent = Me.btnExit
        Me.btnExit.CustomImages.Parent = Me.btnExit
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExit.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverState.Parent = Me.btnExit
        Me.btnExit.Location = New System.Drawing.Point(294, 363)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.ShadowDecoration.Parent = Me.btnExit
        Me.btnExit.Size = New System.Drawing.Size(70, 50)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Close"
        '
        'AircondModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(812, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOFF)
        Me.Controls.Add(Me.btnOnOff)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblOnOff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fanIcon)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "AircondModule"
        Me.Text = "AircondModule"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fanIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents fanIcon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOnOff As Label
    Friend WithEvents lblReport As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents label As Label
    Friend WithEvents btnOnOff As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnOFF As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
End Class
