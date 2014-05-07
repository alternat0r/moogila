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

        Return Nothing
    End Function

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub wb1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb1.DocumentCompleted
        tc1.TabPages(tc1.SelectedIndex).Text = wb1.DocumentTitle
        Me.Text = "Moogila - " & wb1.DocumentTitle
        Dim iconURL = "http://" & wb1.Url.Host & "/favicon.ico"
        Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(iconURL)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim stream As System.IO.Stream = response.GetResponseStream()
        Dim favicon = Image.FromStream(stream)
        If stream.WriteTimeout Then
            'PictureBox1.Image = favicon
        Else
            'web_pic.Image =  <<RESOURCE>>
        End If
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb1.Items.Add("http://")
        cmb1.Items.Add("https://")

        cmb1.SelectedIndex = 0
    End Sub

    '/* generate new object everytime user create new tab */
    Private Sub NewTabToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem1.Click
        Dim tabpage As New TabPage
        tabpage.Text = "(empty)"

        Dim web1 As New WebBrowser
        web1.Parent = tabpage
        web1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top

        tc1.TabPages.Add(tabpage)
    End Sub

    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        NewTabToolStripMenuItem1_Click(sender, e)
    End Sub

    Private Sub wb1_StatusTextChanged(sender As Object, e As EventArgs) Handles wb1.StatusTextChanged
        ToolStripStatusLabel1.Text = wb1.StatusText
    End Sub

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        tc1.TabPages.Remove(tc1.SelectedTab)
    End Sub
End Class
