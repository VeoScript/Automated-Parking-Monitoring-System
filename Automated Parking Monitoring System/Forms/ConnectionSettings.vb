Public Class ConnectionSettings
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtDataSource.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtDatabaseName.Text = ""
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If txtDataSource.Text = "" Then
            MessageBox.Show("Enter Data Source first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDataSource.Focus()
        ElseIf txtDatabaseName.Text = "" Then
            MessageBox.Show("Enter Database first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDatabaseName.Focus()
        Else
            ConStringModule.DataSouceString = txtDataSource.Text
            ConStringModule.DatabaseString = txtDatabaseName.Text
            MessageBox.Show("Connection Saved Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtDataSource.Text = ""
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtDatabaseName.Text = ""
        End If
    End Sub
End Class