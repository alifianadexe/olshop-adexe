Public Class ManagementOrderForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Private Sub ManagementOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_order, id_user, total_harga, tanggal_order FROM tbl_order WHERE is_accept = 0"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt


    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Dim id_order As String = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim detail As New DetailOrderFormPetugas
            detail.lbl_petugas.Text = Me.Tag
            detail.Tag = id_order
            detail.Show()

        End If
    End Sub
End Class