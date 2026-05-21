Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            BukaKoneksi()
            Dim query As String = "SELECT * FROM users WHERE username=@user AND password=@pass"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
            Cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then
                CurrentIdUser = Convert.ToInt32(Rd("id_user"))
                CurrentUsername = Rd("username").ToString()
                CurrentNama = Rd("nama_lengkap").ToString()
                CurrentEmail = Rd("email").ToString()
                CurrentGolDarah = Rd("golongan_darah").ToString()
                CurrentTelepon = Rd("no_telepon").ToString()
                CurrentJenisKelamin = If(IsDBNull(Rd("jenis_kelamin")), "", Rd("jenis_kelamin").ToString())
                CurrentTanggalLahir = If(IsDBNull(Rd("tanggal_lahir")), "", Convert.ToDateTime(Rd("tanggal_lahir")).ToString("yyyy-MM-dd"))
                CurrentRole = Rd("role").ToString()
                Rd.Close()
                TutupKoneksi()

                If CurrentRole = "Admin" Then
                    FormDashboardAdmin.Show()
                Else
                    FormDashboardUser.Show()
                End If
                Me.Hide()
            Else
                Rd.Close()
                TutupKoneksi()
                MessageBox.Show("Username atau Password salah!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Class