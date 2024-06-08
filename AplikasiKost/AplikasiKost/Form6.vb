Imports MySql.Data.MySqlClient

Public Class FormEditKamar
    Private idKamar As String

    Public Sub New(ByVal kamarID As String)
        InitializeComponent()
        idKamar = kamarID
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
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

        Dim deleteFasilitasSql As String = "DELETE FROM fasilitaskamarkost WHERE ID_Kamar = '" & idKamar & "'"
        Try
            OpenConnection()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(deleteFasilitasSql, myConn)
            Else
                myCommand.CommandText = deleteFasilitasSql
            End If
            myCommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error dalam menghapus fasilitas lama: " & ex.Message)
            Exit Sub
        End Try

        For Each idFasilitas As String In fasilitas
            Dim insertFasilitasSql As String = "INSERT INTO fasilitaskamarkost(ID_Kamar, ID_Fasilitas) " &
                                                "VALUES ('" & idKamar & "', '" & idFasilitas & "')"
            Try
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(insertFasilitasSql, myConn)
                Else
                    myCommand.CommandText = insertFasilitasSql
                End If
                myCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error dalam menambahkan faislitas baru: " & ex.Message)
                Exit Sub
            End Try
        Next

        Dim updateKamarSql As String = "UPDATE kamarkost SET Lantai = '" & lantai & "', " &
                                        "UkuranKamar = '" & ukuran & "', " &
                                        "Harga = '" & harga & "' " &
                                        "WHERE ID_Kamar = '" & idKamar & "'"
        Try
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(updateKamarSql, myConn)
            Else
                myCommand.CommandText = updateKamarSql
            End If
            myCommand.ExecuteNonQuery()
            MsgBox("Data Kamar Berhasil Diubah!")
        Catch ex As Exception
            MsgBox("Error dalam update data kamar: " & ex.Message)
        End Try

        Me.Close()
    End Sub

    Private Sub FormEditKamar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlKamar As String = "SELECT * FROM kamarkost WHERE ID_Kamar = '" & idKamar & "'"
        Dim sqlFasilitas As String = "SELECT ID_Fasilitas FROM fasilitaskamarkost WHERE ID_Kamar = '" & idKamar & "'"

        Try
            OpenConnection()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sqlKamar, myConn)
            Else
                myCommand.CommandText = sqlKamar
            End If
            myDataReader = myCommand.ExecuteReader()
            If myDataReader.Read() Then
                txtNomorKamar.Text = myDataReader("ID_Kamar").ToString
                txtLantaiKamar.Text = myDataReader("Lantai").ToString()
                txtUkuranKamar.Text = myDataReader("UkuranKamar").ToString()
                txtHargaKamar.Text = myDataReader("Harga").ToString()
            End If
            myDataReader.Close()

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sqlFasilitas, myConn)
            Else
                myCommand.CommandText = sqlFasilitas
            End If
            myDataReader = myCommand.ExecuteReader()
            While myDataReader.Read()
                Dim fasilitasID As Integer = myDataReader.GetInt32(0)
                Select Case fasilitasID
                    Case 1
                        CheckBox1.Checked = True
                    Case 2
                        CheckBox2.Checked = True
                    Case 3
                        CheckBox3.Checked = True
                    Case 4
                        CheckBox4.Checked = True
                    Case 5
                        CheckBox5.Checked = True
                    Case 6
                        CheckBox6.Checked = True
                    Case 7
                        CheckBox7.Checked = True
                    Case 8
                        CheckBox8.Checked = True
                End Select
            End While
            myDataReader.Close()

        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        End Try
    End Sub
End Class
