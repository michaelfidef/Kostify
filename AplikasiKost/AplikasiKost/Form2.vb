Imports MySql.Data.MySqlClient

Public Class formLogin
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim sql As String = "select username,password from " & tbluser & " where
username='" & txtUsername.Text & "' and password='" & txtPassword.Text & "'"
        CreateConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            myDataReader.Close()
            pengguna = txtUsername.Text
            formMain.lblName.Text = "Hallo " & pengguna & "!!"
            formMain.lblTgl.Text = Now.Day & " - " & Now.Month & " - " & Now.Year
            formMain.Show()
            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub
End Class