Public Class Form1
    Dim canvas As Graphics
    Dim phi = 45
    Dim theta = 45
    Dim cube(8) As ColMatrix
    Structure ColMatrix
        Dim a, b, c, d As Double
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim point1 As Point = New Point(100, 10)
        Dim point2 As Point = New Point(200, 20)
        canvas.DrawLine(Pens.Black, point1, point2)
        InitCube()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = PictureBox1.CreateGraphics()
    End Sub
    Sub InitCube()
        SetColMatrix(cube(0), -1, -1, -1, 1)
        SetColMatrix(cube(1), -1, 1, -1, 1)
        SetColMatrix(cube(2), 1, -1, -1, 1)
        SetColMatrix(cube(3), 1, 1, -1, 1)
        SetColMatrix(cube(4), -1, -1, 1, 1)
        SetColMatrix(cube(5), -1, 1, 1, 1)
        SetColMatrix(cube(6), 1, -1, 1, 1)
        SetColMatrix(cube(7), 1, 1, -1, 1)
    End Sub
    Sub SetColMatrix(ColMatrix As ColMatrix, a As Double, b As Double, c As Double, d As Double)
        ColMatrix.a = a
        ColMatrix.b = b
        ColMatrix.c = c
        ColMatrix.d = d
    End Sub
End Class
