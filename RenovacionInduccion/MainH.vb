Public Class MainH
    Public SelectedNumber(3) As Byte
    Public NumberIndex As Byte = 1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        SelectedNumber(NumberIndex) = sender.Name
        NumberIndex += 1
    End Sub

End Class