Imports MySql.Data.MySqlClient
Public Class FormRegister

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        errProvider.Clear()

        Dim adaError As Boolean = False

        If txtNama.Text.Trim() = "" Then
            errProvider.SetError(txtNama, "Nama lengkap wajib diisi!")
            adaError = True
        End If

        If txtUsername.Text.Trim() = "" Then
            errProvider.SetError(txtUsername, "Username wajib diisi!")
            adaError = True
        End If

        If txtPassword.Text.Trim() = "" Then
            errProvider.SetError(txtPassword, "Password wajib diisi!")
            adaError = True
        End If

        If txtEmail.Text.Trim() = "" Then
            errProvider.SetError(txtEmail, "Email wajib diisi!")
            adaError = True

        ElseIf Not txtEmail.Text.Contains("@") OrElse Not txtEmail.Text.Contains(".") Then
            errProvider.SetError(txtEmail, "Format email tidak valid! Contoh: nama@email.com")
            adaError = True
        End If

        If cboGolDarah.SelectedIndex = -1 Then
            errProvider.SetError(cboGolDarah, "Pilih golongan darah!")
            adaError = True
        End If

        If txtTelepon.Text.Trim() = "" Then
            errProvider.SetError(txtTelepon, "No. telepon wajib diisi!")
            adaError = True
        End If

        If adaError Then Return

        Try
            BukaKoneksi()

            Dim qCek As String = "SELECT COUNT(*) FROM users WHERE username = @user"
            Cmd = New MySqlCommand(qCek, Conn)
            Cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())

            Dim jumlah As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

            If jumlah > 0 Then
                errProvider.SetError(txtUsername, "Username sudah digunakan, pilih yang lain!")
                TutupKoneksi()
                Return
            End If

            Dim qInsert As String =
                "INSERT INTO users (username, password, nama_lengkap, email, golongan_darah, no_telepon, role) " &
                "VALUES (@user, @pass, @nama, @email, @gol, @telp, 'User')"

            Cmd = New MySqlCommand(qInsert, Conn)
            Cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())
            Cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim())
            Cmd.Parameters.AddWithValue("@nama", txtNama.Text.Trim())
            Cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
            Cmd.Parameters.AddWithValue("@gol", cboGolDarah.Text)
            Cmd.Parameters.AddWithValue("@telp", txtTelepon.Text.Trim())

            Cmd.ExecuteNonQuery()
            TutupKoneksi()

            MessageBox.Show(
                "Pendaftaran berhasil!" & vbCrLf &
                "Silakan login dengan username: " & txtUsername.Text,
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Close()

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show(
                "Gagal mendaftar: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

End Class