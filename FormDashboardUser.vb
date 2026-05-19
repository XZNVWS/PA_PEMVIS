Imports MySql.Data.MySqlClient
Public Class FormDashboardUser

	Private selectedIdDonasi As Integer = 0

	Private Sub FormDashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtNamaAuto.Text = CurrentNama
		txtEmailAuto.Text = CurrentEmail
		txtTanggalAuto.Text = Date.Now.ToString("dd MMMM yyyy")

		lblNamaUser.Text = "Selamat datang, " & CurrentNama & "!"
		lblSubHeader.Text = "Golongan Darah: " & CurrentGolDarah & " | Terima kasih atas kontribusi Anda!"

		MuatRiwayat()
	End Sub

	Private Sub txtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJumlah.KeyPress
		If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
			e.Handled = True
		End If
	End Sub

	Private Sub MuatRiwayat()
		Try
			BukaKoneksi()

			Dim query As String =
				"SELECT id_donasi, jumlah_donasi AS Jumlah, tanggal_donasi AS Tanggal, " &
				"       CASE WHEN is_anonim = 1 THEN 'Ya' ELSE 'Tidak' END AS Anonim, " &
				"       status_verifikasi AS Status, " &
				"       COALESCE(hasil_konsultasi, '-') AS Konsultasi, " &
				"       COALESCE(CAST(jadwal_kembali AS CHAR), '-') AS JadwalKembali " &
				"FROM donasi " &
				"WHERE id_user = @id " &
				"ORDER BY created_at DESC"

			Da = New MySqlDataAdapter(query, Conn)
			Da.SelectCommand.Parameters.AddWithValue("@id", CurrentIdUser)

			Ds = New DataSet()
			Da.Fill(Ds, "riwayat")

			dgvRiwayat.DataSource = Ds.Tables("riwayat")
			TutupKoneksi()

			For Each row As DataGridViewRow In dgvRiwayat.Rows
				If row.Cells("Status").Value IsNot Nothing Then
					Select Case row.Cells("Status").Value.ToString()
						Case "Pending"
							row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220)
						Case "Terverifikasi"
							row.DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 230)
						Case "Ditolak"
							row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220)
					End Select
				End If
			Next

		Catch ex As Exception
			TutupKoneksi()
			MessageBox.Show("Error memuat riwayat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub dgvRiwayat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellClick
		If e.RowIndex < 0 Then Return
		Dim row As DataGridViewRow = dgvRiwayat.Rows(e.RowIndex)
		If row.Cells("id_donasi").Value IsNot Nothing Then
			selectedIdDonasi = Convert.ToInt32(row.Cells("id_donasi").Value)
		End If
	End Sub

	Private Sub btnSubmitDonasi_Click(sender As Object, e As EventArgs) Handles btnSubmitDonasi.Click

		If txtJumlah.Text.Trim() = "" Then
			MessageBox.Show(
				"Isi jumlah donasi terlebih dahulu!",
				"Peringatan",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning
			)
			txtJumlah.Focus()
			Return
		End If

		Dim jumlah As Integer
		If Not Integer.TryParse(txtJumlah.Text.Trim(), jumlah) OrElse jumlah <= 0 Then
			MessageBox.Show(
				"Jumlah donasi harus berupa angka positif!",
				"Peringatan",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning
			)
			txtJumlah.Focus()
			Return
		End If

		Dim konfirmasi As DialogResult = MessageBox.Show(
			"Konfirmasi donasi darah:" & vbCrLf &
			"Nama    : " & CurrentNama & vbCrLf &
			"Gol. Darah : " & CurrentGolDarah & vbCrLf &
			"Jumlah  : " & jumlah & " kantung" & vbCrLf &
			"Anonim  : " & If(chkAnonim.Checked, "Ya", "Tidak") & vbCrLf & vbCrLf &
			"Submit sekarang?",
			"Konfirmasi Donasi",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)
		If konfirmasi = DialogResult.No Then Return

		Try
			BukaKoneksi()

			Dim query As String =
				"INSERT INTO donasi (id_user, jumlah_donasi, tanggal_donasi, is_anonim, status_verifikasi) " &
				"VALUES (@idUser, @jumlah, @tanggal, @anonim, 'Pending')"

			Cmd = New MySqlCommand(query, Conn)
			Cmd.Parameters.AddWithValue("@idUser", CurrentIdUser)
			Cmd.Parameters.AddWithValue("@jumlah", jumlah)
			Cmd.Parameters.AddWithValue("@tanggal", Date.Now.ToString("yyyy-MM-dd"))
			Cmd.Parameters.AddWithValue("@anonim", If(chkAnonim.Checked, 1, 0))

			Cmd.ExecuteNonQuery()
			TutupKoneksi()

			MessageBox.Show(
				"Donasi berhasil disubmit!" & vbCrLf &
				"Status: PENDING (menunggu verifikasi Admin)" & vbCrLf & vbCrLf &
				"Terima kasih atas kebaikan Anda! 🩸",
				"Sukses",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			)

			txtJumlah.Clear()
			chkAnonim.Checked = False
			MuatRiwayat()

		Catch ex As Exception
			TutupKoneksi()
			MessageBox.Show("Gagal submit donasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub btnCetakKuitansi_Click(sender As Object, e As EventArgs) Handles btnCetakKuitansi.Click
		If selectedIdDonasi = 0 Then
			MessageBox.Show("Pilih salah satu donasi dari tabel riwayat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		Dim fCetak As New FormCetak(selectedIdDonasi, "kuitansi")
		fCetak.ShowDialog()
	End Sub

	Private Sub btnCetakKonsultasi_Click(sender As Object, e As EventArgs) Handles btnCetakKonsultasi.Click
		If selectedIdDonasi = 0 Then
			MessageBox.Show("Pilih salah satu donasi dari tabel riwayat terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
			Return
		End If

		Dim fCetak As New FormCetak(selectedIdDonasi, "konsultasi")
		fCetak.ShowDialog()
	End Sub

	Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
		MuatRiwayat()
		selectedIdDonasi = 0
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		Dim konfirmasi As DialogResult = MessageBox.Show(
			"Yakin ingin logout?",
			"Konfirmasi Logout",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)
		If konfirmasi = DialogResult.Yes Then
			ResetSession()
			FormLogin.Show()
			Me.Close()
		End If
	End Sub

	Private Sub FormDashboardUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
		FormLogin.Show()
	End Sub

	Private Sub lblPageTitle_Click(sender As Object, e As EventArgs) Handles lblPageTitle.Click

	End Sub
End Class