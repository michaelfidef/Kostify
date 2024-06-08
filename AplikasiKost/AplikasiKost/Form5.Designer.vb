<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditPenghuni
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
        CmbKamar = New ComboBox()
        btnBatal = New Button()
        btnSimpan = New Button()
        txtNoTelp = New TextBox()
        lblNoTelp = New Label()
        dtpTanggalKeluar = New DateTimePicker()
        Label1 = New Label()
        dtpTanggalMasuk = New DateTimePicker()
        lblTanggalMasuk = New Label()
        lblKamar = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        lblTambahPenghuni = New Label()
        SuspendLayout()
        ' 
        ' CmbKamar
        ' 
        CmbKamar.FormattingEnabled = True
        CmbKamar.Location = New Point(342, 104)
        CmbKamar.Name = "CmbKamar"
        CmbKamar.Size = New Size(151, 28)
        CmbKamar.TabIndex = 31
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(544, 260)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(86, 31)
        btnBatal.TabIndex = 30
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(447, 260)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(86, 31)
        btnSimpan.TabIndex = 29
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Font = New Font("Segoe UI", 12F)
        txtNoTelp.Location = New Point(447, 195)
        txtNoTelp.Margin = New Padding(3, 4, 3, 4)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(182, 34)
        txtNoTelp.TabIndex = 28
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Font = New Font("Segoe UI", 12F)
        lblNoTelp.ForeColor = Color.White
        lblNoTelp.Location = New Point(443, 164)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(83, 28)
        lblNoTelp.TabIndex = 27
        lblNoTelp.Text = "No. Telp"
        ' 
        ' dtpTanggalKeluar
        ' 
        dtpTanggalKeluar.Location = New Point(234, 203)
        dtpTanggalKeluar.Margin = New Padding(3, 4, 3, 4)
        dtpTanggalKeluar.Name = "dtpTanggalKeluar"
        dtpTanggalKeluar.Size = New Size(182, 27)
        dtpTanggalKeluar.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(234, 171)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 28)
        Label1.TabIndex = 25
        Label1.Text = "Tanggal Keluar"
        ' 
        ' dtpTanggalMasuk
        ' 
        dtpTanggalMasuk.Location = New Point(17, 203)
        dtpTanggalMasuk.Margin = New Padding(3, 4, 3, 4)
        dtpTanggalMasuk.Name = "dtpTanggalMasuk"
        dtpTanggalMasuk.Size = New Size(182, 27)
        dtpTanggalMasuk.TabIndex = 24
        ' 
        ' lblTanggalMasuk
        ' 
        lblTanggalMasuk.AutoSize = True
        lblTanggalMasuk.Font = New Font("Segoe UI", 12F)
        lblTanggalMasuk.ForeColor = Color.White
        lblTanggalMasuk.Location = New Point(17, 171)
        lblTanggalMasuk.Name = "lblTanggalMasuk"
        lblTanggalMasuk.Size = New Size(142, 28)
        lblTanggalMasuk.TabIndex = 23
        lblTanggalMasuk.Text = "Tanggal Masuk"
        ' 
        ' lblKamar
        ' 
        lblKamar.AutoSize = True
        lblKamar.Font = New Font("Segoe UI", 12F)
        lblKamar.ForeColor = Color.White
        lblKamar.Location = New Point(342, 71)
        lblKamar.Name = "lblKamar"
        lblKamar.Size = New Size(68, 28)
        lblKamar.TabIndex = 22
        lblKamar.Text = "Kamar"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 12F)
        txtNama.Location = New Point(79, 103)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(182, 34)
        txtNama.TabIndex = 21
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 12F)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(75, 71)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(64, 28)
        lblNama.TabIndex = 20
        lblNama.Text = "Nama"
        ' 
        ' lblTambahPenghuni
        ' 
        lblTambahPenghuni.AutoSize = True
        lblTambahPenghuni.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTambahPenghuni.ForeColor = Color.White
        lblTambahPenghuni.Location = New Point(181, 12)
        lblTambahPenghuni.Name = "lblTambahPenghuni"
        lblTambahPenghuni.Size = New Size(282, 46)
        lblTambahPenghuni.TabIndex = 19
        lblTambahPenghuni.Text = "EDIT PENGHUNI"
        ' 
        ' FormEditPenghuni
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(647, 305)
        Controls.Add(CmbKamar)
        Controls.Add(btnBatal)
        Controls.Add(btnSimpan)
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
        Name = "FormEditPenghuni"
        Text = "Edit Penghuni"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CmbKamar As ComboBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents dtpTanggalKeluar As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTanggalMasuk As DateTimePicker
    Friend WithEvents lblTanggalMasuk As Label
    Friend WithEvents lblKamar As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblTambahPenghuni As Label
End Class
