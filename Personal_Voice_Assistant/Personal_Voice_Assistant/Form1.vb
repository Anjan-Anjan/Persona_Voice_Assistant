Imports System.Speech
Imports System.Speech.Recognition
Imports System.Speech.Synthesis
Imports System.IO

Public Class Assistant
    Dim WithEvents reg As New Recognition.SpeechRecognitionEngine

    Private Sub setcolor(ByVal color As System.Drawing.Color)
        Dim synth As New Synthesis.SpeechSynthesizer
        Me.BackColor = color

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reg.SetInputToDefaultAudioDevice()

        Dim gram As New Recognition.SrgsGrammar.SrgsDocument
        Dim command As New Recognition.SrgsGrammar.SrgsRule("command")
        Dim commandList As New Recognition.SrgsGrammar.SrgsOneOf("close Notepad", "close Powerpoint", "close Excel", "close Word", "open Notepad", "open Powerpoint", "open Excel", "open Word", "today date", "what time?", "red", "green", "blue", "yellow", "hello John", "hi John", "who is Anjan?", "who are you?", "describe yourself", "how are you?", "I am fine", "who made you?", "I am fine", "what about you?", "open cmd", "close cmd")

        command.Add(commandList)
        gram.Rules.Add(command)
        gram.Root = command

        reg.LoadGrammar(New Recognition.Grammar(gram))
        reg.RecognizeAsync(RecognizeMode.Multiple)

    End Sub

    Private Sub reg_RecognizeCompleted(sender As Object, e As RecognizeCompletedEventArgs) Handles reg.RecognizeCompleted
        reg.RecognizeAsync()

    End Sub

    Private Sub reg_SpeechRecognized(sender As Object, e As SpeechRecognizedEventArgs) Handles reg.SpeechRecognized

        Dim John
        Dim num As Integer
        Dim cmd As String

        John = CreateObject("sapi.spvoice")
        Johntext.Text = e.Result.Text
        cmd = e.Result.Text

        Select Case cmd
            Case "red"
                setcolor(Color.Red)
            Case "green"
                setcolor(Color.Green)
            Case "blue"
                setcolor(Color.Blue)
            Case "yellow"
                setcolor(Color.Yellow)
        End Select

        If cmd = "hello John" OrElse cmd = "hi John" Then
            num = New Random().Next(1, 5)
            If num = 1 Then
                John.speak("hello sir, what can i do for you?")
            ElseIf num = 2 Then
                John.speak("hello sir, how are you?")
            ElseIf num = 3 Then
                John.speak("hello sir, how can i help you?")
            ElseIf num = 4 Then
                John.speak("hello sir, glad to see you again?")
            End If
        End If

        If cmd = "I am fine" Then
            John.speak("glad to know that")
        End If
        If cmd = "how are you?" Then
            John.speak("I am fine, what about you Sir?")
        End If
        If cmd = "who are you?" OrElse cmd = "describe yourself" Then
            John.speak("I am John, your personal assistant, made by Anjan")
        End If
        If cmd = "who is Anjan?" Then
            John.speak("Anjan is a good boy, he is Bsc Graduate,he loves programming, new technologies and electronics, his creative mind always thought to make something new")
        End If
        If cmd = "open cmd" Then
            John.speak("opening cmd")
            Process.Start("cmd.exe")
        End If
        If cmd = "close cmd" Then
            Dim Program() As Process = System.Diagnostics.Process.GetProcessesByName("CMD")
            For Each p As Process In Program
                p.Kill()
            Next
        End If
        If cmd = "today date" Then
            John.speak(DateTime.Today)
        End If
        If cmd = "what time?" Then
            John.speak(DateTime.Now.ToString("h m,tt"))
        End If

        If cmd = "open Word" Then
            John.speak("opening Word")
            Process.Start("winword.exe")
        End If
        If cmd = "close Word" Then
            Dim Program() As Process = System.Diagnostics.Process.GetProcessesByName("winword")
            For Each p As Process In Program
                p.Kill()
            Next
        End If


        If cmd = "open Excel" Then
            John.speak("opening Excel")
            Process.Start("excel.exe")
        End If
        If cmd = "close Excel" Then
            Dim Program() As Process = System.Diagnostics.Process.GetProcessesByName("Excel")
            For Each p As Process In Program
                p.Kill()
            Next
        End If

        If cmd = "open Powerpoint" Then
            John.speak("opening Powerpoint")
            Process.Start("powerpnt.exe")
        End If
        If cmd = "close Powerpoint" Then
            Dim Program() As Process = System.Diagnostics.Process.GetProcessesByName("Powerpnt")
            For Each p As Process In Program
                p.Kill()
            Next
        End If

        If cmd = "open Notepad" Then
            John.speak("opening Notepad")
            Process.Start("Notepad.exe")
        End If
        If cmd = "close Notepad" Then
            Dim Program() As Process = System.Diagnostics.Process.GetProcessesByName("Notepad")
            For Each p As Process In Program
                p.Kill()
            Next
        End If

    End Sub
End Class
