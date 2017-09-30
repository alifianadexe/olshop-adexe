Imports System.Drawing.Printing
Public Class LaporanPembelianForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub LaporanPembelianForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        Dim sql As String = "SELECT id_beli, nama_barang, nama_depan,nama_distributor,jumlah_qty,total_harga,tanggal_pembelian FROM ((tbl_pembelian INNER JOIN tbl_barang ON tbl_barang.id_barang = tbl_pembelian.id_barang) INNER JOIN tbl_petugas ON tbl_petugas.id_petugas = tbl_pembelian.id_petugas) INNER JOIN tbl_distributor ON tbl_pembelian.id_distributor = tbl_distributor.id_distributor"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Columns(5).DefaultCellStyle.Format = "##,##0.00"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pd As New PrintDocument
        AddHandler pd.PrintPage, AddressOf Me.print_page
        pd.DefaultPageSettings.Landscape = True
        PrintDialog1.Document = pd
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    Private Sub print_page(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim gp As Graphics = ev.Graphics
        Dim font As New Font("Courier New", 12)

        Dim fontHeight As Integer = Math.Round(font.Height)
        Dim posx As Integer = 10
        Dim posy As Integer = 10
        Dim offset As Integer = 40

        gp.DrawString("                      ** LAPORAN PEMBELIAN / RESTOK ** ", New Font("Courier New", 20), New SolidBrush(Color.Black), posx, posy)
        offset += fontHeight + 20
        gp.DrawString("ID ".PadRight(7) + " Nama Petugas".PadRight(20) + "Nama Barang".PadRight(20) + "Jumlah".PadRight(8) + "Total Harga".PadRight(23) + "Distributor".PadRight(15) + "Tanggal".PadRight(30), New Font("Courier New", 12), New SolidBrush(Color.Black), posx, posy + offset)
        offset += fontHeight + 10

        Dim sql As String = "SELECT id_beli, nama_barang, nama_depan,nama_belakang,nama_distributor,jumlah_qty,total_harga,tanggal_pembelian FROM ((tbl_pembelian INNER JOIN tbl_barang ON tbl_barang.id_barang = tbl_pembelian.id_barang) INNER JOIN tbl_petugas ON tbl_petugas.id_petugas = tbl_pembelian.id_petugas) INNER JOIN tbl_distributor ON tbl_pembelian.id_distributor = tbl_distributor.id_distributor"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader

        If rd.HasRows Then
            While rd.Read
                Dim id As String = rd.Item("id_beli").ToString.PadRight(7)
                Dim barang As String = rd.Item("nama_barang").ToString.PadRight(20)
                Dim nama As String = (rd.Item("nama_depan") + " " + rd.Item("nama_belakang")).ToString.PadRight(20)
                Dim distributor As String = rd.Item("nama_distributor").ToString.PadRight(15)
                Dim jumlah As String = rd.Item("jumlah_qty").ToString.PadRight(8)
                Dim total As String = ("Rp. " + Format(rd.Item("total_harga"), "##,##0.00")).PadRight(23)
                Dim tanggal As String = Date.Parse(rd.Item("tanggal_pembelian")).ToShortDateString.ToString.PadRight(30)

                gp.DrawString(id + nama + barang + jumlah + total + distributor + tanggal, font, New SolidBrush(Color.Black), posx, posy + offset)

                offset += fontHeight + 5

            End While
        End If
        rd.Close()
    End Sub
End Class