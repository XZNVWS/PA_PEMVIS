Imports MySql.Data.MySqlClient

Public Class FormDashboardUser

    Private selectedIdDonasi As Integer = 0

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub FormDashboardUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ComboBox
        cmbJenisKelamin.Items.Clear()
        cmbJenisKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})

        cmbGolonganDarah.Items.Clear()
        cmbGolonganDarah.Items.AddRange(New Object() {"A", "B", "AB", "O"})

        cmbRhesus.Items.Clear()
        cmbRhesus.Items.AddRange(New Object() {"+ (Positif)", "- (Negatif)"})

        ' Default panel
        TampilkanPanel("Profil")

        ' Load data
        RefreshProfilData()
        IsiDataDonasi()
        MuatRiwayatDonasi()

    End Sub

    ' =========================
    ' PANEL NAVIGASI
    ' =========================
    Private Sub TampilkanPanel(menu As String)

        pnlProfil.Visible = False
        pnlDonasi.Visible = False
        pnlRiwayat.Visible = False

        Select Case menu
            Case "Profil"
                pnlProfil.Visible = True

            Case "Donasi"
                pnlDonasi.Visible = True

            Case "Riwayat"
                pnlRiwayat.Visible = True
        End Select

    End Sub

    Private Sub btnTabProfil_Click(sender As Object, e As EventArgs) Handles btnTabProfil.Click
        TampilkanPanel("Profil")
    End Sub

    Private Sub btnTabDonasi_Click(sender As Object, e As EventArgs) Handles btnTabDonasi.Click
        TampilkanPanel("Donasi")
    End Sub

    Private Sub btnTabRiwayat_Click(sender As Object, e As EventArgs) Handles btnTabRiwayat.Click
        TampilkanPanel("Riwayat")
    End Sub

    ' =========================
    ' REFRESH DATA PROFIL
    ' =========================
    Private Sub RefreshProfilData()

        lblNamaUser.Text = "Selamat datang, " & CurrentNama
        lblSubHeader.Text =
            "Golongan Darah: " & CurrentGolDarah &
            " | Terima kasih atas kontribusi Anda!"

        ' DATA PROFIL
        txtNamaLengkap.Text = CurrentNama
        txtEmail.Text = CurrentEmail
        txtNomorTelp.Text = CurrentTelepon
        txtUsername.Text = CurrentUsername

        cmbJenisKelamin.Text = CurrentJenisKelamin

        If CurrentGolDarah <> "" Then

            If CurrentGolDarah.Contains("+") Then
                cmbGolonganDarah.Text = CurrentGolDarah.Replace("+", "").Trim()
                cmbRhesus.Text = "+ (Positif)"

            ElseIf CurrentGolDarah.Contains("-") Then
                cmbGolonganDarah.Text = CurrentGolDarah.Replace("-", "").Trim()
                cmbRhesus.Text = "- (Negatif)"

            Else
                cmbGolonganDarah.Text = CurrentGolDarah
            End If

        End If

        If CurrentTanggalLahir <> "" Then

            Try
                dtpTanggalLahir.Value =
                    Convert.ToDateTime(CurrentTanggalLahir)

                HitungUsia()

            Catch ex As Exception
            End Try

        End If

    End Sub

    ' =========================
    ' HITUNG USIA
    ' =========================
    Private Sub HitungUsia()

        Dim umur As Integer =
            Date.Now.Year - dtpTanggalLahir.Value.Year

        If Date.Now <
            dtpTanggalLahir.Value.AddYears(umur) Then

            umur -= 1

        End If

        lblUsiaAuto.Text = umur & " Tahun"

    End Sub

    Private Sub dtpTanggalLahir_ValueChanged(
        sender As Object,
        e As EventArgs
    ) Handles dtpTanggalLahir.ValueChanged

        HitungUsia()

    End Sub

    ' =========================
    ' SIMPAN PROFIL
    ' =========================
    Private Sub btnSimpan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimpan.Click

        If cmbJenisKelamin.Text = "" Then

            MessageBox.Show(
                "Pilih jenis kelamin!",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        If cmbGolonganDarah.Text = "" Then

            MessageBox.Show(
                "Pilih golongan darah!",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        If cmbRhesus.Text = "" Then

            MessageBox.Show(
                "Pilih rhesus!",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        Try

            Dim golDarah As String =
                cmbGolonganDarah.Text &
                If(cmbRhesus.Text.Contains("+"), "+", "-")

            BukaKoneksi()

            Dim query As String =
                "UPDATE users SET " &
                "jenis_kelamin=@jk, " &
                "tanggal_lahir=@tgl, " &
                "golongan_darah=@goldar, " &
                "alamat=@alamat " &
                "WHERE id_user=@id"

            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@jk", cmbJenisKelamin.Text)
            Cmd.Parameters.AddWithValue(
                "@tgl",
                dtpTanggalLahir.Value.ToString("yyyy-MM-dd")
            )
            Cmd.Parameters.AddWithValue("@goldar", golDarah)
            Cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text.Trim())
            Cmd.Parameters.AddWithValue("@id", CurrentIdUser)

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            ' UPDATE SESSION
            CurrentJenisKelamin = cmbJenisKelamin.Text
            CurrentTanggalLahir =
                dtpTanggalLahir.Value.ToString("yyyy-MM-dd")
            CurrentGolDarah = golDarah

            MessageBox.Show(
                "Profil berhasil diperbarui!",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            RefreshProfilData()
            IsiDataDonasi()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal menyimpan profil : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================
    ' ISI DATA PANEL DONASI
    ' =========================
    Private Sub IsiDataDonasi()

        txtNamaDonasi.Text = CurrentNama
        txtEmailDonasi.Text = CurrentEmail
        txtNoTelp.Text = CurrentTelepon
        txtJk.Text = CurrentJenisKelamin
        txtGolDar.Text = CurrentGolDarah

        If CurrentTanggalLahir <> "" Then

            Dim umur As Integer =
                Date.Now.Year -
                Convert.ToDateTime(CurrentTanggalLahir).Year

            txtUmur.Text = umur & " Tahun"

        Else

            txtUmur.Text = "-"

        End If

    End Sub

    ' =========================
    ' AJUKAN DONASI
    ' =========================
    Private Sub btnAjukanDonasi_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAjukanDonasi.Click

        If CurrentJenisKelamin = "" Then

            MessageBox.Show(
                "Lengkapi profil terlebih dahulu!",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        If txtAlamatDonasi.Text.Trim() = "" Then

            MessageBox.Show(
                "Alamat donor wajib diisi!",
                "Validasi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        Try

            BukaKoneksi()

            Dim query As String =
                "INSERT INTO donasi " &
                "(id_user, tanggal_donasi, alamat_donor, status_verifikasi) " &
                "VALUES " &
                "(@id, @tgl, @alamat, @status)"

            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@id", CurrentIdUser)
            Cmd.Parameters.AddWithValue(
                "@tgl",
                DateTimePicker1.Value.ToString("yyyy-MM-dd")
            )
            Cmd.Parameters.AddWithValue(
                "@alamat",
                txtAlamatDonasi.Text.Trim()
            )
            Cmd.Parameters.AddWithValue(
                "@status",
                "Menunggu Konfirmasi"
            )

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Pengajuan donor berhasil dikirim!",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            txtAlamatDonasi.Clear()

            MuatRiwayatDonasi()

            TampilkanPanel("Riwayat")

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal mengajukan donor : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================
    ' LOAD RIWAYAT
    ' =========================
    Private Sub MuatRiwayatDonasi()

        Try

            BukaKoneksi()

            Dim query As String =
                "SELECT " &
                "id_donasi AS 'ID', " &
                "tanggal_donasi AS 'Tanggal Donor', " &
                "alamat_donor AS 'Alamat', " &
                "status_verifikasi AS 'Status', " &
                "hasil_konsultasi AS 'Hasil Konsultasi', " &
                "jadwal_kembali AS 'Jadwal Selanjutnya' " &
                "FROM donasi " &
                "WHERE id_user=@id " &
                "ORDER BY id_donasi DESC"

            Da = New MySqlDataAdapter(query, Conn)

            Da.SelectCommand.Parameters.AddWithValue(
                "@id",
                CurrentIdUser
            )

            Ds = New DataSet()

            Da.Fill(Ds, "donasi")

            dgvRiwayat.DataSource = Ds.Tables("donasi")

            TutupKoneksi()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal memuat riwayat!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================
    ' SELECT DATA RIWAYAT
    ' =========================
    Private Sub dgvRiwayat_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvRiwayat.CellClick

        If e.RowIndex < 0 Then Return

        selectedIdDonasi =
            Convert.ToInt32(
                dgvRiwayat.Rows(e.RowIndex).Cells("ID").Value
            )

    End Sub

    ' =========================
    ' CETAK KUITANSI
    ' =========================
    Private Sub btnCetakKuitansi_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCetakKuitansi.Click

        If selectedIdDonasi = 0 Then

            MessageBox.Show(
                "Pilih data riwayat terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        Dim f As New FormCetak(selectedIdDonasi)
        f.ShowDialog()

    End Sub

    ' =========================
    ' CETAK KONSULTASI
    ' =========================
    Private Sub btnCetakKonsultasi_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCetakKonsultasi.Click

        If selectedIdDonasi = 0 Then

            MessageBox.Show(
                "Pilih data riwayat terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return

        End If

        Dim f As New FormInputKonsultasi(selectedIdDonasi)
        f.ShowDialog()

        MuatRiwayatDonasi()

    End Sub

    ' =========================
    ' REFRESH
    ' =========================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        MuatRiwayatDonasi()

    End Sub

    ' =========================
    ' LOGOUT
    ' =========================
    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        ResetSession()

        FormLogin.Show()

        Me.Close()

    End Sub

End Class