<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboardAdmin
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
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
		pnlSidebar = New Panel()
		lblAppName = New Label()
		lblRole = New Label()
		btnMenuVerifikasi = New Button()
		btnMenuPendonor = New Button()
		btnMenuStok = New Button()
		btnMenuLog = New Button()
		btnMenuLaporan = New Button()
		btnLogout = New Button()
		pnlContent = New Panel()
		tabControl = New TabControl()
		tabVerifikasi = New TabPage()
		dgvDonasi = New DataGridView()
		pnlActionVerif = New Panel()
		btnApprove = New Button()
		btnReject = New Button()
		btnInputKonsultasi = New Button()
		tabPendonor = New TabPage()
		dgvPendonor = New DataGridView()
		btnHapusUser = New Button()
		tabStok = New TabPage()
		dgvStok = New DataGridView()
		lblKurangInfo = New Label()
		txtKurangJumlah = New TextBox()
		btnKurangStok = New Button()
		tabLog = New TabPage()
		dgvLog = New DataGridView()
		pnlAlert = New Panel()
		lblAlert = New Label()
		pnlStatWrapper = New Panel()
		pnlStatDonasi = New Panel()
		lblStatDonasiNum = New Label()
		lblStatDonasiText = New Label()
		pnlStatPending = New Panel()
		lblStatPendingNum = New Label()
		lblStatPendingText = New Label()
		pnlStatStok = New Panel()
		lblStatStokNum = New Label()
		lblStatStokText = New Label()
		pnlTopBar = New Panel()
		lblPageTitle = New Label()
		lblWelcome = New Label()
		pnlSidebar.SuspendLayout()
		pnlContent.SuspendLayout()
		tabControl.SuspendLayout()
		tabVerifikasi.SuspendLayout()
		CType(dgvDonasi, ComponentModel.ISupportInitialize).BeginInit()
		pnlActionVerif.SuspendLayout()
		tabPendonor.SuspendLayout()
		CType(dgvPendonor, ComponentModel.ISupportInitialize).BeginInit()
		tabStok.SuspendLayout()
		CType(dgvStok, ComponentModel.ISupportInitialize).BeginInit()
		tabLog.SuspendLayout()
		CType(dgvLog, ComponentModel.ISupportInitialize).BeginInit()
		pnlAlert.SuspendLayout()
		pnlStatWrapper.SuspendLayout()
		pnlStatDonasi.SuspendLayout()
		pnlStatPending.SuspendLayout()
		pnlStatStok.SuspendLayout()
		pnlTopBar.SuspendLayout()
		SuspendLayout()
		' 
		' pnlSidebar
		' 
		pnlSidebar.BackColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		pnlSidebar.Controls.Add(lblAppName)
		pnlSidebar.Controls.Add(lblRole)
		pnlSidebar.Controls.Add(btnMenuVerifikasi)
		pnlSidebar.Controls.Add(btnMenuPendonor)
		pnlSidebar.Controls.Add(btnMenuStok)
		pnlSidebar.Controls.Add(btnMenuLog)
		pnlSidebar.Controls.Add(btnMenuLaporan)
		pnlSidebar.Controls.Add(btnLogout)
		pnlSidebar.Dock = DockStyle.Left
		pnlSidebar.Location = New Point(0, 0)
		pnlSidebar.Margin = New Padding(3, 4, 3, 4)
		pnlSidebar.Name = "pnlSidebar"
		pnlSidebar.Size = New Size(229, 907)
		pnlSidebar.TabIndex = 1
		' 
		' lblAppName
		' 
		lblAppName.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
		lblAppName.ForeColor = Color.White
		lblAppName.Location = New Point(0, 27)
		lblAppName.Name = "lblAppName"
		lblAppName.Size = New Size(229, 53)
		lblAppName.TabIndex = 0
		lblAppName.Text = ChrW(55358) & ChrW(56952) & " DONOR DARAH"
		lblAppName.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblRole
		' 
		lblRole.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblRole.ForeColor = Color.FromArgb(CByte(255), CByte(180), CByte(180))
		lblRole.Location = New Point(0, 73)
		lblRole.Name = "lblRole"
		lblRole.Size = New Size(229, 33)
		lblRole.TabIndex = 1
		lblRole.Text = "Role: ADMIN"
		lblRole.TextAlign = ContentAlignment.MiddleCenter
		' 
		' btnMenuVerifikasi
		' 
		btnMenuVerifikasi.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnMenuVerifikasi.Cursor = Cursors.Hand
		btnMenuVerifikasi.FlatAppearance.BorderSize = 0
		btnMenuVerifikasi.FlatStyle = FlatStyle.Flat
		btnMenuVerifikasi.Font = New Font("Segoe UI", 9.0F)
		btnMenuVerifikasi.ForeColor = Color.White
		btnMenuVerifikasi.Location = New Point(0, 133)
		btnMenuVerifikasi.Margin = New Padding(3, 4, 3, 4)
		btnMenuVerifikasi.Name = "btnMenuVerifikasi"
		btnMenuVerifikasi.Size = New Size(229, 53)
		btnMenuVerifikasi.TabIndex = 2
		btnMenuVerifikasi.Text = "  ✓  Verifikasi Donasi"
		btnMenuVerifikasi.TextAlign = ContentAlignment.MiddleLeft
		btnMenuVerifikasi.UseVisualStyleBackColor = False
		' 
		' btnMenuPendonor
		' 
		btnMenuPendonor.BackColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		btnMenuPendonor.Cursor = Cursors.Hand
		btnMenuPendonor.FlatAppearance.BorderSize = 0
		btnMenuPendonor.FlatStyle = FlatStyle.Flat
		btnMenuPendonor.Font = New Font("Segoe UI", 9.0F)
		btnMenuPendonor.ForeColor = Color.White
		btnMenuPendonor.Location = New Point(0, 133)
		btnMenuPendonor.Margin = New Padding(3, 4, 3, 4)
		btnMenuPendonor.Name = "btnMenuPendonor"
		btnMenuPendonor.Size = New Size(229, 53)
		btnMenuPendonor.TabIndex = 3
		btnMenuPendonor.Text = "  👤  Data Pendonor"
		btnMenuPendonor.TextAlign = ContentAlignment.MiddleLeft
		btnMenuPendonor.UseVisualStyleBackColor = False
		' 
		' btnMenuStok
		' 
		btnMenuStok.BackColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		btnMenuStok.Cursor = Cursors.Hand
		btnMenuStok.FlatAppearance.BorderSize = 0
		btnMenuStok.FlatStyle = FlatStyle.Flat
		btnMenuStok.Font = New Font("Segoe UI", 9.0F)
		btnMenuStok.ForeColor = Color.White
		btnMenuStok.Location = New Point(0, 133)
		btnMenuStok.Margin = New Padding(3, 4, 3, 4)
		btnMenuStok.Name = "btnMenuStok"
		btnMenuStok.Size = New Size(229, 53)
		btnMenuStok.TabIndex = 4
		btnMenuStok.Text = "  " & ChrW(55358) & ChrW(56952) & "  Stok Darah"
		btnMenuStok.TextAlign = ContentAlignment.MiddleLeft
		btnMenuStok.UseVisualStyleBackColor = False
		' 
		' btnMenuLog
		' 
		btnMenuLog.BackColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		btnMenuLog.Cursor = Cursors.Hand
		btnMenuLog.FlatAppearance.BorderSize = 0
		btnMenuLog.FlatStyle = FlatStyle.Flat
		btnMenuLog.Font = New Font("Segoe UI", 9.0F)
		btnMenuLog.ForeColor = Color.White
		btnMenuLog.Location = New Point(0, 133)
		btnMenuLog.Margin = New Padding(3, 4, 3, 4)
		btnMenuLog.Name = "btnMenuLog"
		btnMenuLog.Size = New Size(229, 53)
		btnMenuLog.TabIndex = 5
		btnMenuLog.Text = "  📋  Log Sirkulasi"
		btnMenuLog.TextAlign = ContentAlignment.MiddleLeft
		btnMenuLog.UseVisualStyleBackColor = False
		' 
		' btnMenuLaporan
		' 
		btnMenuLaporan.BackColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		btnMenuLaporan.Cursor = Cursors.Hand
		btnMenuLaporan.FlatAppearance.BorderSize = 0
		btnMenuLaporan.FlatStyle = FlatStyle.Flat
		btnMenuLaporan.Font = New Font("Segoe UI", 9.0F)
		btnMenuLaporan.ForeColor = Color.White
		btnMenuLaporan.Location = New Point(0, 133)
		btnMenuLaporan.Margin = New Padding(3, 4, 3, 4)
		btnMenuLaporan.Name = "btnMenuLaporan"
		btnMenuLaporan.Size = New Size(229, 53)
		btnMenuLaporan.TabIndex = 6
		btnMenuLaporan.Text = "  📊  Cetak Laporan"
		btnMenuLaporan.TextAlign = ContentAlignment.MiddleLeft
		btnMenuLaporan.UseVisualStyleBackColor = False
		' 
		' btnLogout
		' 
		btnLogout.BackColor = Color.FromArgb(CByte(100), CByte(10), CByte(10))
		btnLogout.Cursor = Cursors.Hand
		btnLogout.Dock = DockStyle.Bottom
		btnLogout.FlatAppearance.BorderSize = 0
		btnLogout.FlatStyle = FlatStyle.Flat
		btnLogout.Font = New Font("Segoe UI", 9.0F)
		btnLogout.ForeColor = Color.White
		btnLogout.Location = New Point(0, 847)
		btnLogout.Margin = New Padding(3, 4, 3, 4)
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(229, 60)
		btnLogout.TabIndex = 7
		btnLogout.Text = "⬅  Logout"
		btnLogout.UseVisualStyleBackColor = False
		' 
		' pnlContent
		' 
		pnlContent.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(248))
		pnlContent.Controls.Add(tabControl)
		pnlContent.Controls.Add(pnlAlert)
		pnlContent.Controls.Add(pnlStatWrapper)
		pnlContent.Controls.Add(pnlTopBar)
		pnlContent.Dock = DockStyle.Fill
		pnlContent.Location = New Point(229, 0)
		pnlContent.Margin = New Padding(3, 4, 3, 4)
		pnlContent.Name = "pnlContent"
		pnlContent.Size = New Size(1028, 907)
		pnlContent.TabIndex = 0
		' 
		' tabControl
		' 
		tabControl.Controls.Add(tabVerifikasi)
		tabControl.Controls.Add(tabPendonor)
		tabControl.Controls.Add(tabStok)
		tabControl.Controls.Add(tabLog)
		tabControl.Location = New Point(11, 280)
		tabControl.Margin = New Padding(3, 4, 3, 4)
		tabControl.Name = "tabControl"
		tabControl.SelectedIndex = 0
		tabControl.Size = New Size(1006, 614)
		tabControl.TabIndex = 0
		' 
		' tabVerifikasi
		' 
		tabVerifikasi.BackColor = Color.White
		tabVerifikasi.Controls.Add(dgvDonasi)
		tabVerifikasi.Controls.Add(pnlActionVerif)
		tabVerifikasi.Location = New Point(4, 29)
		tabVerifikasi.Margin = New Padding(3, 4, 3, 4)
		tabVerifikasi.Name = "tabVerifikasi"
		tabVerifikasi.Size = New Size(998, 581)
		tabVerifikasi.TabIndex = 0
		tabVerifikasi.Text = "  Verifikasi Donasi  "
		' 
		' dgvDonasi
		' 
		dgvDonasi.AllowUserToAddRows = False
		dgvDonasi.AllowUserToDeleteRows = False
		dgvDonasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvDonasi.BackgroundColor = Color.White
		dgvDonasi.BorderStyle = BorderStyle.None
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		DataGridViewCellStyle1.ForeColor = Color.White
		DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
		dgvDonasi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		dgvDonasi.ColumnHeadersHeight = 29
		dgvDonasi.Location = New Point(6, 7)
		dgvDonasi.Margin = New Padding(3, 4, 3, 4)
		dgvDonasi.MultiSelect = False
		dgvDonasi.Name = "dgvDonasi"
		dgvDonasi.ReadOnly = True
		dgvDonasi.RowHeadersWidth = 51
		dgvDonasi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvDonasi.Size = New Size(983, 482)
		dgvDonasi.TabIndex = 0
		' 
		' pnlActionVerif
		' 
		pnlActionVerif.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
		pnlActionVerif.BorderStyle = BorderStyle.FixedSingle
		pnlActionVerif.Controls.Add(btnApprove)
		pnlActionVerif.Controls.Add(btnReject)
		pnlActionVerif.Controls.Add(btnInputKonsultasi)
		pnlActionVerif.Location = New Point(6, 497)
		pnlActionVerif.Margin = New Padding(3, 4, 3, 4)
		pnlActionVerif.Name = "pnlActionVerif"
		pnlActionVerif.Size = New Size(983, 80)
		pnlActionVerif.TabIndex = 1
		' 
		' btnApprove
		' 
		btnApprove.BackColor = Color.FromArgb(CByte(30), CByte(140), CByte(80))
		btnApprove.Cursor = Cursors.Hand
		btnApprove.FlatAppearance.BorderSize = 0
		btnApprove.FlatStyle = FlatStyle.Flat
		btnApprove.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnApprove.ForeColor = Color.White
		btnApprove.Location = New Point(11, 16)
		btnApprove.Margin = New Padding(3, 4, 3, 4)
		btnApprove.Name = "btnApprove"
		btnApprove.Size = New Size(206, 47)
		btnApprove.TabIndex = 0
		btnApprove.Text = "✓  TERVERIFIKASI"
		btnApprove.UseVisualStyleBackColor = False
		' 
		' btnReject
		' 
		btnReject.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnReject.Cursor = Cursors.Hand
		btnReject.FlatAppearance.BorderSize = 0
		btnReject.FlatStyle = FlatStyle.Flat
		btnReject.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnReject.ForeColor = Color.White
		btnReject.Location = New Point(229, 16)
		btnReject.Margin = New Padding(3, 4, 3, 4)
		btnReject.Name = "btnReject"
		btnReject.Size = New Size(171, 47)
		btnReject.TabIndex = 1
		btnReject.Text = "✗  TOLAK"
		btnReject.UseVisualStyleBackColor = False
		' 
		' btnInputKonsultasi
		' 
		btnInputKonsultasi.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
		btnInputKonsultasi.Cursor = Cursors.Hand
		btnInputKonsultasi.FlatAppearance.BorderSize = 0
		btnInputKonsultasi.FlatStyle = FlatStyle.Flat
		btnInputKonsultasi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnInputKonsultasi.ForeColor = Color.White
		btnInputKonsultasi.Location = New Point(411, 16)
		btnInputKonsultasi.Margin = New Padding(3, 4, 3, 4)
		btnInputKonsultasi.Name = "btnInputKonsultasi"
		btnInputKonsultasi.Size = New Size(229, 47)
		btnInputKonsultasi.TabIndex = 2
		btnInputKonsultasi.Text = "📝  Input Hasil Konsultasi"
		btnInputKonsultasi.UseVisualStyleBackColor = False
		' 
		' tabPendonor
		' 
		tabPendonor.BackColor = Color.White
		tabPendonor.Controls.Add(dgvPendonor)
		tabPendonor.Controls.Add(btnHapusUser)
		tabPendonor.Location = New Point(4, 29)
		tabPendonor.Margin = New Padding(3, 4, 3, 4)
		tabPendonor.Name = "tabPendonor"
		tabPendonor.Size = New Size(998, 581)
		tabPendonor.TabIndex = 1
		tabPendonor.Text = "  Data Pendonor  "
		' 
		' dgvPendonor
		' 
		dgvPendonor.AllowUserToAddRows = False
		dgvPendonor.AllowUserToDeleteRows = False
		dgvPendonor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvPendonor.BackgroundColor = Color.White
		dgvPendonor.BorderStyle = BorderStyle.None
		DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		DataGridViewCellStyle2.ForeColor = Color.White
		DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
		DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
		DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
		dgvPendonor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		dgvPendonor.ColumnHeadersHeight = 29
		dgvPendonor.Location = New Point(6, 7)
		dgvPendonor.Margin = New Padding(3, 4, 3, 4)
		dgvPendonor.Name = "dgvPendonor"
		dgvPendonor.ReadOnly = True
		dgvPendonor.RowHeadersWidth = 51
		dgvPendonor.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPendonor.Size = New Size(983, 440)
		dgvPendonor.TabIndex = 0
		' 
		' btnHapusUser
		' 
		btnHapusUser.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnHapusUser.Cursor = Cursors.Hand
		btnHapusUser.FlatAppearance.BorderSize = 0
		btnHapusUser.FlatStyle = FlatStyle.Flat
		btnHapusUser.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnHapusUser.ForeColor = Color.White
		btnHapusUser.Location = New Point(13, 521)
		btnHapusUser.Margin = New Padding(3, 4, 3, 4)
		btnHapusUser.Name = "btnHapusUser"
		btnHapusUser.Size = New Size(206, 47)
		btnHapusUser.TabIndex = 1
		btnHapusUser.Text = "🗑  Hapus Pendonor"
		btnHapusUser.UseVisualStyleBackColor = False
		' 
		' tabStok
		' 
		tabStok.BackColor = Color.White
		tabStok.Controls.Add(dgvStok)
		tabStok.Controls.Add(lblKurangInfo)
		tabStok.Controls.Add(txtKurangJumlah)
		tabStok.Controls.Add(btnKurangStok)
		tabStok.Location = New Point(4, 29)
		tabStok.Margin = New Padding(3, 4, 3, 4)
		tabStok.Name = "tabStok"
		tabStok.Size = New Size(998, 581)
		tabStok.TabIndex = 2
		tabStok.Text = "  Stok Darah  "
		' 
		' dgvStok
		' 
		dgvStok.AllowUserToAddRows = False
		dgvStok.AllowUserToDeleteRows = False
		dgvStok.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvStok.BackgroundColor = Color.White
		dgvStok.BorderStyle = BorderStyle.None
		DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		DataGridViewCellStyle3.ForeColor = Color.White
		DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
		DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
		DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
		dgvStok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
		dgvStok.ColumnHeadersHeight = 29
		dgvStok.Location = New Point(6, 7)
		dgvStok.Margin = New Padding(3, 4, 3, 4)
		dgvStok.Name = "dgvStok"
		dgvStok.ReadOnly = True
		dgvStok.RowHeadersWidth = 51
		dgvStok.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvStok.Size = New Size(983, 400)
		dgvStok.TabIndex = 0
		' 
		' lblKurangInfo
		' 
		lblKurangInfo.AutoSize = True
		lblKurangInfo.Font = New Font("Segoe UI", 9.0F)
		lblKurangInfo.Location = New Point(11, 505)
		lblKurangInfo.Name = "lblKurangInfo"
		lblKurangInfo.Size = New Size(512, 20)
		lblKurangInfo.TabIndex = 1
		lblKurangInfo.Text = "Pilih golongan darah pada tabel, lalu masukkan jumlah kantung yang keluar."
		' 
		' txtKurangJumlah
		' 
		txtKurangJumlah.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtKurangJumlah.BorderStyle = BorderStyle.FixedSingle
		txtKurangJumlah.Font = New Font("Segoe UI", 9.0F)
		txtKurangJumlah.Location = New Point(13, 538)
		txtKurangJumlah.Margin = New Padding(3, 4, 3, 4)
		txtKurangJumlah.Name = "txtKurangJumlah"
		txtKurangJumlah.PlaceholderText = "Jumlah keluar..."
		txtKurangJumlah.Size = New Size(177, 27)
		txtKurangJumlah.TabIndex = 2
		' 
		' btnKurangStok
		' 
		btnKurangStok.BackColor = Color.FromArgb(CByte(180), CByte(100), CByte(0))
		btnKurangStok.Cursor = Cursors.Hand
		btnKurangStok.FlatAppearance.BorderSize = 0
		btnKurangStok.FlatStyle = FlatStyle.Flat
		btnKurangStok.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnKurangStok.ForeColor = Color.White
		btnKurangStok.Location = New Point(204, 532)
		btnKurangStok.Margin = New Padding(3, 4, 3, 4)
		btnKurangStok.Name = "btnKurangStok"
		btnKurangStok.Size = New Size(229, 36)
		btnKurangStok.TabIndex = 3
		btnKurangStok.Text = "Distribusi / Kurangi Stok"
		btnKurangStok.UseVisualStyleBackColor = False
		' 
		' tabLog
		' 
		tabLog.BackColor = Color.White
		tabLog.Controls.Add(dgvLog)
		tabLog.Location = New Point(4, 29)
		tabLog.Margin = New Padding(3, 4, 3, 4)
		tabLog.Name = "tabLog"
		tabLog.Size = New Size(998, 581)
		tabLog.TabIndex = 3
		tabLog.Text = "  Log Sirkulasi  "
		' 
		' dgvLog
		' 
		dgvLog.AllowUserToAddRows = False
		dgvLog.AllowUserToDeleteRows = False
		dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvLog.BackgroundColor = Color.White
		dgvLog.BorderStyle = BorderStyle.None
		DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		DataGridViewCellStyle4.ForeColor = Color.White
		DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
		DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
		DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
		dgvLog.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
		dgvLog.ColumnHeadersHeight = 29
		dgvLog.Location = New Point(6, 7)
		dgvLog.Margin = New Padding(3, 4, 3, 4)
		dgvLog.Name = "dgvLog"
		dgvLog.ReadOnly = True
		dgvLog.RowHeadersWidth = 51
		dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvLog.Size = New Size(983, 520)
		dgvLog.TabIndex = 0
		' 
		' pnlAlert
		' 
		pnlAlert.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(200))
		pnlAlert.BorderStyle = BorderStyle.FixedSingle
		pnlAlert.Controls.Add(lblAlert)
		pnlAlert.Location = New Point(11, 227)
		pnlAlert.Margin = New Padding(3, 4, 3, 4)
		pnlAlert.Name = "pnlAlert"
		pnlAlert.Size = New Size(1002, 39)
		pnlAlert.TabIndex = 1
		pnlAlert.Visible = False
		' 
		' lblAlert
		' 
		lblAlert.AutoSize = True
		lblAlert.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		lblAlert.ForeColor = Color.FromArgb(CByte(180), CByte(80), CByte(0))
		lblAlert.Location = New Point(11, 8)
		lblAlert.Name = "lblAlert"
		lblAlert.Size = New Size(278, 20)
		lblAlert.TabIndex = 0
		lblAlert.Text = "⚠ PERINGATAN: Stok darah menipis!"
		' 
		' pnlStatWrapper
		' 
		pnlStatWrapper.BackColor = Color.Transparent
		pnlStatWrapper.Controls.Add(pnlStatDonasi)
		pnlStatWrapper.Controls.Add(pnlStatPending)
		pnlStatWrapper.Controls.Add(pnlStatStok)
		pnlStatWrapper.Location = New Point(11, 93)
		pnlStatWrapper.Margin = New Padding(3, 4, 3, 4)
		pnlStatWrapper.Name = "pnlStatWrapper"
		pnlStatWrapper.Size = New Size(1002, 120)
		pnlStatWrapper.TabIndex = 2
		' 
		' pnlStatDonasi
		' 
		pnlStatDonasi.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		pnlStatDonasi.Controls.Add(lblStatDonasiNum)
		pnlStatDonasi.Controls.Add(lblStatDonasiText)
		pnlStatDonasi.Location = New Point(0, 7)
		pnlStatDonasi.Margin = New Padding(3, 4, 3, 4)
		pnlStatDonasi.Name = "pnlStatDonasi"
		pnlStatDonasi.Size = New Size(330, 100)
		pnlStatDonasi.TabIndex = 0
		' 
		' lblStatDonasiNum
		' 
		lblStatDonasiNum.AutoSize = True
		lblStatDonasiNum.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
		lblStatDonasiNum.ForeColor = Color.White
		lblStatDonasiNum.Location = New Point(17, 11)
		lblStatDonasiNum.Name = "lblStatDonasiNum"
		lblStatDonasiNum.Size = New Size(43, 50)
		lblStatDonasiNum.TabIndex = 0
		lblStatDonasiNum.Text = "0"
		' 
		' lblStatDonasiText
		' 
		lblStatDonasiText.AutoSize = True
		lblStatDonasiText.Font = New Font("Segoe UI", 9.0F)
		lblStatDonasiText.ForeColor = Color.FromArgb(CByte(255), CByte(200), CByte(200))
		lblStatDonasiText.Location = New Point(17, 64)
		lblStatDonasiText.Name = "lblStatDonasiText"
		lblStatDonasiText.Size = New Size(138, 20)
		lblStatDonasiText.TabIndex = 1
		lblStatDonasiText.Text = "Total Donasi Masuk"
		' 
		' pnlStatPending
		' 
		pnlStatPending.BackColor = Color.FromArgb(CByte(220), CByte(150), CByte(30))
		pnlStatPending.Controls.Add(lblStatPendingNum)
		pnlStatPending.Controls.Add(lblStatPendingText)
		pnlStatPending.Location = New Point(336, 7)
		pnlStatPending.Margin = New Padding(3, 4, 3, 4)
		pnlStatPending.Name = "pnlStatPending"
		pnlStatPending.Size = New Size(320, 100)
		pnlStatPending.TabIndex = 1
		' 
		' lblStatPendingNum
		' 
		lblStatPendingNum.AutoSize = True
		lblStatPendingNum.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
		lblStatPendingNum.ForeColor = Color.White
		lblStatPendingNum.Location = New Point(17, 11)
		lblStatPendingNum.Name = "lblStatPendingNum"
		lblStatPendingNum.Size = New Size(43, 50)
		lblStatPendingNum.TabIndex = 0
		lblStatPendingNum.Text = "0"
		' 
		' lblStatPendingText
		' 
		lblStatPendingText.AutoSize = True
		lblStatPendingText.Font = New Font("Segoe UI", 9.0F)
		lblStatPendingText.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(200))
		lblStatPendingText.Location = New Point(17, 64)
		lblStatPendingText.Name = "lblStatPendingText"
		lblStatPendingText.Size = New Size(143, 20)
		lblStatPendingText.TabIndex = 1
		lblStatPendingText.Text = "Menunggu Verifikasi"
		' 
		' pnlStatStok
		' 
		pnlStatStok.BackColor = Color.FromArgb(CByte(30), CByte(140), CByte(80))
		pnlStatStok.Controls.Add(lblStatStokNum)
		pnlStatStok.Controls.Add(lblStatStokText)
		pnlStatStok.Location = New Point(662, 7)
		pnlStatStok.Margin = New Padding(3, 4, 3, 4)
		pnlStatStok.Name = "pnlStatStok"
		pnlStatStok.Size = New Size(330, 100)
		pnlStatStok.TabIndex = 2
		' 
		' lblStatStokNum
		' 
		lblStatStokNum.AutoSize = True
		lblStatStokNum.Font = New Font("Segoe UI", 22.0F, FontStyle.Bold)
		lblStatStokNum.ForeColor = Color.White
		lblStatStokNum.Location = New Point(17, 11)
		lblStatStokNum.Name = "lblStatStokNum"
		lblStatStokNum.Size = New Size(43, 50)
		lblStatStokNum.TabIndex = 0
		lblStatStokNum.Text = "0"
		' 
		' lblStatStokText
		' 
		lblStatStokText.AutoSize = True
		lblStatStokText.Font = New Font("Segoe UI", 9.0F)
		lblStatStokText.ForeColor = Color.FromArgb(CByte(180), CByte(255), CByte(220))
		lblStatStokText.Location = New Point(17, 64)
		lblStatStokText.Name = "lblStatStokText"
		lblStatStokText.Size = New Size(160, 20)
		lblStatStokText.TabIndex = 1
		lblStatStokText.Text = "Total Kantung Tersedia"
		' 
		' pnlTopBar
		' 
		pnlTopBar.BackColor = Color.White
		pnlTopBar.Controls.Add(lblPageTitle)
		pnlTopBar.Controls.Add(lblWelcome)
		pnlTopBar.Dock = DockStyle.Top
		pnlTopBar.Location = New Point(0, 0)
		pnlTopBar.Margin = New Padding(3, 4, 3, 4)
		pnlTopBar.Name = "pnlTopBar"
		pnlTopBar.Size = New Size(1028, 80)
		pnlTopBar.TabIndex = 3
		' 
		' lblPageTitle
		' 
		lblPageTitle.AutoSize = True
		lblPageTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
		lblPageTitle.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
		lblPageTitle.Location = New Point(23, 16)
		lblPageTitle.Name = "lblPageTitle"
		lblPageTitle.Size = New Size(200, 30)
		lblPageTitle.TabIndex = 0
		lblPageTitle.Text = "Dashboard Admin"
		' 
		' lblWelcome
		' 
		lblWelcome.AutoSize = True
		lblWelcome.Font = New Font("Segoe UI", 9.0F)
		lblWelcome.ForeColor = Color.Gray
		lblWelcome.Location = New Point(23, 46)
		lblWelcome.Name = "lblWelcome"
		lblWelcome.Size = New Size(165, 20)
		lblWelcome.TabIndex = 1
		lblWelcome.Text = "Selamat datang, Admin"
		' 
		' FormDashboardAdmin
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(1257, 907)
		Controls.Add(pnlContent)
		Controls.Add(pnlSidebar)
		Margin = New Padding(3, 4, 3, 4)
		MinimumSize = New Size(1255, 891)
		Name = "FormDashboardAdmin"
		Text = "Dashboard Admin - Sistem Donor Darah"
		pnlSidebar.ResumeLayout(False)
		pnlContent.ResumeLayout(False)
		tabControl.ResumeLayout(False)
		tabVerifikasi.ResumeLayout(False)
		CType(dgvDonasi, ComponentModel.ISupportInitialize).EndInit()
		pnlActionVerif.ResumeLayout(False)
		tabPendonor.ResumeLayout(False)
		CType(dgvPendonor, ComponentModel.ISupportInitialize).EndInit()
		tabStok.ResumeLayout(False)
		tabStok.PerformLayout()
		CType(dgvStok, ComponentModel.ISupportInitialize).EndInit()
		tabLog.ResumeLayout(False)
		CType(dgvLog, ComponentModel.ISupportInitialize).EndInit()
		pnlAlert.ResumeLayout(False)
		pnlAlert.PerformLayout()
		pnlStatWrapper.ResumeLayout(False)
		pnlStatDonasi.ResumeLayout(False)
		pnlStatDonasi.PerformLayout()
		pnlStatPending.ResumeLayout(False)
		pnlStatPending.PerformLayout()
		pnlStatStok.ResumeLayout(False)
		pnlStatStok.PerformLayout()
		pnlTopBar.ResumeLayout(False)
		pnlTopBar.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents pnlSidebar As Panel
	Friend WithEvents lblAppName As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnMenuVerifikasi As Button
    Friend WithEvents btnMenuPendonor As Button
    Friend WithEvents btnMenuStok As Button
    Friend WithEvents btnMenuLog As Button
    Friend WithEvents btnMenuLaporan As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents pnlStatWrapper As Panel
    Friend WithEvents pnlStatDonasi As Panel
    Friend WithEvents lblStatDonasiNum As Label
    Friend WithEvents lblStatDonasiText As Label
    Friend WithEvents pnlStatPending As Panel
    Friend WithEvents lblStatPendingNum As Label
    Friend WithEvents lblStatPendingText As Label
    Friend WithEvents pnlStatStok As Panel
    Friend WithEvents lblStatStokNum As Label
    Friend WithEvents lblStatStokText As Label
    Friend WithEvents pnlAlert As Panel
    Friend WithEvents lblAlert As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tabVerifikasi As TabPage
    Friend WithEvents tabPendonor As TabPage
    Friend WithEvents tabStok As TabPage
    Friend WithEvents tabLog As TabPage
    Friend WithEvents dgvDonasi As DataGridView
    Friend WithEvents pnlActionVerif As Panel
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnInputKonsultasi As Button
    Friend WithEvents dgvPendonor As DataGridView
    Friend WithEvents btnHapusUser As Button
    Friend WithEvents dgvStok As DataGridView
    Friend WithEvents btnKurangStok As Button
    Friend WithEvents txtKurangJumlah As TextBox
    Friend WithEvents lblKurangInfo As Label
    Friend WithEvents dgvLog As DataGridView

End Class