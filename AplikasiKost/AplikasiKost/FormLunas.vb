Imports MySql.Data.MySqlClient

Public Class FormLunas
    Private SisaPembayaran As Integer
    Private idTagihan As String

    Public Sub New(ByVal idTagihan As String, ByVal sisa As Integer)
        InitializeComponent()
        Me.idTagihan = idTagihan
        Me.SisaPembayaran = sisa
    End Sub

    Private Sub FormLunas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sisaBayarFromDatabase As Integer

        OpenConnection()
        Dim sqlw As String

        sqlw = "SELECT COUNT(*) FROM detailtagihan WHERE ID_Tagihan = @ID_Tagihan"
        Dim count As Integer
        Using myCommand As New MySqlCommand(sqlw, myConn)
            myCommand.Parameters.AddWithValue("@ID_Tagihan", idTagihan)
            count = Convert.ToInt32(myCommand.ExecuteScalar())
        End Using

        If count > 0 Then
            Dim sql As String = "SELECT SisaBayar FROM detailTagihan WHERE ID_Tagihan = @ID_Tagihan ORDER BY ID_Detail DESC LIMIT 1"
            Using myCommand As New MySqlCommand(sql, myConn)
                myCommand.Parameters.AddWithValue("@ID_Tagihan", idTagihan)
                Dim result As Object = myCommand.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    sisaBayarFromDatabase = Convert.ToInt32(result)
                End If
            End Using
            labelsisa.Text = sisaBayarFromDatabase.ToString()
        Else
            labelsisa.Text = SisaPembayaran.ToString()
        End If
    End Sub

    Private Sub tambahDataLunas()
        Dim bayar As Integer
        Dim sisaBayar As Integer

        If Not Integer.TryParse(txtBayar.Text, bayar) Then
            MsgBox("Masukkan jumlah pembayaran yang valid.")
            Return
        End If

        sisaBayar = Convert.ToInt32(labelsisa.Text) - bayar

        If sisaBayar < 0 Then
            MsgBox("Maaf, Pembayaran melebihi sisa bayar. Mohon periksa kembali jumlah pembayaran.")
            Return
        ElseIf sisaBayar = 0 Then
            OpenConnection()
            Dim sql1 As String = "INSERT INTO detailtagihan (ID_Tagihan, TglBayar, Bayar, SisaBayar) VALUES (@ID_Tagihan, @TglBayar, @Bayar, @SisaBayar)"
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql1, myConn)
            Else
                myCommand.CommandText = sql1
            End If
            myCommand.Parameters.Clear()
            myCommand.Parameters.AddWithValue("@ID_Tagihan", idTagihan)
            myCommand.Parameters.AddWithValue("@TglBayar", DateTime.Now.ToString("yyyy-MM-dd"))
            myCommand.Parameters.AddWithValue("@Bayar", bayar)
            myCommand.Parameters.AddWithValue("@SisaBayar", sisaBayar)

            myCommand.ExecuteNonQuery()
            MsgBox("Data Tagihan Berhasil Ditambahkan!")
            MsgBox("Terima kasih sudah membayar tepat waktu!")
            Return
        End If

        OpenConnection()
        Dim sql As String = "INSERT INTO detailtagihan (ID_Tagihan, TglBayar, Bayar, SisaBayar) VALUES (@ID_Tagihan, @TglBayar, @Bayar, @SisaBayar)"
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue("@ID_Tagihan", idTagihan)
        myCommand.Parameters.AddWithValue("@TglBayar", DateTime.Now.ToString("yyyy-MM-dd"))
        myCommand.Parameters.AddWithValue("@Bayar", bayar)
        myCommand.Parameters.AddWithValue("@SisaBayar", sisaBayar)

        myCommand.ExecuteNonQuery()
        MsgBox("Data Tagihan Berhasil Ditambahkan!")
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        tambahDataLunas()
        Me.Close()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub
End Class