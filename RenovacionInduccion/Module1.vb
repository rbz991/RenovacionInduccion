﻿Imports System.IO.Ports
Imports System.Threading

Module Module1
    Public Arduino As SerialPort
    Public hiloArduino As Thread
    Public isReading As Boolean = False
    Public v = 1
    Public Actual_Response(4) As String
    Public Previous_Response(4) As String
    Public vTimeNow As Integer
    Public vTimeStart As Integer
    Public RefCount As Double
    Public RefRdy As Boolean
    Public Countdown As Integer
    Public currentPhase As Integer = 1
    Public VIList As List(Of Integer)
    Public Structure SessionSettings
        Public Subject As String
        Public Session As Integer
        Public Port As String
        Public Phase As String
        Public ActiveLever As String
        Public Function File()
            Dim x = "G:\Mi unidad\Datoz\InducciónVar\" & Subject & "_" & Session & "_" & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss") & ".txt"
            Return x
        End Function
        Public Sub Heading(x)
            WriteLine(x, "Subject: " & Subject)
            WriteLine(x, "Session: " & Session)
            WriteLine(x, "COM Port: " & Port)
            WriteLine(x, "Date: " & Format(Date.Now, "dd-MM-yyyy_hh-mm-ss"))
            WriteLine(x, "Lever 1 response: 1")
            WriteLine(x, "Lever 2 response: 2")
            WriteLine(x, "Lever 3 response: 3")
            WriteLine(x, "Lever 4 response: 4")
            WriteLine(x, "Lever 5 response: 5")
            WriteLine(x, "Reinforcer: 6")
            WriteLine(x, "*")
        End Sub
    End Structure
End Module
