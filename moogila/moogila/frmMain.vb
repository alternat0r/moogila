Public Class frmMain

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        wb1.Navigate(txtBrowser.Text)
    End Sub

    Private Sub txtBrowser_Enter(sender As Object, e As EventArgs) Handles txtBrowser.Enter

    End Sub

    Private Sub txtBrowser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBrowser.KeyDown
        If e.KeyCode = Keys.Return Then
            wb1.Navigate(txtBrowser.Text)
        End If

    End Sub

End Class
