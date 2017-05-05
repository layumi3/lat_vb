Public Class Form1

    Dim alarm As Boolean
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = Timer1.Enabled
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Caption = Timer
        If Label1.Text = Label1.Caption And alarm = True Then
            Timer1.Enabled = True
        End If
    End Sub
End Class
