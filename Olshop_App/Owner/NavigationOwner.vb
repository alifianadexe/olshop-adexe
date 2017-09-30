Public Class NavigationOwner
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ManagementPetugas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LaporanPenjualanForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LaporanPembelianForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LaporanLoginForm.Show()
    End Sub
End Class