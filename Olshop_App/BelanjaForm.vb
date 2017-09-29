Public Class BelanjaForm

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Dim id_barang As String = ""
    Dim total_harga_belanja As Integer = 0
    Private Sub BelanjaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        refreshData()

        If Not Me.Tag = "" Then
            If fcn.is_there("SELECT * FROM tbl_user WHERE id_user = '" + Me.Tag + "' AND is_accept = 1", conn) Then
                btn_add.Enabled = True
                btn_order.Enabled = True
                btn_daftar.Enabled = True
                ListBox1.Enabled = True
            Else
                btn_add.Enabled = False
                btn_order.Enabled = False
                btn_daftar.Enabled = False
                ListBox1.Enabled = False
            End If
        End If
    End Sub

    Private Sub refreshData()
        Dim sql As String = "SELECT id_barang, nama_barang, harga_barang as [Harga Barang (Rp.)], qty, kategori FROM tbl_barang"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)
        data_grid.DataSource = dt
        data_grid.Columns(2).DefaultCellStyle.Format = "##,##0"
    End Sub

    Private Sub data_grid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_grid.CellClick

        If e.RowIndex >= 0 Then

            id_barang = data_grid.Rows(e.RowIndex).Cells(0).Value.ToString

            Dim sql As String = "SELECT id_barang,nama_barang,harga_barang,picture,nama_distributor FROM tbl_barang INNER JOIN tbl_distributor ON tbl_distributor.id_distributor = tbl_barang.id_distributor WHERE tbl_barang.id_barang = '" + id_barang + "'"
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If rd.HasRows Then
                Me.lbl_distributor.Text = rd.Item("nama_distributor")
                Me.lbl_id.Text = rd.Item("id_barang")
                Me.lbl_harga.Text = "Rp." + Format(rd.Item("harga_barang"), "##,##0.00")
                Me.lbl_harga.Tag = rd.Item("harga_barang")
                Me.lbl_name.Text = rd.Item("nama_barang")

                Dim arr_image() As Byte = rd.Item("picture")
                Dim mstream As New IO.MemoryStream(arr_image)
                PictureBox1.Image = Image.FromStream(mstream)

            End If
            rd.Close()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If MessageBox.Show("Hapus Dari Daftar Belanjaan ? ", "Hapus", MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
            ListBox1.Items.Remove(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim qty As Integer = Val(InputBox("Jumlah yang ingin dibeli : ", "Jumlah"))

            If Not qty = 0 Then
                Dim total_harga As Integer = Int32.Parse(Me.lbl_harga.Tag) * qty
                ListBox1.Items.Add(Me.lbl_id.Text + "-" + Me.lbl_name.Text + " * " + Str(qty) + "  :   Rp. " + Format(total_harga, "##,##0.00"))
                total_harga_belanja += total_harga
                Me.lbl_total.Text = "Rp." + Format(total_harga_belanja, "##,##0.00")
            End If

        Catch ex As Exception
            MessageBox.Show("Maaf,jumlah tidak diketahui")
        End Try
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        If ListBox1.Items.Count > 0 Then

            Dim sql As String = "INSERT INTO tbl_order (id_order,id_user,total_harga,tanggal_order,is_accept) VALUES (@v1,@v2,@v3,@v4,@v5)"
            Dim id_order As String = fcn.generateID("Order", "SELECT * FROM tbl_order ORDER BY id_order DESC", conn)
            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                If MessageBox.Show("Apakah anda ingin Order Sekarang?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cmnd.Parameters.AddWithValue("@v1", id_order)
                    cmnd.Parameters.AddWithValue("@v2", Me.Tag)
                    cmnd.Parameters.AddWithValue("@v3", insert_det_order(id_order))
                    cmnd.Parameters.AddWithValue("@v4", Date.Now)
                    cmnd.Parameters.AddWithValue("@v5", 0)

                    cmnd.ExecuteNonQuery()

                    MessageBox.Show("Order sedang di proses, Mohon tunggu konfirmasi pengiriman")
                    MessageBox.Show("Anda Bisa Melihat Pesanan Anda Di Daftar Pesanan")
                    ListBox1.Items.Clear()
                End If

            End Using
        Else
            MessageBox.Show("Mohon Pilih Barang Belanjaan")
        End If
        refreshData()
    End Sub

    Function insert_det_order(ByVal id_order As String) As Integer
        Dim total_harga As Integer = 0
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Dim sql As String = "INSERT INTO tbl_det_order (id_det_order,id_order,id_barang,jumlah_barang,harga_barang) VALUES (@v1,@v2,@v3,@v4,@v5)"
            Dim id_barang As String = Mid(ListBox1.Items(i).ToString, 1, 6)
            Dim qty As Integer = Val(Mid(ListBox1.Items(i).ToString, ListBox1.Items(i).ToString.IndexOf("*") + 2, (ListBox1.Items(i).ToString.IndexOf(":") - 3) - ListBox1.Items(i).ToString.IndexOf("*")))
            Dim harga_barang As Integer = Val(Replace(Mid(ListBox1.Items(i).ToString, ListBox1.Items(i).ToString.IndexOf("Rp.") + 5, (ListBox1.Items(i).ToString.IndexOf(".00") - 1) - (ListBox1.Items(i).ToString.IndexOf("Rp.") + 3)), ",", ""))

            Using cmnd As New SqlClient.SqlCommand(sql, conn)
                cmnd.Parameters.AddWithValue("@v1", fcn.generateID("DetailOrder", "SELECT * FROM tbl_det_order ORDER BY id_det_order DESC", conn))
                cmnd.Parameters.AddWithValue("@v2", id_order)
                cmnd.Parameters.AddWithValue("@v3", id_barang)
                cmnd.Parameters.AddWithValue("@v4", qty)
                cmnd.Parameters.AddWithValue("@v5", harga_barang)
                cmnd.ExecuteNonQuery()


                total_harga += harga_barang

                update_barang(id_barang, qty)
            End Using
        Next
        Return total_harga
    End Function

    Private Sub update_barang(ByVal id_barang As String, ByVal qty As Integer)
        Dim sql As String = "SELECT * FROM tbl_barang WHERE id_barang = '" + id_barang + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        Dim newqty As Integer = 0
        rd = cmnd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            newqty = rd.Item("qty") - qty
            rd.Close()
            Dim sql1 As String = "UPDATE tbl_barang SET qty = @v1 WHERE id_barang = '" + id_barang + "'"
            Dim cmnd1 As New SqlClient.SqlCommand(sql1, conn)
            cmnd1.Parameters.AddWithValue("@v1", newqty)

            cmnd1.ExecuteNonQuery()
        End If

    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        DaftarOrderForm.Tag = Me.Tag
        DaftarOrderForm.Show()
    End Sub

    Private Sub BelanjaForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()
        If Me.Tag = "" Then
            MainForm.Show()
        End If
    End Sub
End Class