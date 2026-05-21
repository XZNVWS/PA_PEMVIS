<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboardUser
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
        lblNamaUser = New Label()
        lblSubHeader = New Label()
        pnlTopBar = New Panel()
        lblPageTitle = New Label()
        btnLogout = New Button()
        pnlNav = New Panel()
        btnTabRiwayat = New Button()
        btnTabDonasi = New Button()
        btnTabProfil = New Button()
        pnlContent = New Panel()
        pnlProfil = New Panel()
        lblJenisKelamin = New Label()
        lblUsia = New Label()
        cmbJenisKelamin = New ComboBox()
        lblTanggalLahir = New Label()
        lblUsiaAuto = New Label()
        dtpTanggalLahir = New DateTimePicker()
        grbDataAkun = New GroupBox()
        Label2 = New Label()
        lblEmail = New Label()
        lblNomorTelp = New Label()
        lblNamaLengkap = New Label()
        txtUsername = New TextBox()
        txtNomorTelp = New TextBox()
        txtEmail = New TextBox()
        txtNamaLengkap = New TextBox()
        pnlAlert = New Panel()
        lblAlert = New Label()
        cmbGolonganDarah = New ComboBox()
        cmbRhesus = New ComboBox()
        lblGolonganDarah = New Label()
        lblRhesus = New Label()
        btnSimpan = New Button()
        pnlDonasi = New Panel()
        lblNama = New Label()
        lblEmailDonasi = New Label()
        lblNoTelp = New Label()
        lblJk = New Label()
        lblUmur = New Label()
        lblGolDar = New Label()
        grpData = New GroupBox()
        txtNamaDonasi = New TextBox()
        txtEmailDonasi = New TextBox()
        txtNoTelp = New TextBox()
        txtJk = New TextBox()
        txtUmur = New TextBox()
        txtGolDar = New TextBox()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        btnAjukanDonasi = New Button()
        pnlRiwayat = New Panel()
        dgvRiwayat = New DataGridView()
        pnlAksiRiwayat = New Panel()
        btnCetakKuitansi = New Button()
        btnCetakKonsultasi = New Button()
        btnRefresh = New Button()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        txtAlamatDonasi = New TextBox()
        lblAlamatDonasi = New Label()
        pnlHeader.SuspendLayout()
        pnlTopBar.SuspendLayout()
        pnlNav.SuspendLayout()
        pnlContent.SuspendLayout()
        pnlProfil.SuspendLayout()
        grbDataAkun.SuspendLayout()
        pnlAlert.SuspendLayout()
        pnlDonasi.SuspendLayout()
        grpData.SuspendLayout()
        pnlRiwayat.SuspendLayout()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        pnlAksiRiwayat.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.BorderStyle = BorderStyle.FixedSingle
        pnlHeader.Controls.Add(lblNamaUser)
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 73)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(782, 79)
        pnlHeader.TabIndex = 2
        ' 
        ' lblNamaUser
        ' 
        lblNamaUser.AutoSize = True
        lblNamaUser.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblNamaUser.ForeColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
        lblNamaUser.Location = New Point(17, 11)
        lblNamaUser.Name = "lblNamaUser"
        lblNamaUser.Size = New Size(268, 28)
        lblNamaUser.TabIndex = 0
        lblNamaUser.Text = "Selamat datang, Pendonor!"
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.0F)
        lblSubHeader.ForeColor = Color.Gray
        lblSubHeader.Location = New Point(17, 47)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(368, 20)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Golongan Darah: - | Terima kasih atas kontribusi Anda!"
        ' 
        ' pnlTopBar
        ' 
        pnlTopBar.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
        pnlTopBar.Controls.Add(lblPageTitle)
        pnlTopBar.Controls.Add(btnLogout)
        pnlTopBar.Dock = DockStyle.Top
        pnlTopBar.Location = New Point(0, 0)
        pnlTopBar.Margin = New Padding(3, 4, 3, 4)
        pnlTopBar.Name = "pnlTopBar"
        pnlTopBar.Size = New Size(782, 73)
        pnlTopBar.TabIndex = 3
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.White
        lblPageTitle.Location = New Point(29, 23)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(287, 30)
        lblPageTitle.TabIndex = 0
        lblPageTitle.Text = ChrW(55358) & ChrW(56952) & " Portal Pendonor Darah"
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnLogout.BackColor = Color.FromArgb(CByte(130), CByte(20), CByte(20))
        btnLogout.Cursor = Cursors.Hand
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 9.0F)
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(654, 16)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(114, 40)
        btnLogout.TabIndex = 1
        btnLogout.Text = "⬅ Logout"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlNav
        ' 
        pnlNav.BackColor = Color.Silver
        pnlNav.Controls.Add(btnTabRiwayat)
        pnlNav.Controls.Add(btnTabDonasi)
        pnlNav.Controls.Add(btnTabProfil)
        pnlNav.Dock = DockStyle.Top
        pnlNav.Location = New Point(0, 152)
        pnlNav.Name = "pnlNav"
        pnlNav.Size = New Size(782, 50)
        pnlNav.TabIndex = 4
        ' 
        ' btnTabRiwayat
        ' 
        btnTabRiwayat.BackColor = Color.White
        btnTabRiwayat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabRiwayat.ForeColor = Color.DimGray
        btnTabRiwayat.Location = New Point(522, 0)
        btnTabRiwayat.Name = "btnTabRiwayat"
        btnTabRiwayat.Size = New Size(260, 50)
        btnTabRiwayat.TabIndex = 2
        btnTabRiwayat.Text = "📋 Riwayat"
        btnTabRiwayat.UseVisualStyleBackColor = False
        ' 
        ' btnTabDonasi
        ' 
        btnTabDonasi.BackColor = Color.White
        btnTabDonasi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabDonasi.ForeColor = Color.FromArgb(CByte(139), CByte(26), CByte(26))
        btnTabDonasi.Location = New Point(261, 0)
        btnTabDonasi.Name = "btnTabDonasi"
        btnTabDonasi.Size = New Size(260, 50)
        btnTabDonasi.TabIndex = 1
        btnTabDonasi.Text = "❤ Ajukan Donasi"
        btnTabDonasi.UseVisualStyleBackColor = False
        ' 
        ' btnTabProfil
        ' 
        btnTabProfil.BackColor = Color.White
        btnTabProfil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTabProfil.ForeColor = Color.FromArgb(CByte(220), CByte(150), CByte(36))
        btnTabProfil.Location = New Point(0, 0)
        btnTabProfil.Name = "btnTabProfil"
        btnTabProfil.Size = New Size(260, 50)
        btnTabProfil.TabIndex = 0
        btnTabProfil.Text = "👤 Profil Saya" & vbCrLf
        btnTabProfil.UseVisualStyleBackColor = False
        ' 
        ' pnlContent
        ' 
        pnlContent.Controls.Add(pnlProfil)
        pnlContent.Controls.Add(pnlDonasi)
        pnlContent.Controls.Add(pnlRiwayat)
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(0, 202)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(14)
        pnlContent.Size = New Size(782, 551)
        pnlContent.TabIndex = 5
        ' 
        ' pnlProfil
        ' 
        pnlProfil.Controls.Add(txtAlamat)
        pnlProfil.Controls.Add(lblAlamat)
        pnlProfil.Controls.Add(btnSimpan)
        pnlProfil.Controls.Add(lblRhesus)
        pnlProfil.Controls.Add(lblGolonganDarah)
        pnlProfil.Controls.Add(cmbRhesus)
        pnlProfil.Controls.Add(cmbGolonganDarah)
        pnlProfil.Controls.Add(lblJenisKelamin)
        pnlProfil.Controls.Add(lblUsia)
        pnlProfil.Controls.Add(cmbJenisKelamin)
        pnlProfil.Controls.Add(lblTanggalLahir)
        pnlProfil.Controls.Add(lblUsiaAuto)
        pnlProfil.Controls.Add(dtpTanggalLahir)
        pnlProfil.Controls.Add(grbDataAkun)
        pnlProfil.Controls.Add(pnlAlert)
        pnlProfil.Dock = DockStyle.Fill
        pnlProfil.Location = New Point(14, 14)
        pnlProfil.Name = "pnlProfil"
        pnlProfil.Size = New Size(754, 523)
        pnlProfil.TabIndex = 0
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(396, 276)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(98, 20)
        lblJenisKelamin.TabIndex = 7
        lblJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' lblUsia
        ' 
        lblUsia.AutoSize = True
        lblUsia.Location = New Point(396, 201)
        lblUsia.Name = "lblUsia"
        lblUsia.Size = New Size(112, 20)
        lblUsia.TabIndex = 6
        lblUsia.Text = "Usia (Otomatis)"
        ' 
        ' cmbJenisKelamin
        ' 
        cmbJenisKelamin.DropDownStyle = ComboBoxStyle.DropDownList
        cmbJenisKelamin.FormattingEnabled = True
        cmbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        cmbJenisKelamin.Location = New Point(390, 299)
        cmbJenisKelamin.Name = "cmbJenisKelamin"
        cmbJenisKelamin.Size = New Size(350, 28)
        cmbJenisKelamin.TabIndex = 5
        ' 
        ' lblTanggalLahir
        ' 
        lblTanggalLahir.AutoSize = True
        lblTanggalLahir.Location = New Point(15, 201)
        lblTanggalLahir.Name = "lblTanggalLahir"
        lblTanggalLahir.Size = New Size(97, 20)
        lblTanggalLahir.TabIndex = 4
        lblTanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' lblUsiaAuto
        ' 
        lblUsiaAuto.BackColor = SystemColors.ButtonFace
        lblUsiaAuto.BorderStyle = BorderStyle.FixedSingle
        lblUsiaAuto.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsiaAuto.Location = New Point(390, 225)
        lblUsiaAuto.Name = "lblUsiaAuto"
        lblUsiaAuto.Size = New Size(350, 27)
        lblUsiaAuto.TabIndex = 3
        lblUsiaAuto.Text = "- tahun"
        lblUsiaAuto.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Format = DateTimePickerFormat.Short
        dtpTanggalLahir.Location = New Point(10, 224)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(350, 27)
        dtpTanggalLahir.TabIndex = 2
        ' 
        ' grbDataAkun
        ' 
        grbDataAkun.Controls.Add(Label2)
        grbDataAkun.Controls.Add(lblEmail)
        grbDataAkun.Controls.Add(lblNomorTelp)
        grbDataAkun.Controls.Add(lblNamaLengkap)
        grbDataAkun.Controls.Add(txtUsername)
        grbDataAkun.Controls.Add(txtNomorTelp)
        grbDataAkun.Controls.Add(txtEmail)
        grbDataAkun.Controls.Add(txtNamaLengkap)
        grbDataAkun.Dock = DockStyle.Top
        grbDataAkun.Location = New Point(0, 32)
        grbDataAkun.Name = "grbDataAkun"
        grbDataAkun.Size = New Size(754, 150)
        grbDataAkun.TabIndex = 1
        grbDataAkun.TabStop = False
        grbDataAkun.Text = "Data Akun (Read-Only)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(395, 94)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 7
        Label2.Text = "Username"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(396, 33)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 6
        lblEmail.Text = "Email"
        ' 
        ' lblNomorTelp
        ' 
        lblNomorTelp.AutoSize = True
        lblNomorTelp.Location = New Point(15, 94)
        lblNomorTelp.Name = "lblNomorTelp"
        lblNomorTelp.Size = New Size(89, 20)
        lblNomorTelp.TabIndex = 5
        lblNomorTelp.Text = "No. Telepon"
        ' 
        ' lblNamaLengkap
        ' 
        lblNamaLengkap.AutoSize = True
        lblNamaLengkap.Location = New Point(15, 33)
        lblNamaLengkap.Name = "lblNamaLengkap"
        lblNamaLengkap.Size = New Size(109, 20)
        lblNamaLengkap.TabIndex = 4
        lblNamaLengkap.Text = "Nama Lengkap"
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = SystemColors.ButtonFace
        txtUsername.Location = New Point(390, 117)
        txtUsername.Name = "txtUsername"
        txtUsername.ReadOnly = True
        txtUsername.Size = New Size(350, 27)
        txtUsername.TabIndex = 3
        ' 
        ' txtNomorTelp
        ' 
        txtNomorTelp.BackColor = SystemColors.ButtonFace
        txtNomorTelp.Location = New Point(10, 117)
        txtNomorTelp.Name = "txtNomorTelp"
        txtNomorTelp.ReadOnly = True
        txtNomorTelp.Size = New Size(350, 27)
        txtNomorTelp.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ButtonFace
        txtEmail.Location = New Point(390, 56)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(350, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtNamaLengkap
        ' 
        txtNamaLengkap.BackColor = SystemColors.ButtonFace
        txtNamaLengkap.Location = New Point(10, 56)
        txtNamaLengkap.Name = "txtNamaLengkap"
        txtNamaLengkap.ReadOnly = True
        txtNamaLengkap.Size = New Size(350, 27)
        txtNamaLengkap.TabIndex = 0
        ' 
        ' pnlAlert
        ' 
        pnlAlert.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(200))
        pnlAlert.Controls.Add(lblAlert)
        pnlAlert.Dock = DockStyle.Top
        pnlAlert.Location = New Point(0, 0)
        pnlAlert.Name = "pnlAlert"
        pnlAlert.Size = New Size(754, 32)
        pnlAlert.TabIndex = 0
        ' 
        ' lblAlert
        ' 
        lblAlert.AutoSize = True
        lblAlert.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlert.ForeColor = Color.FromArgb(CByte(180), CByte(80), CByte(0))
        lblAlert.Location = New Point(10, 6)
        lblAlert.Name = "lblAlert"
        lblAlert.Size = New Size(705, 20)
        lblAlert.TabIndex = 0
        lblAlert.Text = "⚠ Jenis kelamin dan tanggal lahir wajib dilengkapi sebelum Anda dapat mengajukan donasi darah!"
        ' 
        ' cmbGolonganDarah
        ' 
        cmbGolonganDarah.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGolonganDarah.FormattingEnabled = True
        cmbGolonganDarah.Items.AddRange(New Object() {"A", "B", "O", "AB"})
        cmbGolonganDarah.Location = New Point(10, 299)
        cmbGolonganDarah.Name = "cmbGolonganDarah"
        cmbGolonganDarah.Size = New Size(350, 28)
        cmbGolonganDarah.TabIndex = 8
        ' 
        ' cmbRhesus
        ' 
        cmbRhesus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRhesus.FormattingEnabled = True
        cmbRhesus.Items.AddRange(New Object() {"+ (Positif)", "- (Negatif)"})
        cmbRhesus.Location = New Point(10, 372)
        cmbRhesus.Name = "cmbRhesus"
        cmbRhesus.Size = New Size(350, 28)
        cmbRhesus.TabIndex = 9
        ' 
        ' lblGolonganDarah
        ' 
        lblGolonganDarah.AutoSize = True
        lblGolonganDarah.Location = New Point(15, 276)
        lblGolonganDarah.Name = "lblGolonganDarah"
        lblGolonganDarah.Size = New Size(118, 20)
        lblGolonganDarah.TabIndex = 10
        lblGolonganDarah.Text = "Golongan Darah"
        ' 
        ' lblRhesus
        ' 
        lblRhesus.AutoSize = True
        lblRhesus.Location = New Point(15, 349)
        lblRhesus.Name = "lblRhesus"
        lblRhesus.Size = New Size(54, 20)
        lblRhesus.TabIndex = 11
        lblRhesus.Text = "Rhesus"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(139), CByte(26), CByte(26))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(590, 458)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 50)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan Profil"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' pnlDonasi
        ' 
        pnlDonasi.Controls.Add(lblAlamatDonasi)
        pnlDonasi.Controls.Add(txtAlamatDonasi)
        pnlDonasi.Controls.Add(btnAjukanDonasi)
        pnlDonasi.Controls.Add(DateTimePicker1)
        pnlDonasi.Controls.Add(Label1)
        pnlDonasi.Controls.Add(grpData)
        pnlDonasi.Dock = DockStyle.Fill
        pnlDonasi.Location = New Point(14, 14)
        pnlDonasi.Name = "pnlDonasi"
        pnlDonasi.Size = New Size(754, 523)
        pnlDonasi.TabIndex = 1
        pnlDonasi.Visible = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(6, 42)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(109, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama Lengkap"
        ' 
        ' lblEmailDonasi
        ' 
        lblEmailDonasi.AutoSize = True
        lblEmailDonasi.Location = New Point(398, 39)
        lblEmailDonasi.Name = "lblEmailDonasi"
        lblEmailDonasi.Size = New Size(46, 20)
        lblEmailDonasi.TabIndex = 1
        lblEmailDonasi.Text = "Email"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.Location = New Point(10, 118)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(89, 20)
        lblNoTelp.TabIndex = 2
        lblNoTelp.Text = "No. Telepon"
        ' 
        ' lblJk
        ' 
        lblJk.AutoSize = True
        lblJk.Location = New Point(398, 118)
        lblJk.Name = "lblJk"
        lblJk.Size = New Size(98, 20)
        lblJk.TabIndex = 3
        lblJk.Text = "Jenis Kelamin"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(10, 201)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(37, 20)
        lblUmur.TabIndex = 4
        lblUmur.Text = "Usia"
        ' 
        ' lblGolDar
        ' 
        lblGolDar.AutoSize = True
        lblGolDar.Location = New Point(396, 201)
        lblGolDar.Name = "lblGolDar"
        lblGolDar.Size = New Size(118, 20)
        lblGolDar.TabIndex = 5
        lblGolDar.Text = "Golongan Darah"
        ' 
        ' grpData
        ' 
        grpData.Controls.Add(txtGolDar)
        grpData.Controls.Add(txtUmur)
        grpData.Controls.Add(txtJk)
        grpData.Controls.Add(txtNoTelp)
        grpData.Controls.Add(txtEmailDonasi)
        grpData.Controls.Add(txtNamaDonasi)
        grpData.Controls.Add(lblNama)
        grpData.Controls.Add(lblEmailDonasi)
        grpData.Controls.Add(lblNoTelp)
        grpData.Controls.Add(lblJk)
        grpData.Controls.Add(lblUmur)
        grpData.Controls.Add(lblGolDar)
        grpData.Dock = DockStyle.Top
        grpData.Location = New Point(0, 0)
        grpData.Name = "grpData"
        grpData.Size = New Size(754, 280)
        grpData.TabIndex = 6
        grpData.TabStop = False
        grpData.Text = "Data Pendonor"
        ' 
        ' txtNamaDonasi
        ' 
        txtNamaDonasi.Location = New Point(6, 65)
        txtNamaDonasi.Name = "txtNamaDonasi"
        txtNamaDonasi.ReadOnly = True
        txtNamaDonasi.Size = New Size(350, 27)
        txtNamaDonasi.TabIndex = 6
        ' 
        ' txtEmailDonasi
        ' 
        txtEmailDonasi.Location = New Point(398, 62)
        txtEmailDonasi.Name = "txtEmailDonasi"
        txtEmailDonasi.ReadOnly = True
        txtEmailDonasi.Size = New Size(350, 27)
        txtEmailDonasi.TabIndex = 7
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(6, 141)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.ReadOnly = True
        txtNoTelp.Size = New Size(350, 27)
        txtNoTelp.TabIndex = 8
        ' 
        ' txtJk
        ' 
        txtJk.Location = New Point(398, 141)
        txtJk.Name = "txtJk"
        txtJk.ReadOnly = True
        txtJk.Size = New Size(350, 27)
        txtJk.TabIndex = 9
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(6, 224)
        txtUmur.Name = "txtUmur"
        txtUmur.ReadOnly = True
        txtUmur.Size = New Size(350, 27)
        txtUmur.TabIndex = 10
        ' 
        ' txtGolDar
        ' 
        txtGolDar.Location = New Point(398, 226)
        txtGolDar.Name = "txtGolDar"
        txtGolDar.ReadOnly = True
        txtGolDar.Size = New Size(350, 27)
        txtGolDar.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 302)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 20)
        Label1.TabIndex = 7
        Label1.Text = "Tanggal Rencana Donor"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(6, 333)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(350, 27)
        DateTimePicker1.TabIndex = 8
        ' 
        ' btnAjukanDonasi
        ' 
        btnAjukanDonasi.BackColor = Color.FromArgb(CByte(139), CByte(26), CByte(26))
        btnAjukanDonasi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAjukanDonasi.ForeColor = Color.White
        btnAjukanDonasi.Location = New Point(540, 458)
        btnAjukanDonasi.Name = "btnAjukanDonasi"
        btnAjukanDonasi.Size = New Size(200, 50)
        btnAjukanDonasi.TabIndex = 9
        btnAjukanDonasi.Text = "Ajukan Donasi"
        btnAjukanDonasi.UseVisualStyleBackColor = False
        ' 
        ' pnlRiwayat
        ' 
        pnlRiwayat.Controls.Add(pnlAksiRiwayat)
        pnlRiwayat.Controls.Add(dgvRiwayat)
        pnlRiwayat.Dock = DockStyle.Fill
        pnlRiwayat.Location = New Point(14, 14)
        pnlRiwayat.Name = "pnlRiwayat"
        pnlRiwayat.Size = New Size(754, 523)
        pnlRiwayat.TabIndex = 2
        pnlRiwayat.Visible = False
        ' 
        ' dgvRiwayat
        ' 
        dgvRiwayat.AllowUserToAddRows = False
        dgvRiwayat.AllowUserToDeleteRows = False
        dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRiwayat.Dock = DockStyle.Fill
        dgvRiwayat.Location = New Point(0, 0)
        dgvRiwayat.Name = "dgvRiwayat"
        dgvRiwayat.ReadOnly = True
        dgvRiwayat.RowHeadersWidth = 51
        dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRiwayat.Size = New Size(754, 523)
        dgvRiwayat.TabIndex = 0
        ' 
        ' pnlAksiRiwayat
        ' 
        pnlAksiRiwayat.Controls.Add(btnRefresh)
        pnlAksiRiwayat.Controls.Add(btnCetakKonsultasi)
        pnlAksiRiwayat.Controls.Add(btnCetakKuitansi)
        pnlAksiRiwayat.Dock = DockStyle.Bottom
        pnlAksiRiwayat.Location = New Point(0, 423)
        pnlAksiRiwayat.Name = "pnlAksiRiwayat"
        pnlAksiRiwayat.Size = New Size(754, 100)
        pnlAksiRiwayat.TabIndex = 1
        ' 
        ' btnCetakKuitansi
        ' 
        btnCetakKuitansi.BackColor = Color.FromArgb(CByte(46), CByte(125), CByte(50))
        btnCetakKuitansi.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetakKuitansi.ForeColor = Color.White
        btnCetakKuitansi.Location = New Point(15, 35)
        btnCetakKuitansi.Name = "btnCetakKuitansi"
        btnCetakKuitansi.Size = New Size(200, 50)
        btnCetakKuitansi.TabIndex = 0
        btnCetakKuitansi.Text = "🖨 Kuitansi"
        btnCetakKuitansi.UseVisualStyleBackColor = False
        ' 
        ' btnCetakKonsultasi
        ' 
        btnCetakKonsultasi.BackColor = Color.FromArgb(CByte(21), CByte(101), CByte(192))
        btnCetakKonsultasi.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCetakKonsultasi.ForeColor = Color.White
        btnCetakKonsultasi.Location = New Point(270, 35)
        btnCetakKonsultasi.Name = "btnCetakKonsultasi"
        btnCetakKonsultasi.Size = New Size(200, 50)
        btnCetakKonsultasi.TabIndex = 1
        btnCetakKonsultasi.Text = " 📄 Konsultasi" & vbLf
        btnCetakKonsultasi.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.FromArgb(CByte(236), CByte(239), CByte(241))
        btnRefresh.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.FromArgb(CByte(55), CByte(71), CByte(79))
        btnRefresh.Location = New Point(515, 35)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(200, 50)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "🔄 Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(395, 349)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 13
        lblAlamat.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(390, 373)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(350, 27)
        txtAlamat.TabIndex = 14
        ' 
        ' txtAlamatDonasi
        ' 
        txtAlamatDonasi.Location = New Point(396, 333)
        txtAlamatDonasi.Name = "txtAlamatDonasi"
        txtAlamatDonasi.Size = New Size(350, 27)
        txtAlamatDonasi.TabIndex = 10
        ' 
        ' lblAlamatDonasi
        ' 
        lblAlamatDonasi.AutoSize = True
        lblAlamatDonasi.Location = New Point(398, 310)
        lblAlamatDonasi.Name = "lblAlamatDonasi"
        lblAlamatDonasi.Size = New Size(117, 20)
        lblAlamatDonasi.TabIndex = 11
        lblAlamatDonasi.Text = "Alamat Lengkap"
        ' 
        ' FormDashboardUser
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(782, 753)
        Controls.Add(pnlContent)
        Controls.Add(pnlNav)
        Controls.Add(pnlHeader)
        Controls.Add(pnlTopBar)
        Margin = New Padding(3, 4, 3, 4)
        MinimumSize = New Size(800, 600)
        Name = "FormDashboardUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Portal Pendonor - Sistem Donor Darah"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlTopBar.ResumeLayout(False)
        pnlTopBar.PerformLayout()
        pnlNav.ResumeLayout(False)
        pnlContent.ResumeLayout(False)
        pnlProfil.ResumeLayout(False)
        pnlProfil.PerformLayout()
        grbDataAkun.ResumeLayout(False)
        grbDataAkun.PerformLayout()
        pnlAlert.ResumeLayout(False)
        pnlAlert.PerformLayout()
        pnlDonasi.ResumeLayout(False)
        pnlDonasi.PerformLayout()
        grpData.ResumeLayout(False)
        grpData.PerformLayout()
        pnlRiwayat.ResumeLayout(False)
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        pnlAksiRiwayat.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblNamaUser As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlNav As Panel
    Friend WithEvents btnTabRiwayat As Button
    Friend WithEvents btnTabDonasi As Button
    Friend WithEvents btnTabProfil As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlProfil As Panel
    Friend WithEvents pnlAlert As Panel
    Friend WithEvents lblAlert As Label
    Friend WithEvents grbDataAkun As GroupBox
    Friend WithEvents txtNomorTelp As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNamaLengkap As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNomorTelp As Label
    Friend WithEvents lblNamaLengkap As Label
    Friend WithEvents lblUsiaAuto As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents lblUsia As Label
    Friend WithEvents cmbJenisKelamin As ComboBox
    Friend WithEvents lblTanggalLahir As Label
    Friend WithEvents cmbRhesus As ComboBox
    Friend WithEvents cmbGolonganDarah As ComboBox
    Friend WithEvents pnlDonasi As Panel
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblRhesus As Label
    Friend WithEvents lblGolonganDarah As Label
    Friend WithEvents lblGolDar As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblJk As Label
    Friend WithEvents lblNoTelp As Label
    Friend WithEvents lblEmailDonasi As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents grpData As GroupBox
    Friend WithEvents txtGolDar As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtJk As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtEmailDonasi As TextBox
    Friend WithEvents txtNamaDonasi As TextBox
    Friend WithEvents btnAjukanDonasi As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlRiwayat As Panel
    Friend WithEvents pnlAksiRiwayat As Panel
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnCetakKonsultasi As Button
    Friend WithEvents btnCetakKuitansi As Button
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamatDonasi As Label
    Friend WithEvents txtAlamatDonasi As TextBox

End Class