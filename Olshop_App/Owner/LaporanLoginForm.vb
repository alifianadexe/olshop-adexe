Imports System.Drawing.Printing
Public Class LaporanLoginForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Private Sub LaporanLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        Dim sql As String = "SELECT id_log , tbl_login.username as [Username], jabatan , nama_depan, tanggal_login, tanggal_logout FROM (( tbl_log INNER JOIN tbl_login ON tbl_login.username = tbl_log.username) INNER JOIN tbl_petugas ON tbl_login.id_petugas = tbl_petugas.id_petugas)"
        Dim adapter As New SqlClient.SqlDataAdapter(sql, conn)
        Dim dt As New DataTable
        adapter.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pd As New PrintDocument
        AddHandler pd.PrintPage, AddressOf Me.print_page
        PrintDialog1.Document = pd
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    Private Sub print_page(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        Dim gp As Graphics = ev.Graphics
        Dim font As New Font("Courier New", 12)

        Dim fontHeight As Integer = Math.Round(font.Height)
        Dim posX As Integer = 10
        Dim posY As Integer = 10
        Dim offset As Integer = 40

        gp.DrawString("         ** LAPORAN LOGIN FORM ** ", New Font("Courier New", 20), New SolidBrush(Color.Black), posX, posY)
        offset += fontHeight + 20
        gp.DrawString("ID Log " + " Nama Petugas".PadRight(20) + "Tanggal Login".PadRight(30) + "Tanggal Logout".PadRight(30), New Font("Courier New", 12), New SolidBrush(Color.Black), posX, posY + offset)
        offset += fontHeight + 10

        Dim sql As String = "SELECT id_log ,  jabatan , nama_depan,nama_belakang, tanggal_login, tanggal_logout FROM (( tbl_log INNER JOIN tbl_login ON tbl_login.username = tbl_log.username) INNER JOIN tbl_petugas ON tbl_login.id_petugas = tbl_petugas.id_petugas)"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)

        rd = cmnd.ExecuteReader
        If rd.HasRows Then
            While rd.Read
                Dim id As String = rd.Item("id_log").ToString
                Dim nama As String = (rd.Item("nama_depan") + " " + rd.Item("nama_belakang")).ToString.PadRight(20)
                Dim tanggal_login As String = rd.Item("tanggal_login").ToString.PadRight(30)
                Dim tanggal_logout As String = rd.Item("tanggal_login").ToString.PadRight(30)
                Dim jabatan As String = rd.Item("jabatan").ToString

                gp.DrawString(id + " " + nama + tanggal_login + tanggal_logout + tanggal_login + jabatan, font, New SolidBrush(Color.Black), posX, posY + offset)

                offset += fontHeight + 5
            End While
            rd.Close()
        End If
    End Sub
End Class