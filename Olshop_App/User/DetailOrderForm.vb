Public Class ManageDetailOrderForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Public id_user As String = ""

    Private Sub DetailOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        Dim sql1 As String = "SELECT tbl_det_order.id_barang as id_barang, jumlah_barang, tbl_det_order.harga_barang, tbl_barang.harga_barang as [harga_barang] , tbl_det_order.harga_barang as [harga_total_barang], picture, nama_barang,total_harga,tanggal_order  FROM (tbl_order INNER JOIN tbl_det_order ON tbl_det_order.id_order = tbl_order.id_order) INNER JOIN tbl_barang ON tbl_barang.id_barang = tbl_det_order.id_barang WHERE tbl_order.id_order = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql1, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Me.lbl_date.Text = rd.Item("tanggal_order")
            Me.lbl_total.Text = "Rp." + Format(rd.Item("total_harga"), "##,##0.00")
        End If

        rd.Close()

        Dim sql As String = "SELECT tbl_det_order.id_barang as [id_barang], nama_barang FROM (tbl_det_order INNER JOIN tbl_barang ON tbl_det_order.id_barang = tbl_barang.id_barang) INNER JOIN tbl_order ON tbl_det_order.id_order = tbl_order.id_order WHERE tbl_det_order.id_order = '" + Me.Tag + "'"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt

    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            Dim id_barang = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim sql As String = "SELECT tbl_det_order.id_barang as id_barang, jumlah_barang, tbl_det_order.harga_barang as [harga_total_barang], tbl_barang.harga_barang as [harga_barang] ,picture, nama_barang,total_harga,tanggal_order  FROM (tbl_order INNER JOIN tbl_det_order ON tbl_det_order.id_order = tbl_order.id_order) INNER JOIN tbl_barang ON tbl_barang.id_barang = tbl_det_order.id_barang WHERE tbl_det_order.id_barang = '" + id_barang + "' AND tbl_order.id_order = '" + Me.Tag + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                Me.lbl_nama.Text = rd.Item("nama_barang")
                Me.lbl_jumlah.Text = rd.Item("jumlah_barang")
                Me.lbl_satuan.Text = "Rp." + Format(rd.Item("harga_barang"), "##,##0.00")
                Me.lbl_beli.Text = "Rp." + Format(rd.Item("harga_total_barang"), "##,##0.00")

                Dim arr_image() As Byte = rd.Item("picture")
                Dim mstream As New IO.MemoryStream(arr_image)
                PictureBox1.Image = Image.FromStream(mstream)

            End If
            rd.Close()
        End If



    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        If MessageBox.Show("Pesanan yang dibatalkan tidak akan dikirim dan anda harus bertanggung jawab..", "Batalkan Pesanan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim sql As String = "DELETE tbl_order WHERE id_order = '" + Me.Tag + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            Dim sql1 As String = "DELETE tbl_det_order WHERE id_order = '" + Me.Tag + "'"
            Dim cmnd1 As New SqlClient.SqlCommand(sql1, conn)
            cmnd1.ExecuteNonQuery()
            cmnd.ExecuteNonQuery()
            MessageBox.Show("Pesanan Berhasil Dibatalkan")


            Me.Close()
        End If
    End Sub
End Class