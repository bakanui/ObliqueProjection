Public Class Form1
    Dim canvas As Graphics
    Dim phi As Double = 45 * (Math.PI / 180)
    Dim theta As Double = 45 * (Math.PI / 180)
    Dim cube(8) As ColMatrix
    Dim view(4) As ColMatrix
    Dim screen(4) As ColMatrix
    Dim VR(), VS() As ColMatrix
    Structure ColMatrix
        Dim a, b, c, d As Double
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim point1 As Point = New Point(100, 10)
        Dim point2 As Point = New Point(200, 20)
        canvas.DrawLine(Pens.Black, point1, point2)
        Init()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = PictureBox1.CreateGraphics()
    End Sub
    Sub Init()
        SetColMatrix(cube(0), -1, -1, -1, 1)
        SetColMatrix(cube(1), -1, 1, -1, 1)
        SetColMatrix(cube(2), 1, -1, -1, 1)
        SetColMatrix(cube(3), 1, 1, -1, 1)
        SetColMatrix(cube(4), -1, -1, 1, 1)
        SetColMatrix(cube(5), -1, 1, 1, 1)
        SetColMatrix(cube(6), 1, -1, 1, 1)
        SetColMatrix(cube(7), 1, 1, -1, 1)

        SetColMatrix(view(0), 1, 0, 0, 0)
        SetColMatrix(view(1), 0, 1, 0, 0)
        SetColMatrix(view(2), (Math.Atan(phi) * Math.Cos(theta)), (Math.Atan(phi) * Math.Sin(theta)), 0, 0)
        SetColMatrix(view(3), 0, 0, 0, 1)

        SetColMatrix(screen(0), 50, 0, 0, 200)
        SetColMatrix(screen(1), 0, -50, 0, 200)
        SetColMatrix(screen(2), 0, 0, 0, 0)
        SetColMatrix(screen(3), 0, 0, 0, 1)

        For i = 0 To 7
            For j = 0 To 3
                MultiplyMatrix(VR(i), cube(i), view(j))
                MultiplyMatrix(VS(i), VR(i), screen(j))
            Next
        Next
    End Sub
    Sub SetColMatrix(ColMatrix As ColMatrix, a As Double, b As Double, c As Double, d As Double)
        ColMatrix.a = a
        ColMatrix.b = b
        ColMatrix.c = c
        ColMatrix.d = d
    End Sub
    Sub MultiplyMatrix(result As ColMatrix, MatrixA As ColMatrix, MatrixB As ColMatrix)
        result.a = MatrixA.a * MatrixB.a
        result.b = MatrixA.b * MatrixB.a
        result.c = MatrixA.c * MatrixB.a
        result.d = MatrixA.d * MatrixB.a
    End Sub
End Class