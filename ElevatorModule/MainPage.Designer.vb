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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEscalator
        '
        Me.btnEscalator.BackColor = System.Drawing.Color.DimGray
        Me.btnEscalator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscalator.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEscalator.Location = New System.Drawing.Point(177, 368)
        Me.btnEscalator.Name = "btnEscalator"
        Me.btnEscalator.Size = New System.Drawing.Size(115, 60)
        Me.btnEscalator.TabIndex = 0
        Me.btnEscalator.Text = "&Escalator"
        Me.btnEscalator.UseVisualStyleBackColor = False
        '
        'btnEntrance
        '
        Me.btnEntrance.BackColor = System.Drawing.Color.DimGray
        Me.btnEntrance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrance.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEntrance.Location = New System.Drawing.Point(317, 368)
        Me.btnEntrance.Name = "btnEntrance"
        Me.btnEntrance.Size = New System.Drawing.Size(115, 60)
        Me.btnEntrance.TabIndex = 1
        Me.btnEntrance.Text = "E&ntrance"
        Me.btnEntrance.UseVisualStyleBackColor = False
        '
        'btnAircon
        '
        Me.btnAircon.BackColor = System.Drawing.Color.DimGray
        Me.btnAircon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAircon.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAircon.Location = New System.Drawing.Point(459, 368)
        Me.btnAircon.Name = "btnAircon"
        Me.btnAircon.Size = New System.Drawing.Size(115, 60)
        Me.btnAircon.TabIndex = 2
        Me.btnAircon.Text = "&Aircon"
        Me.btnAircon.UseVisualStyleBackColor = False
        '
        'btnLight
        '
        Me.btnLight.BackColor = System.Drawing.Color.DimGray
        Me.btnLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLight.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLight.Location = New System.Drawing.Point(247, 444)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Size = New System.Drawing.Size(115, 60)
        Me.btnLight.TabIndex = 3
        Me.btnLight.Text = "&Light"
        Me.btnLight.UseVisualStyleBackColor = False
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
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnAircon)
        Me.GroupBox1.Controls.Add(Me.btnEscalator)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnLight)
        Me.GroupBox1.Controls.Add(Me.btnEntrance)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(779, 521)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElevatorModule.My.Resources.Resources.giphy
        Me.PictureBox1.Location = New System.Drawing.Point(210, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(331, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DimGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(389, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 60)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "E&xit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(803, 545)
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
    Friend WithEvents Button1 As Button
End Class
