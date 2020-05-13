Imports System.Data.SqlClient
Public Class VehiclesInformation

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtPlateNo.Text = ""
        txtOperatorName.Text = ""
        txtVehicleName.Text = ""
        txtVehicleType.Text = ""
        txtPlateNo.Focus()
        Me.Close()
    End Sub

    Private Sub VehiclesInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VehicleTableLoader()
    End Sub

    Public Sub VehicleTableLoader()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            Dim query As String
            query = "SELECT plateno AS 'Plate No.', operator AS 'Operator Name', vehiclename AS 'Vehicle Name', vehicletype AS 'Vehicle Type' FROM vehicle ORDER BY id DESC"
            cmd = New SqlCommand(query, con)

            adapter = New SqlDataAdapter(cmd)
            table = New DataTable
            adapter.Fill(table)

            vehicleInformationTable.DataSource = table
            vehicleInformationTable.Refresh()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub vehicleInformationTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles vehicleInformationTable.CellContentClick, vehicleInformationTable.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.vehicleInformationTable.Rows(e.RowIndex)

            txtPlateNo.Text = row.Cells("Plate No.").Value.ToString
            txtOperatorName.Text = row.Cells("Operator Name").Value.ToString
            txtVehicleName.Text = row.Cells("Vehicle Name").Value.ToString
            txtVehicleType.Text = row.Cells("Vehicle Type").Value.ToString

            Try
                'To Search The ID from VEHICLE and MONITORING TABLE
                con.Open()
                Dim getid As String
                getid = "SELECT id FROM vehicle WHERE plateno='" & row.Cells("Plate No.").Value.ToString & "'"
                cmd = New SqlCommand(getid, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    lblVehicleID.Text = reader("id").ToString
                    reader.Close()
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lblVehicleID.Text = "Vehicle ID" Then
            txtPlateNo.Text = ""
            txtOperatorName.Text = ""
            txtVehicleName.Text = ""
            txtVehicleType.Text = ""
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPlateNo.Text = "" Then
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtOperatorName.Text = "" Then
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtVehicleName.Text = "" Then
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                'To update the VEHICLE TABLE
                con.Open()
                Dim updateVehicle As String
                updateVehicle = "UPDATE vehicle SET plateno='" & txtPlateNo.Text & "', operator='" & txtOperatorName.Text & "', vehiclename='" & txtVehicleName.Text & "', vehicletype='" & txtVehicleType.Text & "' WHERE id='" & lblVehicleID.Text & "'"
                cmd = New SqlCommand(updateVehicle, con)
                cmd.ExecuteNonQuery()
                con.Close()

                'To update the MONITORING TABLE
                con.Open()
                Dim updateMonitor As String
                updateMonitor = "UPDATE monitoring SET plateno='" & txtPlateNo.Text & "', operator='" & txtOperatorName.Text & "', vehiclename='" & txtVehicleName.Text & "', vehicletype='" & txtVehicleType.Text & "' WHERE id='" & lblVehicleID.Text & "'"
                cmd = New SqlCommand(updateMonitor, con)
                cmd.ExecuteNonQuery()
                txtPlateNo.Text = ""
                txtOperatorName.Text = ""
                txtVehicleName.Text = ""
                txtVehicleType.Text = ""
                lblVehicleID.Text = "Vehicle ID"
                VehicleTableLoader()
                Monitoring.TableLoader()
                Monitoring.CountParkedIn()
                MessageBox.Show("Updated Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lblVehicleID.Text = "Vehicle ID" Then
            txtPlateNo.Text = ""
            txtOperatorName.Text = ""
            txtVehicleName.Text = ""
            txtVehicleType.Text = ""
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtPlateNo.Text = "" Then
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtOperatorName.Text = "" Then
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtVehicleName.Text = "" Then
            MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                'To delete the VEHICLE TABLE
                con.Open()
                Dim deleteVehicle As String
                deleteVehicle = "DELETE FROM vehicle WHERE id='" & lblVehicleID.Text & "'"
                cmd = New SqlCommand(deleteVehicle, con)
                cmd.ExecuteNonQuery()
                con.Close()

                'To delete the MONITORING TABLE
                con.Open()
                Dim deleteMonitor As String
                deleteMonitor = "DELETE FROM monitoring WHERE id='" & lblVehicleID.Text & "'"
                cmd = New SqlCommand(deleteMonitor, con)
                cmd.ExecuteNonQuery()
                txtPlateNo.Text = ""
                txtOperatorName.Text = ""
                txtVehicleName.Text = ""
                txtVehicleType.Text = ""
                lblVehicleID.Text = "Vehicle ID"
                VehicleTableLoader()
                Monitoring.TableLoader()
                Monitoring.CountParkedIn()
                MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnParkIn_Click(sender As Object, e As EventArgs) Handles btnParkIn.Click
        Try
            If lblVehicleID.Text = "Vehicle ID" Then
                txtPlateNo.Text = ""
                txtOperatorName.Text = ""
                txtVehicleName.Text = ""
                txtVehicleType.Text = ""
                MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf Monitoring.lblRemainingParkingSlot.Text = 0 Then
                MessageBox.Show("0 Slot! Please Add Slot to Parking Lot first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSearch.Focus()
            ElseIf txtPlateNo.Text = "" Then
                MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtOperatorName.Text = "" Then
                MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf txtVehicleName.Text = "" Then
                MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim getPlate As String
                getPlate = "SELECT * FROM vehicle WHERE plateno='" & txtPlateNo.Text & "' AND operator='" & txtOperatorName.Text & "' AND vehiclename='" & txtVehicleName.Text & "' AND vehicletype='" & txtVehicleType.Text & "'"
                cmd = New SqlCommand(getPlate, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    con.Close()
                    con.Open()
                    Dim search As String
                    search = "SELECT * FROM monitoring WHERE id='" & lblVehicleID.Text & "' and status='PARKIN'"
                    cmd = New SqlCommand(search, con)
                    reader = cmd.ExecuteReader
                    If reader.HasRows Then
                        txtPlateNo.Text = ""
                        txtOperatorName.Text = ""
                        txtVehicleName.Text = ""
                        txtVehicleType.Text = ""
                        lblVehicleID.Text = "Vehicle ID"
                        MessageBox.Show("This Vehicle Park In not Available, Please Parkout first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        con.Close()
                        con.Open()
                        Dim insert As String
                        insert = "INSERT INTO monitoring(id, plateno, operator, vehiclename, vehicletype, timein, dateparkedin, status) VALUES('" & lblVehicleID.Text & "', '" & txtPlateNo.Text & "', '" & txtOperatorName.Text & "', '" & txtVehicleName.Text & "', '" & txtVehicleType.Text & "', '" & Monitoring.lblTime.Text & "', '" & Monitoring.lblDate.Text & "', 'PARKIN')"
                        cmd = New SqlCommand(insert, con)
                        cmd.ExecuteNonQuery()
                        txtPlateNo.Text = ""
                        txtOperatorName.Text = ""
                        txtVehicleName.Text = ""
                        txtVehicleType.Text = ""
                        lblVehicleID.Text = "Vehicle ID"
                        MessageBox.Show("Vehicle Parked In Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Monitoring.TableLoader()
                        Monitoring.CountParkedIn()
                        con.Close()
                        con.Open()
                        Dim autoid As String
                        autoid = "SELECT * FROM monitoring WHERE id='" & lblVehicleID.Text & "' and status='PARKIN'"
                        cmd = New SqlCommand(autoid, con)
                        reader = cmd.ExecuteReader
                        If reader.HasRows Then
                            reader.Read()
                            Monitoring.lblAutoID.Text = reader("autoID").ToString
                            reader.Close()
                        End If
                        con.Close()

                        Dim parkin As Integer
                        Dim slot As Integer
                        Dim remaining As Integer

                        parkin = Integer.Parse(Monitoring.lblCountParkedIn.Text)
                        slot = Integer.Parse(Monitoring.lblCountParkingSlot.Text)
                        remaining = slot - parkin
                        Monitoring.lblRemainingParkingSlot.Text = remaining.ToString

                        con.Open()
                        Dim queryUpdate As String
                        queryUpdate = "UPDATE parkingslot SET remaining='" & Monitoring.lblRemainingParkingSlot.Text & "' WHERE id = 1"
                        cmd = New SqlCommand(queryUpdate, con)
                        cmd.ExecuteNonQuery()
                        Monitoring.RemainingSlot()
                    End If
                Else
                    txtPlateNo.Text = ""
                    txtOperatorName.Text = ""
                    txtVehicleName.Text = ""
                    txtVehicleType.Text = ""
                    MessageBox.Show("Vehicle Not Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            Dim query As String
            query = "SELECT plateno AS 'Plate No.', operator AS 'Operator Name', vehiclename AS 'Vehicle Name', vehicletype AS 'Vehicle Type' FROM vehicle WHERE plateno LIKE '%" & txtSearch.Text & "%' OR operator LIKE '%" & txtSearch.Text & "%' ORDER BY id DESC"
            cmd = New SqlCommand(query, con)

            adapter = New SqlDataAdapter(cmd)
            table = New DataTable
            adapter.Fill(table)

            vehicleInformationTable.DataSource = table
            vehicleInformationTable.Refresh()

            If vehicleInformationTable.RowCount = 0 Then
                VehicleTableLoader()
                MessageBox.Show("No record found! Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        VehicleTableLoader()
        txtSearch.Text = ""
    End Sub
End Class