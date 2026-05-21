Imports MySql.Data.MySqlClient

Public Class FormRegister

    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtPassword.PasswordChar = "*"c

    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso
           e.KeyChar <> Convert.ToChar(Keys.Back) Then

            e.Handled = True

        End If

    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click

        errProvider.Clear()

        Dim adaError As Boolean = False

        ' =========================
        ' VALIDASI NAMA
        ' =========================
        If txtNama.Text.Trim() = "" Then

            errProvider.SetError(txtNama, "Nama lengkap wajib diisi")
            txtNama.Focus()
            adaError = True

        End If

        ' =========================
        ' VALIDASI USERNAME
        ' =========================
        If txtUsername.Text.Trim() = "" Then

            errProvider.SetError(txtUsername, "Username wajib diisi")

            If Not adaError Then
                txtUsername.Focus()
            End If

            adaError = True

        ElseIf txtUsername.Text.Trim.Length < 4 Then

            errProvider.SetError(txtUsername, "Username minimal 4 karakter")

            If Not adaError Then
                txtUsername.Focus()
            End If

            adaError = True

        End If

        ' =========================
        ' VALIDASI PASSWORD
        ' =========================
        If txtPassword.Text.Trim() = "" Then

            errProvider.SetError(txtPassword, "Password wajib diisi")

            If Not adaError Then
                txtPassword.Focus()
            End If

            adaError = True

        ElseIf txtPassword.Text.Trim.Length < 6 Then

            errProvider.SetError(txtPassword, "Password minimal 6 karakter")

            If Not adaError Then
                txtPassword.Focus()
            End If

            adaError = True

        End If

        ' =========================
        ' VALIDASI EMAIL
        ' =========================
        If txtEmail.Text.Trim() = "" Then

            errProvider.SetError(txtEmail, "Email wajib diisi")

            If Not adaError Then
                txtEmail.Focus()
            End If

            adaError = True

        ElseIf Not txtEmail.Text.Contains("@") OrElse
               Not txtEmail.Text.Contains(".") Then

            errProvider.SetError(txtEmail, "Format email tidak valid")

            If Not adaError Then
                txtEmail.Focus()
            End If

            adaError = True

        End If

        ' =========================
        ' VALIDASI TELEPON
        ' =========================
        If txtTelepon.Text.Trim() = "" Then

            errProvider.SetError(txtTelepon, "No. telepon wajib diisi")

            If Not adaError Then
                txtTelepon.Focus()
            End If

            adaError = True

        ElseIf txtTelepon.Text.Trim.Length < 10 Then

            errProvider.SetError(txtTelepon, "Nomor telepon tidak valid")

            If Not adaError Then
                txtTelepon.Focus()
            End If

            adaError = True

        End If

        ' =========================
        ' JIKA ADA ERROR
        ' =========================
        If adaError Then
            Return
        End If

        Try

            BukaKoneksi()

            ' =========================
            ' CEK USERNAME
            ' =========================
            Dim qCek As String =
                "SELECT COUNT(*) FROM users WHERE username = @user"

            Cmd = New MySqlCommand(qCek, Conn)

            Cmd.Parameters.AddWithValue("@user", txtUsername.Text.Trim())

            Dim jumlahUser As Integer =
                Convert.ToInt32(Cmd.ExecuteScalar())

            If jumlahUser > 0 Then

                errProvider.SetError(txtUsername,
                                     "Username sudah digunakan")

                txtUsername.Focus()

                TutupKoneksi()
                Return

            End If

            ' =========================
            ' INSERT DATA
            ' =========================
            Dim query As String =
                "INSERT INTO users " &
                "(username, password, nama_lengkap, email, no_telepon, role) " &
                "VALUES " &
                "(@user, @pass, @nama, @email, @telp, 'User')"

            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@user",
                                        txtUsername.Text.Trim())

            Cmd.Parameters.AddWithValue("@pass",
                                        txtPassword.Text.Trim())

            Cmd.Parameters.AddWithValue("@nama",
                                        txtNama.Text.Trim())

            Cmd.Parameters.AddWithValue("@email",
                                        txtEmail.Text.Trim())

            Cmd.Parameters.AddWithValue("@telp",
                                        txtTelepon.Text.Trim())

            Cmd.ExecuteNonQuery()

            TutupKoneksi()

            MessageBox.Show(
                "Registrasi berhasil!" &
                vbCrLf &
                "Silakan login menggunakan akun Anda.",
                "Sukses",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Close()

        Catch ex As Exception

            TutupKoneksi()

            MessageBox.Show(
                "Terjadi kesalahan:" &
                vbCrLf &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click

        Me.Close()

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object,
                                    e As KeyEventArgs) _
                                    Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            btnDaftar.PerformClick()

        End If

    End Sub

End Class