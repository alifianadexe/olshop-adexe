Public Class DaftarForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass
    Private Sub DaftarForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()
    End Sub

    Private Sub DaftarForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()

    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        If Me.txt_re_password.Text = Me.txt_password.Text Then
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, Imaging.ImageFormat.Png)
            Dim arr_image = mstream.GetBuffer
            Dim sql As String = "INSERT INTO tbl_user(id_user,nama_depan,nama_belakang,alamat,email,no_hp,picture,is_accept) VALUES (@v1,@v2,@v3,@v4,@v5,@v6,@v7,@V8)"

            Dim id_user As String = fcn.generateID("User", "SELECT * FROM tbl_user ORDER BY id_user DESC", conn)

            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.Parameters.AddWithValue("@v1", id_user)
                cmnd.Parameters.AddWithValue("@v2", Me.txt_nama_depan.Text)
                cmnd.Parameters.AddWithValue("@v3", Me.txt_nama_belakang.Text)
                cmnd.Parameters.AddWithValue("@v4", Me.txt_alamat.Text)
                cmnd.Parameters.AddWithValue("@v5", Me.txt_email.Text)
                cmnd.Parameters.AddWithValue("@v6", Me.txt_no_hp.Text)
                cmnd.Parameters.AddWithValue("@v7", arr_image)
                cmnd.Parameters.AddWithValue("@v8", 0)

                If MessageBox.Show("Apakah Data Diri Sudah Benar", "Benar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    If fcn.is_there("SELECT * FROM tbl_login WHERE username = '" + Me.txt_username.Text + "'", conn) Then
                        MessageBox.Show("Username Sudah Terpakai")
                    Else
                        Dim sql1 As String = "INSERT INTO tbl_login(username,id_user,password,status) VALUES (@v1,@v2,@v3,@v4)"
                        Using cmnd1 As New SqlClient.SqlCommand(sql1, conn)
                            cmnd1.Parameters.AddWithValue("@v1", Me.txt_username.Text)
                            cmnd1.Parameters.AddWithValue("@v2", id_user)
                            cmnd1.Parameters.AddWithValue("@v3", Me.txt_password.Text)
                            cmnd1.Parameters.AddWithValue("@v4", "User")

                            cmnd1.ExecuteNonQuery()
                        End Using
                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Selamat Anda Berhasil Terdaftar")
                    End If
                End If
            End Using
        Else
            MessageBox.Show("Maaf, Password Tidak Cocok")
        End If


    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        LoginForm.Show()
    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged

    End Sub
End Class