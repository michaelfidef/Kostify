<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        logoKostify = New PictureBox()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblPassword = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnExit = New Button()
        CType(logoKostify, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' logoKostify
        ' 
        logoKostify.BackgroundImageLayout = ImageLayout.Stretch
        logoKostify.Image = My.Resources.Resources.Logo_Putih_Kostify
        logoKostify.Location = New Point(121, 37)
        logoKostify.Margin = New Padding(3, 4, 3, 4)
        logoKostify.Name = "logoKostify"
        logoKostify.Size = New Size(397, 100)
        logoKostify.TabIndex = 0
        logoKostify.TabStop = False
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(267, 159)
        txtUsername.Margin = New Padding(3, 4, 3, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(229, 27)
        txtUsername.TabIndex = 1
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblUsername.ForeColor = Color.White
        lblUsername.Location = New Point(162, 159)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(106, 28)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(168, 199)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(101, 28)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(267, 197)
        txtPassword.Margin = New Padding(3, 4, 3, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(229, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(267, 236)
        btnLogin.Margin = New Padding(3, 4, 3, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 31)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(386, 236)
        btnExit.Margin = New Padding(3, 4, 3, 4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 31)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(677, 332)
        Controls.Add(btnExit)
        Controls.Add(btnLogin)
        Controls.Add(lblPassword)
        Controls.Add(txtPassword)
        Controls.Add(lblUsername)
        Controls.Add(txtUsername)
        Controls.Add(logoKostify)
        Margin = New Padding(3, 4, 3, 4)
        Name = "formLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        CType(logoKostify, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents logoKostify As PictureBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnExit As Button
End Class
