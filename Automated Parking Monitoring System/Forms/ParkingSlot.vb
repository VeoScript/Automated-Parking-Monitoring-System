Imports System.Data.SqlClient
Public Class ParkingSlot

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Monitoring.lblCountParkedIn.Text = 0 Then
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim querySelect As String
                querySelect = "SELECT slot FROM parkingslot WHERE id = 1"
                cmd = New SqlCommand(querySelect, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    con.Close()
                    con.Open()
                    Dim queryUpdate As String
                    queryUpdate = "UPDATE parkingslot SET slot='" & txtAdd.Text & "', remaining='" & txtAdd.Text & "' WHERE id = 1"
                    cmd = New SqlCommand(queryUpdate, con)
                    cmd.ExecuteNonQuery()
                    txtAdd.Text = ""
                    txtAdd.Focus()
                    Monitoring.CountParkingSlot()
                    Monitoring.RemainingSlot()
                    MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    con.Close()
                    con.Open()
                    Dim queryInsert As String
                    queryInsert = "INSERT INTO parkingslot(slot, remaining) VALUES('" & txtAdd.Text & "', '" & txtAdd.Text & "')"
                    cmd = New SqlCommand(queryInsert, con)
                    cmd.ExecuteNonQuery()
                    txtAdd.Text = ""
                    txtAdd.Focus()
                    Monitoring.CountParkingSlot()
                    Monitoring.RemainingSlot()
                    MessageBox.Show("Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf txtAdd.Text = "" Then
            MessageBox.Show("Please Enter a Value first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdd.Text = ""
            txtAdd.Focus()
        Else
            MessageBox.Show("You cannot update the Parking Slot! Parked out all the vehicles first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAdd.Text = ""
            txtAdd.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtAdd.Text = ""
    End Sub
End Class