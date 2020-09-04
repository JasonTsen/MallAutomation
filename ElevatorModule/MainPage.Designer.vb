<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.btnEscalator = New System.Windows.Forms.Button()
        Me.btnEntrance = New System.Windows.Forms.Button()
        Me.btnAircon = New System.Windows.Forms.Button()
        Me.btnLight = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEscalator
        '
        Me.btnEscalator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscalator.Location = New System.Drawing.Point(127, 379)
        Me.btnEscalator.Name = "btnEscalator"
        Me.btnEscalator.Size = New System.Drawing.Size(100, 61)
        Me.btnEscalator.TabIndex = 0
        Me.btnEscalator.Text = "Escalator Module"
        Me.btnEscalator.UseVisualStyleBackColor = True
        '
        'btnEntrance
        '
        Me.btnEntrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrance.Location = New System.Drawing.Point(256, 379)
        Me.btnEntrance.Name = "btnEntrance"
        Me.btnEntrance.Size = New System.Drawing.Size(100, 60)
        Me.btnEntrance.TabIndex = 1
        Me.btnEntrance.Text = "Entrance Module"
        Me.btnEntrance.UseVisualStyleBackColor = True
        '
        'btnAircon
        '
        Me.btnAircon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAircon.Location = New System.Drawing.Point(385, 379)
        Me.btnAircon.Name = "btnAircon"
        Me.btnAircon.Size = New System.Drawing.Size(100, 61)
        Me.btnAircon.TabIndex = 2
        Me.btnAircon.Text = "Aircon Module"
        Me.btnAircon.UseVisualStyleBackColor = True
        '
        'btnLight
        '
        Me.btnLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLight.Location = New System.Drawing.Point(508, 379)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Size = New System.Drawing.Size(100, 60)
        Me.btnLight.TabIndex = 3
        Me.btnLight.Text = "Light Module"
        Me.btnLight.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(136, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 69)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mall Automation"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.btnAircon)
        Me.GroupBox1.Controls.Add(Me.btnEscalator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnLight)
        Me.GroupBox1.Controls.Add(Me.btnEntrance)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 479)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElevatorModule.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(217, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(317, 265)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(803, 503)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEscalator As Button
    Friend WithEvents btnEntrance As Button
    Friend WithEvents btnAircon As Button
    Friend WithEvents btnLight As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
