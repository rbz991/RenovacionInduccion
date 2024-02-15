Public Class MainH
    Public SelectedNumber As String
    Public PerformedSequences(49) As Byte
    Public NumberIndex As Byte = 0
    Public SequenceIndex As Byte = 0
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        SelectedNumber = SelectedNumber & sender.Text
        If Len(SelectedNumber) = 4 Then
            PerformedSequences(SequenceIndex) = SelectedNumber
            WriteLine(1, SelectedNumber)
            SelectedNumber = ""
            SequenceIndex += 1
        End If
        If SequenceIndex = 50 Then
            End
        End If
    End Sub

End Class