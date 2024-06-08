Imports MySql.Data.MySqlClient

Public Class FormDetail
    Private idTagihan As String
    Private sisa As Integer

    Public Sub New(ByVal idTagihan As String, ByVal sisa As Integer)
        InitializeComponent()
        Me.idTagihan = idTagihan
        Me.sisa = sisa
    End Sub

    Private Sub FormDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataDetail()
        lblLunas.Text = "Rp " + sisa.ToString()
    End Sub

    Public Sub loadDataDetail()
        Dim i
        i = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "SELECT * FROM detailtagihan WHERE ID_Tagihan = @ID_Tagihan"
        OpenConnection()
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myCommand.Parameters.Clear()
        myCommand.Parameters.AddWithValue("@ID_Tagihan", idTagihan)

        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                With DataGridView1
                    .Rows.Add()
                    .Item(0, i).Value = myDataReader("ID_Tagihan")
                    .Item(1, i).Value = myDataReader("TglBayar")
                    .Item(2, i).Value = myDataReader("Bayar")
                    .Item(3, i).Value = myDataReader("SisaBayar")
                End With
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formLunas As New FormLunas(idTagihan, sisa)
        formLunas.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class