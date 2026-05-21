<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		pnlHeader = New Panel()
		picLogo = New PictureBox()
		lblJudul = New Label()
		lblSubJudul = New Label()
		pnlForm = New Panel()
		lblUsername = New Label()
		txtUsername = New TextBox()
		lblPassword = New Label()
		txtPassword = New TextBox()
		chkShowPass = New CheckBox()
		btnLogin = New Button()
		btnRegister = New Button()
		lblFooter = New Label()
		pnlHeader.SuspendLayout()
		CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
		pnlForm.SuspendLayout()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		pnlHeader.Controls.Add(picLogo)
		pnlHeader.Controls.Add(lblJudul)
		pnlHeader.Controls.Add(lblSubJudul)
		pnlHeader.Dock = DockStyle.Top
		pnlHeader.Location = New Point(0, 0)
		pnlHeader.Margin = New Padding(3, 4, 3, 4)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(457, 139)
		pnlHeader.TabIndex = 1
		' 
		' picLogo
		' 
		picLogo.BackColor = Color.White
		picLogo.Location = New Point(27, 33)
		picLogo.Margin = New Padding(3, 4, 3, 4)
		picLogo.Name = "picLogo"
		picLogo.Size = New Size(71, 72)
		picLogo.SizeMode = PictureBoxSizeMode.CenterImage
		picLogo.TabIndex = 0
		picLogo.TabStop = False
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
		lblJudul.ForeColor = Color.White
		lblJudul.Location = New Point(118, 33)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(322, 37)
		lblJudul.TabIndex = 1
		lblJudul.Text = "SISTEM DONOR DARAH"
		' 
		' lblSubJudul
		' 
		lblSubJudul.AutoSize = True
		lblSubJudul.Font = New Font("Segoe UI", 9.0F)
		lblSubJudul.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(200))
		lblSubJudul.Location = New Point(122, 70)
		lblSubJudul.Name = "lblSubJudul"
		lblSubJudul.Size = New Size(291, 20)
		lblSubJudul.TabIndex = 2
		lblSubJudul.Text = "Sistem Informasi Manajemen Donor Darah"
		' 
		' pnlForm
		' 
		pnlForm.BackColor = Color.White
		pnlForm.Controls.Add(lblUsername)
		pnlForm.Controls.Add(txtUsername)
		pnlForm.Controls.Add(lblPassword)
		pnlForm.Controls.Add(txtPassword)
		pnlForm.Controls.Add(chkShowPass)
		pnlForm.Controls.Add(btnLogin)
		pnlForm.Controls.Add(btnRegister)
		pnlForm.Controls.Add(lblFooter)
		pnlForm.Dock = DockStyle.Fill
		pnlForm.Location = New Point(0, 139)
		pnlForm.Margin = New Padding(3, 4, 3, 4)
		pnlForm.Name = "pnlForm"
		pnlForm.Padding = New Padding(46, 27, 46, 27)
		pnlForm.Size = New Size(457, 481)
		pnlForm.TabIndex = 0
		' 
		' lblUsername
		' 
		lblUsername.AutoSize = True
		lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblUsername.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
		lblUsername.Location = New Point(45, 39)
		lblUsername.Name = "lblUsername"
		lblUsername.Size = New Size(89, 23)
		lblUsername.TabIndex = 0
		lblUsername.Text = "Username"
		' 
		' txtUsername
		' 
		txtUsername.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtUsername.BorderStyle = BorderStyle.FixedSingle
		txtUsername.Font = New Font("Segoe UI", 10.0F)
		txtUsername.Location = New Point(45, 79)
		txtUsername.Margin = New Padding(3, 4, 3, 4)
		txtUsername.Name = "txtUsername"
		txtUsername.PlaceholderText = "Masukkan username..."
		txtUsername.Size = New Size(365, 30)
		txtUsername.TabIndex = 0
		' 
		' lblPassword
		' 
		lblPassword.AutoSize = True
		lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblPassword.ForeColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
		lblPassword.Location = New Point(45, 142)
		lblPassword.Name = "lblPassword"
		lblPassword.Size = New Size(85, 23)
		lblPassword.TabIndex = 1
		lblPassword.Text = "Password"
		' 
		' txtPassword
		' 
		txtPassword.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtPassword.BorderStyle = BorderStyle.FixedSingle
		txtPassword.Font = New Font("Segoe UI", 10.0F)
		txtPassword.Location = New Point(45, 178)
		txtPassword.Margin = New Padding(3, 4, 3, 4)
		txtPassword.Name = "txtPassword"
		txtPassword.PasswordChar = "*"c
		txtPassword.PlaceholderText = "Masukkan password..."
		txtPassword.Size = New Size(365, 30)
		txtPassword.TabIndex = 1
		' 
		' chkShowPass
		' 
		chkShowPass.AutoSize = True
		chkShowPass.Font = New Font("Segoe UI", 8.0F)
		chkShowPass.ForeColor = Color.Gray
		chkShowPass.Location = New Point(45, 216)
		chkShowPass.Margin = New Padding(3, 4, 3, 4)
		chkShowPass.Name = "chkShowPass"
		chkShowPass.Size = New Size(153, 23)
		chkShowPass.TabIndex = 2
		chkShowPass.Text = "Tampilkan Password"
		' 
		' btnLogin
		' 
		btnLogin.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnLogin.Cursor = Cursors.Hand
		btnLogin.FlatAppearance.BorderSize = 0
		btnLogin.FlatStyle = FlatStyle.Flat
		btnLogin.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
		btnLogin.ForeColor = Color.White
		btnLogin.Location = New Point(45, 286)
		btnLogin.Margin = New Padding(3, 4, 3, 4)
		btnLogin.Name = "btnLogin"
		btnLogin.Size = New Size(366, 53)
		btnLogin.TabIndex = 3
		btnLogin.Text = "LOGIN"
		btnLogin.UseVisualStyleBackColor = False
		' 
		' btnRegister
		' 
		btnRegister.BackColor = Color.White
		btnRegister.Cursor = Cursors.Hand
		btnRegister.FlatAppearance.BorderColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnRegister.FlatStyle = FlatStyle.Flat
		btnRegister.Font = New Font("Segoe UI", 9.0F)
		btnRegister.ForeColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnRegister.Location = New Point(45, 358)
		btnRegister.Margin = New Padding(3, 4, 3, 4)
		btnRegister.Name = "btnRegister"
		btnRegister.Size = New Size(366, 47)
		btnRegister.TabIndex = 4
		btnRegister.Text = "Belum punya akun? Daftar di sini"
		btnRegister.UseVisualStyleBackColor = False
		' 
		' lblFooter
		' 
		lblFooter.AutoSize = True
		lblFooter.Font = New Font("Segoe UI", 8.0F)
		lblFooter.ForeColor = Color.Gray
		lblFooter.Location = New Point(27, 430)
		lblFooter.Name = "lblFooter"
		lblFooter.Size = New Size(401, 19)
		lblFooter.TabIndex = 5
		lblFooter.Text = "© 2025 Sistem Manajemen Donor Darah - Pemrograman Visual"
		' 
		' FormLogin
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.White
		ClientSize = New Size(457, 620)
		Controls.Add(pnlForm)
		Controls.Add(pnlHeader)
		FormBorderStyle = FormBorderStyle.FixedSingle
		Margin = New Padding(3, 4, 3, 4)
		MaximizeBox = False
		Name = "FormLogin"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Login - Sistem Donor Darah"
		pnlHeader.ResumeLayout(False)
		pnlHeader.PerformLayout()
		CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
		pnlForm.ResumeLayout(False)
		pnlForm.PerformLayout()
		ResumeLayout(False)
	End Sub

	' -- Deklarasi Variabel Kontrol --
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblJudul As Label
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPass As CheckBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents lblFooter As Label

End Class