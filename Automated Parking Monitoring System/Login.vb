Imports System.Data.SqlClient
Public Class Login

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Then
            MessageBox.Show("Please enter Username first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter Username first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM useraccount WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    AccountInformation.lblAccountName.Text = reader("name").ToString
                    AccountInformation.lblPosition.Text = reader("position").ToString
                    AccountInformation.lblUsername.Text = reader("username").ToString
                    reader.Close()
                    txtUsername.Focus()
                    txtUsername.Text = ""
                    txtPassword.Text = ""

                    Me.Hide()
                    Monitoring.Show()
                Else
                    MessageBox.Show("Invalid Account!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtUsername.Focus()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                End If
                con.Close()
            Catch ex As Exception
                'MsgBox(ex.Message)
                MessageBox.Show("No Connection! Please Connect to the Data source", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Focus()
                txtUsername.Focus()
                txtUsername.Text = ""
                txtPassword.Text = ""
            End Try
        End If
    End Sub

    Private Sub btnConnectionSettings_Click(sender As Object, e As EventArgs) Handles btnConnectionSettings.Click
        ConnectionSettings.ShowDialog()
    End Sub
End Class