Imports MySql.Data.MySqlClient

Public Class FormCetakLaporan
    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim g As Graphics = e.Graphics
        g.DrawString("LAPORAN STOK DARAH KESELURUHAN", New Font("Arial", 16, FontStyle.Bold), Brushes.Black, 150, 50)

        Dim yPos As Integer = 120
        BukaKoneksi()
        Cmd = New MySqlCommand("SELECT * FROM stok_darah", Conn)
        Rd = Cmd.ExecuteReader()

        While Rd.Read()
            g.DrawString("Golongan " & Rd("golongan_darah").ToString() & " : " & Rd("total_stok").ToString() & " Kantung",
                         New Font("Arial", 12), Brushes.Black, 100, yPos)
            yPos += 30
        End While
        Rd.Close()
        TutupKoneksi()
    End Sub
End Class