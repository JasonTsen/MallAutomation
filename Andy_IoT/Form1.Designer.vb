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
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.lblText)
        Me.GroupBox1.Controls.Add(Me.lblTemp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(697, 281)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(565, 91)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(51, 17)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "Label3"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(565, 54)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(51, 17)
        Me.lblTemp.TabIndex = 1
        Me.lblTemp.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(565, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(291, 340)
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
        'Entrance_Module
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 394)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTime)
        Me.Name = "Entrance_Module"
        Me.Text = "Entrance Module"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStart As Button
    Friend WithEvents lblText As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents Label1 As Label
    Public WithEvents Timer1 As Timer
End Class
