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
    Public responsesByBin(39) As Integer
    Public binCounter As Integer = 0
    Public rateByPhase(2) As Integer
    Public tasaLineaBase As Integer = 0 ' O Double?
    Public phaseChangeCheck(1) As Boolean





    Public Arduino As SerialPort
    Function ArduinoVB() As Integer

        Arduino = New SerialPort(SetUp.txtCOM.Text, 9600)
        Arduino.Open()
        tmrStart.Enabled = True
        Me.Text = SetUp.txtCOM.Text


        VIList = New List(Of Integer)
        VIGen()
        Do
            Try
                If Arduino.BytesToRead > 0 Then
                    Actual_Response = Split(Arduino.ReadLine(), ",")
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
                responsesByBin(binCounter) += 1


                WriteLine(1, vTimeNow, binCounter, x)

                If RefRdy = True Then Reinforce()
            ElseIf SetUp.rdoCenter.Checked = True Then
                ResponseCount(x - 1) += 1
                WriteLine(1, vTimeNow, binCounter, x)
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
            'Preparar un resumen de los datos como preanalisis

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

        If currentPhase = 1 Then
            RefRdy = True
        End If



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

    'Private Sub tmrComponent_Tick(sender As Object, e As EventArgs) Handles tmrComponent.Tick

    '    If currentComponent = 1 Then
    '        currentComponent += 1
    '        RatMove()
    '        Dim f As Integer = 0
    '        For i = 0 To 11
    '            f += bins(0, i)
    '        Next
    '        rateByPhase(0) = f / 3
    '        'calcular la tasa de respuestas en cada bin  de extinción
    '        'si tenemos 2 bins seguidos con menos del 80% des respuestas pasa a F3


    '        'calcular la duiracion del componente 2
    '        'cambiar a duración del componente 2
    '    ElseIf currentComponent = 2 Then
    '        currentComponent += 1
    '        RatMove()
    '    ElseIf currentComponent = 3 Then
    '        SessionOver()
    '        End
    '    End If


    'End Sub

    Private Sub tmrBin_Tick(sender As Object, e As EventArgs) Handles tmrBin.Tick
        binCounter += 1

        If binCounter = 12 Then
            currentPhase = 2
            ChangePhase()

            Dim f As Integer = 0
            For i = 9 To 11
                f += responsesByBin(i)
            Next

            tasaLineaBase = (f / 3) * 0.2

        End If

        If currentPhase = 2 Then


            If binCounter < 36 Then
                If phaseChangeCheck(0) = False Then
                    If responsesByBin(binCounter - 1) < tasaLineaBase Then
                        phaseChangeCheck(0) = True
                    End If
                ElseIf phaseChangeCheck(0) = True Then
                    If responsesByBin(binCounter - 1) < tasaLineaBase Then
                        currentPhase = 3
                        ChangePhase()
                    Else
                        phaseChangeCheck(0) = False
                    End If
                End If
            Else
                currentPhase = 3
                ChangePhase()
            End If

        End If

        'Cerrar el programa
        'Limpieza "Housekeeping"
        'Bienvenida e instrucciones
        'Encuesta de satisfacciòn
        'Conección Arduino
        'Sonidos de calle de dia y de noche
        'PRUEBAS

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response(1)
    End Sub

    Private Sub ChangePhase()
        RatMove()
    End Sub

End Class






























