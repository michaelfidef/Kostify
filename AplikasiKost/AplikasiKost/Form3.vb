Imports MySql.Data.MySqlClient

Public Class FormTambahKamar
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim idKamar As String = txtNomorKamar.Text
        Dim fasilitas As New List(Of String)()
        Dim lantai As String = txtLantaiKamar.Text
        Dim ukuran As String = txtUkuranKamar.Text
        Dim harga As String = txtHargaKamar.Text

        If CheckBox1.Checked Then
            fasilitas.Add("1")
        End If
        If CheckBox2.Checked Then
            fasilitas.Add("2")
        End If
        If CheckBox3.Checked Then
            fasilitas.Add("3")
        End If
        If CheckBox4.Checked Then
            fasilitas.Add("4")
        End If
        If CheckBox5.Checked Then
            fasilitas.Add("5")
        End If
        If CheckBox6.Checked Then
            fasilitas.Add("6")
        End If
        If CheckBox7.Checked Then
            fasilitas.Add("7")
        End If
        If CheckBox8.Checked Then
            fasilitas.Add("8")
        End If

        For Each idFasilitas As String In fasilitas
            Dim sql As String = "INSERT INTO fasilitaskamarkost(ID_Kamar, ID_Fasilitas) " &
                                 "VALUES ('" & idKamar & "', '" & idFasilitas & "')"

            Try
                OpenConnection()
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(sql, myConn)
                Else
                    myCommand.CommandText = sql
                End If

                If myCommand.ExecuteNonQuery() > 0 Then
                    MsgBox("Data Fasilitas Berhasil Ditambahkan!")
                Else
                    MsgBox("Gagal menambahkan data fasilitas.")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        Next

        Dim sqlKamar As String = "INSERT INTO kamarkost(ID_Kamar, Lantai, UkuranKamar, Harga, Status) " &
                              "VALUES ('" & idKamar & "', '" & lantai & "', '" & ukuran & "', '" & harga & "', '0')"

        Try
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sqlKamar, myConn)
            Else
                myCommand.CommandText = sqlKamar
            End If

            If myCommand.ExecuteNonQuery() > 0 Then
                MsgBox("Data Kamar Berhasil Ditambahkan!")
            Else
                MsgBox("Gagal menambahkan data kamar.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        txtHargaKamar.Clear()
        txtLantaiKamar.Clear()
        txtNomorKamar.Clear()
        txtUkuranKamar.Clear()
        formMain.RefreshGridKamarKost()

        Me.Close()
    End Sub
End Class