Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler picLogo.Paint, AddressOf PicLogo_Paint
    End Sub

    Private Sub PicLogo_Paint(sender As Object, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        g.FillEllipse(New SolidBrush(Color.FromArgb(180, 30, 30)), 5, 5, 60, 60)

        g.FillRectangle(Brushes.White, 20, 30, 30, 10)

        g.FillRectangle(Brushes.White, 30, 20, 10, 30)
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked Then
            txtPassword.PasswordChar = Nothing
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUsername.Text.Trim() = "" OrElse txtPassword.Text.Trim() = "" Then
            MessageBox.Show(
                "Username dan Password wajib diisi!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtUsername.Focus()
            Return
        End If

        Try
            Call BukaKoneksi()

            Dim query As String =
                "SELECT id_user, username, nama_lengkap, email, golongan_darah, no_telepon, role " &
                "FROM users " &
                "WHERE username = @user AND password = @pass"

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
                CurrentRole = Rd("role").ToString()

                Rd.Close()
                TutupKoneksi()

                If CurrentRole = "Admin" Then
                    Dim fAdmin As New FormDashboardAdmin()
                    fAdmin.Show()
                    Me.Hide()

                ElseIf CurrentRole = "User" Then
                    Dim fUser As New FormDashboardUser()
                    fUser.Show()
                    Me.Hide()

                End If

            Else
                Rd.Close()
                TutupKoneksi()

                MessageBox.Show(
                    "Username atau Password salah!" & vbCrLf & "Silakan coba lagi.",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
                txtPassword.Clear()
                txtUsername.Focus()
            End If

        Catch ex As Exception
            TutupKoneksi()
            MessageBox.Show(
                "Terjadi kesalahan sistem:" & vbCrLf & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fReg As New FormRegister()
        fReg.ShowDialog()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin.PerformClick()
        End If
    End Sub

End Class