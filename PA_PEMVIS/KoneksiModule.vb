Imports MySql.Data.MySqlClient

Module KoneksiModule
    Public Conn As MySqlConnection
    Public Cmd As MySqlCommand
    Public Da As MySqlDataAdapter
    Public Ds As DataSet
    Public Rd As MySqlDataReader

    Private ConnectionString As String = "server=localhost;port=3306;user id=root;password=;database=db_donor_darah;Convert Zero Datetime=True"

    Public Sub BukaKoneksi()
        Try
            Conn = New MySqlConnection(ConnectionString)
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi Database Gagal: " & ex.Message, MsgBoxStyle.Critical, "Error")
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
End Module