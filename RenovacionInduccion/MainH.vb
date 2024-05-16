Imports System.Math
Imports System.IO.Ports

Public Class MainH
    Public SelectedNumber As String
    Public PerformedSequences(49) As Integer
    Public LabelIndex As Byte = 1
    Public SequenceIndex As Byte = 0
    Public LagFailed As Boolean = False
    Public blnRatRotation = False
    Public ratJumpCounter As Integer = 0
    Public blnRatJump As Boolean = False
    Public currentComponent As Byte = 0
    'Private Sub Button_Click(sender As Object, e As EventArgs)
    '    SelectedNumber = SelectedNumber & sender.Text
    '    LagFailed = False
    '    Dim lbls() As Control = Controls.Find("lblPreview" & LabelIndex, True)
    '    Dim lbl As Label = lbls(0)
    '    lbl.Text = sender.Text
    '    If Len(SelectedNumber) < 5 Then
    '        LabelIndex += 1
    '        If LabelIndex >= 5 Then
    '            tmrHoldUp.Enabled = True
    '            'Button1.Enabled = False
    '            'Button2.Enabled = False
    '            'Button3.Enabled = False
    '            'Button4.Enabled = False
    '            For i = 0 To SequenceIndex
    '                If SelectedNumber = PerformedSequences(i) Then
    '                    LagFailed = True
    '                End If
    '            Next
    '            If LagFailed = False Then Reinforce()
    '            'If LagFailed = True Then Failed()
    '            PerformedSequences(SequenceIndex) = SelectedNumber
    '            WriteLine(1, SelectedNumber)
    '        End If
    '    End If
    '    If SequenceIndex >= 50 Then
    '        End
    '    End If
    'End Sub
    'Private Sub Sequenceready()
    '    SelectedNumber = ""
    '    'lblPreview1.Text = ""
    '    'lblPreview2.Text = ""
    '    'lblPreview3.Text = ""
    '    'lblPreview4.Text = ""
    '    SequenceIndex += 1
    '    LabelIndex = 1
    'End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FileOpen(1, "G:\My Drive\Datoz\InducciónVar\TEST.txt", OpenMode.Append)
    End Sub

    'Private Sub tmrHoldUp_Tick(sender As Object, e As EventArgs) Handles tmrHoldUp.Tick
    '    Sequenceready()
    '    tmrHoldUp.Enabled = False
    '    'Button1.Enabled = True
    '    'Button2.Enabled = True
    '    'Button3.Enabled = True
    '    'Button4.Enabled = True
    '    'btnStim.Text = ""
    'End Sub
















    Public Arduino As SerialPort
        Function ArduinoVB() As Integer 'This function starts the Arduino-VB communication.

        Arduino = New SerialPort(SetUp.txtCOM.Text, 9600) 'Assigns the Arduino to the selected port at a 9600 baud rate. 
        Arduino.Open() 'Starts the Arduino-VB communication.
        tmrStart.Enabled = True
        'Arduino.WriteLine("abh")
        Me.Text = SetUp.txtCOM.Text


        VIList = New List(Of Integer)
        VIGen()
        Do 'This code will run throughout the session to allow response collection. 
            Try
                If Arduino.BytesToRead > 0 Then 'Checks for activity on the Arduino.
                    Actual_Response = Split(Arduino.ReadLine(), ",") 'Splits data from the arduino into separate responses.
                End If
                If (Actual_Response(0) <> Previous_Response(0) And Actual_Response(0) <> 1) Then
                    Response(1)
                End If
                If (Actual_Response(1) <> Previous_Response(1) And Actual_Response(1) <> 1) Then
                    Response(2)
                End If
                If (Actual_Response(2) <> Previous_Response(2) And Actual_Response(2) <> 1) Then
                    Response(3)
                End If
                If (Actual_Response(3) <> Previous_Response(3) And Actual_Response(3) <> 1) Then
                    Response(4)
                End If
                If (Actual_Response(4) <> Previous_Response(4) And Actual_Response(4) <> 1) Then
                    Response(5)
                End If

                Previous_Response(0) = Actual_Response(0)
                Previous_Response(1) = Actual_Response(1)
                Previous_Response(2) = Actual_Response(2)
                Previous_Response(3) = Actual_Response(3)
                Previous_Response(4) = Actual_Response(4)



                If tmrStart.Enabled = False Then vTimeNow = Environment.TickCount - vTimeStart  'This keeps track of time for the Data output file.
                'If tmrStart.Enabled = True Then vTimeNow = (Countdown) - Environment.TickCount


                ' lblTime.Text = Round(vTimeNow / 1000)
                'lblResponses1.Text = ResponseCount(0)
                'lblResponses2.Text = ResponseCount(1)
                'lblResponses3.Text = ResponseCount(2)
                'lblResponses4.Text = ResponseCount(3)
                'lblResponses5.Text = ResponseCount(4)
                'lblIV.Text = v
                lblReforzadores.Text = RefCount
                If vTimeNow >= 900 Then SessionOver() 'This sets the criteria to finish the session.

            Catch ex As Exception
            End Try
            My.Application.DoEvents()
        Loop
        Return 0
        End Function

        Private Sub tmrStart_Tick(sender As Object, e As EventArgs) Handles tmrStart.Tick
            tmrStart.Enabled = False
            vTimeStart = Environment.TickCount
        currentComponent += 1


    End Sub

        Private Sub Response(x As Byte)
            If tmrStart.Enabled = False Then
            If SetUp.rdoAll.Checked = True Then
                RatJump()

                ResponseCount(x - 1) += 1
                WriteLine(1, vTimeNow, x)
                If RefRdy = True Then Reinforce()
            ElseIf SetUp.rdoCenter.Checked = True Then
                ResponseCount(x - 1) += 1
                    WriteLine(1, vTimeNow, x)
                    If x = 3 Then
                    RatJump()
                    If RefRdy = True Then Reinforce()
                End If
                End If

            End If
        End Sub

        Private Sub Reinforce()
            If RefRdy = True Then

                RefRdy = False
                RefCount += 1
                WriteLine(1, vTimeNow, 6)
            'Arduino.WriteLine("P")
            VIGen()

        End If
        End Sub

        Private Sub VIGen()

            Dim n = 10 'This value represents the VI iterations. 
            Dim rd(n)
            Dim vi(n)
            Dim order
            Randomize()
            If VIList.Count = 0 Then
                For m As Integer = 1 To n
                    If m = n Then vi(m) = v * (1 + Log(n)) : GoTo 1
                    vi(m) = v * (1 + (Log(n)) + (n - m) * (Log(n - m)) - (n - m + 1) * Log(n - m + 1))
1:                  order = Int((n * Rnd() + 1))
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

    'Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
    '    If btnFinish.BackColor = Color.Red Then
    '        End
    '    Else
    '        WriteLine(1, "Forced exit time: " & (vTimeNow / 1000) / 60)
    '        Arduino.WriteLine("hab")
    '        Arduino.Close()
    '        FileClose(1)
    '        End
    '    End If
    '    End
    'End Sub

    Private Sub SessionOver()
            Try
                WriteLine(1, "Total time: " & (vTimeNow / 1000) / 60)
            'Arduino.WriteLine("hab")
            Arduino.Close()
                FileClose(1)
            ' btnFinish.BackColor = Color.Red
        Catch ex As Exception
            End Try
        End Sub

        Private Sub tmrVI_Tick(sender As Object, e As EventArgs) Handles tmrVI.Tick
            tmrVI.Enabled = False
            RefRdy = True
        End Sub



    Private Sub RatMove()
        If blnRatRotation = False Then
            blnRatRotation = True
            pctRat.ImageLocation = "C:\Users\rbz99\Source\Repos\rbz991\RenovacionInduccion\RenovacionInduccion\Resources\rat_rotated.gif"
            BackgroundImage = My.Resources.fondoCalle_noche
        ElseIf blnRatRotation = True Then
            blnRatRotation = False
            pctRat.ImageLocation = "C:\Users\rbz99\Source\Repos\rbz991\RenovacionInduccion\RenovacionInduccion\Resources\rat.gif"
            BackgroundImage = My.Resources.fondoCalle
        End If

    End Sub

    Private Sub RatJump()
        If tmrRatJump.Enabled = False Then
            tmrRatJump.Enabled = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RatMove()
    End Sub

    Private Sub tmrRatJump_Tick(sender As Object, e As EventArgs) Handles tmrRatJump.Tick
        If blnRatJump = True Then
            pctRat.Top = pctRat.Top + 15
            ratJumpCounter -= 1
            If ratJumpCounter = 0 Then
                tmrRatJump.Enabled = False
                blnRatJump = False
            End If
        ElseIf blnRatJump = False Then
            pctRat.Top = pctRat.Top - 15
            ratJumpCounter += 1
            If ratJumpCounter = 5 Then blnRatJump = True
        End If
    End Sub

    Private Sub tmrComponent_Tick(sender As Object, e As EventArgs) Handles tmrComponent.Tick

        If currentComponent = 1 Then
            currentComponent += 1
            RatMove()
        ElseIf currentComponent = 2 Then
            currentComponent += 1
            RatMove()
        ElseIf currentComponent = 3 Then
            SessionOver()
            End
        End If


    End Sub
End Class






























