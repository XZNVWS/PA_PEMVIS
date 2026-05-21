Imports MySql.Data.MySqlClient

Public Class FormInputKonsultasi

    Private _idDonasi As Integer
    Private statusDonor As String = ""

    Public Sub New(idDonasi As Integer)
        InitializeComponent()
        _idDonasi = idDonasi
    End Sub

    Private Sub FormInputKonsultasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblInfo.Text =
            "Donasi ID #" & _idDonasi &
            " - Input hasil konsultasi kesehatan pendonor."

        Try
            BukaKoneksi()

            Dim query As String =
                "SELECT d.hasil_konsultasi,
                        d.tanggal_boleh_donor_lagi,
                        u.jenis_kelamin
                 FROM donasi d
                 JOIN users u ON d.id_user = u.id_user
                 WHERE d.id_donasi = @id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@id", _idDonasi)

            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then

                If Not IsDBNull(Rd("hasil_konsultasi")) Then
                    txtHasilKonsultasi.Text =
                        Rd("hasil_konsultasi").ToString()
                End If

                If Not IsDBNull(Rd("jenis_kelamin")) Then
                    txtJenisKelamin.Text =
                        Rd("jenis_kelamin").ToString()
                Else
                    txtJenisKelamin.Text = "-"
                End If

                If Not IsDBNull(Rd("tanggal_boleh_donor_lagi")) Then
                    txtJadwalSelanjutnya.Text =
                        Convert.ToDateTime(
                            Rd("tanggal_boleh_donor_lagi")
                        ).ToString("dd MMMM yyyy")
                Else
                    txtJadwalSelanjutnya.Text = "-"
                End If

            End If

            Rd.Close()
            TutupKoneksi()

        Catch ex As Exception
            TutupKoneksi()

            MessageBox.Show(
                "Gagal memuat data konsultasi: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtHasilKonsultasi.Text.Trim = "" Then
            MessageBox.Show(
                "Hasil konsultasi wajib diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim hasilDialog As DialogResult =
            MessageBox.Show(
                "Apakah pendonor LOLOS konsultasi kesehatan?" &
                vbCrLf &
                "YES = Lolos Konsultasi" &
                vbCrLf &
                "NO = Gagal Konsultasi",
                "Status Konsultasi",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            )

        If hasilDialog = DialogResult.Cancel Then
            Return
        End If

        Dim tanggalDonorLagi As Date

        If hasilDialog = DialogResult.Yes Then

            statusDonor = "Lolos Konsultasi"

            ' donor lagi 70 hari
            tanggalDonorLagi = Date.Now.AddDays(70)

        Else

            statusDonor = "Gagal Konsultasi"

            tanggalDonorLagi = Date.Now

        End If

        Try

            BukaKoneksi()

            Dim query As String =
                "UPDATE donasi SET
                    hasil_konsultasi = @hasil,
                    status_donor = @status,
                    tanggal_boleh_donor_lagi = @tgl
                 WHERE id_donasi = @id"

            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue(
                "@hasil",
                txtHasilKonsultasi.Text.Trim()
            )

            Cmd.Parameters.AddWithValue(
                "@status",
                statusDonor
            )

            Cmd.Parameters.AddWithValue(
                "@tgl",
                tanggalDonorLagi.ToString("yyyy-MM-dd")
            )

            Cmd.Parameters.AddWithValue(
                "@id",
                _idDonasi
            )

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            txtJadwalSelanjutnya.Text =
                tanggalDonorLagi.ToString("dd MMMM yyyy")

            MessageBox.Show(
                "Data konsultasi berhasil disimpan!" &
                vbCrLf &
                "Status: " & statusDonor &
                vbCrLf &
                "Donor berikutnya: " &
                tanggalDonorLagi.ToString("dd MMMM yyyy"),
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Close()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Gagal menyimpan konsultasi: " &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnBatal_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBatal.Click

        Me.Close()

    End Sub

End Class