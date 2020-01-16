Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Form1.BackColor
        Version.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
        AppName.BackColor = Form1.BackColor
        Version.BackColor = Form1.BackColor
        Copyright.BackColor = Form1.BackColor
    End Sub

    Private Sub FecharJanelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharJanelaToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class