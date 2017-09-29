Public Class NavigationPetugas
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Private Sub NavigationPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()
        refreshData()

    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_petugas WHERE id_petugas = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Me.lbl_id.Text = rd.Item("id_petugas")
            Me.lbl_nama.Text = rd.Item("nama_depan").ToString + " " + rd.Item("nama_belakang").ToString
            Me.lbl_jabatan.Text = rd.Item("Jabatan")
            Me.lbl_tgl.Text = Date.Now

            Dim arr_image() As Byte = rd.Item("picture")
            Dim mstream As New System.IO.MemoryStream(arr_image)
            PictureBox1.Image = Image.FromStream(mstream)

        End If

        rd.Close()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        If MessageBox.Show("Yakin?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            fcn.updateLog(Me.lbl_log.Text, conn)
            LoginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ManagementUser.Show()
    End Sub

    Private Sub btn_barang_Click(sender As Object, e As EventArgs) Handles btn_barang.Click
        ManagementBarang.Show()
    End Sub

    Private Sub btn_pembelian_Click(sender As Object, e As EventArgs) Handles btn_pembelian.Click
        ManagementPembelian.Tag = Me.Tag
        ManagementPembelian.Show()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        ManagementOrderForm.Tag = Me.Tag
        ManagementOrderForm.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class