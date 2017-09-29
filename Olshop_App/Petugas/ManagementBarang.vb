Public Class ManagementBarang
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Dim id_barang As String = ""
    Private Sub ManagementBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_olshopDataSet.tbl_distributor' table. You can move, or remove it, as needed.
        Me.Tbl_distributorTableAdapter.Fill(Me.Db_olshopDataSet.tbl_distributor)
        conn.ConnectionString = generateString()
        conn.Open()

        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_barang,nama_barang,qty,harga_barang as [Harga Barang (Rp.)],kategori FROM tbl_barang"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        data_grid.DataSource = dt
        Me.data_grid.Columns(3).DefaultCellStyle.Format = "##,##0"

    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        is_enabled(True)
        is_clear()
        Me.txt_id.Text = fcn.generateID("Barang", "SELECT * FROM tbl_barang ORDER BY id_barang DESC", conn)

    End Sub

    Private Sub btn_sve_Click(sender As Object, e As EventArgs) Handles btn_sve.Click
        If Me.btn_sve.Text = "Save" Then
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Png)
            Dim arr_image = mstream.GetBuffer
            Dim sql As String = "INSERT INTO tbl_barang(id_barang,id_distributor,nama_barang,qty,harga_barang,picture,kategori) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7)"

            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                cmnd.Parameters.AddWithValue("@v2", Me.txt_distributor.SelectedValue)
                cmnd.Parameters.AddWithValue("@v3", Me.txt_nama.Text)
                cmnd.Parameters.AddWithValue("@v4", Me.txt_jumlah.Text)
                cmnd.Parameters.AddWithValue("@v5", Me.txt_harga.Text)
                cmnd.Parameters.AddWithValue("@v6", arr_image)
                cmnd.Parameters.AddWithValue("@v7", Me.txt_kategori.Text)

                If MessageBox.Show("Tambah Barang ?", "Tambah", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("Selamat Data Berhasil Ditambahkan")
                End If
            End Using
        ElseIf Me.btn_sve.Text = "Update"
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Png)
            Dim arr_image = mstream.GetBuffer

            Dim sql As String = "UPDATE tbl_barang SET id_distributor = @v2, nama_barang = @v3, qty = @v4, harga_barang = @v5, picture = @v6, kategori = @v7 WHERE id_barang = '" + Me.txt_id.Text + "'"
            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.Parameters.AddWithValue("@v2", Me.txt_distributor.SelectedValue)
                cmnd.Parameters.AddWithValue("@v3", Me.txt_nama.Text)
                cmnd.Parameters.AddWithValue("@v4", Me.txt_jumlah.Text)
                cmnd.Parameters.AddWithValue("@v5", Me.txt_harga.Text)
                cmnd.Parameters.AddWithValue("@v6", arr_image)
                cmnd.Parameters.AddWithValue("@v7", Me.txt_kategori.Text)

                If MessageBox.Show("Update Data Tersebut ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmnd.ExecuteNonQuery()
                    MessageBox.Show("Data Berhasil Diupdate")
                End If
            End Using
        End If
        Me.btn_sve.Text = "Save"
        is_enabled(False)
        is_clear()
        refreshData()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        is_enabled(True)
        Me.btn_sve.Text = "Update"
    End Sub

    Private Sub btn_deleye_Click(sender As Object, e As EventArgs) Handles btn_deleye.Click
        Dim sql As String = "DELETE FROM tbl_barang WHERE id_barang = '" + Me.txt_nama.Text + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        If MessageBox.Show("Hapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cmnd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
        End If
        refreshData()
    End Sub


    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_harga.Enabled = bool
        Me.txt_jumlah.Enabled = bool
        Me.txt_nama.Enabled = bool
        Me.txt_distributor.Enabled = bool
        Me.txt_kategori.Enabled = bool
        Me.btn_browse.Enabled = bool
    End Sub

    Private Sub is_clear()
        Me.txt_id.Clear()
        Me.txt_harga.Clear()
        Me.txt_jumlah.Clear()
        Me.txt_nama.Clear()
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            id_barang = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim sql As String = "SELECT tbl_barang.id_barang as id_barang, nama_barang, qty, harga_barang, picture, kategori, nama_distributor FROM tbl_barang INNER JOIN tbl_distributor ON tbl_distributor.id_distributor = tbl_barang.id_distributor WHERE tbl_barang.id_barang = '" + id_barang + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then

                Me.txt_id.Text = rd.Item("id_barang")
                Me.txt_harga.Text = rd.Item("harga_barang")
                Me.txt_jumlah.Text = rd.Item("qty")
                Me.txt_nama.Text = rd.Item("nama_barang")
                Me.txt_distributor.Text = rd.Item("nama_distributor")
                Me.txt_kategori.Text = rd.Item("kategori")

                Dim arr_image() As Byte = rd.Item("picture")
                Dim mstream As New IO.MemoryStream(arr_image)
                PictureBox1.Image = Image.FromStream(mstream)

            End If
        End If
        rd.Close()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class