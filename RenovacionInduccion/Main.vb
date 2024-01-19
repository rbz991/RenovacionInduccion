Imports System.Math
Imports System.IO.Ports

Public Class Main
    Public Arduino As SerialPort
    Function ArduinoVB() As Integer 'This function starts the Arduino-VB communication.
        Dim Countdown
        Arduino = New SerialPort(SetUp.txtCOM.Text, 9600) 'Assigns the Arduino to the selected port at a 9600 baud rate. 
        Arduino.Open() 'Starts the Arduino-VB communication.
        Countdown = Environment.TickCount + tmrStart.Interval
        tmrStart.Enabled = True
        VIGen()
        Do 'This code will run throughout the session to allow response collection. 
            Try
                If Arduino.BytesToRead > 0 Then 'Checks for activity on the Arduino.
                    Actual_Response = Split(Arduino.ReadLine(), ",") 'Splits data from the arduino into separate responses.
                End If
                If (Actual_Response(0) <> Previous_Response(0) And Actual_Response(0) <> 1) Then
                    Response(0)
                    btn1.BackColor = Color.Black
                End If
                If (Actual_Response(0) <> Previous_Response(0) And Actual_Response(0) <> 0) Then
                    btn1.BackColor = Color.White
                End If
                If (Actual_Response(1) <> Previous_Response(1) And Actual_Response(1) <> 1) Then
                    Response(1)
                    btn2.BackColor = Color.Black
                End If
                If (Actual_Response(1) <> Previous_Response(1) And Actual_Response(1) <> 0) Then
                    btn2.BackColor = Color.White
                End If
                If (Actual_Response(2) <> Previous_Response(2) And Actual_Response(2) <> 1) Then
                    Response(2)
                    btn3.BackColor = Color.Black
                End If
                If (Actual_Response(2) <> Previous_Response(2) And Actual_Response(2) <> 0) Then
                    btn3.BackColor = Color.White
                End If
                If (Actual_Response(3) <> Previous_Response(3) And Actual_Response(3) <> 1) Then
                    Response(3)
                    btn4.BackColor = Color.Black
                End If
                If (Actual_Response(3) <> Previous_Response(3) And Actual_Response(3) <> 0) Then
                    btn4.BackColor = Color.White
                End If
                If (Actual_Response(4) <> Previous_Response(4) And Actual_Response(4) <> 1) Then
                    Response(4)
                    btn5.BackColor = Color.Black
                End If
                If (Actual_Response(4) <> Previous_Response(4) And Actual_Response(4) <> 0) Then
                    btn5.BackColor = Color.White
                End If
                Previous_Response(0) = Actual_Response(0)
                Previous_Response(1) = Actual_Response(1)
                Previous_Response(2) = Actual_Response(2)
                Previous_Response(3) = Actual_Response(3)
                Previous_Response(4) = Actual_Response(4)
                If tmrStart.Enabled = False Then vTimeNow = Environment.TickCount - tmrStart.Interval  'This keeps track of time for the Data output file.
                If tmrStart.Enabled = True Then vTimeNow = (Countdown) - Environment.TickCount
                lblTime.Text = Round(vTimeNow / 1000)
                lblResponses1.Text = ResponseCount(0)
                lblResponses2.Text = ResponseCount(1)
                lblReinforcers.Text = RefCount
                If RefCount >= 50 Or lblTime.Text >= 1800 Then SessionOver() 'This sets the criteria to finish the session.
            Catch ex As Exception
            End Try
            My.Application.DoEvents()
        Loop
        Return 0
    End Function

    Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
        tmrStart.Enabled = False
    End Sub

    Private Sub Response(x As Byte)
        If tmrStart.Enabled = False Then
            ResponseCount(x) += 1
            WriteLine(1, vTimeNow, x)
            If RefRdy = True Then Reinforce()
        End If
    End Sub

    Private Sub Reinforce()
        If RefRdy = True Then
            RefRdy = False
            RefCount += 1
            WriteLine(1, vTimeNow, 6)
            Arduino.WriteLine("R")
            VIGen()
        End If
    End Sub

    Private Sub VIGen()
        Dim v = 20
        Dim n = 10 'This value represents the VI iterations. 
        Dim rd(n)
        Dim vi(n)
        Dim order
        Randomize()
        If VIList.Count = 0 Then
            For m As Integer = 1 To n
                If m = n Then vi(m) = v * (1 + Log(n)) : GoTo 1
                vi(m) = v * (1 + (Log(n)) + (n - m) * (Log(n - m)) - (n - m + 1) * Log(n - m + 1))
1:              order = Int((n * Rnd() + 1))
                If rd(order) = 0 Then
                    rd(order) = vi(m)
                Else
                    GoTo 1
                End If
            Next
            For a As Integer = 1 To n
                VIList.Add(rd(a))
            Next
        End If
        Dim Rand As New Random
        Dim p As Integer = Rand.Next(VIList.Count)
        tmrVI.Interval = (VIList.Item(p) + 1) * 1000
        tmrVI.Enabled = True
        VIList.RemoveAt(p)
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        End
    End Sub

    Private Sub SessionOver()
        WriteLine(1, "@")
        Arduino.Close()
        FileClose(1)
        btnFinish.Enabled = True
    End Sub

    Private Sub tmrVI_Tick(sender As Object, e As EventArgs) Handles tmrVI.Tick
        tmrVI.Enabled = False
        RefRdy = True
    End Sub
End Class