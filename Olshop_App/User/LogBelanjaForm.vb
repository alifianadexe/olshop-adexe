Public Class LogBelanjaForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass
    Private Sub LogBelanjaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_order,total_harga ,tanggal_order FROM tbl_order WHERE id_user = '" + Me.Tag + "' AND is_accept = 1"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt
        data_grid.Columns(1).DefaultCellStyle.Format = "##,##0"
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            ManageDetailOrderForm.Tag = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim det As New ManageDetailOrderForm
            det.lbl_text.Tag = Me.Tag
            ManageDetailOrderForm.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refreshData()
    End Sub
End Class