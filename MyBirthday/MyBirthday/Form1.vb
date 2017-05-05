Public Class DatePicker


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Your birth date was " & DateTimePicker1.Text)
        MsgBox("Day of the year: " & DateTimePicker1.Value.DayOfYear.ToString())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

End Class
