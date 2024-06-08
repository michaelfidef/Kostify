Imports MySql.Data.MySqlClient

Public Class FormEditPenghuni
    Private idPenghuni As String

    Public Sub InitializeForEdit(ByVal nama As String, ByVal idKamar As String, ByVal tglMasuk As DateTime, ByVal tglKeluar As DateTime, ByVal noTelp As String)
        txtNama.Text = nama
        FillDataForEdit(idKamar)
        dtpTanggalMasuk.Value = tglMasuk
        dtpTanggalKeluar.Value = tglKeluar
        txtNoTelp.Text = noTelp
    End Sub

    Public Sub New(ByVal penghuniID As String)
        InitializeComponent()
        idPenghuni = penghuniID
        FillDataForEdit(idPenghuni)
    End Sub

    Private Sub FillDataForEdit(ByVal idPenghuni As String)
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
                txtNama.Text = myDataReader("NamaPenghuni").ToString()
                CmbKamar.Items.Clear()
                Dim idKamar As String = myDataReader("ID_Kamar").ToString()
                CmbKamar.Items.Add(idKamar)
                CmbKamar.SelectedItem = idKamar
                dtpTanggalMasuk.Value = myDataReader.GetDateTime("TglMasuk")
                dtpTanggalKeluar.Value = myDataReader.GetDateTime("TglKeluar")
                txtNoTelp.Text = myDataReader("NoTelp").ToString()
            End If
            myDataReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error occurred while retrieving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim tglMasuk As String = dtpTanggalMasuk.Value.ToString("yyyy-MM-dd")
        Dim tglKeluar As String = dtpTanggalKeluar.Value.ToString("yyyy-MM-dd")

        Dim sql As String = "UPDATE penghunikost SET NamaPenghuni = '" & txtNama.Text & "', " &
                        "ID_Kamar = '" & CmbKamar.SelectedItem.ToString() & "', " &
                        "TglMasuk = '" & tglMasuk & "', " &
                        "TglKeluar = '" & tglKeluar & "', " &
                        "NoTelp = '" & txtNoTelp.Text & "' " &
                        "WHERE ID_Penghuni = '" & idPenghuni & "'"

        Try
            OpenConnection()
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            If myCommand.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Data Penghuni Berhasil Diubah!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Gagal update penghuni data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error occurred while updating data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub


    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class
