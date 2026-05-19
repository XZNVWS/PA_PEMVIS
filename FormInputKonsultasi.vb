Imports MySql.Data.MySqlClient
Public Class FormInputKonsultasi

    Private _idDonasi As Integer

    Public Sub New(idDonasi As Integer)
        InitializeComponent()
        _idDonasi = idDonasi
    End Sub

    Private Sub FormInputKonsultasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInfo.Text = "Donasi ID #" & _idDonasi & " - Isi hasil konsultasi dan jadwal donor berikutnya:"

        Try
            BukaKoneksi()
            Cmd = New MySqlCommand(
                "SELECT hasil_konsultasi, jadwal_kembali FROM donasi WHERE id_donasi = @id", Conn)
            Cmd.Parameters.AddWithValue("@id", _idDonasi)
            Rd = Cmd.ExecuteReader()
            If Rd.Read() Then
                If Not IsDBNull(Rd("hasil_konsultasi")) Then
                    txtHasilKonsultasi.Text = Rd("hasil_konsultasi").ToString()
                End If
                If Not IsDBNull(Rd("jadwal_kembali")) Then
                    dtpJadwalKembali.Value = Convert.ToDateTime(Rd("jadwal_kembali"))
                End If
            End If
            Rd.Close()
            TutupKoneksi()
        Catch ex As Exception
            TutupKoneksi()
        End Try
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtHasilKonsultasi.Text.Trim() = "" Then
            MessageBox.Show("Isi hasil konsultasi terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            BukaKoneksi()

            Dim query As String =
                "UPDATE donasi SET hasil_konsultasi = @hasil, jadwal_kembali = @jadwal " &
                "WHERE id_donasi = @id"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@hasil", txtHasilKonsultasi.Text.Trim())
            Cmd.Parameters.AddWithValue("@jadwal", dtpJadwalKembali.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@id", _idDonasi)
            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Hasil konsultasi berhasil disimpan!" & vbCrLf &
                "Jadwal kembali: " & dtpJadwalKembali.Value.ToString("dd MMMM yyyy"),
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Me.Close()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class