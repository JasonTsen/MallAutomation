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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.stopEscalator = New System.Windows.Forms.PictureBox()
        Me.startEscalator = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBuzzer = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.stopEscalator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startEscalator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.DimGray
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStart.Location = New System.Drawing.Point(536, 551)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(156, 68)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'stopEscalator
        '
        Me.stopEscalator.Image = CType(resources.GetObject("stopEscalator.Image"), System.Drawing.Image)
        Me.stopEscalator.Location = New System.Drawing.Point(390, 138)
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
        Me.startEscalator.Location = New System.Drawing.Point(390, 138)
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
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblName.Location = New System.Drawing.Point(388, 440)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(2, 31)
        Me.lblName.TabIndex = 3
        '
        'lblBuzzer
        '
        Me.lblBuzzer.AutoSize = True
        Me.lblBuzzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuzzer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuzzer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBuzzer.Location = New System.Drawing.Point(388, 481)
        Me.lblBuzzer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuzzer.Name = "lblBuzzer"
        Me.lblBuzzer.Size = New System.Drawing.Size(2, 31)
        Me.lblBuzzer.TabIndex = 4
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDateTime.Location = New System.Drawing.Point(196, 71)
        Me.lblDateTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(857, 46)
        Me.lblDateTime.TabIndex = 5
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'EscalatorSyst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1333, 692)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblBuzzer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.startEscalator)
        Me.Controls.Add(Me.stopEscalator)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EscalatorSyst"
        Me.Text = "Escalator System"
        CType(Me.stopEscalator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startEscalator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents stopEscalator As PictureBox
    Friend WithEvents startEscalator As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblBuzzer As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents timer As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
