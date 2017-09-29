Public Class ManagementPetugas
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Dim id_petugas As String = ""

    Private Sub ManagementPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()
        refreshData()
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_petugas, nama_depan, alamat, email, no_hp, jabatan FROM tbl_petugas"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)
        data_grid.DataSource = dt
    End Sub

    Private Sub btn_sve_Click(sender As Object, e As EventArgs) Handles btn_sve.Click
        If Me.btn_sve.Text = "Save" Then
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Png)
            Dim arr_image = mstream.GetBuffer
            Dim sql As String = "INSERT INTO tbl_petugas(id_petugas,nama_depan,nama_belakang,alamat,email,no_hp,picture,jabatan) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@v8)"

            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.Parameters.AddWithValue("@v1", Me.txt_id.Text)
                cmnd.Parameters.AddWithValue("@v2", Me.txt_nama_depan.Text)
                cmnd.Parameters.AddWithValue("@v3", Me.txt_nama_belakang.Text)
                cmnd.Parameters.AddWithValue("@v4", Me.txt_alamat.Text)
                cmnd.Parameters.AddWithValue("@v5", Me.txt_email.Text)
                cmnd.Parameters.AddWithValue("@v6", Me.txt_no_hp.Text)
                cmnd.Parameters.AddWithValue("@v7", arr_image)
                cmnd.Parameters.AddWithValue("@v8", Me.txt_jabatan.Text)

                If MessageBox.Show("Apakah Data Diri Sudah Benar", "Benar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If fcn.is_there("SELECT * FROM tbl_login WHERE username = '" + Me.txt_username.Text + "'", conn) Then
                        MessageBox.Show("username Sudah Terpakai")
                    Else
                        Dim sql1 As String = "INSERT INTO tbl_login(username,id_petugas,password,status) VALUES (@v1,@v2,@v3,@v4)"
                        Using cmnd1 As New SqlClient.SqlCommand(sql1, conn)
                            cmnd1.Parameters.AddWithValue("@v1", Me.txt_username.Text)
                            cmnd1.Parameters.AddWithValue("@v2", Me.txt_id.Text)
                            cmnd1.Parameters.AddWithValue("@v3", Me.txt_password.Text)
                            cmnd1.Parameters.AddWithValue("@v4", "Petugas")

                            cmnd1.ExecuteNonQuery()
                        End Using
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Selamat Data Berhasil Ditambahkan")
                    End If
                End If
            End Using
        ElseIf Me.btn_sve.Text = "Update"
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Png)
            Dim arr_image = mstream.GetBuffer

            Dim sql1 As String = "UPDATE tbl_petugas SET nama_depan = @v1,nama_belakang = @v2,alamat = @v3,email = @v4,no_hp = @v5,picture = @v6,jabatan = @v7 WHERE id_petugas = '" + Me.txt_id.Text + "'"
            Dim sql2 As String = "UPDATE tbl_login SET username = @v1 , password = @v2 WHERE id_petugas = '" + Me.txt_id.Text + "'"
            Using cmnd1 As New SqlClient.SqlCommand(sql1, conn)
                cmnd1.Parameters.AddWithValue("@v1", Me.txt_nama_depan.Text)
                cmnd1.Parameters.AddWithValue("@v2", Me.txt_nama_belakang.Text)
                cmnd1.Parameters.AddWithValue("@v3", Me.txt_alamat.Text)
                cmnd1.Parameters.AddWithValue("@v4", Me.txt_email.Text)
                cmnd1.Parameters.AddWithValue("@v5", Me.txt_no_hp.Text)
                cmnd1.Parameters.AddWithValue("@v6", arr_image)
                cmnd1.Parameters.AddWithValue("@v7", Me.txt_jabatan.Text)

                Using cmnd2 As New SqlClient.SqlCommand(sql2, conn)
                    cmnd2.Parameters.AddWithValue("@v1", Me.txt_username.Text)
                    cmnd2.Parameters.AddWithValue("@v2", Me.txt_password.Text)

                    If MessageBox.Show("Update Data Tersebut ?", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        cmnd2.ExecuteNonQuery()
                        cmnd1.ExecuteNonQuery()

                    End If
                End Using
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
        Dim sql As String = "DELETE FROM tbl_petugas WHERE id_petugas = '" + Me.txt_username.Text + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        If MessageBox.Show("Hapus Data Ini?", "Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cmnd.ExecuteNonQuery()
            MessageBox.Show("Data Berhasil Dihapus")
        End If
        refreshData()
    End Sub

    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        is_enabled(True)
        is_clear()
        Me.txt_id.Text = fcn.generateID("Petugas", "SELECT * FROM tbl_petugas ORDER BY id_petugas DESC", conn)
    End Sub

    Private Sub is_enabled(ByVal bool As Boolean)
        Me.txt_alamat.Enabled = bool
        Me.txt_email.Enabled = bool
        Me.txt_nama_belakang.Enabled = bool
        Me.txt_nama_depan.Enabled = bool
        Me.txt_no_hp.Enabled = bool
        Me.txt_password.Enabled = bool
        Me.txt_username.Enabled = bool
        Me.txt_jabatan.Enabled = bool

        Me.btn_browse.Enabled = bool
    End Sub

    Private Sub is_clear()
        Me.txt_id.Clear()
        Me.txt_alamat.Clear()
        Me.txt_email.Clear()
        Me.txt_nama_belakang.Clear()
        Me.txt_nama_depan.Clear()
        Me.txt_no_hp.Clear()
        Me.txt_password.Clear()
        Me.txt_username.Clear()
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick
        If e.RowIndex >= 0 Then
            id_petugas = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString
            Dim sql As String = "SELECT tbl_petugas.id_petugas as id_petugas, nama_depan,nama_belakang,alamat,email,no_hp,picture,jabatan,username,password FROM tbl_petugas INNER JOIN tbl_login ON tbl_login.id_petugas = tbl_petugas.id_petugas WHERE tbl_petugas.id_petugas = '" + id_petugas + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then

                Me.txt_id.Text = rd.Item("id_petugas")
                Me.txt_username.Text = rd.Item("username")
                Me.txt_password.Text = rd.Item("password")
                Me.txt_nama_depan.Text = rd.Item("nama_depan")
                Me.txt_nama_belakang.Text = rd.Item("nama_belakang")
                Me.txt_alamat.Text = rd.Item("alamat")
                Me.txt_jabatan.Text = rd.Item("jabatan")
                Me.txt_no_hp.Text = rd.Item("no_hp")
                Me.txt_email.Text = rd.Item("email")

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


End Class