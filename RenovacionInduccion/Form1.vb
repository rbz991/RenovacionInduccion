Imports System.Threading

Public Class Instr
    Private Sub Comenzar_Click(sender As Object, e As EventArgs) Handles Comenzar.Click
        Dim x As New MainH
        x.Show()
        isReading = True
        hiloArduino = New Thread(AddressOf x.ArduinoVB)
        hiloArduino.Start()
    End Sub


End Class