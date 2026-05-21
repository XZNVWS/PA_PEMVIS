Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormCetak

    Private selectedIdDonasi As Integer

    ' =========================
    ' CONSTRUCTOR
    ' =========================
    Public Sub New(idDonasi As Integer)

        InitializeComponent()

        selectedIdDonasi = idDonasi

    End Sub

    ' =========================
    ' LOAD FORM
    ' =========================
    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AmbilData()

    End Sub

    ' =========================
    ' AMBIL DATA DONASI
    ' =========================
    Private Sub AmbilData()

        Try

            BukaKoneksi()

            Dim sql As String =
                "SELECT d.id_donasi, " &
                "u.nama_lengkap, " &
                "u.golongan_darah, " &
                "d.jumlah_donasi, " &
                "d.tanggal_donasi, " &
                "d.jadwal_kembali " &
                "FROM donasi d " &
                "JOIN users u ON d.id_user = u.id_user " &
                "WHERE d.id_donasi = @id"

            Cmd = New MySqlCommand(sql, Conn)

            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@id", selectedIdDonasi)

            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then

                lblIdDonasi.Text =
                    ": BD-" & Rd("id_donasi").ToString()

                lblNama.Text =
                    ": " & Rd("nama_lengkap").ToString()

                lblGolDarah.Text =
                    ": " & Rd("golongan_darah").ToString()

                lblJumlah.Text =
                    ": " & Rd("jumlah_donasi").ToString() & " Kantong"

                lblTanggal.Text =
                    ": " &
                    Convert.ToDateTime(Rd("tanggal_donasi")).ToString("dd/MM/yyyy")

                If IsDBNull(Rd("jadwal_kembali")) Then

                    lblJadwalKembali.Text = ": -"

                Else

                    lblJadwalKembali.Text =
                        ": " &
                        Convert.ToDateTime(Rd("jadwal_kembali")).ToString("dd/MM/yyyy")

                End If

            Else

                MessageBox.Show(
                    "Data donasi tidak ditemukan!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Me.Close()

            End If

            Rd.Close()

        Catch ex As Exception

            MessageBox.Show(
                "Error : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            TutupKoneksi()

        End Try

    End Sub

    ' =========================
    ' BUTTON CETAK
    ' =========================
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        Try

            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal membuka preview : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' =========================
    ' PRINT
    ' =========================
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Try

            Dim bmp As New Bitmap(
                pnlKuitansi.Width,
                pnlKuitansi.Height
            )

            pnlKuitansi.DrawToBitmap(
                bmp,
                New Rectangle(
                    0,
                    0,
                    pnlKuitansi.Width,
                    pnlKuitansi.Height
                )
            )

            e.Graphics.DrawImage(bmp, 100, 100)

        Catch ex As Exception

            MessageBox.Show(
                "Gagal mencetak : " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

End Class