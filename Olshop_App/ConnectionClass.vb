Imports System.Configuration
Module ConnectionClass
    Dim server As String = "1.1.1.248"
    Public Function generateString() As String
        Dim connString As String = "Data Source=" + server + ",1433;Network Library=DBMSSOCN;Initial Catalog=db_olshop;User id=sa;password=adexe123"
        Try
            Dim conn As New SqlClient.SqlConnection
            conn.ConnectionString = connString
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            server = InputBox("Alamat IP Server yang dituju : ", "Server", "127.0.0.1")
            generateString()
        End Try
        Return connString
    End Function

End Module
