Public Class SetUp
    Private Sub rdoReinforcement_CheckedChanged(sender As Object, e As EventArgs) Handles rdoReinforcement.CheckedChanged
        grpActiveLever.Visible = True
    End Sub

    Private Sub rdoExtinction_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExtinction.CheckedChanged
        grpActiveLever.Visible = False
        rdoAll.Checked = False
        rdoCenter.Checked = False
    End Sub

    Private Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Dim Session As New SessionSettings
        Session.Subject = txtSubject.Text
        Session.Session = txtSession.Text
        Session.Port = txtCOM.Text
        If rdoReinforcement.Checked = True Then Session.Phase = rdoReinforcement.Text
        If rdoExtinction.Checked = True Then Session.Phase = rdoExtinction.Text
        If rdoAll.Checked = True Then Session.ActiveLever = rdoAll.Text
        If rdoCenter.Checked = True Then Session.ActiveLever = rdoCenter.Text
        If Session.Phase = rdoExtinction.Text Then Session.ActiveLever = "None"
        FileOpen(1, Session.File(), OpenMode.Append)
        Session.Heading(1)

        Dim x As New Main
        x.Show()
        x.ArduinoVB()
    End Sub
End Class
