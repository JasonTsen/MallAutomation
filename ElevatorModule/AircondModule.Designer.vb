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
        Me.btnOn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.fanIcon = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.radManual = New System.Windows.Forms.RadioButton()
        Me.radAuto = New System.Windows.Forms.RadioButton()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOnOff = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fanIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Air Conditioner"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOn
        '
        Me.btnOn.BackColor = System.Drawing.Color.DimGray
        Me.btnOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOn.Location = New System.Drawing.Point(265, 306)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(132, 56)
        Me.btnOn.TabIndex = 1
        Me.btnOn.Text = "ON"
        Me.btnOn.UseVisualStyleBackColor = False
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
        Me.Label2.BackColor = System.Drawing.Color.DimGray
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 157)
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
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 207)
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
        Me.lblTemp.Location = New System.Drawing.Point(241, 157)
        Me.lblTemp.MinimumSize = New System.Drawing.Size(0, 30)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(0, 30)
        Me.lblTemp.TabIndex = 6
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.DimGray
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(165, 246)
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
        'radManual
        '
        Me.radManual.AutoSize = True
        Me.radManual.BackColor = System.Drawing.Color.DimGray
        Me.radManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManual.Location = New System.Drawing.Point(256, 388)
        Me.radManual.MinimumSize = New System.Drawing.Size(0, 30)
        Me.radManual.Name = "radManual"
        Me.radManual.Size = New System.Drawing.Size(141, 30)
        Me.radManual.TabIndex = 8
        Me.radManual.TabStop = True
        Me.radManual.Text = "Manual Mode"
        Me.radManual.UseVisualStyleBackColor = False
        '
        'radAuto
        '
        Me.radAuto.AutoSize = True
        Me.radAuto.BackColor = System.Drawing.Color.DimGray
        Me.radAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAuto.Location = New System.Drawing.Point(420, 388)
        Me.radAuto.MinimumSize = New System.Drawing.Size(0, 30)
        Me.radAuto.Name = "radAuto"
        Me.radAuto.Size = New System.Drawing.Size(119, 30)
        Me.radAuto.TabIndex = 9
        Me.radAuto.TabStop = True
        Me.radAuto.Text = "Auto Mode"
        Me.radAuto.UseVisualStyleBackColor = False
        '
        'btnOff
        '
        Me.btnOff.BackColor = System.Drawing.Color.DimGray
        Me.btnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOff.Location = New System.Drawing.Point(407, 306)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(132, 56)
        Me.btnOff.TabIndex = 10
        Me.btnOff.Text = "OFF"
        Me.btnOff.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(97, 257)
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
        Me.lblOnOff.BackColor = System.Drawing.Color.DimGray
        Me.lblOnOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnOff.Location = New System.Drawing.Point(172, 207)
        Me.lblOnOff.MinimumSize = New System.Drawing.Size(0, 30)
        Me.lblOnOff.Name = "lblOnOff"
        Me.lblOnOff.Size = New System.Drawing.Size(0, 30)
        Me.lblOnOff.TabIndex = 12
        Me.lblOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AircondModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOnOff)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.radAuto)
        Me.Controls.Add(Me.radManual)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fanIcon)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Name = "AircondModule"
        Me.Text = "AircondModule"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fanIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnOn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents fanIcon As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents radManual As RadioButton
    Friend WithEvents radAuto As RadioButton
    Friend WithEvents btnOff As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOnOff As Label
End Class
