Imports MySql.Data.MySqlClient

Public Class FormTambahPenghuni
    Private PenghuniID As String

    Public Sub New(Optional ByVal idPenghuni As String = "")
        InitializeComponent()
        PenghuniID = idPenghuni
        If Not String.IsNullOrEmpty(idPenghuni) Then
            FillDataForAdd(idPenghuni)
        End If
    End Sub

    Private Sub FillDataForAdd(ByVal idPenghuni As String)
        Dim sql As String = "SELECT * FROM penghunikost WHERE ID_Penghuni = '" & idPenghuni & "'"
        Try
            OpenConnection()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If
            myDataReader = myCommand.ExecuteReader()
            If myDataReader.Read() Then
                txtNama.Text = myDataReader("Nama").ToString()
            End If
            myDataReader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim hasil As DateTime = dtpTanggalMasuk.Value
        Dim hasil1 As DateTime = dtpTanggalKeluar.Value
        Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day
        Dim waktu1 As String = hasil1.Year & "-" & hasil1.Month & "-" & hasil1.Day

        If CmbKamar.SelectedItem Is Nothing Then
            MsgBox("Pilih kamar terlebih dahulu.")
            Return
        End If

        Dim sql As String = "INSERT INTO penghunikost(namaPenghuni, ID_Kamar, TglMasuk, TglKeluar, NoTelp) " &
                  "VALUES ('" & txtNama.Text & "', '" & CmbKamar.SelectedItem.ToString() & "', '" & waktu & "', '" & waktu1 & "', '" & txtNoTelp.Text & "')"

        Try
            OpenConnection()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            If myCommand.ExecuteNonQuery() > 0 Then
                MsgBox("Data Penghuni Berhasil Ditambahkan!")
            Else
                MsgBox("Gagal menambahkan data.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
        formMain.RefreshGridPenghuni()
        formMain.RefreshGridKamarKost()
        Me.Close()
    End Sub

    Private Sub CmbKamar_Click(sender As Object, e As EventArgs) Handles CmbKamar.Click
        Dim sql As String = "SELECT ID_Kamar FROM kamarkost WHERE Status = 0"

        Try
            OpenConnection()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            CmbKamar.Items.Clear()

            myDataReader = myCommand.ExecuteReader()

            While myDataReader.Read()
                CmbKamar.Items.Add(myDataReader("ID_Kamar").ToString())
            End While

            myDataReader.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
