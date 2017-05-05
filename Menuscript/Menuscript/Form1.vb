Public Class Form1

    Private Sub DateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem1.Click
        Label1.Text = DateString
    End Sub

    Private Sub TimeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem1.Click
        Label1.Text = TimeString
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        OpenFileDialog1.Filter = "JPEG (*.jpg)|*.jpg"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = System.Drawing.Image.FromFile _(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        ColorDialog1.ShowDialog()
        Label1.ForeColor = ColorDialog1.Color
    End Sub
End Class
