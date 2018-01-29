Public Class Form1
    Dim canvas As Graphics
    Dim phi As Double = 45 * (Math.PI / 180)
    Dim theta As Double = 45 * (Math.PI / 180)
    Dim vertex(8) As ColMatrix
    Dim edges(12) As Edge
    Dim view(4) As ColMatrix
    Dim screen(4) As ColMatrix
    Dim VR(), VS() As ColMatrix
    Structure Edge
        Dim point1 As Point
        Dim point2 As Point
    End Structure
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
        SetColMatrix(vertex(0), -1, -1, -1, 1)
        SetColMatrix(vertex(1), -1, 1, -1, 1)
        SetColMatrix(vertex(2), 1, -1, -1, 1)
        SetColMatrix(vertex(3), 1, 1, -1, 1)
        SetColMatrix(vertex(4), -1, -1, 1, 1)
        SetColMatrix(vertex(5), -1, 1, 1, 1)
        SetColMatrix(vertex(6), 1, -1, 1, 1)
        SetColMatrix(vertex(7), 1, 1, -1, 1)

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
                MultiplyMatrix(VR(i), vertex(i), view(j))
                MultiplyMatrix(VS(i), VR(i), screen(j))
            Next
        Next

        SetEdge(edges(0), VS(0), VS(1))
        SetEdge(edges(1), VS(1), VS(2))
        SetEdge(edges(2), VS(2), VS(3))
        SetEdge(edges(3), VS(3), VS(4))
        SetEdge(edges(4), VS(4), VS(5))
        SetEdge(edges(5), VS(5), VS(6))
        SetEdge(edges(6), VS(7), VS(8))
        SetEdge(edges(7), VS(9), VS(10))
        SetEdge(edges(8), VS(11), VS(12))
        SetEdge(edges(9), VS(0), VS(1))
        SetEdge(edges(10), VS(0), VS(1))
        SetEdge(edges(11), VS(0), VS(1))

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

        result.a = result.a + (MatrixA.a * MatrixB.b)
        result.b = result.b + (MatrixA.b * MatrixB.b)
        result.c = result.c + (MatrixA.c * MatrixB.b)
        result.d = result.d + (MatrixA.d * MatrixB.b)

        result.a = result.a + (MatrixA.a * MatrixB.c)
        result.b = result.b + (MatrixA.b * MatrixB.c)
        result.c = result.c + (MatrixA.c * MatrixB.c)
        result.d = result.d + (MatrixA.d * MatrixB.c)

        result.a = result.a + (MatrixA.a * MatrixB.d)
        result.b = result.b + (MatrixA.b * MatrixB.d)
        result.c = result.c + (MatrixA.c * MatrixB.d)
        result.d = result.d + (MatrixA.d * MatrixB.d)
    End Sub
    Sub SetEdge(edge As Edge, vertexA As ColMatrix, vertexB As ColMatrix)
        edge.point1 = New Point(vertexA.a, vertexA.b)
        edge.point2 = New Point(vertexB.a, vertexB.b)
    End Sub
End Class