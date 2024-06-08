Imports MySql.Data.MySqlClient

Module ModuleDB
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public pengguna As String = "fidef"
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users"
    Public bts As Integer = 5
    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "localhost"
        myStrCon.Password = ""
        myStrCon.Database = "kostify"
        myConn = New MySqlConnection(myStrCon.ToString)
        OpenConnection()
    End Sub

    Public Sub OpenConnection()
        Try
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
        Catch ex As Exception
            Console.WriteLine("Error saat membuka koneksi: " & ex.Message)
            MsgBox("gagal")
        End Try
    End Sub

    Public Sub CloseConnection()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
    End Sub
End Module
