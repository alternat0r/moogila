Public Class frmSettings

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDefaultSearch.Items.Add("Google Search")
        cmbDefaultSearch.Items.Add("Duckduckgo")
        cmbDefaultSearch.Items.Add("Baidu Search")
        cmbDefaultSearch.Items.Add("Yahoo Search")

        cmbDefaultSearch.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        txtDefaultURL.Text = My.Settings.setDefaultURL
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        txtDefaultURL.Text = My.Settings.setDefaultURL
    End Sub
End Class