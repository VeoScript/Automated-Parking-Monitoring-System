Imports System.Data.SqlClient
Public Class AddAccount

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter Name first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtName.Focus()
        ElseIf txtPosition.Text = "" Then
            MessageBox.Show("Please enter Position first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPosition.Focus()
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Please enter Username first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Please enter Password first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Focus()
        ElseIf txtRePassword.Text = "" Then
            MessageBox.Show("Please re-enter your password first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtRePassword.Focus()
        ElseIf txtPassword.Text <> txtRePassword.Text Then
            MessageBox.Show("Your Password doesn't match! Try again...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
            txtRePassword.Text = ""
            txtPassword.Focus()
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM useraccount WHERE name='" & txtName.Text & "' OR username='" & txtUsername.Text & "'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MessageBox.Show("This Account Name or Username is already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtName.Focus()
                    txtName.Text = ""
                    txtPosition.Text = ""
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtRePassword.Text = ""
                Else
                    con.Close()
                    con.Open()
                    Dim insert As String
                    insert = "INSERT INTO useraccount(name, position, username, password) VALUES('" & txtName.Text & "', '" & txtPosition.Text & "', '" & txtUsername.Text & "', '" & txtPassword.Text & "')"
                    cmd = New SqlCommand(insert, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("User Account Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.None)
                    txtName.Focus()
                    txtName.Text = ""
                    txtPosition.Text = ""
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtRePassword.Text = ""
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Focus()
        txtName.Text = ""
        txtPosition.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
    End Sub
End Class