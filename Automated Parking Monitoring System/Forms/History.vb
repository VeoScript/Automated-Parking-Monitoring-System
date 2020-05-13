Imports System.Data.SqlClient
Public Class History

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim reader As SqlDataReader
    Dim adapter As SqlDataAdapter
    Dim table As New DataTable

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HistoryTableLoader()
    End Sub

    Public Sub HistoryTableLoader()
        lblDate.Text = dtpSearchDate.Text
        Try
            con = New SqlConnection
            con.ConnectionString = ConString()

            con.Open()
            Dim query As String
            query = "SELECT plateno AS 'Plate No.', operator AS 'Operator Name', vehiclename AS 'Vehicle Name', vehicletype AS 'Vehicle Type', timein AS 'Time In', timeout AS 'Time Out', dateparkedin AS 'Date In', dateparkedout AS 'Date Out' FROM monitoring WHERE status='PARKOUT' AND dateparkedout='" & dtpSearchDate.Text & "' ORDER BY autoID DESC"
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

    Private Sub dtpSearchDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSearchDate.ValueChanged
        HistoryTableLoader()
        If parkedListTable.RowCount = 0 Then
            HistoryTableLoader()
            MessageBox.Show("No record found! Try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        dtpSearchDate.Text = Now
        HistoryTableLoader()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        dtpSearchDate.Text = Now
    End Sub
End Class