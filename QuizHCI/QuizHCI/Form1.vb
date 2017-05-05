Public Class Calculator
    Private Sub Button1plus_Click(sender As Object, e As EventArgs) Handles Button1plus.Click
        TextBox3.Text = CSng(TextBox1.Text) + CSng(TextBox2.Text)
    End Sub
    Private Sub Button2min_Click(sender As Object, e As EventArgs) Handles Button2min.Click
        TextBox3.Text = CSng(TextBox1.Text) - CSng(TextBox2.Text)
    End Sub
    Private Sub Button3kali_Click(sender As Object, e As EventArgs) Handles Button3kali.Click
        TextBox3.Text = CSng(TextBox1.Text) * CSng(TextBox2.Text)
    End Sub
    Private Sub Button4bagi_Click(sender As Object, e As EventArgs) Handles Button4bagi.Click
        TextBox3.Text = CSng(TextBox1.Text) / CSng(TextBox2.Text)
        If TextBox1.Text & TextBox2.Text = 0 Then
            MsgBox("hasilnya tidak terdefinisi , karena pembagi b = 0")
        End If
    End Sub
    Private Sub Button5clr_Click(sender As Object, e As EventArgs) Handles Button5clr.Click
        TextBox3.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub
End Class
