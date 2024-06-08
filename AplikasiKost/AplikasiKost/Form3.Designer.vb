<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahKamar
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
        lblTambahKamar = New Label()
        lblFasilitasKamar = New Label()
        txtLantaiKamar = New TextBox()
        lblLantaiKamar = New Label()
        txtUkuranKamar = New TextBox()
        lblUkuranKamar = New Label()
        txtHargaKamar = New TextBox()
        lblHargaKamar = New Label()
        btnTambah = New Button()
        btnBatal = New Button()
        txtNomorKamar = New TextBox()
        Label1 = New Label()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox8 = New CheckBox()
        SuspendLayout()
        ' 
        ' lblTambahKamar
        ' 
        lblTambahKamar.AutoSize = True
        lblTambahKamar.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTambahKamar.ForeColor = Color.White
        lblTambahKamar.Location = New Point(184, 12)
        lblTambahKamar.Name = "lblTambahKamar"
        lblTambahKamar.Size = New Size(301, 46)
        lblTambahKamar.TabIndex = 0
        lblTambahKamar.Text = "TAMBAH KAMAR"
        ' 
        ' lblFasilitasKamar
        ' 
        lblFasilitasKamar.AutoSize = True
        lblFasilitasKamar.Font = New Font("Segoe UI", 12F)
        lblFasilitasKamar.ForeColor = Color.White
        lblFasilitasKamar.Location = New Point(227, 85)
        lblFasilitasKamar.Name = "lblFasilitasKamar"
        lblFasilitasKamar.Size = New Size(140, 28)
        lblFasilitasKamar.TabIndex = 3
        lblFasilitasKamar.Text = "Fasilitas Kamar"
        ' 
        ' txtLantaiKamar
        ' 
        txtLantaiKamar.Font = New Font("Segoe UI", 12F)
        txtLantaiKamar.Location = New Point(552, 117)
        txtLantaiKamar.Margin = New Padding(3, 4, 3, 4)
        txtLantaiKamar.Name = "txtLantaiKamar"
        txtLantaiKamar.Size = New Size(182, 34)
        txtLantaiKamar.TabIndex = 6
        ' 
        ' lblLantaiKamar
        ' 
        lblLantaiKamar.AutoSize = True
        lblLantaiKamar.Font = New Font("Segoe UI", 12F)
        lblLantaiKamar.ForeColor = Color.White
        lblLantaiKamar.Location = New Point(549, 85)
        lblLantaiKamar.Name = "lblLantaiKamar"
        lblLantaiKamar.Size = New Size(125, 28)
        lblLantaiKamar.TabIndex = 5
        lblLantaiKamar.Text = "Lantai Kamar"
        ' 
        ' txtUkuranKamar
        ' 
        txtUkuranKamar.Font = New Font("Segoe UI", 12F)
        txtUkuranKamar.Location = New Point(13, 283)
        txtUkuranKamar.Margin = New Padding(3, 4, 3, 4)
        txtUkuranKamar.Name = "txtUkuranKamar"
        txtUkuranKamar.Size = New Size(182, 34)
        txtUkuranKamar.TabIndex = 8
        ' 
        ' lblUkuranKamar
        ' 
        lblUkuranKamar.AutoSize = True
        lblUkuranKamar.Font = New Font("Segoe UI", 12F)
        lblUkuranKamar.ForeColor = Color.White
        lblUkuranKamar.Location = New Point(9, 251)
        lblUkuranKamar.Name = "lblUkuranKamar"
        lblUkuranKamar.Size = New Size(136, 28)
        lblUkuranKamar.TabIndex = 7
        lblUkuranKamar.Text = "Ukuran Kamar"
        ' 
        ' txtHargaKamar
        ' 
        txtHargaKamar.Font = New Font("Segoe UI", 12F)
        txtHargaKamar.Location = New Point(229, 283)
        txtHargaKamar.Margin = New Padding(3, 4, 3, 4)
        txtHargaKamar.Name = "txtHargaKamar"
        txtHargaKamar.Size = New Size(182, 34)
        txtHargaKamar.TabIndex = 10
        ' 
        ' lblHargaKamar
        ' 
        lblHargaKamar.AutoSize = True
        lblHargaKamar.Font = New Font("Segoe UI", 12F)
        lblHargaKamar.ForeColor = Color.White
        lblHargaKamar.Location = New Point(225, 251)
        lblHargaKamar.Name = "lblHargaKamar"
        lblHargaKamar.Size = New Size(126, 28)
        lblHargaKamar.TabIndex = 9
        lblHargaKamar.Text = "Harga Kamar"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(552, 337)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(86, 31)
        btnTambah.TabIndex = 11
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(649, 337)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(86, 31)
        btnBatal.TabIndex = 12
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' txtNomorKamar
        ' 
        txtNomorKamar.Font = New Font("Segoe UI", 12F)
        txtNomorKamar.Location = New Point(14, 117)
        txtNomorKamar.Margin = New Padding(3, 4, 3, 4)
        txtNomorKamar.Name = "txtNomorKamar"
        txtNomorKamar.Size = New Size(182, 34)
        txtNomorKamar.TabIndex = 16
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(11, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 28)
        Label1.TabIndex = 15
        Label1.Text = "Nomor Kamar"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Gainsboro
        CheckBox1.Location = New Point(230, 117)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(147, 24)
        CheckBox1.TabIndex = 17
        CheckBox1.Text = "Km Mandi Dalam"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.BackColor = Color.Gainsboro
        CheckBox2.Location = New Point(230, 147)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(50, 24)
        CheckBox2.TabIndex = 18
        CheckBox2.Text = "AC"
        CheckBox2.UseVisualStyleBackColor = False
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.BackColor = Color.Gainsboro
        CheckBox3.Location = New Point(230, 177)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(141, 24)
        CheckBox3.TabIndex = 20
        CheckBox3.Text = "Jaringan Internet"
        CheckBox3.UseVisualStyleBackColor = False
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.BackColor = Color.Gainsboro
        CheckBox4.Location = New Point(230, 207)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(133, 24)
        CheckBox4.TabIndex = 19
        CheckBox4.Text = "Dapur Bersama"
        CheckBox4.UseVisualStyleBackColor = False
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.BackColor = Color.Gainsboro
        CheckBox5.Location = New Point(384, 207)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(156, 24)
        CheckBox5.TabIndex = 24
        CheckBox5.Text = "Fasilitas Keamanan"
        CheckBox5.UseVisualStyleBackColor = False
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.BackColor = Color.Gainsboro
        CheckBox6.Location = New Point(384, 177)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(142, 24)
        CheckBox6.TabIndex = 23
        CheckBox6.Text = "Parkir Kendaraan"
        CheckBox6.UseVisualStyleBackColor = False
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.BackColor = Color.Gainsboro
        CheckBox7.Location = New Point(384, 147)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(147, 24)
        CheckBox7.TabIndex = 22
        CheckBox7.Text = "Fasilitas Olahraga"
        CheckBox7.UseVisualStyleBackColor = False
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.BackColor = Color.Gainsboro
        CheckBox8.Location = New Point(384, 117)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(141, 24)
        CheckBox8.TabIndex = 21
        CheckBox8.Text = "Fasilitas Rooftop"
        CheckBox8.UseVisualStyleBackColor = False
        ' 
        ' FormTambahKamar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(761, 389)
        Controls.Add(CheckBox5)
        Controls.Add(CheckBox6)
        Controls.Add(CheckBox7)
        Controls.Add(CheckBox8)
        Controls.Add(CheckBox3)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(txtNomorKamar)
        Controls.Add(Label1)
        Controls.Add(btnBatal)
        Controls.Add(btnTambah)
        Controls.Add(txtHargaKamar)
        Controls.Add(lblHargaKamar)
        Controls.Add(txtUkuranKamar)
        Controls.Add(lblUkuranKamar)
        Controls.Add(txtLantaiKamar)
        Controls.Add(lblLantaiKamar)
        Controls.Add(lblFasilitasKamar)
        Controls.Add(lblTambahKamar)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormTambahKamar"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Tambah Kamar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTambahKamar As Label
    Friend WithEvents lblFasilitasKamar As Label
    Friend WithEvents txtLantaiKamar As TextBox
    Friend WithEvents lblLantaiKamar As Label
    Friend WithEvents txtUkuranKamar As TextBox
    Friend WithEvents lblUkuranKamar As Label
    Friend WithEvents txtHargaKamar As TextBox
    Friend WithEvents lblHargaKamar As Label
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents txtNomorKamar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
End Class
