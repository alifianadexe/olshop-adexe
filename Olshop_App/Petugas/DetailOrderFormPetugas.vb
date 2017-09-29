Imports System.Drawing.Printing
Public Class DetailOrderFormPetugas

    Public Property pembayaran As Integer

    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Public id_user As String = ""

    Private Sub ManageDetailOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        Dim sql1 As String = "SELECT tbl_det_order.id_barang as id_barang, jumlah_barang, tbl_det_order.harga_barang, tbl_barang.harga_barang as [harga_barang] , tbl_det_order.harga_barang as [harga_total_barang], nama_barang,total_harga,tanggal_order, nama_depan, nama_belakang, alamat, email, no_hp , tbl_barang.picture as [picture] FROM ((tbl_order INNER JOIN tbl_det_order ON tbl_det_order.id_order = tbl_order.id_order) INNER JOIN tbl_barang ON tbl_barang.id_barang = tbl_det_order.id_barang) INNER JOIN tbl_user ON tbl_user.id_user = tbl_order.id_user WHERE tbl_order.id_order = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql1, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Me.lbl_tanggal_order.Text = rd.Item("tanggal_order")
            Me.lbl_total.Text = "Rp." + Format(rd.Item("total_harga"), "##,##0.00")
            Me.lbl_total.Tag = rd.Item("total_harga")
            Me.lbl_nama_pemesan.Text = rd.Item("nama_depan") + " " + rd.Item("nama_belakang")
            Me.lbl_no_hp.Text = rd.Item("no_hp")
            Me.lbl_email.Text = rd.Item("email")
            Me.lbl_alamat.Text = rd.Item("alamat")
            Me.lb_id.Text = Me.Tag
        End If

        rd.Close()

        Dim sql As String = "Select tbl_det_order.id_barang As [id_barang], nama_barang FROM (tbl_det_order INNER JOIN tbl_barang ON tbl_det_order.id_barang = tbl_barang.id_barang) INNER JOIN tbl_order ON tbl_det_order.id_order = tbl_order.id_order WHERE tbl_order.id_order = '" + Me.Tag + "'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_terima.Click
        If MessageBox.Show("Apakah Order Sudah Diterima", "Terima", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Dim prompt As New InputBoxForm


            If prompt.ShowDialog("Bayar", "", "", pembayaran, False) = DialogResult.OK Then
                If Not pembayaran < Val(Me.lbl_total.Tag) Then
                    Dim sql As String = "INSERT INTO tbl_terima(id_terima, id_order, id_petugas, tanggal_terima,pembayaran,kembalian) VALUES (@v1,@v2,@v3,@v4,@v5,@v6)"
                    Using cmnd As New SqlClient.SqlCommand(sql, conn)
                        cmnd.Parameters.AddWithValue("@v1", fcn.generateID("Terima", "SELECT * FROM tbl_terima ORDER BY id_terima DESC", conn))
                        cmnd.Parameters.AddWithValue("@v2", Me.Tag)
                        cmnd.Parameters.AddWithValue("@v3", Me.lbl_petugas.Text)
                        cmnd.Parameters.AddWithValue("@v4", Date.Now)
                        cmnd.Parameters.AddWithValue("@v5", pembayaran)
                        cmnd.Parameters.AddWithValue("@v6", pembayaran - Val(Me.lbl_total.Tag))


                        cmnd.ExecuteNonQuery()
                        MessageBox.Show("Order Berhasil Dikonfirmasi")


                        Dim sql1 As String = "UPDATE tbl_order SET is_accept = 1 WHERE id_order = '" + Me.Tag + "'"
                        Dim cmnd1 As New SqlClient.SqlCommand(sql1, conn)
                        cmnd1.ExecuteNonQuery()

                        printReceipt()
                    End Using
                End If
            End If
        End If

    End Sub

    Private Sub printReceipt()

        Dim pd As New PrintDocument()
        AddHandler pd.PrintPage, AddressOf Me.pd_printpage
        PrintDialog1.Document = pd
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    Sub pd_printpage(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim gp As Graphics = ev.Graphics
        Dim font As New Font("Courier New", 12)

        Dim fontheight As Double = font.GetHeight
        Dim startx As Integer = 10
        Dim starty As Integer = 10
        Dim offset As Integer = 40

        gp.DrawString("    ** Selamat Datang Di Adexe Olshop ** ", New Font("Courier New", 20), New SolidBrush(Color.Black), startx, starty)

        Dim sql As String = "SELECT tbl_det_order.id_barang as id_barang,kembalian, pembayaran, jumlah_barang, tbl_det_order.harga_barang, tbl_barang.harga_barang as [harga_barang] , tbl_det_order.harga_barang as [harga_total_barang], nama_barang,total_harga,tanggal_order, tbl_barang.picture as [picture] FROM ((tbl_order INNER JOIN tbl_det_order ON tbl_det_order.id_order = tbl_order.id_order) INNER JOIN tbl_barang ON tbl_barang.id_barang = tbl_det_order.id_barang)INNER JOIN tbl_terima ON tbl_terima.id_order = tbl_order.id_order  WHERE tbl_order.id_order = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        Dim total As String = ""
        Dim kembalian As String = ""
        Dim pembayaran As String = ""
        While rd.Read()
            If rd.HasRows Then
                Dim nama_barang As String = rd.Item("nama_barang").ToString
                Dim qty As String = " * " + rd.Item("jumlah_barang").ToString
                Dim concatline As String = (nama_barang + qty)
                concatline = concatline.PadRight(40)

                Dim total_harga As String = "Rp." + Format(rd.Item("harga_total_barang"), "##,##0.00")
                Dim productline As String = concatline + total_harga

                gp.DrawString(productline, font, New SolidBrush(Color.Black), startx, starty + offset)

                offset = offset + Math.Round(fontheight) + 5
                total = ("Rp." + Format(rd.Item("total_harga"), "##,##0.00")).PadLeft(60)
                pembayaran = ("Rp." + Format(rd.Item("pembayaran"), "##,##0.00")).PadLeft(60)
                kembalian = ("Rp." + Format(rd.Item("kembalian"), "##,##0.00")).PadLeft(58)
            End If
        End While


        offset = offset + Math.Round(fontheight) + 20

        rd.Close()
        gp.DrawString("Total : " + total, New Font("Courier New", 14), New SolidBrush(Color.Black), startx, starty + offset)
        offset = offset + Math.Round(fontheight) + 5
        gp.DrawString("-------------------------------------------------------------------------------- " + kembalian, font, New SolidBrush(Color.Black), startx, starty + offset)
        offset = offset + Math.Round(fontheight) + 5
        gp.DrawString("Bayar : " + pembayaran, New Font("Courier New", 14), New SolidBrush(Color.Black), startx, starty + offset)
        offset = offset + Math.Round(fontheight) + 5
        offset = offset + Math.Round(fontheight) + 5
        gp.DrawString("Kembali :" + kembalian, New Font("Courier New", 14), New SolidBrush(Color.Black), startx, starty + offset)
        offset = offset + Math.Round(fontheight) + 5
        gp.DrawString("-------------------------------------------------------------------------------- " + kembalian, font, New SolidBrush(Color.Black), startx, starty + offset)
        offset = offset + Math.Round(fontheight) + 5
        gp.DrawString("                    ******* TERIMA KASIH *******  ", New Font("Courier New", 14), New SolidBrush(Color.Black), startx, starty + offset)

    End Sub

    Function countNumber(ByVal kata As String) As Integer
        Dim number As Integer = 60 - kata.Length
        'MessageBox.Show(number)
        Return number
    End Function
End Class