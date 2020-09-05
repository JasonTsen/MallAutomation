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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLight = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(77, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "- System Current Time -"
        '
        'radManual
        '
        Me.radManual.AutoSize = True
        Me.radManual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radManual.ForeColor = System.Drawing.SystemColors.Control
        Me.radManual.Location = New System.Drawing.Point(473, 305)
        Me.radManual.Name = "radManual"
        Me.radManual.Size = New System.Drawing.Size(141, 24)
        Me.radManual.TabIndex = 20
        Me.radManual.TabStop = True
        Me.radManual.Text = "Manual Mode"
        Me.radManual.UseVisualStyleBackColor = True
        '
        'radAuto
        '
        Me.radAuto.AutoSize = True
        Me.radAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAuto.ForeColor = System.Drawing.SystemColors.Control
        Me.radAuto.Location = New System.Drawing.Point(654, 305)
        Me.radAuto.Name = "radAuto"
        Me.radAuto.Size = New System.Drawing.Size(119, 24)
        Me.radAuto.TabIndex = 19
        Me.radAuto.TabStop = True
        Me.radAuto.Text = "Auto Mode"
        Me.radAuto.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.DimGray
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Control
        Me.btnBack.Location = New System.Drawing.Point(717, 339)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(95, 50)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "&Close"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.DimGray
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStop.Location = New System.Drawing.Point(577, 339)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(95, 50)
        Me.btnStop.TabIndex = 17
        Me.btnStop.Text = "S&top"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.Black
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblName.Location = New System.Drawing.Point(62, 105)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(260, 40)
        Me.lblName.TabIndex = 16
        '
        'lblLight
        '
        Me.lblLight.BackColor = System.Drawing.Color.Black
        Me.lblLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLight.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLight.Location = New System.Drawing.Point(62, 249)
        Me.lblLight.Name = "lblLight"
        Me.lblLight.Size = New System.Drawing.Size(260, 40)
        Me.lblLight.TabIndex = 14
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Black
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.Control
        Me.lblDateTime.Location = New System.Drawing.Point(62, 339)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(260, 40)
        Me.lblDateTime.TabIndex = 13
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Black
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.Control
        Me.lblMessage.Location = New System.Drawing.Point(62, 177)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(260, 40)
        Me.lblMessage.TabIndex = 12
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DimGray
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(429, 339)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(95, 50)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = False
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(37, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 55)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Light System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElevatorModule.My.Resources.Resources.nolight
        Me.PictureBox1.Location = New System.Drawing.Point(429, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'LightSenseModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(887, 483)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radManual)
        Me.Controls.Add(Me.radAuto)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblLight)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "LightSenseModule"
        Me.Text = "Light System"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radManual As RadioButton
    Friend WithEvents radAuto As RadioButton
    Friend WithEvents btnBack As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblLight As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
End Class
