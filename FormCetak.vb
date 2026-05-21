Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormCetak
    Public SelectedIdDonasi As Integer = 1

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AmbilData()
    End Sub

    Sub AmbilData()
        Try
            BukaKoneksi()
            Dim sql As String = "SELECT d.id_donasi, u.nama_lengkap, u.golongan_darah, d.jumlah_donasi, d.tanggal_donasi, d.jadwal_kembali " &
                               "FROM donasi d JOIN users u ON d.id_user = u.id_user " &
                               "WHERE d.id_donasi = @id"
            Cmd = New MySqlCommand(sql, Conn)
            Cmd.Parameters.AddWithValue("@id", SelectedIdDonasi)
            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then
                lblIdDonasi.Text = ": BD-" & Rd("id_donasi").ToString()
                lblNama.Text = ": " & Rd("nama_lengkap").ToString()
                lblGolDarah.Text = ": " & Rd("golongan_darah").ToString()
                lblJumlah.Text = ": " & Rd("jumlah_donasi").ToString() & " Kantong"
                lblTanggal.Text = ": " & CDate(Rd("tanggal_donasi")).ToString("dd/MM/yyyy")

                If Not IsDBNull(Rd("jadwal_kembali")) Then
                    lblJadwalKembali.Text = ": " & CDate(Rd("jadwal_kembali")).ToString("dd/MM/yyyy")
                Else
                    lblJadwalKembali.Text = ": -"
                End If
            End If
            Rd.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private WithEvents pd As New PrintDocument

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = pd
        ppd.ShowDialog()
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pd.PrintPage
        Dim bmp As New Bitmap(pnlKuitansi.Width, pnlKuitansi.Height)
        pnlKuitansi.DrawToBitmap(bmp, New Rectangle(0, 0, pnlKuitansi.Width, pnlKuitansi.Height))
        e.Graphics.DrawImage(bmp, 100, 100)
    End Sub
End Class