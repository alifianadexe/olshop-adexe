Public Class LoginForm
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim sql As String = "SELECT * FROM tbl_login WHERE username='" + Me.txt_username.Text + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            If rd.Item("password") = Me.txt_password.Text Then

                If rd.Item("status") = "User" Then
                    Dim navus As New NavigationUser()
                    navus.Tag = rd.Item("id_user")
                    rd.Close()
                    navus.lbl_log.Text = insertLog()

                    navus.Show()
                    Me.Hide()
                ElseIf rd.Item("status") = "Petugas" Then
                    Dim navus As New NavigationPetugas()

                    navus.Tag = rd.Item("id_petugas")
                    rd.Close()

                    navus.lbl_log.Text = insertLog()

                    navus.Show()
                    Me.Hide()
                ElseIf rd.Item("status") = "Owner" Then
                    rd.Close()
                    NavigationOwner.Show()
                End If
            Else
                MessageBox.Show("Maaf , Password Salah")
            End If
        Else
            MessageBox.Show("Maaf, Anda Belum Terdaftar")
            rd.Close()
        End If

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conn.Close()
        MainForm.Show()
    End Sub

    Private Sub btn_daftar_Click(sender As Object, e As EventArgs) Handles btn_daftar.Click
        DaftarForm.Show()
    End Sub

    Private Function insertLog() As String
        Dim sql As String = "INSERT INTO tbl_log (id_log,username,tanggal_login) VALUES (@v1,@v2,@v3)"
        Dim id As String = fcn.generateID("Log", "SELECT * FROM tbl_log ORDER BY id_log DESC", conn)
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", id)
            cmnd.Parameters.AddWithValue("@v2", Me.txt_username.Text)
            cmnd.Parameters.AddWithValue("@v3", Date.Now)

            cmnd.ExecuteNonQuery()
        End Using
        Return id
    End Function
End Class