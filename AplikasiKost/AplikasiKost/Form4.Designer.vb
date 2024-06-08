<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahPenghuni
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTambahPenghuni = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        lblKamar = New Label()
        lblTanggalMasuk = New Label()
        dtpTanggalMasuk = New DateTimePicker()
        dtpTanggalKeluar = New DateTimePicker()
        Label1 = New Label()
        txtNoTelp = New TextBox()
        lblNoTelp = New Label()
        btnTambah = New Button()
        btnBatal = New Button()
        CmbKamar = New ComboBox()
        SuspendLayout()
        ' 
        ' lblTambahPenghuni
        ' 
        lblTambahPenghuni.AutoSize = True
        lblTambahPenghuni.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTambahPenghuni.ForeColor = Color.White
        lblTambahPenghuni.Location = New Point(157, 12)
        lblTambahPenghuni.Name = "lblTambahPenghuni"
        lblTambahPenghuni.Size = New Size(355, 46)
        lblTambahPenghuni.TabIndex = 1
        lblTambahPenghuni.Text = "TAMBAH PENGHUNI"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 12F)
        txtNama.Location = New Point(75, 101)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(182, 34)
        txtNama.TabIndex = 6
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 12F)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(72, 69)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(64, 28)
        lblNama.TabIndex = 5
        lblNama.Text = "Nama"
        ' 
        ' lblKamar
        ' 
        lblKamar.AutoSize = True
        lblKamar.Font = New Font("Segoe UI", 12F)
        lblKamar.ForeColor = Color.White
        lblKamar.Location = New Point(338, 69)
        lblKamar.Name = "lblKamar"
        lblKamar.Size = New Size(68, 28)
        lblKamar.TabIndex = 7
        lblKamar.Text = "Kamar"
        ' 
        ' lblTanggalMasuk
        ' 
        lblTanggalMasuk.AutoSize = True
        lblTanggalMasuk.Font = New Font("Segoe UI", 12F)
        lblTanggalMasuk.ForeColor = Color.White
        lblTanggalMasuk.Location = New Point(14, 169)
        lblTanggalMasuk.Name = "lblTanggalMasuk"
        lblTanggalMasuk.Size = New Size(142, 28)
        lblTanggalMasuk.TabIndex = 9
        lblTanggalMasuk.Text = "Tanggal Masuk"
        ' 
        ' dtpTanggalMasuk
        ' 
        dtpTanggalMasuk.Location = New Point(14, 201)
        dtpTanggalMasuk.Margin = New Padding(3, 4, 3, 4)
        dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        dtpTanggalMasuk.Size = New Size(182, 27)
        dtpTanggalMasuk.TabIndex = 11
        ' 
        ' dtpTanggalKeluar
        ' 
        dtpTanggalKeluar.Location = New Point(231, 201)
        dtpTanggalKeluar.Margin = New Padding(3, 4, 3, 4)
        dtpTanggalKeluar.Name = "dtpTanggalKeluar"
        dtpTanggalKeluar.Size = New Size(182, 27)
        dtpTanggalKeluar.TabIndex = 13
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(231, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 28)
        Label1.TabIndex = 12
        Label1.Text = "Tanggal Keluar"
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Segoe UI", 12F)
        txtNoTelp.Location = New Point(443, 193)
        txtNoTelp.Margin = New Padding(3, 4, 3, 4)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(182, 34)
        txtNoTelp.TabIndex = 15
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Font = New Font("Segoe UI", 12F)
        lblNoTelp.ForeColor = Color.White
        lblNoTelp.Location = New Point(440, 163)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(83, 28)
        lblNoTelp.TabIndex = 14
        lblNoTelp.Text = "No. Telp"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(443, 259)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(86, 31)
        btnTambah.TabIndex = 16
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(541, 259)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(86, 31)
        btnBatal.TabIndex = 17
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' CmbKamar
        ' 
        CmbKamar.FormattingEnabled = True
        CmbKamar.Location = New Point(338, 103)
        CmbKamar.Name = "CmbKamar"
        CmbKamar.Size = New Size(151, 28)
        CmbKamar.TabIndex = 18
        ' 
        ' FormTambahPenghuni
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(647, 305)
        Controls.Add(CmbKamar)
        Controls.Add(btnBatal)
        Controls.Add(btnTambah)
        Controls.Add(txtNoTelp)
        Controls.Add(lblNoTelp)
        Controls.Add(dtpTanggalKeluar)
        Controls.Add(Label1)
        Controls.Add(dtpTanggalMasuk)
        Controls.Add(lblTanggalMasuk)
        Controls.Add(lblKamar)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(lblTambahPenghuni)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormTambahPenghuni"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah Penghuni"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTambahPenghuni As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblKamar As Label
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents dtpTanggalMasuk As DateTimePicker
    Friend WithEvents dtpTanggalKeluar As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents CmbKamar As ComboBox
End Class
