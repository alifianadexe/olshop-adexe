Public Class ManagementPembelian
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass
    Private Sub ManagementPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()
        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_barang, nama_barang, harga_barang, qty, id_distributor FROM tbl_barang ORDER BY qty ASC"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)
        data_grid.DataSource = dt
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            If MessageBox.Show("Ingin Menambah Stok Barang?", "Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim qtyplus As Integer = Val(InputBox("Jumlah Barang : ", "Jumlah", 0))
                If Not qtyplus = 0 Then
                    Dim id_barang As String = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
                    Dim id_distributor As String = data_grid.Rows(e.RowIndex).Cells(4).Value.ToString
                    Dim qty As Integer = data_grid.Rows(e.RowIndex).Cells(3).Value
                    Dim harga_barang As Integer = data_grid.Rows(e.RowIndex).Cells(2).Value

                    harga_barang = harga_barang - (harga_barang * 20 / 100)
                    Dim sql As String = "UPDATE tbl_barang SET qty = @v1 WHERE id_barang = '" + id_barang + "'"
                    Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                    cmnd.Parameters.AddWithValue("@v1", (qty + qtyplus))

                    Dim sql1 As String = "INSERT INTO tbl_pembelian(id_beli,id_barang,id_petugas,id_distributor,jumlah_qty,total_harga,tanggal_pembelian) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7)"
                    Using cmnd1 As New SqlClient.SqlCommand(sql1, conn)
                        cmnd1.Parameters.AddWithValue("@v1", fcn.generateID("Pembelian", "SELECT * FROM tbl_pembelian ORDER BY id_beli DESC", conn))
                        cmnd1.Parameters.AddWithValue("@v2", id_barang)
                        cmnd1.Parameters.AddWithValue("@v3", Me.Tag)
                        cmnd1.Parameters.AddWithValue("@v4", id_distributor)
                        cmnd1.Parameters.AddWithValue("@v5", qtyplus)
                        cmnd1.Parameters.AddWithValue("@v6", qtyplus * harga_barang)
                        cmnd1.Parameters.AddWithValue("@v7", Date.Now)

                        cmnd1.ExecuteNonQuery()
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Barang Berhasil Ditambahkan")
                    End Using
                End If
            End If

            End If
        refreshData()
    End Sub

End Class