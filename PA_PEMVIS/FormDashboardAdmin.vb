Imports MySql.Data.MySqlClient

Public Class FormDashboardAdmin

    Private selectedIdDonasi As Integer = 0
    Private selectedGolDarahStok As String = ""
    Private isLogout As Boolean = False

    ' =========================================================
    ' LOAD FORM
    ' =========================================================
    Private Sub FormDashboardAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblWelcome.Text =
            "Selamat datang, " & CurrentNama &
            " | " & Date.Now.ToString("dddd, dd MMMM yyyy")

        lblPageTitle.Text = "Dashboard Admin"

        AturSidebar()
        AturGrid()

        MuatStatistik()
        MuatDonasi()
        MuatPendonor()
        MuatStok()
        MuatLog()

    End Sub

    ' =========================================================
    ' ATUR SIDEBAR
    ' =========================================================
    Private Sub AturSidebar()

        btnMenuVerifikasi.Location = New Point(0, 133)
        btnMenuPendonor.Location = New Point(0, 186)
        btnMenuStok.Location = New Point(0, 239)
        btnMenuLog.Location = New Point(0, 292)
        btnMenuLaporan.Location = New Point(0, 345)

    End Sub

    ' =========================================================
    ' STYLE GRID
    ' =========================================================
    Private Sub AturGrid()

        Dim semuaGrid As DataGridView() = {
            dgvDonasi,
            dgvPendonor,
            dgvStok,
            dgvLog
        }

        For Each dgv As DataGridView In semuaGrid

            dgv.EnableHeadersVisualStyles = False
            dgv.RowHeadersVisible = False
            dgv.AllowUserToResizeRows = False
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            dgv.MultiSelect = False
            dgv.ReadOnly = True
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Next

    End Sub

    ' =========================================================
    ' MUAT STATISTIK
    ' =========================================================
    Private Sub MuatStatistik()

        Try

            BukaKoneksi()

            Cmd = New MySqlCommand(
                "SELECT COUNT(*) FROM donasi",
                Conn
            )
            lblStatDonasiNum.Text = Cmd.ExecuteScalar().ToString()

            Cmd = New MySqlCommand(
                "SELECT COUNT(*) FROM donasi WHERE status_verifikasi = 'Pending'",
                Conn
            )
            lblStatPendingNum.Text = Cmd.ExecuteScalar().ToString()

            Cmd = New MySqlCommand(
                "SELECT COALESCE(SUM(total_stok),0) FROM stok_darah",
                Conn
            )
            lblStatStokNum.Text = Cmd.ExecuteScalar().ToString()

            TutupKoneksi()

            CekAlertStok()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Error memuat statistik : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================================================
    ' ALERT STOK
    ' =========================================================
    Private Sub CekAlertStok()

        Try

            BukaKoneksi()

            Dim query As String =
                "SELECT golongan_darah, total_stok " &
                "FROM stok_darah " &
                "WHERE total_stok < 10"

            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            Dim alertMsg As String = "⚠ STOK MENIPIS : "
            Dim adaAlert As Boolean = False

            While Rd.Read()

                alertMsg &= Rd("golongan_darah").ToString() &
                            " (" &
                            Rd("total_stok").ToString() &
                            ")  "

                adaAlert = True

            End While

            Rd.Close()
            TutupKoneksi()

            If adaAlert Then

                pnlAlert.Visible = True
                lblAlert.Text = alertMsg

            Else

                pnlAlert.Visible = False

            End If

        Catch ex As Exception

            TutupKoneksi()

        End Try

    End Sub

    ' =========================================================
    ' MUAT DONASI
    ' =========================================================
    Private Sub MuatDonasi()

        Try

            BukaKoneksi()

            Dim query As String =
                "SELECT " &
                "d.id_donasi AS id_donasi, " &
                "CASE " &
                "WHEN d.is_anonim = 1 THEN 'Anonim' " &
                "ELSE u.nama_lengkap " &
                "END AS Nama, " &
                "u.golongan_darah AS GolDarah, " &
                "d.jumlah_donasi AS Jumlah, " &
                "d.tanggal_donasi AS Tanggal, " &
                "d.status_verifikasi AS Status, " &
                "d.hasil_konsultasi AS Konsultasi, " &
                "d.jadwal_kembali AS JadwalKembali " &
                "FROM donasi d " &
                "INNER JOIN users u ON d.id_user = u.id_user " &
                "ORDER BY d.created_at DESC"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()

            Da.Fill(Ds, "donasi")

            dgvDonasi.DataSource = Ds.Tables("donasi")

            If dgvDonasi.Columns.Contains("id_donasi") Then
                dgvDonasi.Columns("id_donasi").Visible = False
            End If

            TutupKoneksi()

            WarnaiStatusDonasi()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Error memuat data donasi : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================================================
    ' WARNA STATUS DONASI
    ' =========================================================
    Private Sub WarnaiStatusDonasi()

        For Each row As DataGridViewRow In dgvDonasi.Rows

            If row.Cells("Status").Value IsNot Nothing Then

                Select Case row.Cells("Status").Value.ToString()

                    Case "Pending"
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 248, 220)

                    Case "Terverifikasi"
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(220, 255, 230)

                    Case "Ditolak"
                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 220, 220)

                End Select

            End If

        Next

    End Sub

    ' =========================================================
    ' MUAT PENDONOR
    ' =========================================================
    Private Sub MuatPendonor()

        Try

            BukaKoneksi()

            Dim query As String =
                "SELECT " &
                "id_user AS ID, " &
                "nama_lengkap AS Nama, " &
                "username AS Username, " &
                "email AS Email, " &
                "golongan_darah AS GolDarah, " &
                "no_telepon AS Telepon, " &
                "created_at AS Terdaftar " &
                "FROM users " &
                "WHERE role = 'User' " &
                "ORDER BY created_at DESC"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()

            Da.Fill(Ds, "users")

            dgvPendonor.DataSource = Ds.Tables("users")

            TutupKoneksi()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Error memuat pendonor : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================================================
    ' MUAT STOK
    ' =========================================================
    Private Sub MuatStok()

        Try

            BukaKoneksi()

            Dim query As String =
                "SELECT " &
                "golongan_darah AS GolDarah, " &
                "total_stok AS TotalStok, " &
                "CASE " &
                "WHEN total_stok < 10 THEN 'MENIPIS' " &
                "ELSE 'AMAN' " &
                "END AS Status, " &
                "updated_at AS Diupdate " &
                "FROM stok_darah " &
                "ORDER BY golongan_darah"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()

            Da.Fill(Ds, "stok")

            dgvStok.DataSource = Ds.Tables("stok")

            TutupKoneksi()

            For Each row As DataGridViewRow In dgvStok.Rows

                If row.Cells("Status").Value IsNot Nothing Then

                    If row.Cells("Status").Value.ToString() = "MENIPIS" Then

                        row.DefaultCellStyle.BackColor =
                            Color.FromArgb(255, 220, 220)

                        row.DefaultCellStyle.ForeColor =
                            Color.DarkRed

                    End If

                End If

            Next

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Error memuat stok : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================================================
    ' MUAT LOG
    ' =========================================================
    Private Sub MuatLog()

        Try

            BukaKoneksi()

            Dim query As String =
                "SELECT " &
                "id_log AS ID, " &
                "golongan_darah AS GolDarah, " &
                "jenis_aksi AS Aksi, " &
                "jumlah AS Jumlah, " &
                "keterangan AS Keterangan, " &
                "created_at AS Tanggal " &
                "FROM log_sirkulasi_darah " &
                "ORDER BY created_at DESC"

            Da = New MySqlDataAdapter(query, Conn)
            Ds = New DataSet()

            Da.Fill(Ds, "log")

            dgvLog.DataSource = Ds.Tables("log")

            TutupKoneksi()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Error memuat log : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================================================
    ' PILIH DONASI
    ' =========================================================
    Private Sub dgvDonasi_SelectionChanged(sender As Object, e As EventArgs) Handles dgvDonasi.SelectionChanged

        If dgvDonasi.CurrentRow Is Nothing Then Exit Sub

        Try

            selectedIdDonasi =
                Convert.ToInt32(
                    dgvDonasi.CurrentRow.Cells("id_donasi").Value
                )

        Catch ex As Exception

            selectedIdDonasi = 0

        End Try

    End Sub

    ' =========================================================
    ' PILIH STOK
    ' =========================================================
    Private Sub dgvStok_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStok.SelectionChanged

        If dgvStok.CurrentRow Is Nothing Then Exit Sub

        Try

            selectedGolDarahStok =
                dgvStok.CurrentRow.Cells("GolDarah").Value.ToString()

        Catch ex As Exception

            selectedGolDarahStok = ""

        End Try

    End Sub

    ' =========================================================
    ' APPROVE DONASI
    ' =========================================================
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click

        If selectedIdDonasi = 0 Then

            MessageBox.Show(
                "Pilih data donasi terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        Try

            BukaKoneksi()

            Dim qDetail As String =
                "SELECT d.jumlah_donasi, u.golongan_darah, d.status_verifikasi " &
                "FROM donasi d " &
                "INNER JOIN users u ON d.id_user = u.id_user " &
                "WHERE d.id_donasi = @id"

            Cmd = New MySqlCommand(qDetail, Conn)
            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)

            Rd = Cmd.ExecuteReader()

            If Not Rd.Read() Then

                Rd.Close()
                TutupKoneksi()

                MessageBox.Show("Data tidak ditemukan!")
                Return

            End If

            Dim status As String =
                Rd("status_verifikasi").ToString()

            If status <> "Pending" Then

                Rd.Close()
                TutupKoneksi()

                MessageBox.Show(
                    "Donasi sudah diproses!",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                Return

            End If

            Dim jumlah As Integer =
                Convert.ToInt32(Rd("jumlah_donasi"))

            Dim gol As String =
                Rd("golongan_darah").ToString()

            Rd.Close()

            Cmd = New MySqlCommand(
                "UPDATE donasi " &
                "SET status_verifikasi = 'Terverifikasi' " &
                "WHERE id_donasi = @id",
                Conn
            )

            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)
            Cmd.ExecuteNonQuery()

            Cmd = New MySqlCommand(
                "UPDATE stok_darah " &
                "SET total_stok = total_stok + @jumlah " &
                "WHERE golongan_darah = @gol",
                Conn
            )

            Cmd.Parameters.AddWithValue("@jumlah", jumlah)
            Cmd.Parameters.AddWithValue("@gol", gol)

            Cmd.ExecuteNonQuery()

            Cmd = New MySqlCommand(
                "INSERT INTO log_sirkulasi_darah " &
                "(golongan_darah, jenis_aksi, jumlah, keterangan) " &
                "VALUES " &
                "(@gol, 'Masuk', @jumlah, @ket)",
                Conn
            )

            Cmd.Parameters.AddWithValue("@gol", gol)
            Cmd.Parameters.AddWithValue("@jumlah", jumlah)
            Cmd.Parameters.AddWithValue(
                "@ket",
                "Donasi ID #" & selectedIdDonasi & " diverifikasi"
            )

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Donasi berhasil diverifikasi!",
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

            MessageBox.Show(
                "Gagal verifikasi : " & ex.Message
            )

        End Try

    End Sub

    ' =========================================================
    ' REJECT DONASI
    ' =========================================================
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click

        If selectedIdDonasi = 0 Then

            MessageBox.Show("Pilih data donasi!")
            Return

        End If

        Try

            BukaKoneksi()

            Cmd = New MySqlCommand(
                "SELECT status_verifikasi " &
                "FROM donasi " &
                "WHERE id_donasi = @id",
                Conn
            )

            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)

            Dim hasil = Cmd.ExecuteScalar()

            If hasil Is Nothing Then

                TutupKoneksi()

                MessageBox.Show("Data tidak ditemukan!")
                Return

            End If

            Dim status As String = hasil.ToString()

            If status <> "Pending" Then

                TutupKoneksi()

                MessageBox.Show("Donasi sudah diproses!")
                Return

            End If

            Cmd = New MySqlCommand(
                "UPDATE donasi " &
                "SET status_verifikasi = 'Ditolak' " &
                "WHERE id_donasi = @id",
                Conn
            )

            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Donasi berhasil ditolak!"
            )

            selectedIdDonasi = 0

            MuatStatistik()
            MuatDonasi()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal menolak : " & ex.Message
            )

        End Try

    End Sub

    ' =========================================================
    ' INPUT KONSULTASI
    ' =========================================================
    Private Sub btnInputKonsultasi_Click(sender As Object, e As EventArgs) Handles btnInputKonsultasi.Click

        If selectedIdDonasi = 0 Then

            MessageBox.Show("Pilih data donasi!")
            Return

        End If

        Dim f As New FormInputKonsultasi(selectedIdDonasi)

        f.ShowDialog()

        MuatDonasi()

    End Sub

    ' =========================================================
    ' HAPUS USER
    ' =========================================================
    Private Sub btnHapusUser_Click(sender As Object, e As EventArgs) Handles btnHapusUser.Click

        If dgvPendonor.CurrentRow Is Nothing Then

            MessageBox.Show("Pilih user!")
            Return

        End If

        Dim idUser As Integer =
            Convert.ToInt32(
                dgvPendonor.CurrentRow.Cells("ID").Value
            )

        Try

            BukaKoneksi()

            Cmd = New MySqlCommand(
                "DELETE FROM users WHERE id_user = @id",
                Conn
            )

            Cmd.Parameters.AddWithValue("@id", idUser)

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show("Pendonor berhasil dihapus!")

            MuatPendonor()
            MuatDonasi()
            MuatStatistik()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal hapus user : " & ex.Message
            )

        End Try

    End Sub

    ' =========================================================
    ' KURANG STOK
    ' =========================================================
    Private Sub btnKurangStok_Click(sender As Object, e As EventArgs) Handles btnKurangStok.Click

        If selectedGolDarahStok = "" Then

            MessageBox.Show("Pilih golongan darah!")
            Return

        End If

        Dim jumlahKeluar As Integer

        If Not Integer.TryParse(
            txtKurangJumlah.Text,
            jumlahKeluar
        ) Then

            MessageBox.Show("Jumlah tidak valid!")
            Return

        End If

        Try

            BukaKoneksi()

            Cmd = New MySqlCommand(
                "SELECT total_stok " &
                "FROM stok_darah " &
                "WHERE golongan_darah = @gol",
                Conn
            )

            Cmd.Parameters.AddWithValue(
                "@gol",
                selectedGolDarahStok
            )

            Dim stok As Integer =
                Convert.ToInt32(
                    Cmd.ExecuteScalar()
                )

            If jumlahKeluar > stok Then

                TutupKoneksi()

                MessageBox.Show(
                    "Stok tidak mencukupi!"
                )

                Return

            End If

            Cmd = New MySqlCommand(
                "UPDATE stok_darah " &
                "SET total_stok = total_stok - @jml " &
                "WHERE golongan_darah = @gol",
                Conn
            )

            Cmd.Parameters.AddWithValue(
                "@jml",
                jumlahKeluar
            )

            Cmd.Parameters.AddWithValue(
                "@gol",
                selectedGolDarahStok
            )

            Cmd.ExecuteNonQuery()

            Cmd = New MySqlCommand(
                "INSERT INTO log_sirkulasi_darah " &
                "(golongan_darah, jenis_aksi, jumlah, keterangan) " &
                "VALUES " &
                "(@gol, 'Keluar', @jml, @ket)",
                Conn
            )

            Cmd.Parameters.AddWithValue(
                "@gol",
                selectedGolDarahStok
            )

            Cmd.Parameters.AddWithValue(
                "@jml",
                jumlahKeluar
            )

            Cmd.Parameters.AddWithValue(
                "@ket",
                "Distribusi darah oleh Admin"
            )

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Stok berhasil dikurangi!"
            )

            txtKurangJumlah.Clear()

            selectedGolDarahStok = ""

            MuatStatistik()
            MuatStok()
            MuatLog()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal distribusi : " & ex.Message
            )

        End Try

    End Sub

    ' =========================================================
    ' VALIDASI ANGKA
    ' =========================================================
    Private Sub txtKurangJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKurangJumlah.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> Chr(8) Then

            e.Handled = True

        End If

    End Sub

    ' =========================================================
    ' MENU
    ' =========================================================
    Private Sub btnMenuVerifikasi_Click(sender As Object, e As EventArgs) Handles btnMenuVerifikasi.Click

        tabControl.SelectedTab = tabVerifikasi
        lblPageTitle.Text = "Verifikasi Donasi"

        HighlightMenu(btnMenuVerifikasi)

    End Sub

    Private Sub btnMenuPendonor_Click(sender As Object, e As EventArgs) Handles btnMenuPendonor.Click

        tabControl.SelectedTab = tabPendonor
        lblPageTitle.Text = "Data Pendonor"

        HighlightMenu(btnMenuPendonor)

    End Sub

    Private Sub btnMenuStok_Click(sender As Object, e As EventArgs) Handles btnMenuStok.Click

        tabControl.SelectedTab = tabStok
        lblPageTitle.Text = "Manajemen Stok"

        HighlightMenu(btnMenuStok)

    End Sub

    Private Sub btnMenuLog_Click(sender As Object, e As EventArgs) Handles btnMenuLog.Click

        tabControl.SelectedTab = tabLog
        lblPageTitle.Text = "Log Sirkulasi"

        HighlightMenu(btnMenuLog)

    End Sub

    Private Sub btnMenuLaporan_Click(sender As Object, e As EventArgs) Handles btnMenuLaporan.Click

        Dim f As New FormCetakLaporan()
        f.ShowDialog()

    End Sub

    ' =========================================================
    ' HIGHLIGHT MENU
    ' =========================================================
    Private Sub HighlightMenu(btnAktif As Button)

        Dim semuaBtn As Button() = {
            btnMenuVerifikasi,
            btnMenuPendonor,
            btnMenuStok,
            btnMenuLog,
            btnMenuLaporan
        }

        For Each btn As Button In semuaBtn

            btn.BackColor =
                Color.FromArgb(140, 20, 20)

        Next

        btnAktif.BackColor =
            Color.FromArgb(180, 30, 30)

    End Sub

    ' =========================================================
    ' LOGOUT
    ' =========================================================
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim konfirmasi As DialogResult =
            MessageBox.Show(
                "Yakin logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If konfirmasi = DialogResult.Yes Then

            isLogout = True

            ResetSession()

            FormLogin.Show()

            Me.Close()

        End If

    End Sub

    ' =========================================================
    ' FORM CLOSED
    ' =========================================================
    Private Sub FormDashboardAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

        If Not isLogout Then
            Application.Exit()
        End If

    End Sub

End Class