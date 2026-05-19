Imports MySql.Data.MySqlClient

Public Class FormDashboardAdmin

    Private selectedIdDonasi As Integer = 0
    Private selectedGolDarahStok As String = ""

    Private Sub FormDashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Selamat datang, " & CurrentNama & " | " & Date.Now.ToString("dddd, dd MMMM yyyy")

        MuatStatistik()
        MuatDonasi()
        MuatPendonor()
        MuatStok()
        MuatLog()
    End Sub

    Private Sub MuatStatistik()
        Try
            BukaKoneksi()

            Cmd = New MySqlCommand("SELECT COUNT(*) FROM donasi", Conn)
            lblStatDonasiNum.Text = Cmd.ExecuteScalar().ToString()

            Cmd = New MySqlCommand("SELECT COUNT(*) FROM donasi WHERE status_verifikasi = 'Pending'", Conn)
            lblStatPendingNum.Text = Cmd.ExecuteScalar().ToString()

            Cmd = New MySqlCommand("SELECT COALESCE(SUM(total_stok), 0) FROM stok_darah", Conn)
            lblStatStokNum.Text = Cmd.ExecuteScalar().ToString()

            TutupKoneksi()

            CekAlertStok()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Error memuat statistik: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CekAlertStok()
        Try
            BukaKoneksi()

            Dim query As String = "SELECT golongan_darah, total_stok FROM stok_darah WHERE total_stok < 10"
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            Dim alertMsg As String = "⚠ STOK MENIPIS: "
            Dim adaAlert As Boolean = False

            Do While Rd.Read()
                alertMsg &= "Gol. " & Rd("golongan_darah").ToString() &
                            " (" & Rd("total_stok").ToString() & " kantung)  "
                adaAlert = True
            Loop

            Rd.Close()
            TutupKoneksi()

            If adaAlert Then
                pnlAlert.Visible = True
                lblAlert.Text = alertMsg

                MessageBox.Show(
                    alertMsg & vbCrLf & "Segera lakukan penambahan stok!",
                    "PERINGATAN STOK DARAH",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
            Else
                pnlAlert.Visible = False
            End If

        Catch ex As Exception
            TutupKoneksi()
        End Try
    End Sub

    Private Sub MuatDonasi()
        Try
            BukaKoneksi()

            Dim query As String =
                "SELECT d.id_donasi, " &
                "       CASE WHEN d.is_anonim = 1 THEN 'Anonim' ELSE u.nama_lengkap END AS Nama, " &
                "       u.golongan_darah AS GolDarah, " &
                "       d.jumlah_donasi AS Jumlah, " &
                "       d.tanggal_donasi AS Tanggal, " &
                "       d.status_verifikasi AS Status, " &
                "       d.hasil_konsultasi AS Konsultasi, " &
                "       d.jadwal_kembali AS JadwalKembali " &
                "FROM donasi d " &
                "JOIN users u ON d.id_user = u.id_user " &
                "ORDER BY d.created_at DESC"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "donasi")

            dgvDonasi.DataSource = Ds.Tables("donasi")
            TutupKoneksi()

            WarnaiStatusDonasi()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Error memuat data donasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub WarnaiStatusDonasi()
        For Each row As DataGridViewRow In dgvDonasi.Rows
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
    End Sub

    Private Sub MuatPendonor()
        Try
            BukaKoneksi()

            Dim query As String =
                "SELECT id_user AS ID, nama_lengkap AS Nama, username AS Username, " &
                "email AS Email, golongan_darah AS GolDarah, no_telepon AS Telepon, " &
                "created_at AS Terdaftar " &
                "FROM users WHERE role = 'User' ORDER BY created_at DESC"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "users")

            dgvPendonor.DataSource = Ds.Tables("users")
            TutupKoneksi()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Error memuat data pendonor: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MuatStok()
        Try
            BukaKoneksi()

            Dim query As String =
                "SELECT golongan_darah AS GolDarah, " &
                "       total_stok AS TotalStok, " &
                "       CASE WHEN total_stok < 10 THEN '⚠ MENIPIS' ELSE '✓ AMAN' END AS Status, " &
                "       updated_at AS Diupdate " &
                "FROM stok_darah ORDER BY golongan_darah"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "stok")

            dgvStok.DataSource = Ds.Tables("stok")
            TutupKoneksi()

            For Each row As DataGridViewRow In dgvStok.Rows
                If row.Cells("Status").Value IsNot Nothing Then
                    If row.Cells("Status").Value.ToString().Contains("MENIPIS") Then
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220)
                        row.DefaultCellStyle.ForeColor = Color.DarkRed
                    End If
                End If
            Next

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Error memuat stok: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MuatLog()
        Try
            BukaKoneksi()

            Dim query As String =
                "SELECT id_log AS ID, golongan_darah AS GolDarah, " &
                "       jenis_aksi AS Aksi, jumlah AS Jumlah, " &
                "       keterangan AS Keterangan, created_at AS Tanggal " &
                "FROM log_sirkulasi_darah ORDER BY created_at DESC LIMIT 200"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()
            Da.Fill(Ds, "log")

            dgvLog.DataSource = Ds.Tables("log")
            TutupKoneksi()

            For Each row As DataGridViewRow In dgvLog.Rows
                If row.Cells("Aksi").Value IsNot Nothing Then
                    If row.Cells("Aksi").Value.ToString() = "Masuk" Then
                        row.DefaultCellStyle.ForeColor = Color.DarkGreen
                    Else
                        row.DefaultCellStyle.ForeColor = Color.DarkRed
                    End If
                End If
            Next

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Error memuat log: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvDonasi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDonasi.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvDonasi.Rows(e.RowIndex)
        If row.Cells("id_donasi").Value IsNot Nothing Then
            selectedIdDonasi = Convert.ToInt32(row.Cells("id_donasi").Value)
        End If
    End Sub

    Private Sub dgvStok_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStok.CellClick
        If e.RowIndex < 0 Then Return
        Dim row As DataGridViewRow = dgvStok.Rows(e.RowIndex)
        If row.Cells("GolDarah").Value IsNot Nothing Then
            selectedGolDarahStok = row.Cells("GolDarah").Value.ToString()
        End If
    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If selectedIdDonasi = 0 Then
            MessageBox.Show("Pilih data donasi dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Setujui donasi ID #" & selectedIdDonasi & "?" & vbCrLf &
            "Stok darah akan otomatis bertambah.",
            "Konfirmasi Verifikasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If konfirmasi = DialogResult.No Then Return

        Try
            BukaKoneksi()

            Dim qDetail As String =
                "SELECT d.jumlah_donasi, u.golongan_darah, d.status_verifikasi " &
                "FROM donasi d JOIN users u ON d.id_user = u.id_user " &
                "WHERE d.id_donasi = @id"
            Cmd = New MySqlCommand(qDetail, Conn)
            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)
            Rd = Cmd.ExecuteReader()

            If Not Rd.Read() Then
                Rd.Close()
                TutupKoneksi()
                MessageBox.Show("Data donasi tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim statusSaatIni As String = Rd("status_verifikasi").ToString()
            If statusSaatIni <> "Pending" Then
                Rd.Close()
                TutupKoneksi()
                MessageBox.Show("Donasi ini sudah diproses sebelumnya (Status: " & statusSaatIni & ")!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim jumlahDonasi As Integer = Convert.ToInt32(Rd("jumlah_donasi"))
            Dim golDarah As String = Rd("golongan_darah").ToString()
            Rd.Close()

            Dim q1 As String = "UPDATE donasi SET status_verifikasi = 'Terverifikasi' WHERE id_donasi = @id"
            Cmd = New MySqlCommand(q1, Conn)
            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)
            Cmd.ExecuteNonQuery()

            Dim q2 As String =
                "UPDATE stok_darah SET total_stok = total_stok + @jumlah " &
                "WHERE golongan_darah = @gol"
            Cmd = New MySqlCommand(q2, Conn)
            Cmd.Parameters.AddWithValue("@jumlah", jumlahDonasi)
            Cmd.Parameters.AddWithValue("@gol", golDarah)
            Cmd.ExecuteNonQuery()

            Dim q3 As String =
                "INSERT INTO log_sirkulasi_darah (golongan_darah, jenis_aksi, jumlah, keterangan) " &
                "VALUES (@gol, 'Masuk', @jumlah, @ket)"
            Cmd = New MySqlCommand(q3, Conn)
            Cmd.Parameters.AddWithValue("@gol", golDarah)
            Cmd.Parameters.AddWithValue("@jumlah", jumlahDonasi)
            Cmd.Parameters.AddWithValue("@ket", "Donasi ID #" & selectedIdDonasi & " terverifikasi oleh Admin")
            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Donasi berhasil DIVERIFIKASI!" & vbCrLf &
                "Stok darah golongan " & golDarah & " bertambah " & jumlahDonasi & " kantung.",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            selectedIdDonasi = 0
            MuatStatistik()
            MuatDonasi()
            MuatStok()
            MuatLog()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Gagal memverifikasi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If selectedIdDonasi = 0 Then
            MessageBox.Show("Pilih data donasi dari tabel terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Tolak donasi ID #" & selectedIdDonasi & "?" & vbCrLf & "Stok tidak akan berubah.",
            "Konfirmasi Penolakan",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )
        If konfirmasi = DialogResult.No Then Return

        Try
            BukaKoneksi()

            Cmd = New MySqlCommand("SELECT status_verifikasi FROM donasi WHERE id_donasi = @id", Conn)
            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)
            Dim statusSaatIni As String = Cmd.ExecuteScalar().ToString()

            If statusSaatIni <> "Pending" Then
                TutupKoneksi()
                MessageBox.Show("Donasi ini sudah diproses (Status: " & statusSaatIni & ")!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Cmd = New MySqlCommand("UPDATE donasi SET status_verifikasi = 'Ditolak' WHERE id_donasi = @id", Conn)
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)
            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show("Donasi ID #" & selectedIdDonasi & " berhasil DITOLAK.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            selectedIdDonasi = 0
            MuatStatistik()
            MuatDonasi()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Gagal menolak: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInputKonsultasi_Click(sender As Object, e As EventArgs) Handles btnInputKonsultasi.Click
        If selectedIdDonasi = 0 Then
            MessageBox.Show("Pilih data donasi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim fKonsultasi As New FormInputKonsultasi(selectedIdDonasi)
        fKonsultasi.ShowDialog()

        MuatDonasi()
    End Sub

    Private Sub btnHapusUser_Click(sender As Object, e As EventArgs) Handles btnHapusUser.Click
        If dgvPendonor.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih data pendonor yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idUser As Integer = Convert.ToInt32(dgvPendonor.CurrentRow.Cells("ID").Value)
        Dim namaUser As String = dgvPendonor.CurrentRow.Cells("Nama").Value.ToString()

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Hapus pendonor: " & namaUser & "?" & vbCrLf &
            "SEMUA data donasi milik pendonor ini akan ikut terhapus (CASCADE)!",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )
        If konfirmasi = DialogResult.No Then Return

        Try
            BukaKoneksi()
            Cmd = New MySqlCommand("DELETE FROM users WHERE id_user = @id", Conn)
            Cmd.Parameters.AddWithValue("@id", idUser)
            Cmd.ExecuteNonQuery()
            TutupKoneksi()

            MessageBox.Show("Pendonor " & namaUser & " berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MuatPendonor()
            MuatDonasi()
            MuatStatistik()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Gagal menghapus: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnKurangStok_Click(sender As Object, e As EventArgs) Handles btnKurangStok.Click
        If selectedGolDarahStok = "" Then
            MessageBox.Show("Pilih golongan darah dari tabel stok terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim jumlahKeluar As Integer
        If Not Integer.TryParse(txtKurangJumlah.Text.Trim(), jumlahKeluar) OrElse jumlahKeluar <= 0 Then
            MessageBox.Show("Masukkan jumlah yang valid (angka positif)!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            BukaKoneksi()

            Cmd = New MySqlCommand("SELECT total_stok FROM stok_darah WHERE golongan_darah = @gol", Conn)
            Cmd.Parameters.AddWithValue("@gol", selectedGolDarahStok)
            Dim stokSekarang As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

            If jumlahKeluar > stokSekarang Then
                TutupKoneksi()
                MessageBox.Show("Jumlah distribusi (" & jumlahKeluar & ") melebihi stok saat ini (" & stokSekarang & ")!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Cmd = New MySqlCommand(
                "UPDATE stok_darah SET total_stok = total_stok - @jml WHERE golongan_darah = @gol", Conn)
            Cmd.Parameters.AddWithValue("@jml", jumlahKeluar)
            Cmd.Parameters.AddWithValue("@gol", selectedGolDarahStok)
            Cmd.ExecuteNonQuery()

            Cmd = New MySqlCommand(
                "INSERT INTO log_sirkulasi_darah (golongan_darah, jenis_aksi, jumlah, keterangan) " &
                "VALUES (@gol, 'Keluar', @jml, 'Distribusi darah oleh Admin')", Conn)
            Cmd.Parameters.AddWithValue("@gol", selectedGolDarahStok)
            Cmd.Parameters.AddWithValue("@jml", jumlahKeluar)
            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Distribusi berhasil!" & vbCrLf &
                "Golongan " & selectedGolDarahStok & " berkurang " & jumlahKeluar & " kantung.",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtKurangJumlah.Clear()
            selectedGolDarahStok = ""
            MuatStatistik()
            MuatStok()
            MuatLog()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Gagal distribusi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtKurangJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKurangJumlah.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnMenuVerifikasi_Click(sender As Object, e As EventArgs) Handles btnMenuVerifikasi.Click
        TabControl.SelectedTab = tabVerifikasi
        lblPageTitle.Text = "Verifikasi Donasi"
        HighlightMenu(btnMenuVerifikasi)
    End Sub

    Private Sub btnMenuPendonor_Click(sender As Object, e As EventArgs) Handles btnMenuPendonor.Click
        TabControl.SelectedTab = tabPendonor
        lblPageTitle.Text = "Data Pendonor"
        HighlightMenu(btnMenuPendonor)
    End Sub

    Private Sub btnMenuStok_Click(sender As Object, e As EventArgs) Handles btnMenuStok.Click
        TabControl.SelectedTab = tabStok
        lblPageTitle.Text = "Manajemen Stok Darah"
        HighlightMenu(btnMenuStok)
    End Sub

    Private Sub btnMenuLog_Click(sender As Object, e As EventArgs) Handles btnMenuLog.Click
        TabControl.SelectedTab = tabLog
        lblPageTitle.Text = "Log Sirkulasi Darah"
        HighlightMenu(btnMenuLog)
        MuatLog()
    End Sub

    Private Sub btnMenuLaporan_Click(sender As Object, e As EventArgs) Handles btnMenuLaporan.Click
        Dim fLaporan As New FormCetakLaporan()
        fLaporan.ShowDialog()
    End Sub

    Private Sub HighlightMenu(btnAktif As Button)
        Dim semuaBtn As Button() = {btnMenuVerifikasi, btnMenuPendonor, btnMenuStok, btnMenuLog, btnMenuLaporan}
        For Each btn As Button In semuaBtn
            btn.BackColor = Color.FromArgb(140, 20, 20)
        Next
        btnAktif.BackColor = Color.FromArgb(180, 30, 30)
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

    Private Sub FormDashboardAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormLogin.Show()
    End Sub

End Class