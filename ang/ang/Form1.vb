Public Class anime
    Private Property goingup As Boolean
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        goingup = False
        Timer1.Enabled = False
        PictureBox1.Location = New Point(90, 60)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If goingup = True Then
            If PictureBox1.Top > 10 Then
                PictureBox1.Location = New Point(PictureBox1.Location.X - 10, PictureBox1.Location.Y - 12)
            End If
        Else
            If PictureBox1.Bottom < Me.Size.Height - 75 Then
                PictureBox1.Location = New Point(PictureBox1.Location.X + 20, PictureBox1.Location.Y + 20)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        goingup = True
        Timer1.Enabled = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        goingup = False
        Timer1.Enabled = True
    End Sub
End Class
