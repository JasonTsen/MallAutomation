<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntranceModule
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pic_entrance1 = New System.Windows.Forms.PictureBox()
        Me.pic_entrance = New System.Windows.Forms.PictureBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblBuzzer = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblUltra = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblEntranceRep = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_entrance1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_entrance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.pic_entrance1)
        Me.GroupBox1.Controls.Add(Me.pic_entrance)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblDisplay)
        Me.GroupBox1.Controls.Add(Me.lblBuzzer)
        Me.GroupBox1.Controls.Add(Me.lblTemp)
        Me.GroupBox1.Controls.Add(Me.lblUltra)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 113)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(652, 281)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'pic_entrance1
        '
        Me.pic_entrance1.Image = Global.ElevatorModule.My.Resources.Resources.entrance_customer
        Me.pic_entrance1.Location = New System.Drawing.Point(5, 11)
        Me.pic_entrance1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_entrance1.Name = "pic_entrance1"
        Me.pic_entrance1.Size = New System.Drawing.Size(397, 270)
        Me.pic_entrance1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_entrance1.TabIndex = 2
        Me.pic_entrance1.TabStop = False
        Me.pic_entrance1.Visible = False
        '
        'pic_entrance
        '
        Me.pic_entrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_entrance.Location = New System.Drawing.Point(5, 21)
        Me.pic_entrance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_entrance.Name = "pic_entrance"
        Me.pic_entrance.Size = New System.Drawing.Size(397, 246)
        Me.pic_entrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_entrance.TabIndex = 5
        Me.pic_entrance.TabStop = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplay.Location = New System.Drawing.Point(422, 231)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(208, 31)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuzzer
        '
        Me.lblBuzzer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBuzzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuzzer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBuzzer.Location = New System.Drawing.Point(541, 96)
        Me.lblBuzzer.Name = "lblBuzzer"
        Me.lblBuzzer.Size = New System.Drawing.Size(89, 32)
        Me.lblBuzzer.TabIndex = 2
        Me.lblBuzzer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTemp
        '
        Me.lblTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTemp.Location = New System.Drawing.Point(554, 140)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(76, 32)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUltra
        '
        Me.lblUltra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUltra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltra.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUltra.Location = New System.Drawing.Point(541, 53)
        Me.lblUltra.Name = "lblUltra"
        Me.lblUltra.Size = New System.Drawing.Size(89, 32)
        Me.lblUltra.TabIndex = 0
        Me.lblUltra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTime.Location = New System.Drawing.Point(76, 76)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(544, 31)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Current Time"
        '
        'lblEntranceRep
        '
        Me.lblEntranceRep.BackColor = System.Drawing.Color.Transparent
        Me.lblEntranceRep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEntranceRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntranceRep.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblEntranceRep.Location = New System.Drawing.Point(749, 113)
        Me.lblEntranceRep.Name = "lblEntranceRep"
        Me.lblEntranceRep.Size = New System.Drawing.Size(403, 281)
        Me.lblEntranceRep.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(749, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(403, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ultra      Temperature(°C)    Date/Time"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(744, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 39)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Entrance Report"
        '
        'btnClose
        '
        Me.btnClose.BorderRadius = 20
        Me.btnClose.CheckedState.Parent = Me.btnClose
        Me.btnClose.CustomImages.Parent = Me.btnClose
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnClose.HoverState.Parent = Me.btnClose
        Me.btnClose.Location = New System.Drawing.Point(343, 409)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(135, 50)
        Me.btnClose.TabIndex = 27
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
        Me.btnStart.Location = New System.Drawing.Point(159, 409)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.ShadowDecoration.Parent = Me.btnStart
        Me.btnStart.Size = New System.Drawing.Size(135, 50)
        Me.btnStart.TabIndex = 26
        Me.btnStart.Text = "Start"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(64, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(491, 52)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Entrance System"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(408, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 32)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ultra: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(408, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 32)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Temperature: "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(408, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 32)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Buzzer: "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EntranceModule
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(1181, 487)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEntranceRep)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "EntranceModule"
        Me.Text = "Entrance System"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_entrance1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_entrance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pic_entrance1 As PictureBox
    Friend WithEvents pic_entrance As PictureBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblBuzzer As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblUltra As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblEntranceRep As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
