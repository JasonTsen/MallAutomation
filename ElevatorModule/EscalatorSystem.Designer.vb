<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EscalatorSyst
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EscalatorSyst))
        Me.stopEscalator = New System.Windows.Forms.PictureBox()
        Me.startEscalator = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBuzzer = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.lblReport = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnClose = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.stopEscalator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startEscalator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stopEscalator
        '
        Me.stopEscalator.Image = CType(resources.GetObject("stopEscalator.Image"), System.Drawing.Image)
        Me.stopEscalator.Location = New System.Drawing.Point(72, 122)
        Me.stopEscalator.Margin = New System.Windows.Forms.Padding(4)
        Me.stopEscalator.Name = "stopEscalator"
        Me.stopEscalator.Size = New System.Drawing.Size(456, 290)
        Me.stopEscalator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stopEscalator.TabIndex = 1
        Me.stopEscalator.TabStop = False
        '
        'startEscalator
        '
        Me.startEscalator.Image = CType(resources.GetObject("startEscalator.Image"), System.Drawing.Image)
        Me.startEscalator.Location = New System.Drawing.Point(72, 122)
        Me.startEscalator.Margin = New System.Windows.Forms.Padding(4)
        Me.startEscalator.Name = "startEscalator"
        Me.startEscalator.Size = New System.Drawing.Size(455, 290)
        Me.startEscalator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.startEscalator.TabIndex = 2
        Me.startEscalator.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblName.Location = New System.Drawing.Point(115, 420)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 29)
        Me.lblName.TabIndex = 3
        '
        'lblBuzzer
        '
        Me.lblBuzzer.AutoSize = True
        Me.lblBuzzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuzzer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBuzzer.Location = New System.Drawing.Point(115, 483)
        Me.lblBuzzer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuzzer.Name = "lblBuzzer"
        Me.lblBuzzer.Size = New System.Drawing.Size(0, 29)
        Me.lblBuzzer.TabIndex = 4
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateTime.Location = New System.Drawing.Point(482, 39)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(839, 46)
        Me.lblDateTime.TabIndex = 5
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'lblReport
        '
        Me.lblReport.AutoSize = True
        Me.lblReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblReport.Location = New System.Drawing.Point(700, 189)
        Me.lblReport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReport.Name = "lblReport"
        Me.lblReport.Size = New System.Drawing.Size(2, 31)
        Me.lblReport.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(695, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Escalator Report"
        '
        'lblDesign
        '
        Me.lblDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesign.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDesign.Location = New System.Drawing.Point(700, 142)
        Me.lblDesign.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(579, 42)
        Me.lblDesign.TabIndex = 9
        Me.lblDesign.Text = "Ultra              Buzzer                             DateTime"
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
        Me.btnStart.Location = New System.Drawing.Point(120, 566)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.ShadowDecoration.Parent = Me.btnStart
        Me.btnStart.Size = New System.Drawing.Size(135, 50)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "Start"
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
        Me.btnClose.Location = New System.Drawing.Point(341, 566)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.ShadowDecoration.Parent = Me.btnClose
        Me.btnClose.Size = New System.Drawing.Size(135, 50)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(63, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 55)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Escalator System"
        '
        'EscalatorSyst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1334, 637)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblReport)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblBuzzer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.startEscalator)
        Me.Controls.Add(Me.stopEscalator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EscalatorSyst"
        Me.Text = "Escalator System"
        CType(Me.stopEscalator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startEscalator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stopEscalator As PictureBox
    Friend WithEvents startEscalator As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblBuzzer As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents timer As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblReport As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDesign As Label
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
End Class
