Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class FormCetakLaporan
    Private Sub FormCetakLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpMulai.Value = Now.AddMonths(-1)
        TampilkanLaporan()
    End Sub

    Sub TampilkanLaporan()
        Try
            BukaKoneksi()
            Dim query As String = "SELECT d.tanggal_donasi, u.nama_lengkap, u.golongan_darah, d.jumlah_donasi, d.status_verifikasi " &
                                 "FROM donasi d JOIN users u ON d.id_user = u.id_user " &
                                 "WHERE d.tanggal_donasi BETWEEN @t1 AND @t2"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@t1", dtpMulai.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@t2", dtpSelesai.Value.ToString("yyyy-MM-dd"))

            Da = New MySqlDataAdapter(Cmd)
            Ds = New DataSet()
            Da.Fill(Ds, "Laporan")
            dgvLaporan.DataSource = Ds.Tables("Laporan")


            Dim total As Integer = 0
            For i As Integer = 0 To dgvLaporan.Rows.Count - 1
                total += Val(dgvLaporan.Rows(i).Cells(3).Value)
            Next
            lblTotalKantong.Text = "Total Kantong Terkumpul: " & total & " Kantong"
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            TutupKoneksi()
        End Try
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        TampilkanLaporan()
    End Sub

    Private WithEvents pdLap As New PrintDocument

    Private Sub btnCetakLaporan_Click(sender As Object, e As EventArgs) Handles btnCetakLaporan.Click
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = pdLap
        ppd.ShowDialog()
    End Sub

    Private Sub pdLap_PrintPage(sender As Object, e As PrintPageEventArgs) Handles pdLap.PrintPage
        Dim fJudul As New Font("Arial", 14, FontStyle.Bold)
        Dim fHeader As New Font("Arial", 10, FontStyle.Bold) ' Font Tebal untuk Header Tabel
        Dim fTeks As New Font("Arial", 10)
        Dim y As Integer = 50

        e.Graphics.DrawString("LAPORAN AKTIVITAS DONOR DARAH", fJudul, Brushes.Black, 200, y)
        y += 40
        e.Graphics.DrawString("Periode: " & dtpMulai.Text & " s/d " & dtpSelesai.Text, fTeks, Brushes.Black, 50, y)
        y += 30


        e.Graphics.DrawLine(Pens.Black, 50, y, 750, y)
        y += 5

        e.Graphics.DrawString("Tgl", fHeader, Brushes.Black, 50, y)
        e.Graphics.DrawString("Nama Pendonor", fHeader, Brushes.Black, 150, y)
        e.Graphics.DrawString("Gol", fHeader, Brushes.Black, 450, y)
        e.Graphics.DrawString("Jumlah", fHeader, Brushes.Black, 550, y)
        y += 20


        e.Graphics.DrawLine(Pens.Black, 50, y, 750, y)
        y += 10


        For i As Integer = 0 To dgvLaporan.Rows.Count - 1
            If dgvLaporan.Rows(i).Cells(0).Value IsNot Nothing Then
                e.Graphics.DrawString(CDate(dgvLaporan.Rows(i).Cells(0).Value).ToString("dd/MM/yyyy"), fTeks, Brushes.Black, 50, y)
                e.Graphics.DrawString(dgvLaporan.Rows(i).Cells(1).Value.ToString(), fTeks, Brushes.Black, 150, y)
                e.Graphics.DrawString(dgvLaporan.Rows(i).Cells(2).Value.ToString(), fTeks, Brushes.Black, 450, y)
                e.Graphics.DrawString(dgvLaporan.Rows(i).Cells(3).Value.ToString(), fTeks, Brushes.Black, 550, y)
                y += 20
            End If
        Next

        y += 20
        e.Graphics.DrawString(lblTotalKantong.Text, fJudul, Brushes.Black, 50, y)
    End Sub
End Class