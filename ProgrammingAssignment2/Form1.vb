Public Class Form1
    Dim graphics As Graphics
    Dim canvas As Bitmap
    Dim phi As Double = 45 * (Math.PI / 180)
    Dim theta As Double = 45 * (Math.PI / 180)
    Dim vertex(7) As Point
    Dim edges(12) As Edge
    Dim view(3, 3), screen(3, 3) As Single
    Dim VR(7), VS(7) As Point
    Structure Edge
        Dim point1 As Integer
        Dim point2 As Integer
    End Structure
    Structure Point
        Dim x, y, z, w As Single
    End Structure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Init()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        canvas = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        graphics = Graphics.FromImage(canvas)
    End Sub
    Sub DrawCube()
        Dim i, j As Integer
        For j = 0 To 3
            graphics.DrawLine(Pens.Red, VS(edges(j).point1).x, VS(edges(j).point1).y, VS(edges(j).point2).x, VS(edges(j).point2).y)
        Next
        For i = 4 To 11
            graphics.DrawLine(Pens.Black, VS(edges(i).point1).x, VS(edges(i).point1).y, VS(edges(i).point2).x, VS(edges(i).point2).y)
        Next
        PictureBox1.Image = canvas
    End Sub
    Sub Init()
        SetPoint(vertex(0), -1, -1, 1)
        SetPoint(vertex(1), 1, -1, 1)
        SetPoint(vertex(2), 1, 1, 1)
        SetPoint(vertex(3), -1, 1, 1)
        SetPoint(vertex(4), -1, -1, -1)
        SetPoint(vertex(5), 1, -1, -1)
        SetPoint(vertex(6), 1, 1, -1)
        SetPoint(vertex(7), -1, 1, -1)

        SetColMat(screen, 0, 50, 0, 0, 200)
        SetColMat(screen, 1, 0, -50, 0, 200)
        SetColMat(screen, 2, 0, 0, 0, 0)
        SetColMat(screen, 3, 0, 0, 0, 1)

        SetColMat(view, 0, 1, 0, 0, 0)
        SetColMat(view, 1, 0, 1, 0, 0)
        SetColMat(view, 2, 0, 0, 1, 0)
        SetColMat(view, 3, 0, 0, (1.0 / -5), 1)

        SetEdge(edges(0), 0, 1)
        SetEdge(edges(1), 1, 2)
        SetEdge(edges(2), 2, 3)
        SetEdge(edges(3), 3, 0)
        SetEdge(edges(4), 4, 5)
        SetEdge(edges(5), 5, 6)
        SetEdge(edges(6), 6, 7)
        SetEdge(edges(7), 7, 4)
        SetEdge(edges(8), 0, 4)
        SetEdge(edges(9), 1, 5)
        SetEdge(edges(10), 2, 6)
        SetEdge(edges(11), 3, 7)

        For i = 0 To 7
            VR(i) = MultiplyMat(vertex(i), view)
            VS(i) = MultiplyMat(VR(i), screen)
        Next
        DrawCube()
    End Sub
    Sub SetEdge(ByRef edge As Edge, n1 As Integer, n2 As Integer)
        edge.point1 = n1
        edge.point2 = n2
    End Sub
    Sub SetPoint(ByRef point As Point, x As Integer, y As Integer, z As Integer)
        point.x = x
        point.y = y
        point.z = z
        point.w = 1
    End Sub
    Sub SetColMat(ByRef Matrix(,) As Single, col As Integer, a As Double, b As Double, c As Double, d As Double)
        Matrix(0, col) = a
        Matrix(1, col) = b
        Matrix(2, col) = c
        Matrix(3, col) = d
    End Sub
    Function MultiplyMat(point As Point, M(,) As Single) As Point
        Dim result As Point
        Dim w As Single
        w = (point.x * M(0, 3) + point.y * M(1, 3) + point.z * M(2, 3) + point.w * M(3, 3))
        result.x = (point.x * M(0, 0) + point.y * M(1, 0) + point.z * M(2, 0) + point.w * M(3, 0)) / w
        result.y = (point.x * M(0, 1) + point.y * M(1, 1) + point.z * M(2, 1) + point.w * M(3, 1)) / w
        result.z = (point.x * M(0, 2) + point.y * M(1, 2) + point.z * M(2, 2) + point.w * M(3, 2)) / w
        result.w = 1
        Return result
    End Function
End Class