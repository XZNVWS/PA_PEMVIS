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
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		pnlHeader = New Panel()
		lblNamaUser = New Label()
		lblSubHeader = New Label()
		pnlKiri = New Panel()
		grpDonasi = New GroupBox()
		lblNamaLabel = New Label()
		txtNamaAuto = New TextBox()
		lblEmailLabel = New Label()
		txtEmailAuto = New TextBox()
		lblTanggalLabel = New Label()
		txtTanggalAuto = New TextBox()
		lblJumlahLabel = New Label()
		txtJumlah = New TextBox()
		chkAnonim = New CheckBox()
		btnSubmitDonasi = New Button()
		pnlKanan = New Panel()
		grpRiwayat = New GroupBox()
		dgvRiwayat = New DataGridView()
		pnlActionUser = New Panel()
		btnCetakKuitansi = New Button()
		btnCetakKonsultasi = New Button()
		btnRefresh = New Button()
		pnlTopBar = New Panel()
		lblPageTitle = New Label()
		btnLogout = New Button()
		pnlHeader.SuspendLayout()
		pnlKiri.SuspendLayout()
		grpDonasi.SuspendLayout()
		pnlKanan.SuspendLayout()
		grpRiwayat.SuspendLayout()
		CType(dgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
		pnlActionUser.SuspendLayout()
		pnlTopBar.SuspendLayout()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(245), CByte(240), CByte(240))
		pnlHeader.BorderStyle = BorderStyle.FixedSingle
		pnlHeader.Controls.Add(lblNamaUser)
		pnlHeader.Controls.Add(lblSubHeader)
		pnlHeader.Location = New Point(11, 87)
		pnlHeader.Margin = New Padding(3, 4, 3, 4)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(1108, 79)
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
		' pnlKiri
		' 
		pnlKiri.BackColor = Color.White
		pnlKiri.BorderStyle = BorderStyle.FixedSingle
		pnlKiri.Controls.Add(grpDonasi)
		pnlKiri.Location = New Point(11, 180)
		pnlKiri.Margin = New Padding(3, 4, 3, 4)
		pnlKiri.Name = "pnlKiri"
		pnlKiri.Size = New Size(377, 573)
		pnlKiri.TabIndex = 1
		' 
		' grpDonasi
		' 
		grpDonasi.BackColor = Color.White
		grpDonasi.Controls.Add(lblNamaLabel)
		grpDonasi.Controls.Add(txtNamaAuto)
		grpDonasi.Controls.Add(lblEmailLabel)
		grpDonasi.Controls.Add(txtEmailAuto)
		grpDonasi.Controls.Add(lblTanggalLabel)
		grpDonasi.Controls.Add(txtTanggalAuto)
		grpDonasi.Controls.Add(lblJumlahLabel)
		grpDonasi.Controls.Add(txtJumlah)
		grpDonasi.Controls.Add(chkAnonim)
		grpDonasi.Controls.Add(btnSubmitDonasi)
		grpDonasi.Dock = DockStyle.Fill
		grpDonasi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		grpDonasi.ForeColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		grpDonasi.Location = New Point(0, 0)
		grpDonasi.Margin = New Padding(3, 4, 3, 4)
		grpDonasi.Name = "grpDonasi"
		grpDonasi.Padding = New Padding(3, 4, 3, 4)
		grpDonasi.Size = New Size(375, 571)
		grpDonasi.TabIndex = 0
		grpDonasi.TabStop = False
		grpDonasi.Text = "  Form Donasi Darah  "
		' 
		' lblNamaLabel
		' 
		lblNamaLabel.AutoSize = True
		lblNamaLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
		lblNamaLabel.ForeColor = Color.Gray
		lblNamaLabel.Location = New Point(17, 40)
		lblNamaLabel.Name = "lblNamaLabel"
		lblNamaLabel.Size = New Size(128, 19)
		lblNamaLabel.TabIndex = 0
		lblNamaLabel.Text = "NAMA (Otomatis)"
		' 
		' txtNamaAuto
		' 
		txtNamaAuto.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
		txtNamaAuto.BorderStyle = BorderStyle.FixedSingle
		txtNamaAuto.Font = New Font("Segoe UI", 9.0F)
		txtNamaAuto.Location = New Point(17, 67)
		txtNamaAuto.Margin = New Padding(3, 4, 3, 4)
		txtNamaAuto.Name = "txtNamaAuto"
		txtNamaAuto.ReadOnly = True
		txtNamaAuto.Size = New Size(331, 27)
		txtNamaAuto.TabIndex = 1
		txtNamaAuto.TabStop = False
		' 
		' lblEmailLabel
		' 
		lblEmailLabel.AutoSize = True
		lblEmailLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
		lblEmailLabel.ForeColor = Color.Gray
		lblEmailLabel.Location = New Point(17, 120)
		lblEmailLabel.Name = "lblEmailLabel"
		lblEmailLabel.Size = New Size(125, 19)
		lblEmailLabel.TabIndex = 2
		lblEmailLabel.Text = "EMAIL (Otomatis)"
		' 
		' txtEmailAuto
		' 
		txtEmailAuto.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
		txtEmailAuto.BorderStyle = BorderStyle.FixedSingle
		txtEmailAuto.Font = New Font("Segoe UI", 9.0F)
		txtEmailAuto.Location = New Point(17, 147)
		txtEmailAuto.Margin = New Padding(3, 4, 3, 4)
		txtEmailAuto.Name = "txtEmailAuto"
		txtEmailAuto.ReadOnly = True
		txtEmailAuto.Size = New Size(331, 27)
		txtEmailAuto.TabIndex = 3
		txtEmailAuto.TabStop = False
		' 
		' lblTanggalLabel
		' 
		lblTanggalLabel.AutoSize = True
		lblTanggalLabel.Font = New Font("Segoe UI", 8.0F, FontStyle.Bold)
		lblTanggalLabel.ForeColor = Color.Gray
		lblTanggalLabel.Location = New Point(17, 200)
		lblTanggalLabel.Name = "lblTanggalLabel"
		lblTanggalLabel.Size = New Size(207, 19)
		lblTanggalLabel.TabIndex = 4
		lblTanggalLabel.Text = "TANGGAL DONASI (Otomatis)"
		' 
		' txtTanggalAuto
		' 
		txtTanggalAuto.BackColor = Color.FromArgb(CByte(235), CByte(235), CByte(235))
		txtTanggalAuto.BorderStyle = BorderStyle.FixedSingle
		txtTanggalAuto.Font = New Font("Segoe UI", 9.0F)
		txtTanggalAuto.Location = New Point(17, 227)
		txtTanggalAuto.Margin = New Padding(3, 4, 3, 4)
		txtTanggalAuto.Name = "txtTanggalAuto"
		txtTanggalAuto.ReadOnly = True
		txtTanggalAuto.Size = New Size(331, 27)
		txtTanggalAuto.TabIndex = 5
		txtTanggalAuto.TabStop = False
		' 
		' lblJumlahLabel
		' 
		lblJumlahLabel.AutoSize = True
		lblJumlahLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		lblJumlahLabel.ForeColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
		lblJumlahLabel.Location = New Point(17, 287)
		lblJumlahLabel.Name = "lblJumlahLabel"
		lblJumlahLabel.Size = New Size(209, 20)
		lblJumlahLabel.TabIndex = 6
		lblJumlahLabel.Text = "JUMLAH DONASI (Kantung)"
		' 
		' txtJumlah
		' 
		txtJumlah.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
		txtJumlah.BorderStyle = BorderStyle.FixedSingle
		txtJumlah.Font = New Font("Segoe UI", 11.0F)
		txtJumlah.Location = New Point(17, 316)
		txtJumlah.Margin = New Padding(3, 4, 3, 4)
		txtJumlah.Name = "txtJumlah"
		txtJumlah.PlaceholderText = "Contoh: 1"
		txtJumlah.Size = New Size(331, 32)
		txtJumlah.TabIndex = 0
		' 
		' chkAnonim
		' 
		chkAnonim.AutoSize = True
		chkAnonim.Font = New Font("Segoe UI", 9.0F)
		chkAnonim.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
		chkAnonim.Location = New Point(17, 376)
		chkAnonim.Margin = New Padding(3, 4, 3, 4)
		chkAnonim.Name = "chkAnonim"
		chkAnonim.Size = New Size(310, 24)
		chkAnonim.TabIndex = 1
		chkAnonim.Text = "Donasi secara Anonim (nama disamarkan)"
		' 
		' btnSubmitDonasi
		' 
		btnSubmitDonasi.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		btnSubmitDonasi.Cursor = Cursors.Hand
		btnSubmitDonasi.FlatAppearance.BorderSize = 0
		btnSubmitDonasi.FlatStyle = FlatStyle.Flat
		btnSubmitDonasi.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
		btnSubmitDonasi.ForeColor = Color.White
		btnSubmitDonasi.Location = New Point(17, 490)
		btnSubmitDonasi.Margin = New Padding(3, 4, 3, 4)
		btnSubmitDonasi.Name = "btnSubmitDonasi"
		btnSubmitDonasi.Size = New Size(331, 60)
		btnSubmitDonasi.TabIndex = 2
		btnSubmitDonasi.Text = ChrW(55358) & ChrW(56952) & "  SUBMIT DONASI"
		btnSubmitDonasi.UseVisualStyleBackColor = False
		' 
		' pnlKanan
		' 
		pnlKanan.BackColor = Color.White
		pnlKanan.BorderStyle = BorderStyle.FixedSingle
		pnlKanan.Controls.Add(grpRiwayat)
		pnlKanan.Location = New Point(400, 180)
		pnlKanan.Margin = New Padding(3, 4, 3, 4)
		pnlKanan.Name = "pnlKanan"
		pnlKanan.Size = New Size(720, 573)
		pnlKanan.TabIndex = 0
		' 
		' grpRiwayat
		' 
		grpRiwayat.BackColor = Color.White
		grpRiwayat.Controls.Add(dgvRiwayat)
		grpRiwayat.Controls.Add(pnlActionUser)
		grpRiwayat.Dock = DockStyle.Fill
		grpRiwayat.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		grpRiwayat.ForeColor = Color.FromArgb(CByte(140), CByte(20), CByte(20))
		grpRiwayat.Location = New Point(0, 0)
		grpRiwayat.Margin = New Padding(3, 4, 3, 4)
		grpRiwayat.Name = "grpRiwayat"
		grpRiwayat.Padding = New Padding(3, 4, 3, 4)
		grpRiwayat.Size = New Size(718, 571)
		grpRiwayat.TabIndex = 0
		grpRiwayat.TabStop = False
		grpRiwayat.Text = "  Riwayat Donasi Saya  "
		' 
		' dgvRiwayat
		' 
		dgvRiwayat.AllowUserToAddRows = False
		dgvRiwayat.AllowUserToDeleteRows = False
		dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvRiwayat.BackgroundColor = Color.White
		dgvRiwayat.BorderStyle = BorderStyle.None
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(180), CByte(30), CByte(30))
		DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		DataGridViewCellStyle1.ForeColor = Color.White
		DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
		DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
		DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
		dgvRiwayat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
		dgvRiwayat.ColumnHeadersHeight = 29
		dgvRiwayat.Location = New Point(11, 37)
		dgvRiwayat.Margin = New Padding(3, 4, 3, 4)
		dgvRiwayat.MultiSelect = False
		dgvRiwayat.Name = "dgvRiwayat"
		dgvRiwayat.ReadOnly = True
		dgvRiwayat.RowHeadersWidth = 51
		dgvRiwayat.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvRiwayat.Size = New Size(686, 427)
		dgvRiwayat.TabIndex = 0
		' 
		' pnlActionUser
		' 
		pnlActionUser.BackColor = Color.FromArgb(CByte(250), CByte(250), CByte(250))
		pnlActionUser.BorderStyle = BorderStyle.FixedSingle
		pnlActionUser.Controls.Add(btnCetakKuitansi)
		pnlActionUser.Controls.Add(btnCetakKonsultasi)
		pnlActionUser.Controls.Add(btnRefresh)
		pnlActionUser.Location = New Point(11, 477)
		pnlActionUser.Margin = New Padding(3, 4, 3, 4)
		pnlActionUser.Name = "pnlActionUser"
		pnlActionUser.Size = New Size(685, 73)
		pnlActionUser.TabIndex = 1
		' 
		' btnCetakKuitansi
		' 
		btnCetakKuitansi.BackColor = Color.FromArgb(CByte(30), CByte(140), CByte(80))
		btnCetakKuitansi.Cursor = Cursors.Hand
		btnCetakKuitansi.FlatAppearance.BorderSize = 0
		btnCetakKuitansi.FlatStyle = FlatStyle.Flat
		btnCetakKuitansi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnCetakKuitansi.ForeColor = Color.White
		btnCetakKuitansi.Location = New Point(11, 13)
		btnCetakKuitansi.Margin = New Padding(3, 4, 3, 4)
		btnCetakKuitansi.Name = "btnCetakKuitansi"
		btnCetakKuitansi.Size = New Size(194, 47)
		btnCetakKuitansi.TabIndex = 0
		btnCetakKuitansi.Text = "🖨 Cetak Kuitansi"
		btnCetakKuitansi.UseVisualStyleBackColor = False
		' 
		' btnCetakKonsultasi
		' 
		btnCetakKonsultasi.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
		btnCetakKonsultasi.Cursor = Cursors.Hand
		btnCetakKonsultasi.FlatAppearance.BorderSize = 0
		btnCetakKonsultasi.FlatStyle = FlatStyle.Flat
		btnCetakKonsultasi.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
		btnCetakKonsultasi.ForeColor = Color.White
		btnCetakKonsultasi.Location = New Point(223, 13)
		btnCetakKonsultasi.Margin = New Padding(3, 4, 3, 4)
		btnCetakKonsultasi.Name = "btnCetakKonsultasi"
		btnCetakKonsultasi.Size = New Size(217, 47)
		btnCetakKonsultasi.TabIndex = 1
		btnCetakKonsultasi.Text = "🖨 Cetak Hasil Konsultasi"
		btnCetakKonsultasi.UseVisualStyleBackColor = False
		' 
		' btnRefresh
		' 
		btnRefresh.BackColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
		btnRefresh.Cursor = Cursors.Hand
		btnRefresh.FlatAppearance.BorderSize = 0
		btnRefresh.FlatStyle = FlatStyle.Flat
		btnRefresh.Font = New Font("Segoe UI", 9.0F)
		btnRefresh.ForeColor = Color.White
		btnRefresh.Location = New Point(457, 13)
		btnRefresh.Margin = New Padding(3, 4, 3, 4)
		btnRefresh.Name = "btnRefresh"
		btnRefresh.Size = New Size(114, 47)
		btnRefresh.TabIndex = 2
		btnRefresh.Text = "↻ Refresh"
		btnRefresh.UseVisualStyleBackColor = False
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
		pnlTopBar.Size = New Size(1133, 73)
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
		btnLogout.Location = New Point(1005, 16)
		btnLogout.Margin = New Padding(3, 4, 3, 4)
		btnLogout.Name = "btnLogout"
		btnLogout.Size = New Size(114, 40)
		btnLogout.TabIndex = 1
		btnLogout.Text = "⬅ Logout"
		btnLogout.UseVisualStyleBackColor = False
		' 
		' FormDashboardUser
		' 
		AutoScaleDimensions = New SizeF(8.0F, 20.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(248))
		ClientSize = New Size(1133, 767)
		Controls.Add(pnlKanan)
		Controls.Add(pnlKiri)
		Controls.Add(pnlHeader)
		Controls.Add(pnlTopBar)
		Margin = New Padding(3, 4, 3, 4)
		MinimumSize = New Size(1129, 758)
		Name = "FormDashboardUser"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Portal Pendonor - Sistem Donor Darah"
		pnlHeader.ResumeLayout(False)
		pnlHeader.PerformLayout()
		pnlKiri.ResumeLayout(False)
		grpDonasi.ResumeLayout(False)
		grpDonasi.PerformLayout()
		pnlKanan.ResumeLayout(False)
		grpRiwayat.ResumeLayout(False)
		CType(dgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
		pnlActionUser.ResumeLayout(False)
		pnlTopBar.ResumeLayout(False)
		pnlTopBar.PerformLayout()
		ResumeLayout(False)
	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblNamaUser As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents pnlKiri As Panel
    Friend WithEvents grpDonasi As GroupBox
    Friend WithEvents lblNamaLabel As Label
    Friend WithEvents txtNamaAuto As TextBox
    Friend WithEvents lblEmailLabel As Label
    Friend WithEvents txtEmailAuto As TextBox
    Friend WithEvents lblTanggalLabel As Label
    Friend WithEvents txtTanggalAuto As TextBox
    Friend WithEvents lblJumlahLabel As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents chkAnonim As CheckBox
    Friend WithEvents btnSubmitDonasi As Button
    Friend WithEvents pnlKanan As Panel
    Friend WithEvents grpRiwayat As GroupBox
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents pnlActionUser As Panel
    Friend WithEvents btnCetakKuitansi As Button
    Friend WithEvents btnCetakKonsultasi As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents btnLogout As Button

End Class