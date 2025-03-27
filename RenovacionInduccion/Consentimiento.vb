Public Class Consentimiento
    Dim part As Double = 0
    Private Sub reg()
        WriteLine(1, "Consentimiento")
        WriteLine(1, part)
        If acept.Checked = True Then
            part += 1
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New Instr
        x.Show()
        reg()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub acept_CheckedChanged(sender As Object, e As EventArgs) Handles acept.CheckedChanged
        If acept.Checked = True Then
            Button1.Visible = True
        End If
    End Sub


End Class