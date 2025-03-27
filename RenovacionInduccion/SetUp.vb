Imports System.Collections.Specialized.BitVector32
Imports System.Threading

Public Class SetUp
    Private Sub rdoReinforcement_CheckedChanged(sender As Object, e As EventArgs)
        grpActiveLever.Visible = True
    End Sub

    Private Sub rdoExtinction_CheckedChanged(sender As Object, e As EventArgs)
        grpActiveLever.Visible = False
        rdoAll.Checked = False
        rdoCenter.Checked = False
    End Sub

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        v = txtIV.Text
        FileOpen(1, "C:\Data\" & txtSubject.Text & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt", OpenMode.Append)
        WriteLine(1, "Subject: " & txtSubject.Text)
        WriteLine(1, "COM Port: " & txtCOM.Text)
        WriteLine(1, "Date: " & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
        WriteLine(1, "Lever 1 response: 1")
        WriteLine(1, "Lever 2 response: 2")
        WriteLine(1, "Lever 3 response: 3")
        WriteLine(1, "Lever 4 response: 4")
        WriteLine(1, "Lever 5 response: 5")
        WriteLine(1, "Reinforcer: 6")
        WriteLine(1, "*")
        ' FileOpen(1, "G:\My Drive\Datoz\InducciónVar\TEST.txt", OpenMode.Append)
        If CheckBox1.Checked = True Then
            Dim x As New Consentimiento
            x.Show()
            'x.ArduinoVB()
        ElseIf CheckBox1.Checked = False Then
            Dim x As New Main
            x.Show()
            'x.ArduinoVB()
        End If

    End Sub


End Class
