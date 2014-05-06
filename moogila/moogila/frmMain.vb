Public Class frmMain

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Call navigate()
    End Sub

    Private Sub txtBrowser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrowser.KeyDown
        If e.KeyCode = Keys.Return Then
            Call navigate()
        End If

    End Sub

    Function navigate()
        wb1.Navigate(txtBrowser.Text)
        Application.DoEvents()
        System.Threading.Thread.Sleep(1024)
        tc1.TabPages(tc1.SelectedIndex).Text = wb1.DocumentTitle
        Me.Text = "Moogila - " & wb1.DocumentTitle
        Return Nothing
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
End Class
