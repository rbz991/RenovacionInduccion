Public Class Salida
    Dim punt As Integer = 0

    Private Sub regsalida()
        If bt1.Checked = True Then
            punt += 1
        ElseIf bt2.Checked = True Then
            punt += 2
        ElseIf bt3.Checked = True Then
            punt += 3
        ElseIf bt4.Checked = True Then
            punt += 4
        ElseIf bt5.Checked = True Then
            punt += 5
        End If
        WriteLine(1, "comentarios finales")
        WriteLine(1, "///p1///")
        WriteLine(1, TextBox1.Text)
        WriteLine(1, "///p2///")
        WriteLine(1, TextBox2.Text)
        WriteLine(1, "///s///")
        WriteLine(1, punt)
        FileClose(1)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        regsalida()
        Dim x As New Fin
        x.Show()
    End Sub


End Class