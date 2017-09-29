Public Class FunctionClass
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader

    Function is_there(ByVal sql As String, ByVal conn As SqlClient.SqlConnection) As Boolean
        Dim what As Boolean = False
        Dim cmnd As New SqlClient.SqlCommand(sql, conn)

        rd = cmnd.ExecuteReader
        rd.Read()

        If rd.HasRows Then
            what = True
        End If

        rd.Close()
        Return what

    End Function

    Function generateID(ByVal idfor As String, ByVal sql As String, ByVal conn As SqlClient.SqlConnection)
        Dim id As String = ""

        If idfor = "User" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "USR" + "001"
            Else
                id = Val(Mid(rd("id_user"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "USR00" + id
                ElseIf Len(id) = 2 Then
                    id = "USR0" + id
                ElseIf Len(id) = 3 Then
                    id = "USR" + id
                End If
            End If
        ElseIf idfor = "Petugas" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "PTG" + "001"
            Else
                id = Val(Mid(rd("id_petugas"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "PTG00" + id
                ElseIf Len(id) = 2 Then
                    id = "PTG0" + id
                ElseIf Len(id) = 3 Then
                    id = "PTG" + id
                End If
            End If
        ElseIf idfor = "Pembelian" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "PMB" + "001"
            Else
                id = Val(Mid(rd("id_beli"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "PMB00" + id
                ElseIf Len(id) = 2 Then
                    id = "PMB0" + id
                ElseIf Len(id) = 3 Then
                    id = "PMB" + id
                End If
            End If

        ElseIf idfor = "Order" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "ORD" + "001"
            Else
                id = Val(Mid(rd("id_order"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "ORD00" + id
                ElseIf Len(id) = 2 Then
                    id = "ORD0" + id
                ElseIf Len(id) = 3 Then
                    id = "ORD" + id
                End If
            End If

        ElseIf idfor = "Terima" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "TRM" + "001"
            Else
                id = Val(Mid(rd("id_terima"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "TRM00" + id
                ElseIf Len(id) = 2 Then
                    id = "TRM0" + id
                ElseIf Len(id) = 3 Then
                    id = "TRM" + id
                End If
            End If

        ElseIf idfor = "Distributor" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "DST" + "001"
            Else
                id = Val(Mid(rd("id_distributor"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "DST00" + id
                ElseIf Len(id) = 2 Then
                    id = "DST0" + id
                ElseIf Len(id) = 3 Then
                    id = "DST" + id
                End If
            End If

        ElseIf idfor = "DetailOrder" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "DOR" + "001"
            Else
                id = Val(Mid(rd("id_det_order"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "DOR00" + id
                ElseIf Len(id) = 2 Then
                    id = "DOR0" + id
                ElseIf Len(id) = 3 Then
                    id = "DOR" + id
                End If
            End If
        ElseIf idfor = "Barang" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "BRG" + "001"
            Else
                id = Val(Mid(rd("id_barang"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "BRG00" + id
                ElseIf Len(id) = 2 Then
                    id = "BRG0" + id
                ElseIf Len(id) = 3 Then
                    id = "BRG" + id
                End If
            End If
        ElseIf idfor = "Log" Then
            Dim cmnd As New SqlClient.SqlCommand(sql, conn)
            rd = cmnd.ExecuteReader
            rd.Read()

            If Not rd.HasRows Then
                id = "LOG" + "001"
            Else
                id = Val(Mid(rd("id_log"), 4, 3)) + 1
                If Len(id) = 1 Then
                    id = "LOG00" + id
                ElseIf Len(id) = 2 Then
                    id = "LOG0" + id
                ElseIf Len(id) = 3 Then
                    id = "LOG" + id
                End If
            End If
        End If
        rd.Close
        Return id
    End Function

    Public Sub updateLog(ByVal id_log As String, ByVal conn As SqlClient.SqlConnection)
        Dim sql As String = "UPDATE tbl_log SET tanggal_logout = @v1 WHERE id_log = '" + id_log + "'"
        Using cmnd As New SqlClient.SqlCommand(sql, conn)
            cmnd.Parameters.AddWithValue("@v1", Date.Now)

            cmnd.ExecuteNonQuery()
        End Using
    End Sub
End Class
