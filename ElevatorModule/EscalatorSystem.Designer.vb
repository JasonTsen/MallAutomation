<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EscalatorSyst
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EscalatorSyst))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.stopEscalator = New System.Windows.Forms.PictureBox()
        Me.startEscalator = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBuzzer = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.stopEscalator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startEscalator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(422, 399)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'stopEscalator
        '
        Me.stopEscalator.Image = CType(resources.GetObject("stopEscalator.Image"), System.Drawing.Image)
        Me.stopEscalator.Location = New System.Drawing.Point(292, 40)
        Me.stopEscalator.Name = "stopEscalator"
        Me.stopEscalator.Size = New System.Drawing.Size(342, 236)
        Me.stopEscalator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stopEscalator.TabIndex = 1
        Me.stopEscalator.TabStop = False
        '
        'startEscalator
        '
        Me.startEscalator.Image = CType(resources.GetObject("startEscalator.Image"), System.Drawing.Image)
        Me.startEscalator.Location = New System.Drawing.Point(293, 40)
        Me.startEscalator.Name = "startEscalator"
        Me.startEscalator.Size = New System.Drawing.Size(341, 236)
        Me.startEscalator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.startEscalator.TabIndex = 2
        Me.startEscalator.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Location = New System.Drawing.Point(293, 300)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(2, 15)
        Me.lblName.TabIndex = 3
        '
        'lblBuzzer
        '
        Me.lblBuzzer.AutoSize = True
        Me.lblBuzzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBuzzer.Location = New System.Drawing.Point(293, 333)
        Me.lblBuzzer.Name = "lblBuzzer"
        Me.lblBuzzer.Size = New System.Drawing.Size(2, 15)
        Me.lblBuzzer.TabIndex = 4
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDateTime.Location = New System.Drawing.Point(82, 112)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(2, 15)
        Me.lblDateTime.TabIndex = 5
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'EscalatorSyst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 562)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblBuzzer)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.startEscalator)
        Me.Controls.Add(Me.stopEscalator)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
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
End Class
