<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
		components = New ComponentModel.Container()
		pnlHeader = New Panel()
		lblJudul = New Label()
		pnlForm = New Panel()
		lblNama = New Label()
		txtNama = New TextBox()
		lblUsername = New Label()
		txtUsername = New TextBox()
		lblPassword = New Label()
		txtPassword = New TextBox()
		lblEmail = New Label()
		txtEmail = New TextBox()
		lblGolDarah = New Label()
		cboGolDarah = New ComboBox()
		lblTelepon = New Label()
		txtTelepon = New TextBox()
		btnDaftar = New Button()
		btnBatal = New Button()
		errProvider = New ErrorProvider(components)
		pnlHeader.SuspendLayout()
		pnlForm.SuspendLayout()
		CType(errProvider, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		pnlHeader.Controls.Add(lblJudul)
		pnlHeader.Dock = DockStyle.Top
		pnlHeader.Location = New Point(0, 0)
		pnlHeader.Margin = New Padding(3, 4, 3, 4)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(549, 80)
		pnlHeader.TabIndex = 1
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
		lblJudul.ForeColor = Color.White
		lblJudul.Location = New Point(23, 24)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(368, 30)
		lblJudul.TabIndex = 0
		lblJudul.Text = "PENDAFTARAN AKUN PENDONOR"
		' 
		' pnlForm
		' 
		pnlForm.BackColor = Color.White
		pnlForm.Controls.Add(lblNama)
		pnlForm.Controls.Add(txtNama)
		pnlForm.Controls.Add(lblUsername)
		pnlForm.Controls.Add(txtUsername)
		pnlForm.Controls.Add(lblPassword)
		pnlForm.Controls.Add(txtPassword)
		pnlForm.Controls.Add(lblEmail)
		pnlForm.Controls.Add(txtEmail)
		pnlForm.Controls.Add(lblGolDarah)
		pnlForm.Controls.Add(cboGolDarah)
		pnlForm.Controls.Add(lblTelepon)
		pnlForm.Controls.Add(txtTelepon)
		pnlForm.Controls.Add(btnDaftar)
		pnlForm.Controls.Add(btnBatal)
		pnlForm.Dock = DockStyle.Fill
		pnlForm.Location = New Point(0, 80)
		pnlForm.Margin = New Padding(3, 4, 3, 4)
		pnlForm.Name = "pnlForm"
		pnlForm.Size = New Size(549, 400)
		pnlForm.TabIndex = 0
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNama.Location = New Point(34, 36)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(131, 23)
		lblNama.TabIndex = 0
		lblNama.Text = "Nama Lengkap"
		' 
		' txtNama
		' 
		txtNama.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtNama.BorderStyle = BorderStyle.FixedSingle
		txtNama.Font = New Font("Segoe UI", 9.0F)
		txtNama.Location = New Point(34, 70)
		txtNama.Margin = New Padding(3, 4, 3, 4)
		txtNama.Name = "txtNama"
		txtNama.PlaceholderText = "Nama lengkap..."
		txtNama.Size = New Size(228, 27)
		txtNama.TabIndex = 0
		' 
		' lblUsername
		' 
		lblUsername.AutoSize = True
		lblUsername.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblUsername.Location = New Point(286, 36)
		lblUsername.Name = "lblUsername"
		lblUsername.Size = New Size(89, 23)
		lblUsername.TabIndex = 1
		lblUsername.Text = "Username"
		' 
		' txtUsername
		' 
		txtUsername.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtUsername.BorderStyle = BorderStyle.FixedSingle
		txtUsername.Font = New Font("Segoe UI", 9.0F)
		txtUsername.Location = New Point(286, 70)
		txtUsername.Margin = New Padding(3, 4, 3, 4)
		txtUsername.Name = "txtUsername"
		txtUsername.PlaceholderText = "Username unik..."
		txtUsername.Size = New Size(228, 27)
		txtUsername.TabIndex = 1
		' 
		' lblPassword
		' 
		lblPassword.AutoSize = True
		lblPassword.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblPassword.Location = New Point(34, 128)
		lblPassword.Name = "lblPassword"
		lblPassword.Size = New Size(85, 23)
		lblPassword.TabIndex = 2
		lblPassword.Text = "Password"
		' 
		' txtPassword
		' 
		txtPassword.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtPassword.BorderStyle = BorderStyle.FixedSingle
		txtPassword.Font = New Font("Segoe UI", 9.0F)
		txtPassword.Location = New Point(34, 165)
		txtPassword.Margin = New Padding(3, 4, 3, 4)
		txtPassword.Name = "txtPassword"
		txtPassword.PasswordChar = "*"c
		txtPassword.PlaceholderText = "Password..."
		txtPassword.Size = New Size(228, 27)
		txtPassword.TabIndex = 2
		' 
		' lblEmail
		' 
		lblEmail.AutoSize = True
		lblEmail.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblEmail.Location = New Point(286, 128)
		lblEmail.Name = "lblEmail"
		lblEmail.Size = New Size(54, 23)
		lblEmail.TabIndex = 3
		lblEmail.Text = "Email"
		' 
		' txtEmail
		' 
		txtEmail.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtEmail.BorderStyle = BorderStyle.FixedSingle
		txtEmail.Font = New Font("Segoe UI", 9.0F)
		txtEmail.Location = New Point(286, 165)
		txtEmail.Margin = New Padding(3, 4, 3, 4)
		txtEmail.Name = "txtEmail"
		txtEmail.PlaceholderText = "contoh@email.com"
		txtEmail.Size = New Size(228, 27)
		txtEmail.TabIndex = 3
		' 
		' lblGolDarah
		' 
		lblGolDarah.AutoSize = True
		lblGolDarah.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblGolDarah.Location = New Point(34, 226)
		lblGolDarah.Name = "lblGolDarah"
		lblGolDarah.Size = New Size(140, 23)
		lblGolDarah.TabIndex = 4
		lblGolDarah.Text = "Golongan Darah"
		' 
		' cboGolDarah
		' 
		cboGolDarah.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		cboGolDarah.DropDownStyle = ComboBoxStyle.DropDownList
		cboGolDarah.Font = New Font("Segoe UI", 9.0F)
		cboGolDarah.Items.AddRange(New Object() {"A", "B", "AB", "O"})
		cboGolDarah.Location = New Point(34, 260)
		cboGolDarah.Margin = New Padding(3, 4, 3, 4)
		cboGolDarah.Name = "cboGolDarah"
		cboGolDarah.Size = New Size(148, 28)
		cboGolDarah.TabIndex = 4
		' 
		' lblTelepon
		' 
		lblTelepon.AutoSize = True
		lblTelepon.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTelepon.Location = New Point(286, 226)
		lblTelepon.Name = "lblTelepon"
		lblTelepon.Size = New Size(105, 23)
		lblTelepon.TabIndex = 5
		lblTelepon.Text = "No. Telepon"
		' 
		' txtTelepon
		' 
		txtTelepon.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtTelepon.BorderStyle = BorderStyle.FixedSingle
		txtTelepon.Font = New Font("Segoe UI", 9.0F)
		txtTelepon.Location = New Point(286, 261)
		txtTelepon.Margin = New Padding(3, 4, 3, 4)
		txtTelepon.Name = "txtTelepon"
		txtTelepon.PlaceholderText = "08xxxxxxxxxx"
		txtTelepon.Size = New Size(228, 27)
		txtTelepon.TabIndex = 5
		' 
		' btnDaftar
		' 
		btnDaftar.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnDaftar.Cursor = Cursors.Hand
		btnDaftar.FlatAppearance.BorderSize = 0
		btnDaftar.FlatStyle = FlatStyle.Flat
		btnDaftar.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
		btnDaftar.ForeColor = Color.White
		btnDaftar.Location = New Point(34, 317)
		btnDaftar.Margin = New Padding(3, 4, 3, 4)
		btnDaftar.Name = "btnDaftar"
		btnDaftar.Size = New Size(229, 53)
		btnDaftar.TabIndex = 6
		btnDaftar.Text = "DAFTAR SEKARANG"
		btnDaftar.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.White
		btnBatal.Cursor = Cursors.Hand
		btnBatal.FlatAppearance.BorderColor = Color.Gray
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.Font = New Font("Segoe UI", 9.0F)
		btnBatal.ForeColor = Color.Gray
		btnBatal.Location = New Point(286, 317)
		btnBatal.Margin = New Padding(3, 4, 3, 4)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(229, 53)
		btnBatal.TabIndex = 7
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' errProvider
		' 
		errProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink
		errProvider.ContainerControl = Me
		' 
		' FormRegister
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.White
		ClientSize = New Size(549, 480)
		Controls.Add(pnlForm)
		Controls.Add(pnlHeader)
		FormBorderStyle = FormBorderStyle.FixedSingle
		Margin = New Padding(3, 4, 3, 4)
		MaximizeBox = False
		Name = "FormRegister"
		StartPosition = FormStartPosition.CenterParent
		Text = "Daftar Akun - Sistem Donor Darah"
		pnlHeader.ResumeLayout(False)
		pnlHeader.PerformLayout()
		pnlForm.ResumeLayout(False)
		pnlForm.PerformLayout()
		CType(errProvider, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblJudul As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblGolDarah As Label
    Friend WithEvents cboGolDarah As ComboBox
    Friend WithEvents lblTelepon As Label
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents errProvider As ErrorProvider

End Class