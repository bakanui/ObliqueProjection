<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObliqueProjection
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RotationTick = New System.Windows.Forms.Timer(Me.components)
        Me.phiTextBox = New System.Windows.Forms.TextBox()
        Me.alphaTextBox = New System.Windows.Forms.TextBox()
        Me.degreeChange = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ZButton = New System.Windows.Forms.RadioButton()
        Me.YButton = New System.Windows.Forms.RadioButton()
        Me.XButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 406)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 103)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 36)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Rotating"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RotationTick
        '
        '
        'phiTextBox
        '
        Me.phiTextBox.Location = New System.Drawing.Point(5, 38)
        Me.phiTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.phiTextBox.Name = "phiTextBox"
        Me.phiTextBox.Size = New System.Drawing.Size(31, 20)
        Me.phiTextBox.TabIndex = 2
        '
        'alphaTextBox
        '
        Me.alphaTextBox.Location = New System.Drawing.Point(37, 38)
        Me.alphaTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.alphaTextBox.Name = "alphaTextBox"
        Me.alphaTextBox.Size = New System.Drawing.Size(33, 20)
        Me.alphaTextBox.TabIndex = 3
        '
        'degreeChange
        '
        Me.degreeChange.Location = New System.Drawing.Point(4, 64)
        Me.degreeChange.Margin = New System.Windows.Forms.Padding(2)
        Me.degreeChange.Name = "degreeChange"
        Me.degreeChange.Size = New System.Drawing.Size(69, 20)
        Me.degreeChange.TabIndex = 4
        Me.degreeChange.Text = "Change"
        Me.degreeChange.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ZButton)
        Me.GroupBox1.Controls.Add(Me.YButton)
        Me.GroupBox1.Controls.Add(Me.XButton)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(614, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(75, 187)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rotation Axis"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 143)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Stop Rotating"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ZButton
        '
        Me.ZButton.AutoSize = True
        Me.ZButton.Location = New System.Drawing.Point(6, 81)
        Me.ZButton.Name = "ZButton"
        Me.ZButton.Size = New System.Drawing.Size(30, 17)
        Me.ZButton.TabIndex = 4
        Me.ZButton.Text = "z"
        Me.ZButton.UseVisualStyleBackColor = True
        '
        'YButton
        '
        Me.YButton.AutoSize = True
        Me.YButton.Location = New System.Drawing.Point(6, 58)
        Me.YButton.Name = "YButton"
        Me.YButton.Size = New System.Drawing.Size(30, 17)
        Me.YButton.TabIndex = 3
        Me.YButton.TabStop = True
        Me.YButton.Text = "y"
        Me.YButton.UseVisualStyleBackColor = True
        '
        'XButton
        '
        Me.XButton.AutoSize = True
        Me.XButton.Checked = True
        Me.XButton.Location = New System.Drawing.Point(6, 35)
        Me.XButton.Name = "XButton"
        Me.XButton.Size = New System.Drawing.Size(30, 17)
        Me.XButton.TabIndex = 2
        Me.XButton.TabStop = True
        Me.XButton.Text = "x"
        Me.XButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.degreeChange)
        Me.GroupBox2.Controls.Add(Me.phiTextBox)
        Me.GroupBox2.Controls.Add(Me.alphaTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(614, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(75, 90)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transform"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "φ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "α"
        '
        'ObliqueProjection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 424)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ObliqueProjection"
        Me.Text = "Oblique Projection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RotationTick As Timer
    Friend WithEvents phiTextBox As TextBox
    Friend WithEvents alphaTextBox As TextBox
    Friend WithEvents degreeChange As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ZButton As RadioButton
    Friend WithEvents YButton As RadioButton
    Friend WithEvents XButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
