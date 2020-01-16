Imports System.Text

Public Class Form1

    Private TimerCounter As Integer = 0

    Private R1 As String
    Private R2 As String

    Private G1 As String
    Private G2 As String

    Private B1 As String
    Private B2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()

        If Me.BackColor = Color.White And TimerCounter >= 6 Then
            Me.BackColor = ColorTranslator.FromHtml("#" + R1 + R2 + G1 + G2 + B1 + B2)
        Else
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TimerCounter = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerCounter += 1

        If TimerCounter = 1 Then
            Dim R1ValidChar As String = "1234567890ABCDEF"
            Dim R1SB As New StringBuilder()
            Dim R1Randomize As New Random()
            For R1i As Integer = 1 To 1
                Dim R1Index As Integer = R1Randomize.Next(0, R1ValidChar.Length)
                Dim R1GeneratedChar As Char = R1ValidChar(R1Index)
                R1SB.Append(R1GeneratedChar)
            Next R1i
            Dim R1GeneretedCode = R1SB.ToString()
            R1 = R1GeneretedCode
            Console.WriteLine(R1)
        End If


        If TimerCounter = 2 Then
            Dim R2ValidChar As String = "1234567890ABCDEF"
            Dim R2SB As New StringBuilder()
            Dim R2Randomize As New Random()
            For R2i As Integer = 1 To 1
                Dim R2Index As Integer = R2Randomize.Next(0, R2ValidChar.Length)
                Dim R2GeneratedChar As Char = R2ValidChar(R2Index)
                R2SB.Append(R2GeneratedChar)
            Next R2i
            Dim R2GeneretedCode = R2SB.ToString()
            R2 = R2GeneretedCode
            If R2 = R1 Then
                Try
                    R2 += 1
                Catch ex As Exception

                End Try

            End If
            Console.WriteLine(R2)
        End If

        If TimerCounter = 3 Then
            Dim G1ValidChar As String = "1234567890ABCDEF"
            Dim G1SB As New StringBuilder()
            Dim G1Randomize As New Random()
            For G1i As Integer = 1 To 1
                Dim G1Index As Integer = G1Randomize.Next(0, G1ValidChar.Length)
                Dim G1GeneratedChar As Char = G1ValidChar(G1Index)
                G1SB.Append(G1GeneratedChar)
            Next G1i
            Dim G1GeneretedCode = G1SB.ToString()
            G1 = G1GeneretedCode
            If G1 = R2 Then
                Try
                    G1 += 1
                Catch ex As Exception

                End Try
            End If
            Console.WriteLine(G1)
        End If

        If TimerCounter = 4 Then
            Dim G2ValidChar As String = "1234567890ABCDEF"
            Dim G2SB As New StringBuilder()
            Dim G2Randomize As New Random()
            For G2i As Integer = 1 To 1
                Dim G2Index As Integer = G2Randomize.Next(0, G2ValidChar.Length)
                Dim G2GeneratedChar As Char = G2ValidChar(G2Index)
                G2SB.Append(G2GeneratedChar)
            Next G2i
            Dim G2GeneretedCode = G2SB.ToString()
            G2 = G2GeneretedCode
            If G2 = G1 Then
                Try
                    G2 += 1
                Catch ex As Exception

                End Try
            End If
            Console.WriteLine(G2)
        End If

        If TimerCounter = 5 Then
            Dim B1ValidChar As String = "1234567890ABCDEF"
            Dim B1SB As New StringBuilder()
            Dim B1Randomize As New Random()
            For B1i As Integer = 1 To 1
                Dim B1Index As Integer = B1Randomize.Next(0, B1ValidChar.Length)
                Dim B1GeneratedChar As Char = B1ValidChar(B1Index)
                B1SB.Append(B1GeneratedChar)
            Next B1i
            Dim B1GeneretedCode = B1SB.ToString()
            B1 = B1GeneretedCode
            If B1 = G2 Then
                Try
                    B1 += 1
                Catch ex As Exception

                End Try
            End If
            Console.WriteLine(B1)
        End If

        If TimerCounter = 6 Then
            Dim B2ValidChar As String = "1234567890ABCDEF"
            Dim B2SB As New StringBuilder()
            Dim B2Randomize As New Random()
            For B2i As Integer = 1 To 1
                Dim B2Index As Integer = B2Randomize.Next(0, B2ValidChar.Length)
                Dim B2GeneratedChar As Char = B2ValidChar(B2Index)
                B2SB.Append(B2GeneratedChar)
            Next B2i
            Dim B2GeneretedCode = B2SB.ToString()
            B2 = B2GeneretedCode
            If B2 = B1 Then
                Try
                    B2 += 1
                Catch ex As Exception

                End Try
            End If
            Console.WriteLine(B2)
        End If

        If TimerCounter = 7 Then
            Try
                Me.BackColor = ColorTranslator.FromHtml("#" + R1 + R2 + G1 + G2 + B1 + B2)
                Timer1.Stop()
            Catch ex As Exception
                Me.BackColor = Color.White
                Timer1.Stop()
            End Try

        End If
    End Sub

    Private Sub ShowMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMenuToolStripMenuItem.Click
        'MenuStrip1.Visible = True

        If MenuStrip1.Visible = False Then
            MenuStrip1.Visible = True
        Else
            MenuStrip1.Visible = False
        End If
    End Sub

    Private Sub CodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodeToolStripMenuItem.Click
        InputAction.Show()
    End Sub
End Class
