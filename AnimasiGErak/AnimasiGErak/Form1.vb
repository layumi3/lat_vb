Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        If PictureBox1.Left = PictureBox1.Left Or PictureBox1.Right = PictureBox1.Right Then
            PictureBox1.Visible = False
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = True
        PictureBox1.Visible = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        PictureBox1.Left += 10
        If PictureBox1.Left > Me.Right Then
            PictureBox1.Left = Me.Left
            PictureBox1.Visible = True
        End If

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = True
        PictureBox1.Top += 10
        If PictureBox1.Top > Me.Bottom - 280 Then
            Timer1.Enabled = False
            PictureBox1.Top = Me.Top
            PictureBox1.Visible = False
            PictureBox1.Visible = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Button1.Visible = False
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
