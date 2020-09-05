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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.pic_entrance1)
        Me.GroupBox1.Controls.Add(Me.pic_entrance)
        Me.GroupBox1.Controls.Add(Me.lblDisplay)
        Me.GroupBox1.Controls.Add(Me.lblBuzzer)
        Me.GroupBox1.Controls.Add(Me.lblTemp)
        Me.GroupBox1.Controls.Add(Me.lblUltra)
        Me.GroupBox1.Location = New System.Drawing.Point(76, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 281)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'pic_entrance1
        '
        Me.pic_entrance1.Image = Global.ElevatorModule.My.Resources.Resources.entrance_customer
        Me.pic_entrance1.Location = New System.Drawing.Point(8, 21)
        Me.pic_entrance1.Name = "pic_entrance1"
        Me.pic_entrance1.Size = New System.Drawing.Size(396, 246)
        Me.pic_entrance1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_entrance1.TabIndex = 2
        Me.pic_entrance1.TabStop = False
        Me.pic_entrance1.Visible = False
        '
        'pic_entrance
        '
        Me.pic_entrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_entrance.Location = New System.Drawing.Point(6, 21)
        Me.pic_entrance.Name = "pic_entrance"
        Me.pic_entrance.Size = New System.Drawing.Size(396, 246)
        Me.pic_entrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_entrance.TabIndex = 5
        Me.pic_entrance.TabStop = False
        '
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(442, 232)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(150, 31)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBuzzer
        '
        Me.lblBuzzer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBuzzer.Location = New System.Drawing.Point(445, 96)
        Me.lblBuzzer.Name = "lblBuzzer"
        Me.lblBuzzer.Size = New System.Drawing.Size(138, 32)
        Me.lblBuzzer.TabIndex = 2
        Me.lblBuzzer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTemp
        '
        Me.lblTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTemp.Location = New System.Drawing.Point(445, 140)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(138, 32)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUltra
        '
        Me.lblUltra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUltra.Location = New System.Drawing.Point(445, 53)
        Me.lblUltra.Name = "lblUltra"
        Me.lblUltra.Size = New System.Drawing.Size(138, 32)
        Me.lblUltra.TabIndex = 0
        Me.lblUltra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(132, 367)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 42)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "Close"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(308, 367)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(123, 42)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(80, 33)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(544, 31)
        Me.lblTime.TabIndex = 6
        Me.lblTime.Text = "Current Time"
        '
        'EntranceModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "EntranceModule"
        Me.Text = "EntranceModule"
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
    Friend WithEvents btnBack As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblTime As Label
End Class
