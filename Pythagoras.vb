Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a1, b1, c1 As Single
        a1 = TextBox1.Text
        b1 = TextBox2.Text
        c1 = (a1 ^ 2 + b1 ^ 2) ^ (1 / 2)
        TextBox3.Text = c1

        Dim mypen As Pen
        Dim A As New Point(10, a1)
        Dim B As New Point(100, b1)
        Dim C As New Point(60, 150)
        Dim mypoint As Point() = {A, B, C}
        mypen = New Pen(Drawing.Color.Blue, 5)
        Dim G As Graphics = Me.CreateGraphics
        G.DrawPolygon(mypen, mypoint)
    End Sub
End Class
