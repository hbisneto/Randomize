Public Class InputAction

    Private Sub InputAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Form1.BackColor
        MessageBox.Show("Entre com o texto 'comandos' para receber a lista de comandos disponíveis", "Sobre os Comandos", MessageBoxButtons.OK)
    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        If CommandText.Text = "Comandos" Or CommandText.Text = "comandos" Then
            MessageBox.Show("Comandos disponíveis:" & vbCrLf & vbCrLf & "'Set-Color: + Cor em RGB'" & vbCrLf & "Exemplo: 'Set-Color: #444444' (Para uma janela cinza escuro)" & vbCrLf & vbCrLf & "'Show About' (Mostra a janela sobre)" & vbCrLf & vbCrLf & "Mais códigos estarão disponíveis na lista em breve." & vbCrLf & "Você também pode contribuir com as atualizações de codigos desse projeto." & vbCrLf & vbCrLf & "Mande um e-mail para hbarbisneto@gmail.com se tiver qualquer duvida sobre implementações.", "Command List", MessageBoxButtons.OK)
        End If
        If CommandText.Text = "Show About" Or CommandText.Text = "show about" Or CommandText.Text = "Abrir Sobre" Then
            About.Show()
        End If

        If CommandText.Text.Contains("Set-Color: ") And CommandText.Text.Length = 18 Or CommandText.Text.Contains("set-color: ") And CommandText.Text.Length = 18 Then
            Form1.BackColor = ColorTranslator.FromHtml(CommandText.Text.Substring(11, 7))
            Me.BackColor = Form1.BackColor
        End If

        If CommandText.Text = "Close About" Or CommandText.Text = "close about" Or CommandText.Text = "Fechar Sobre" Then
            About.Close()
        End If
    End Sub
End Class