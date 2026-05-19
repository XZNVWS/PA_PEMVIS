Imports MySql.Data.MySqlClient

Public Class FormCetak
    Private _idDonasi As Integer
    Private _mode As String

    Public Sub New(id As Integer, mode As String)
        InitializeComponent()
        _idDonasi = id
        _mode = mode
    End Sub

    Private Sub FormCetak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        Dim titleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim bodyFont As New Font("Arial", 12)

        BukaKoneksi()
        Cmd = New MySqlCommand("SELECT d.*, u.nama_lengkap FROM donasi d JOIN users u ON d.id_user = u.id_user WHERE d.id_donasi = @id", Conn)
        Cmd.Parameters.AddWithValue("@id", _idDonasi)
        Rd = Cmd.ExecuteReader()

        If Rd.Read() Then
            g.DrawString("LAPORAN DONOR DARAH", titleFont, Brushes.Black, 250, 50)
            g.DrawString("ID Donasi: " & _idDonasi, bodyFont, Brushes.Black, 50, 100)
            g.DrawString("Nama: " & Rd("nama_lengkap").ToString(), bodyFont, Brushes.Black, 50, 130)

            If _mode = "kuitansi" Then
                g.DrawString("Jumlah Donasi: " & Rd("jumlah_donasi").ToString() & " Kantung", bodyFont, Brushes.Black, 50, 160)
            Else
                g.DrawString("Hasil Medis: " & Rd("hasil_konsultasi").ToString(), bodyFont, Brushes.Black, 50, 160)
                g.DrawString("Jadwal Kembali: " & Rd("jadwal_kembali").ToString(), bodyFont, Brushes.Black, 50, 190)
            End If
        End If
        Rd.Close()
        TutupKoneksi()
    End Sub
End Class