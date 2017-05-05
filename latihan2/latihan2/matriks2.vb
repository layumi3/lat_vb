Public Class matriks2

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = False
        TextBox2.Text = False
        TextBox3.Text = False
        TextBox4.Text = False
        TextBox5.Text = False
        TextBox6.Text = False
        TextBox7.Text = False
        TextBox8.Text = False
        TextBox9.Text = False
        TextBox10.Text = False
        TextBox11.Text = False
        TextBox12.Text = False
    End Sub
    Dim A(2, 2), B(2, 2), C(2, 2), D(2, 2), E(2, 2) As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tempStr As Integer
        A(0, 0) = 2
        A(0, 1) = 2
        A(1, 0) = 4
        A(1, 1) = 2

        tempStr = ""

        Dim i, j As Integer
        For i = 0 To 1
            For j = 0 To 1
                TextBox1.Text = A(i, j)
            Next j
        Next i

    End Sub
End Class