Imports System.Data.SqlClient
Public Class Registration

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPlateNo.Text = ""
        txtOperatorName.Text = ""
        txtVehicleName.Text = ""
        txtVehicleType.Text = ""
        txtPlateNo.Focus()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If txtPlateNo.Text = "" Then
                MessageBox.Show("Please Enter Plate Number First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPlateNo.Focus()
            ElseIf txtOperatorName.Text = "" Then
                MessageBox.Show("Please Enter Operator Name First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtOperatorName.Focus()
            ElseIf txtVehicleName.Text = "" Then
                MessageBox.Show("Please Enter Vehicle Name First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtVehicleName.Focus()
            ElseIf txtVehicleType.Text = "" Then
                MessageBox.Show("Please Enter Vehicle Type First!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtVehicleType.Focus()
            Else
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim selectquery As String
                selectquery = "SELECT * FROM vehicle WHERE plateno='" & txtPlateNo.Text & "' OR operator='" & txtOperatorName.Text & "'"
                cmd = New SqlCommand(selectquery, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MessageBox.Show("This Vehicle is Already Registered! Try Again...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtPlateNo.Text = ""
                    txtOperatorName.Text = ""
                    txtVehicleName.Text = ""
                    txtVehicleType.Text = ""
                    txtPlateNo.Focus()
                Else
                    con.Close()
                    con.Open()
                    Dim insertquery As String
                    insertquery = "INSERT INTO vehicle(plateno, operator, vehiclename, vehicletype) VALUES('" & txtPlateNo.Text & "', '" & txtOperatorName.Text & "', '" & txtVehicleName.Text & "', '" & txtVehicleType.Text & "')"
                    cmd = New SqlCommand(insertquery, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Vehicle Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtPlateNo.Text = ""
                    txtOperatorName.Text = ""
                    txtVehicleName.Text = ""
                    txtVehicleType.Text = ""
                    txtPlateNo.Focus()
                    VehiclesInformation.VehicleTableLoader()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class