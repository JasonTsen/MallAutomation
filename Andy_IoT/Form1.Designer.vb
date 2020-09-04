<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrance_Module
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
        Me.lblTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBuzzer = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUltra = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pic_entrance = New System.Windows.Forms.PictureBox()
        Me.pic_entrance1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pic_entrance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_entrance1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(156, 15)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(544, 31)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "Current Time"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pic_entrance1)
        Me.GroupBox1.Controls.Add(Me.pic_entrance)
        Me.GroupBox1.Controls.Add(Me.lblDisplay)
        Me.GroupBox1.Controls.Add(Me.lblBuzzer)
        Me.GroupBox1.Controls.Add(Me.lblTemp)
        Me.GroupBox1.Controls.Add(Me.lblUltra)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 281)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
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
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(336, 340)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(123, 42)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        'lblDisplay
        '
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(442, 232)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(150, 31)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackgroundWorker1
        '
        '
        'pic_entrance
        '
        Me.pic_entrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_entrance.Image = Global.Andy_IoT.My.Resources.Resources.entrace
        Me.pic_entrance.Location = New System.Drawing.Point(6, 21)
        Me.pic_entrance.Name = "pic_entrance"
        Me.pic_entrance.Size = New System.Drawing.Size(396, 246)
        Me.pic_entrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_entrance.TabIndex = 5
        Me.pic_entrance.TabStop = False
        '
        'pic_entrance1
        '
        Me.pic_entrance1.Image = Global.Andy_IoT.My.Resources.Resources.entrance_customer
        Me.pic_entrance1.Location = New System.Drawing.Point(6, 21)
        Me.pic_entrance1.Name = "pic_entrance1"
        Me.pic_entrance1.Size = New System.Drawing.Size(396, 246)
        Me.pic_entrance1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_entrance1.TabIndex = 2
        Me.pic_entrance1.TabStop = False
        Me.pic_entrance1.Visible = False
        '
        'btnBack
        '
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnBack.Location = New System.Drawing.Point(160, 340)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 42)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Entrance_Module
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnBack
        Me.ClientSize = New System.Drawing.Size(650, 394)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Entrance_Module"
        Me.Text = "Entrance Module"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pic_entrance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_entrance1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblBuzzer As Label
    Friend WithEvents lblTemp As Label
    Public WithEvents Timer1 As Timer
    Friend WithEvents lblUltra As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pic_entrance As PictureBox
    Friend WithEvents pic_entrance1 As PictureBox
    Friend WithEvents btnBack As Button
End Class
