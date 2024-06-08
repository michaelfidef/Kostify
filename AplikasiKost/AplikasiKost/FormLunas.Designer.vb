<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLunas
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
        btnBatal = New Button()
        btnTambah = New Button()
        lblKamar = New Label()
        txtBayar = New TextBox()
        lblNama = New Label()
        lbl = New Label()
        labelsisa = New Label()
        SuspendLayout()
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
        ' btnTambah
        ' 
        btnTambah.Location = New Point(446, 260)
        btnTambah.Margin = New Padding(3, 4, 3, 4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(86, 31)
        btnTambah.TabIndex = 29
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lblKamar
        ' 
        lblKamar.AutoSize = True
        lblKamar.Font = New Font("Segoe UI", 12F)
        lblKamar.ForeColor = Color.White
        lblKamar.Location = New Point(350, 119)
        lblKamar.Name = "lblKamar"
        lblKamar.Size = New Size(69, 28)
        lblKamar.TabIndex = 22
        lblKamar.Text = "Bayar :"
        ' 
        ' txtBayar
        ' 
        txtBayar.Font = New Font("Segoe UI", 12F)
        txtBayar.Location = New Point(350, 157)
        txtBayar.Margin = New Padding(3, 4, 3, 4)
        txtBayar.Name = "txtBayar"
        txtBayar.Size = New Size(182, 34)
        txtBayar.TabIndex = 21
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 12F)
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(89, 125)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(55, 28)
        lblNama.TabIndex = 20
        lblNama.Text = "Sisa :"
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lbl.ForeColor = Color.White
        lbl.Location = New Point(195, 9)
        lbl.Name = "lbl"
        lbl.Size = New Size(221, 46)
        lbl.TabIndex = 19
        lbl.Text = "PELUNASAN"
        ' 
        ' labelsisa
        ' 
        labelsisa.AutoSize = True
        labelsisa.Font = New Font("Segoe UI", 12F)
        labelsisa.ForeColor = Color.White
        labelsisa.Location = New Point(89, 167)
        labelsisa.Name = "labelsisa"
        labelsisa.Size = New Size(64, 28)
        labelsisa.TabIndex = 31
        labelsisa.Text = "Nama"
        ' 
        ' FormLunas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(647, 305)
        Controls.Add(labelsisa)
        Controls.Add(btnBatal)
        Controls.Add(btnTambah)
        Controls.Add(lblKamar)
        Controls.Add(txtBayar)
        Controls.Add(lblNama)
        Controls.Add(lbl)
        Name = "FormLunas"
        Text = "FormLunas"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents lblKamar As Label
    Friend WithEvents txtBayar As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lbl As Label
    Friend WithEvents labelsisa As Label
End Class
