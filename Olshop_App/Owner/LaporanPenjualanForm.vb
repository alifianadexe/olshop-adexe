Imports System.Drawing.Printing
Public Class LaporanPenjualanForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Private Sub LaporanPenjualanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        Dim sql As String = "SELECT tbl_terima.id_order as id_order, nama_depan,total_harga,tanggal_order,tanggal_terima FROM (tbl_terima INNER JOIN tbl_order ON tbl_order.id_order = tbl_terima.id_order)INNER JOIN tbl_petugas ON tbl_terima.id_petugas = tbl_petugas.id_petugas"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Columns(2).DefaultCellStyle.Format = "##,##0.00"

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

        Dim fontHeight As Integer = font.Height
        Dim posX As Integer = 10
        Dim posY As Integer = 10
        Dim offset As Integer = 40
        gp.DrawString("                      ** LAPORAN PENJUALAN ** ", New Font("Courier New", 20), New SolidBrush(Color.Black), posX, posY)
        offset += fontHeight + 20
        gp.DrawString("ID ORDER".PadRight(10) + "ID USER".PadRight(10) + "Total Harga".PadRight(25) + "Petugas".PadRight(25) + "Tanggal Order".PadRight(20) + "Tanggal Terima".PadRight(20), New Font("Courier New", 12), New SolidBrush(Color.Black), posX, posY + offset)
        offset += fontHeight + 10

        Dim sql As String = "SELECT tbl_terima.id_order as id_order,id_user, nama_depan,nama_belakang,total_harga,tanggal_order,tanggal_terima FROM (tbl_terima INNER JOIN tbl_order ON tbl_order.id_order = tbl_terima.id_order)INNER JOIN tbl_petugas ON tbl_terima.id_petugas = tbl_petugas.id_petugas"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader

        Dim total_penjualan As Integer = 0

        If rd.HasRows Then
            While rd.Read()
                Dim id_order As String = rd.Item("id_order").PadRight(10)
                Dim id_user As String = rd.Item("id_user").PadRight(10)
                Dim nama As String = rd.Item("nama_depan") + " " + rd.Item("nama_belakang").PadRight(25)
                Dim tanggal_order As String = Date.Parse(rd.Item("tanggal_order")).ToShortDateString.PadRight(20)
                Dim tanggal_terima As String = Date.Parse(rd.Item("tanggal_terima")).ToShortDateString.PadRight(20)
                Dim value As Integer = Val(rd.Item("total_harga"))
                Dim total_harga As String = ("Rp. " + Format(value, "##,##0.00")).PadRight(25)

                gp.DrawString(id_order + id_user + total_harga + nama + tanggal_order + tanggal_terima, font, New SolidBrush(Color.Black), posX, posY + offset)

                offset += fontHeight + 5
                total_penjualan += value
            End While
        End If

        offset = offset + fontHeight + 20
        gp.DrawString("-------------------------------------------------------------------------------------------------------------------------- ", font, New SolidBrush(Color.Black), posX, posY + offset)
        offset = offset + fontHeight + 5
        gp.DrawString("Total Penjualan : " + ("Rp. " + Format(total_penjualan, "##,##0.00")).PadLeft(60), New Font("Courier New", 14), New SolidBrush(Color.Black), posX, posY + offset)
        offset = offset + fontHeight + 5
        gp.DrawString("--------------------------------------------------------------------------------------------------------------------------", font, New SolidBrush(Color.Black), posX, posY + offset)


    End Sub
End Class