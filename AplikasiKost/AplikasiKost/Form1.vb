Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Imports ClosedXML.Excel


Public Class formMain
    Private Sub RefreshBeranda()
        Dim sqlPenghuni As String = "SELECT COUNT(*) FROM penghunikost;"
        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sqlPenghuni, myConn)
        Else
            myCommand.CommandText = sqlPenghuni
        End If
        myDataReader = myCommand.ExecuteReader()
        If myDataReader.Read() Then
            Dim jumlahPenghuni As Integer = myDataReader.GetInt32(0)
            lblTotalPenghuni.Text = jumlahPenghuni.ToString()
        End If
        myDataReader.Close()

        Dim sqlKamar As String = "SELECT COUNT(*) FROM kamarkost WHERE Status = 0;"
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sqlKamar, myConn)
        Else
            myCommand.CommandText = sqlKamar
        End If
        myDataReader = myCommand.ExecuteReader()
        If myDataReader.Read() Then
            Dim jumlahKamar As Integer = myDataReader.GetInt32(0)
            lblTotalKamarKost.Text = jumlahKamar.ToString()
        End If
        myDataReader.Close()

        CalculateTotalPendapatan()

        Dim sqltag As String = "SELECT count(*) FROM tagihan;"
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sqltag, myConn)
        Else
            myCommand.CommandText = sqltag
        End If
        myDataReader = myCommand.ExecuteReader()
        If myDataReader.Read() Then
            Dim jumlahtagihan As Integer = myDataReader.GetInt32(0)
            lblJumlahTagihan.Text = jumlahtagihan.ToString()
        End If
        myDataReader.Close()
    End Sub

    Private Sub CalculateTotalPendapatan()
        OpenConnection()
        Dim totalBayar As Integer = 0
        Dim totalBiaya As Integer = 0

        ' Query untuk total Bayar dari detailTagihan
        Dim sqlTotalBayar As String = "SELECT SUM(Bayar) AS TotalBayar FROM detailTagihan"
        Using myCommand As New MySqlCommand(sqlTotalBayar, myConn)
            Dim result As Object = myCommand.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                totalBayar = Convert.ToInt32(result)
            End If
        End Using

        ' Query untuk total Biaya dari Tagihan
        Dim sqlTotalBiaya As String = "SELECT SUM(Biaya) AS TotalBiaya FROM Tagihan"
        Using myCommand As New MySqlCommand(sqlTotalBiaya, myConn)
            Dim result As Object = myCommand.ExecuteScalar()
            If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                totalBiaya = Convert.ToInt32(result)
            End If
        End Using

        Dim totalPendapatan As Integer = totalBayar + totalBiaya
        lblTotalPendapatan.Text = totalPendapatan.ToString()
        lblTotal.Text = "Total Bayar : Rp " + totalPendapatan.ToString()
    End Sub

    Public Sub RefreshGridKamarKost()
        Dim i
        i = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT kamarkost.ID_Kamar, GROUP_CONCAT(DISTINCT fasilitaskamarkost.ID_Fasilitas SEPARATOR ', ') AS fasilitas, kamarkost.Lantai, kamarkost.UkuranKamar, kamarkost.Harga, kamarkost.Status " &
                    "FROM kamarkost " &
                    "LEFT JOIN fasilitaskamarkost ON kamarkost.ID_Kamar = fasilitaskamarkost.ID_Kamar " &
                    "GROUP BY kamarkost.ID_Kamar;"
        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = myDataReader("ID_Kamar")
                DataGridView1.Item(1, i).Value = myDataReader("fasilitas")
                DataGridView1.Item(2, i).Value = myDataReader("Lantai")
                DataGridView1.Item(3, i).Value = myDataReader("UkuranKamar")
                DataGridView1.Item(4, i).Value = myDataReader("Harga")
                If myDataReader("Status") = "1" Then
                    DataGridView1.Item(5, i).Value = "Terisi"
                Else
                    DataGridView1.Item(5, i).Value = "Tersedia"
                End If
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Public Sub RefreshGridPenghuni()
        Dim i
        i = 0
        DataGridView2.Rows.Clear()
        Dim sql As String = "select * from penghunikost"
        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView2.Rows.Add()
                DataGridView2.Item(0, i).Value = myDataReader("ID_Penghuni")
                DataGridView2.Item(1, i).Value = myDataReader("namaPenghuni")
                DataGridView2.Item(2, i).Value = myDataReader("ID_Kamar")
                DataGridView2.Item(3, i).Value = myDataReader("TglMasuk")
                DataGridView2.Item(4, i).Value = myDataReader("TglKeluar")
                DataGridView2.Item(5, i).Value = myDataReader("NoTelp")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If

        Dim updateStatusSql As String = "UPDATE kamarkost SET Status = '1' WHERE ID_Kamar = @KamarID"
        OpenConnection()
        Using updateCmd As New MySqlCommand(updateStatusSql, myConn)
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(2).Value IsNot Nothing Then
                    Dim kamarID As String = row.Cells(2).Value.ToString()
                    updateCmd.Parameters.Clear()
                    updateCmd.Parameters.AddWithValue("@KamarID", kamarID)
                    updateCmd.ExecuteNonQuery()
                End If
            Next
        End Using
    End Sub

    Public Sub RefreshGridLaporan()
        Dim i
        i = 0
        DataGridView3.Rows.Clear()
        Dim sql As String = "select * from tagihan"
        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                With DataGridView3
                    .Rows.Add()
                    .Item(0, i).Value = myDataReader("ID_Tagihan")
                    .Item(1, i).Value = myDataReader("ID_Penghuni")
                    .Item(2, i).Value = myDataReader("ID_Kamar")
                    .Item(3, i).Value = myDataReader("Harga")
                    .Item(4, i).Value = myDataReader("tglBayar")
                    .Item(5, i).Value = myDataReader("Biaya")
                    .Item(6, i).Value = myDataReader("Keterangan")
                End With
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnBeranda_Click(sender As Object, e As EventArgs) Handles btnBeranda.Click
        PanelBeranda.Visible = True
        PanelLaporan.Visible = False
        PanelKamarKost.Visible = False
        PanelPenghuniKamar.Visible = False
        PanelTagihan.Visible = False
        lblJudul.Text = "BERANDA"
        btnBeranda.BackColor = Color.Orange
        btnLaporan.BackColor = Color.WhiteSmoke
        btnKamarKost.BackColor = Color.WhiteSmoke
        btnPenghuniKamar.BackColor = Color.WhiteSmoke
        btnTagihan.BackColor = Color.WhiteSmoke
        RefreshBeranda()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        RefreshGridLaporan()
        PanelLaporan.Visible = True
        PanelBeranda.Visible = False
        PanelKamarKost.Visible = False
        PanelPenghuniKamar.Visible = False
        PanelTagihan.Visible = False
        lblJudul.Text = "LAPORAN"
        btnBeranda.BackColor = Color.WhiteSmoke
        btnLaporan.BackColor = Color.Orange
        btnKamarKost.BackColor = Color.WhiteSmoke
        btnPenghuniKamar.BackColor = Color.WhiteSmoke
        btnTagihan.BackColor = Color.WhiteSmoke

        Dim sqltag As String = "SELECT count(*) FROM tagihan;"
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sqltag, myConn)
        Else
            myCommand.CommandText = sqltag
        End If
        myDataReader = myCommand.ExecuteReader()
        If myDataReader.Read() Then
            Dim jumlahtagihan As Integer = myDataReader.GetInt32(0)
            lblTagihan.Text = "Jumlah Tagihan : " + jumlahtagihan.ToString()
        End If
        myDataReader.Close()

        Dim sqlBlmLunas As String = "SELECT COUNT(*) AS Jumlah_Tagihan_Belum_Lunas FROM tagihan WHERE Harga <> Biaya;"
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sqlBlmLunas, myConn)
        Else
            myCommand.CommandText = sqlBlmLunas
        End If
        myDataReader = myCommand.ExecuteReader()
        If myDataReader.Read() Then
            Dim JumlahBelumLunas As Integer = myDataReader.GetInt32(0)
            lblLunas.Text = "Belum Lunas : " + JumlahBelumLunas.ToString()
        End If
        myDataReader.Close()
        CalculateTotalPendapatan()
    End Sub

    Private Sub btnKamarKost_Click(sender As Object, e As EventArgs) Handles btnKamarKost.Click
        RefreshGridKamarKost()
        PanelKamarKost.Visible = True
        PanelBeranda.Visible = False
        PanelLaporan.Visible = False
        PanelPenghuniKamar.Visible = False
        PanelTagihan.Visible = False
        With lblJudul
            .Text = "KAMAR KOST"
            .Font = New Font(.Font.FontFamily, 19)
        End With
        btnKamarKost.BackColor = Color.Orange
        btnBeranda.BackColor = Color.WhiteSmoke
        btnLaporan.BackColor = Color.WhiteSmoke
        btnPenghuniKamar.BackColor = Color.WhiteSmoke
        btnTagihan.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnPenghuniKamar_Click(sender As Object, e As EventArgs) Handles btnPenghuniKamar.Click
        RefreshGridPenghuni()
        PanelPenghuniKamar.Visible = True
        PanelKamarKost.Visible = False
        PanelBeranda.Visible = False
        PanelLaporan.Visible = False
        PanelTagihan.Visible = False
        With lblJudul
            .Text = "PENGHUNI KAMAR"
            .Font = New Font(.Font.FontFamily, 19)
        End With
        btnKamarKost.BackColor = Color.WhiteSmoke
        btnBeranda.BackColor = Color.WhiteSmoke
        btnLaporan.BackColor = Color.WhiteSmoke
        btnPenghuniKamar.BackColor = Color.Orange
        btnTagihan.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub btnTagihan_Click(sender As Object, e As EventArgs) Handles btnTagihan.Click
        PanelTagihan.Visible = True
        PanelPenghuniKamar.Visible = False
        PanelKamarKost.Visible = False
        PanelBeranda.Visible = False
        PanelLaporan.Visible = False
        lblJudul.Text = "TAGIHAN"
        btnKamarKost.BackColor = Color.WhiteSmoke
        btnBeranda.BackColor = Color.WhiteSmoke
        btnLaporan.BackColor = Color.WhiteSmoke
        btnPenghuniKamar.BackColor = Color.WhiteSmoke
        btnTagihan.BackColor = Color.Orange
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs)
        CloseConnection()
        Application.Exit()
    End Sub

    Private Sub btnAkun_Click(sender As Object, e As EventArgs) Handles btnAkun.Click
        Dim form2 As New formLogin()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub FillDataByIDPenghuni(ByVal idPenghuni As String)
        Dim sql As String = "SELECT penghunikost.namaPenghuni, penghunikost.ID_Kamar, kamarkost.Harga " &
                        "FROM penghunikost " &
                        "INNER JOIN kamarkost ON penghunikost.ID_Kamar = kamarkost.ID_Kamar " &
                        "WHERE penghunikost.ID_Penghuni = '" & idPenghuni & "'"

        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader()
        If myDataReader.Read() Then
            txtNamaPenghuni.Text = myDataReader("namaPenghuni").ToString()
            txtKamar.Text = myDataReader("ID_Kamar").ToString()
            txtHargaKamar.Text = myDataReader("Harga").ToString()
            txtNamaPenghuni.Visible = True
            txtKamar.Visible = True
            txtHargaKamar.Visible = True
        End If
        myDataReader.Close()
    End Sub

    Private Sub btnTambahTagihan_Click(sender As Object, e As EventArgs) Handles btnTambahTagihan.Click
        Dim tanggalHariIni As String = DateTime.Now.ToString("yyyy-MM-dd")

        Dim sqlCheck As String = "SELECT COUNT(*) FROM tagihan WHERE ID_Kamar = '" & txtKamar.Text & "'"
        Dim count As Integer

        OpenConnection()
        Using cmdCheck As New MySqlCommand(sqlCheck, myConn)
            count = Convert.ToInt32(cmdCheck.ExecuteScalar())
        End Using

        If count > 0 Then
            MsgBox("ID Kamar sudah ada!")
            Return '
        End If

        Dim sql As String = "INSERT INTO tagihan(ID_Penghuni, ID_Kamar, Harga, tglBayar, Biaya, Keterangan) " &
                    "VALUES ('" & CmbIdPenghuni.SelectedItem.ToString() & "', '" & txtKamar.Text & "', '" & txtHargaKamar.Text & "', '" & tanggalHariIni & "', '" & txtBayar.Text & "','" & txtKeterangan.Text & "')"

        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myCommand.ExecuteNonQuery()
        MsgBox("Data Tagihan Berhasil Ditambahkan!")

        CmbIdPenghuni.SelectedIndex = -1
        txtNamaPenghuni.Text = ""
        txtKamar.Text = ""
        txtHargaKamar.Text = ""
        txtBayar.Clear()
        txtKeterangan.Clear()
    End Sub

    Private Sub btnTambahPenghuni_Click(sender As Object, e As EventArgs) Handles btnTambahPenghuni.Click
        Dim form4 As New FormTambahPenghuni()
        form4.Show()
    End Sub

    Private Sub btnTambahKamar_Click(sender As Object, e As EventArgs) Handles btnTambahKamar.Click
        Dim form3 As New FormTambahKamar()
        form3.Show()
    End Sub

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshBeranda()
    End Sub

    Private Sub CmbIdPenghuni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbIdPenghuni.SelectedIndexChanged
        If CmbIdPenghuni.SelectedItem IsNot Nothing Then
            Dim selectedID As String = CmbIdPenghuni.SelectedItem.ToString()
            FillDataByIDPenghuni(selectedID)
        End If
    End Sub


    Private Sub CmbIdPenghuni_Click(sender As Object, e As EventArgs) Handles CmbIdPenghuni.Click
        Dim sql As String = "SELECT ID_Penghuni FROM penghunikost"

        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader()

        CmbIdPenghuni.Items.Clear()

        While myDataReader.Read()
            CmbIdPenghuni.Items.Add(myDataReader("ID_Penghuni").ToString())
        End While

        myDataReader.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim calendarForm As New Form()
        Dim monthCalendar As New MonthCalendar()

        monthCalendar.MaxSelectionCount = 1
        monthCalendar.ShowToday = True

        calendarForm.Controls.Add(monthCalendar)

        calendarForm.Size = New Size(300, 200)
        calendarForm.StartPosition = FormStartPosition.CenterParent

        calendarForm.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            Dim sql As String = "DELETE FROM kamarkost WHERE ID_Kamar = '" & selectedID & "'"

            Dim result As DialogResult = MsgBox("Apakah Anda Yakin Ingin Menghapus Data Ini?", MsgBoxStyle.YesNo)

            If result = DialogResult.Yes Then
                OpenConnection()
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(sql, myConn)
                Else
                    myCommand.CommandText = sql
                End If
                myCommand.ExecuteNonQuery()

                RefreshGridKamarKost()
            Else
                MsgBox("Penghapusan dibatalkan.")
            End If
        Else
            MsgBox("Pilih baris terlebih dahulu untuk menghapus data.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim selectedID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()
            Dim selectedRoomID As String = DataGridView2.SelectedRows(0).Cells(2).Value.ToString()

            Dim result As DialogResult = MsgBox("Apakah Anda Yakin Ingin Menghapus Data Ini?", MsgBoxStyle.YesNo)

            If result = DialogResult.Yes Then
                Dim deleteTagihanSql As String = "DELETE FROM tagihan WHERE ID_Penghuni = '" & selectedID & "'"
                OpenConnection()
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(deleteTagihanSql, myConn)
                Else
                    myCommand.CommandText = deleteTagihanSql
                End If
                myCommand.ExecuteNonQuery()

                Dim deleteSql As String = "DELETE FROM penghunikost WHERE ID_Penghuni = '" & selectedID & "'"
                OpenConnection()
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(deleteSql, myConn)
                Else
                    myCommand.CommandText = deleteSql
                End If
                myCommand.ExecuteNonQuery()

                Dim updateStatusSql As String = "UPDATE kamarkost SET Status = '0' WHERE ID_Kamar = @KamarID"
                Using updateCmd As New MySqlCommand(updateStatusSql, myConn)
                    updateCmd.Parameters.AddWithValue("@KamarID", selectedRoomID)
                    Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MsgBox("Status kamar telah diperbarui.")
                    Else
                        MsgBox("Gagal memperbarui status kamar.")
                    End If
                End Using

                RefreshGridPenghuni()
            Else
                MsgBox("Penghapusan dibatalkan.")
            End If
        Else
            MsgBox("Pilih baris terlebih dahulu untuk menghapus data.")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If DataGridView2.SelectedRows.Count > 0 Then
            Dim selectedID As String = DataGridView2.SelectedRows(0).Cells(0).Value.ToString()

            Dim formEdit As New FormEditPenghuni(selectedID)

            formEdit.ShowDialog()
            RefreshGridPenghuni()
        Else
            MsgBox("Pilih baris terlebih dahulu untuk mengedit data.")
        End If
    End Sub

    Private Sub FormEditPenghuni_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RefreshGridPenghuni()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedID As String = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()

            Dim formEdit As New FormEditKamar(selectedID)

            formEdit.ShowDialog()
            RefreshGridKamarKost()
        Else
            MsgBox("Pilih baris terlebih dahulu untuk mengedit data.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If DataGridView3.SelectedRows.Count > 0 Then
            Dim selectedID As String = DataGridView3.SelectedRows(0).Cells(0).Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Ini?", "Konfirmasi", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                OpenConnection()
                Dim transaction As MySqlTransaction = myConn.BeginTransaction()
                myCommand = myConn.CreateCommand()
                myCommand.Transaction = transaction

                Try
                    Dim deleteDetailSql As String = "DELETE FROM detailtagihan WHERE ID_Tagihan = @ID_Tagihan"
                    myCommand.CommandText = deleteDetailSql
                    myCommand.Parameters.AddWithValue("@ID_Tagihan", selectedID)
                    myCommand.ExecuteNonQuery()

                    Dim deleteTagihanSql As String = "DELETE FROM tagihan WHERE ID_Tagihan = @ID_Tagihan"
                    myCommand.CommandText = deleteTagihanSql
                    myCommand.ExecuteNonQuery()

                    transaction.Commit()

                    MsgBox("Data berhasil dihapus!")
                    RefreshGridLaporan()
                Catch ex As Exception
                    transaction.Rollback()
                    MsgBox("Terjadi kesalahan: " & ex.Message)
                End Try
            End If
        Else
            MsgBox("Pilih baris terlebih dahulu untuk menghapus data.")
        End If
    End Sub

    Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
        If DataGridView3 IsNot Nothing AndAlso DataGridView3.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)
            If selectedRow IsNot Nothing Then
                Dim selectedID As String = selectedRow.Cells(0).Value.ToString()
                Dim harga As Integer = 0
                Dim biaya As Integer = 0
                If Integer.TryParse(selectedRow.Cells(3).Value.ToString(), harga) AndAlso Integer.TryParse(selectedRow.Cells(5).Value.ToString(), biaya) Then
                    Dim sisa As Integer = harga - biaya
                    Dim formDetail As New FormDetail(selectedID, sisa)
                    formDetail.ShowDialog()
                Else
                    MsgBox("Format harga atau biaya tidak valid.")
                End If
            End If
        Else
            MsgBox("Pilih baris terlebih dahulu untuk melihat detail data.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView3.Rows.Count > 0 Then
            Dim workbook As New XLWorkbook()
            Dim worksheet As IXLWorksheet = workbook.Worksheets.Add("Data Laporan")

            For i As Integer = 1 To DataGridView3.Columns.Count
                worksheet.Cell(1, i).Value = DataGridView3.Columns(i - 1).HeaderText
            Next

            For i As Integer = 0 To DataGridView3.Rows.Count - 1
                For j As Integer = 0 To DataGridView3.Columns.Count - 1
                    worksheet.Cell(i + 2, j + 1).Value = If(DataGridView3.Rows(i).Cells(j).Value IsNot Nothing, DataGridView3.Rows(i).Cells(j).Value.ToString(), "")
                Next
            Next

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Files|*.xlsx"
            saveDialog.Title = "Save an Excel File"

            Try
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    workbook.SaveAs(saveDialog.FileName)
                    MsgBox("Data berhasil diexport ke Excel", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox("Terjadi kesalahan: " & ex.Message)
            End Try
        Else
            MsgBox("Tidak ada data yang bisa diexport", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        Dim keyword As String = TextBox16.Text.Trim()

        ' Lakukan filter data berdasarkan keyword di TextBox16
        If keyword <> "" Then
            For Each row As DataGridViewRow In DataGridView3.Rows
                ' Pastikan baris tersebut bukan baris yang baru ditambahkan
                If Not row.IsNewRow Then
                    Dim visible As Boolean = False
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing AndAlso cell.Value.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            visible = True
                            Exit For
                        End If
                    Next
                    row.Visible = visible
                End If
            Next
        Else
            ' Jika TextBox16 kosong, tampilkan semua baris kecuali baris yang baru ditambahkan
            For Each row As DataGridViewRow In DataGridView3.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub TextBox28_TextChanged(sender As Object, e As EventArgs) Handles TextBox28.TextChanged
        Dim keyword As String = TextBox28.Text.Trim()

        ' Lakukan filter data berdasarkan keyword di TextBox28
        If keyword <> "" Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                ' Pastikan baris tersebut bukan baris yang baru ditambahkan
                If Not row.IsNewRow Then
                    Dim visible As Boolean = False
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing AndAlso cell.Value.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            visible = True
                            Exit For
                        End If
                    Next
                    row.Visible = visible
                End If
            Next
        Else
            ' Jika TextBox28 kosong, tampilkan semua baris kecuali baris yang baru ditambahkan
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
        End If
    End Sub

    Private Sub TextBox27_TextChanged(sender As Object, e As EventArgs) Handles TextBox27.TextChanged
        Dim keyword As String = TextBox27.Text.Trim()

        ' Lakukan filter data berdasarkan keyword di TextBox28
        If keyword <> "" Then
            For Each row As DataGridViewRow In DataGridView2.Rows
                ' Pastikan baris tersebut bukan baris yang baru ditambahkan
                If Not row.IsNewRow Then
                    Dim visible As Boolean = False
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing AndAlso cell.Value.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0 Then
                            visible = True
                            Exit For
                        End If
                    Next
                    row.Visible = visible
                End If
            Next
        Else
            ' Jika TextBox28 kosong, tampilkan semua baris kecuali baris yang baru ditambahkan
            For Each row As DataGridViewRow In DataGridView2.Rows
                If Not row.IsNewRow Then
                    row.Visible = True
                End If
            Next
        End If
    End Sub
End Class