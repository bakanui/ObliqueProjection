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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 406)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(628, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Rotate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RotationTick
        '
        '
        'phiTextBox
        '
        Me.phiTextBox.Location = New System.Drawing.Point(616, 54)
        Me.phiTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.phiTextBox.Name = "phiTextBox"
        Me.phiTextBox.Size = New System.Drawing.Size(31, 20)
        Me.phiTextBox.TabIndex = 2
        '
        'alphaTextBox
        '
        Me.alphaTextBox.Location = New System.Drawing.Point(659, 54)
        Me.alphaTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.alphaTextBox.Name = "alphaTextBox"
        Me.alphaTextBox.Size = New System.Drawing.Size(33, 20)
        Me.alphaTextBox.TabIndex = 3
        '
        'degreeChange
        '
        Me.degreeChange.Location = New System.Drawing.Point(628, 76)
        Me.degreeChange.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.degreeChange.Name = "degreeChange"
        Me.degreeChange.Size = New System.Drawing.Size(56, 20)
        Me.degreeChange.TabIndex = 4
        Me.degreeChange.Text = "Change"
        Me.degreeChange.UseVisualStyleBackColor = True
        '
        'ObliqueProjection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 424)
        Me.Controls.Add(Me.degreeChange)
        Me.Controls.Add(Me.alphaTextBox)
        Me.Controls.Add(Me.phiTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ObliqueProjection"
        Me.Text = "Oblique Projection"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RotationTick As Timer
    Friend WithEvents phiTextBox As TextBox
    Friend WithEvents alphaTextBox As TextBox
    Friend WithEvents degreeChange As Button
End Class
