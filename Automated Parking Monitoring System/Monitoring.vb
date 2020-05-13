Imports System.Data.SqlClient
Public Class Monitoring

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable

    Private Sub Monitoring_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        TableLoader()
        CountParkedIn()
        CountParkingSlot()
        RemainingSlot()
    End Sub

    Public Sub RemainingSlot()
        Try
            con.Close()
            con.Open()
            Dim query As String
            query = "SELECT remaining FROM parkingslot WHERE id = 1"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                lblRemainingParkingSlot.Text = reader("remaining").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountParkingSlot()
        Try
            con.Open()
            Dim query As String
            query = "SELECT slot FROM parkingslot WHERE id = 1"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                lblCountParkingSlot.Text = reader("slot").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CountParkedIn()
        Try
            con.Open()
            Dim query As String
            query = "SELECT COUNT(id) AS PARKEDIN FROM monitoring WHERE status='PARKIN'"
            cmd = New SqlCommand(query, con)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                reader.Read()
                lblCountParkedIn.Text = reader("PARKEDIN").ToString
                reader.Close()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub TableLoader()
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            Dim query As String
            query = "SELECT plateno AS 'Plate No.', operator AS 'Operator Name', vehiclename AS 'Vehicle Name', vehicletype AS 'Vehicle Type', timein AS 'Park In', timeout AS 'Park Out', dateparkedin AS 'Date Parked In', dateparkedout AS 'Date Parked Out' FROM monitoring ORDER BY autoID DESC"
            cmd = New SqlCommand(query, con)

            adapter = New SqlDataAdapter(cmd)
            table = New DataTable
            adapter.Fill(table)

            parkedListTable.DataSource = table
            parkedListTable.Refresh()

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = String.Format("{0:D}", DateTime.Today)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        Registration.ShowDialog()
    End Sub

    Private Sub btnVehiclesList_Click(sender As Object, e As EventArgs) Handles btnVehiclesList.Click
        VehiclesInformation.ShowDialog()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        History.ShowDialog()
    End Sub

    Private Sub btnParkingSlot_Click(sender As Object, e As EventArgs) Handles btnParkingSlot.Click
        ParkingSlot.ShowDialog()
    End Sub

    Private Sub btnAccountInformation_Click(sender As Object, e As EventArgs) Handles btnAccountInformation.Click
        AccountInformation.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Text = ""
    End Sub

    Private Sub txtSearch_OnValueChanged(sender As Object, e As EventArgs) Handles txtSearch.OnValueChanged
        Try
            If txtSearch.Text = "" Then
                'MessageBox.Show("Please Input First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                lblVehicleID.Text = ""
                lblPlateNo.Text = ""
                lblOperatorName.Text = ""
                lblVehicleName.Text = ""
                lblVehicleType.Text = ""
                txtSearch.Focus()
            Else
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM vehicle WHERE plateno LIKE '%" & txtSearch.Text & "%' OR operator LIKE '%" & txtSearch.Text & "%'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    lblVehicleID.Text = reader("id").ToString
                    lblPlateNo.Text = reader("plateno").ToString
                    lblOperatorName.Text = reader("operator").ToString
                    lblVehicleName.Text = reader("vehiclename").ToString
                    lblVehicleType.Text = reader("vehicletype").ToString
                    reader.Close()
                Else
                    lblVehicleID.Text = ""
                    lblPlateNo.Text = ""
                    lblOperatorName.Text = ""
                    lblVehicleName.Text = ""
                    lblVehicleType.Text = ""
                    txtSearch.Focus()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub parkedListTable_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles parkedListTable.CellFormatting
        Dim i As Integer

        For i = 0 To parkedListTable.Rows.Count - 1
            If parkedListTable.Rows(i).Cells("Park Out").Value.ToString = "" Then
                parkedListTable.Rows(i).DefaultCellStyle.BackColor = Color.FromArgb(113, 168, 162)
                parkedListTable.Rows(i).DefaultCellStyle.ForeColor = Color.FromArgb(17, 49, 72)
                parkedListTable.Rows(i).DefaultCellStyle.SelectionBackColor = Color.FromArgb(17, 49, 72)
                parkedListTable.Rows(i).DefaultCellStyle.SelectionForeColor = Color.White
            End If
        Next
    End Sub

    Private Sub parkedListTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles parkedListTable.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.parkedListTable.Rows(e.RowIndex)

            txtSearch.Text = row.Cells("Plate No.").Value.ToString
        End If
    End Sub

    Private Sub btnParkIn_Click(sender As Object, e As EventArgs) Handles btnParkIn.Click
        Try
            If lblPlateNo.Text = "" Then
                MessageBox.Show("Please Search Plate No. First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSearch.Focus()
            ElseIf lblRemainingParkingSlot.Text = 0 Then
                MessageBox.Show("0 Slot! Please Add Slot to Parking Lot first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSearch.Focus()
            ElseIf lblRemainingParkingSlot.Text = 0 Then
                MessageBox.Show("Sorry there is no available parking area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSearch.Focus()
            Else
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM monitoring WHERE id='" & lblVehicleID.Text & "' and status='PARKIN'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    MessageBox.Show("This Vehicle Park In not Available, Please Parkout first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    con.Close()
                    con.Open()
                    Dim insert As String
                    insert = "INSERT INTO monitoring(id, plateno, operator, vehiclename, vehicletype, timein, dateparkedin, status) VALUES('" & lblVehicleID.Text & "', '" & lblPlateNo.Text & "', '" & lblOperatorName.Text & "', '" & lblVehicleName.Text & "', '" & lblVehicleType.Text & "', '" & lblTime.Text & "', '" & lblDate.Text & "', 'PARKIN')"
                    cmd = New SqlCommand(insert, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Vehicle Parked In Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TableLoader()
                    CountParkedIn()
                    CountParkingSlot()

                    con.Close()
                    con.Open()
                    Dim autoid As String
                    autoid = "SELECT * FROM monitoring WHERE id='" & lblVehicleID.Text & "' and status='PARKIN'"
                    cmd = New SqlCommand(autoid, con)
                    reader = cmd.ExecuteReader
                    If reader.HasRows Then
                        reader.Read()
                        lblAutoID.Text = reader("autoID").ToString
                        reader.Close()
                    End If
                    con.Close()

                    Dim parkin As Integer
                    Dim slot As Integer
                    Dim remaining As Integer

                    parkin = Integer.Parse(lblCountParkedIn.Text)
                    slot = Integer.Parse(lblCountParkingSlot.Text)
                    remaining = slot - parkin
                    lblRemainingParkingSlot.Text = remaining.ToString

                    con.Open()
                    Dim queryUpdate As String
                    queryUpdate = "UPDATE parkingslot SET remaining='" & lblRemainingParkingSlot.Text & "' WHERE id = 1"
                    cmd = New SqlCommand(queryUpdate, con)
                    cmd.ExecuteNonQuery()
                    RemainingSlot()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnParkOut_Click(sender As Object, e As EventArgs) Handles btnParkOut.Click
        Try
            If lblPlateNo.Text = "" Then
                MessageBox.Show("Please Search Plate No. First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSearch.Focus()
            Else
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM monitoring WHERE id='" & lblVehicleID.Text & "' and status='PARKIN'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader
                If reader.HasRows Then
                    reader.Read()
                    lblAutoID.Text = reader("autoID").ToString
                    reader.Close()
                    con.Close()
                    con.Open()
                    Dim update As String
                    update = "UPDATE monitoring SET timeout='" & lblTime.Text & "', dateparkedout='" & lblDate.Text & "', status='PARKOUT' WHERE id='" & lblVehicleID.Text & "' AND autoID='" & lblAutoID.Text & "'"
                    cmd = New SqlCommand(update, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Vehicle Parked Out Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TableLoader()
                    CountParkedIn()
                    CountParkingSlot()
                    con.Close()

                    Dim parkin As Integer
                    Dim slot As Integer
                    Dim remaining As Integer

                    parkin = Integer.Parse(lblCountParkedIn.Text)
                    remaining = Integer.Parse(lblRemainingParkingSlot.Text)
                    slot = remaining + 1
                    lblRemainingParkingSlot.Text = slot.ToString

                    con.Open()
                    Dim queryUpdate As String
                    queryUpdate = "UPDATE parkingslot SET remaining='" & lblRemainingParkingSlot.Text & "' WHERE id = 1"
                    cmd = New SqlCommand(queryUpdate, con)
                    cmd.ExecuteNonQuery()
                    RemainingSlot()
                Else
                    MessageBox.Show("This Vehicle Park Out not Available, Please Parkin first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnParkOutAll_Click(sender As Object, e As EventArgs) Handles btnParkOutAll.Click
        DialogResult = MessageBox.Show("Are you sure you want to Park Out all Vehicles?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult = Windows.Forms.DialogResult.Yes Then
            Try
                con = New SqlConnection
                con.ConnectionString = ConString()

                con.Open()
                Dim search As String
                search = "SELECT * FROM monitoring WHERE status='PARKIN'"
                cmd = New SqlCommand(search, con)
                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    con.Close()
                    con.Open()
                    Dim update As String
                    update = "UPDATE monitoring SET timeout='" & lblTime.Text & "', dateparkedout='" & lblDate.Text & "', status='PARKOUT' WHERE status='PARKIN'"
                    cmd = New SqlCommand(update, con)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Parked Out All Vehicles Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtSearch.Text = ""
                    txtSearch.Focus()
                    TableLoader()
                    CountParkedIn()
                    CountParkingSlot()

                    con.Close()
                    con.Open()
                    Dim queryUpdate As String
                    queryUpdate = "UPDATE parkingslot SET remaining='" & lblCountParkingSlot.Text & "' WHERE id = 1"
                    cmd = New SqlCommand(queryUpdate, con)
                    cmd.ExecuteNonQuery()
                    RemainingSlot()
                Else
                    MessageBox.Show("Invalid! No Vehicles Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Return
        End If
    End Sub
End Class
