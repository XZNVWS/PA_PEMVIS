Imports MySql.Data.MySqlClient
Module KoneksiModule

    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader

    Private ConnectionString As String =
        "server=localhost;port=3306;user id=root;password=;database=db_donor_darah;Convert Zero Datetime=True"

    Public Sub BukaKoneksi()
        Try
            Conn = New MySqlConnection(ConnectionString)

            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(
                "Gagal terhubung ke database!" & vbCrLf &
                "Pastikan XAMPP MySQL sudah aktif." & vbCrLf & vbCrLf &
                "Detail: " & ex.Message,
                "Error Koneksi",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Public Sub TutupKoneksi()
        Try
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function TestKoneksi() As Boolean
        Try
            BukaKoneksi()
            If Conn.State = ConnectionState.Open Then
                TutupKoneksi()
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module