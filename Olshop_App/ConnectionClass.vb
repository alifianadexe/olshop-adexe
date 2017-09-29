Imports System.Configuration
Module ConnectionClass
    Public Function generateString() As String
        Dim connString As String = "Data Source=1.1.1.248,1433;Network Library=DBMSSOCN;Initial Catalog=db_olshop;User id=sa;password=adexe123"
        Try
            Dim conn As New SqlClient.SqlConnection
            conn.ConnectionString = connString
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return connString
    End Function

End Module
