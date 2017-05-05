Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Select Case ListBox1.SelectedIndex
            Case 0
                PictureBox1.Image = My.Resources.images_098
            Case 1
                PictureBox1.Image = My.Resources.MINATO
            Case 2
                PictureBox1.Image = My.Resources.NARUTO_MO
            Case 3
                PictureBox1.Image = My.Resources.kk
        End Select
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add items to a list box this:
        ListBox1.Items.Add("image_098")
        ListBox1.Items.Add("MINATO")
        ListBox1.Items.Add("NARUTO_MO")
        ListBox1.Items.Add("kk")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End

    End Sub
End Class
