Public Class MainH
    Public SelectedNumber As String
    Public PerformedSequences(49) As Integer
    Public LabelIndex As Byte = 1
    Public SequenceIndex As Byte = 0
    Public LagFailed As Boolean = False
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        SelectedNumber = SelectedNumber & sender.Text
        LagFailed = False
        Dim lbls() As Control = Controls.Find("lblPreview" & LabelIndex, True)
        Dim lbl As Label = lbls(0)
        lbl.Text = sender.Text
        If Len(SelectedNumber) < 5 Then
            LabelIndex += 1
            If LabelIndex >= 5 Then
                tmrHoldUp.Enabled = True
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                For i = 0 To SequenceIndex
                    If SelectedNumber = PerformedSequences(i) Then
                        LagFailed = True
                    End If
                Next
                If LagFailed = False Then Reinforce()
                If LagFailed = True Then Failed()
                PerformedSequences(SequenceIndex) = SelectedNumber
                WriteLine(1, SelectedNumber)
            End If
        End If
        If SequenceIndex >= 50 Then
            End
        End If
    End Sub
    Private Sub Sequenceready()
        SelectedNumber = ""
        lblPreview1.Text = ""
        lblPreview2.Text = ""
        lblPreview3.Text = ""
        lblPreview4.Text = ""
        SequenceIndex += 1
        LabelIndex = 1
    End Sub

    Private Sub Reinforce()
        btnStim.Text = "Yass"
    End Sub

    Private Sub Failed()
        btnStim.Text = "Nayy"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FileOpen(1, "G:\My Drive\Datoz\InducciónVar\TEST.txt", OpenMode.Append)
    End Sub

    Private Sub tmrHoldUp_Tick(sender As Object, e As EventArgs) Handles tmrHoldUp.Tick
        Sequenceready()
        tmrHoldUp.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        btnStim.Text = ""
    End Sub
End Class






























