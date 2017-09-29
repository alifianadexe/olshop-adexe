Public Class NavigationUser
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader
    Dim fcn As New FunctionClass
    Private Sub NavigationUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = generateString()
        conn.Open()

        refreshData()
    End Sub
    Private Sub refreshData()
        Dim sql As String = "SELECT * FROM tbl_user WHERE id_user = '" + Me.Tag + "'"
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)
        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            Me.lbl_id.Text = rd.Item("id_user")
            Me.lbl_nama.Text = rd.Item("nama_depan").ToString + " " + rd.Item("nama_belakang").ToString
            Me.lbl_tgl.Text = Date.Now

            Dim arr_image() As Byte = rd.Item("picture")
            Dim mstream As New System.IO.MemoryStream(arr_image)
            PictureBox1.Image = Image.FromStream(mstream)

        End If

        rd.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BelanjaForm.Tag = Me.lbl_id.Text
        BelanjaForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DaftarOrderForm.Tag = Me.Tag
        DaftarOrderForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show("Yakin?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            fcn.updateLog(Me.lbl_log.Text, conn)
            LoginForm.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LogBelanjaForm.Tag = Me.Tag
        LogBelanjaForm.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


End Class