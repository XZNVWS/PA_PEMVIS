<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInputKonsultasi
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlHeader = New Panel()
        lblJudul = New Label()
        lblInfo = New Label()
        lblHasil = New Label()
        txtHasilKonsultasi = New RichTextBox()
        lblJadwal = New Label()
        btnSimpan = New Button()
        btnBatal = New Button()
        lblJenisKelamin = New Label()
        txtJadwalSelanjutnya = New TextBox()
        txtJenisKelamin = New TextBox()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        pnlHeader.Controls.Add(lblJudul)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Margin = New Padding(3, 4, 3, 4)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(549, 73)
        pnlHeader.TabIndex = 7
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblJudul.ForeColor = Color.White
        lblJudul.Location = New Point(17, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(316, 28)
        lblJudul.TabIndex = 0
        lblJudul.Text = "📝 Input Hasil Konsultasi Medis"
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9.0F)
        lblInfo.ForeColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        lblInfo.Location = New Point(23, 93)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(452, 20)
        lblInfo.TabIndex = 6
        lblInfo.Text = "Isi hasil konsultasi dan jadwal donor berikutnya untuk pendonor ini:"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblHasil.Location = New Point(23, 128)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(239, 20)
        lblHasil.TabIndex = 5
        lblHasil.Text = "Hasil Konsultasi / Catatan Medis:"
        ' 
        ' txtHasilKonsultasi
        ' 
        txtHasilKonsultasi.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(245))
        txtHasilKonsultasi.BorderStyle = BorderStyle.FixedSingle
        txtHasilKonsultasi.Font = New Font("Segoe UI", 9.0F)
        txtHasilKonsultasi.Location = New Point(23, 163)
        txtHasilKonsultasi.Margin = New Padding(3, 4, 3, 4)
        txtHasilKonsultasi.Name = "txtHasilKonsultasi"
        txtHasilKonsultasi.Size = New Size(502, 132)
        txtHasilKonsultasi.TabIndex = 4
        txtHasilKonsultasi.Text = ""
        ' 
        ' lblJadwal
        ' 
        lblJadwal.AutoSize = True
        lblJadwal.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJadwal.Location = New Point(283, 315)
        lblJadwal.Name = "lblJadwal"
        lblJadwal.Size = New Size(189, 20)
        lblJadwal.TabIndex = 3
        lblJadwal.Text = "Jadwal Donor Berikutnya:"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(30), CByte(80), CByte(160))
        btnSimpan.Cursor = Cursors.Hand
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(23, 407)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(229, 51)
        btnSimpan.TabIndex = 1
        btnSimpan.Text = "SIMPAN KONSULTASI"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.White
        btnBatal.Cursor = Cursors.Hand
        btnBatal.FlatAppearance.BorderColor = Color.Gray
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 9.0F)
        btnBatal.ForeColor = Color.Gray
        btnBatal.Location = New Point(283, 407)
        btnBatal.Margin = New Padding(3, 4, 3, 4)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(137, 51)
        btnBatal.TabIndex = 0
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblJenisKelamin.Location = New Point(23, 315)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(109, 20)
        lblJenisKelamin.TabIndex = 8
        lblJenisKelamin.Text = "Jenis Kelamin:"
        ' 
        ' txtJadwalSelanjutnya
        ' 
        txtJadwalSelanjutnya.Location = New Point(283, 338)
        txtJadwalSelanjutnya.Name = "txtJadwalSelanjutnya"
        txtJadwalSelanjutnya.ReadOnly = True
        txtJadwalSelanjutnya.Size = New Size(229, 27)
        txtJadwalSelanjutnya.TabIndex = 9
        ' 
        ' txtJenisKelamin
        ' 
        txtJenisKelamin.Location = New Point(23, 338)
        txtJenisKelamin.Name = "txtJenisKelamin"
        txtJenisKelamin.ReadOnly = True
        txtJenisKelamin.Size = New Size(229, 27)
        txtJenisKelamin.TabIndex = 10
        ' 
        ' FormInputKonsultasi
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(549, 487)
        Controls.Add(txtJenisKelamin)
        Controls.Add(txtJadwalSelanjutnya)
        Controls.Add(lblJenisKelamin)
        Controls.Add(btnBatal)
        Controls.Add(btnSimpan)
        Controls.Add(lblJadwal)
        Controls.Add(txtHasilKonsultasi)
        Controls.Add(lblHasil)
        Controls.Add(lblInfo)
        Controls.Add(pnlHeader)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FormInputKonsultasi"
        StartPosition = FormStartPosition.CenterParent
        Text = "Input Hasil Konsultasi"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtHasilKonsultasi As RichTextBox
    Friend WithEvents lblJadwal As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents lblJenisKelamin As Label
    Friend WithEvents txtJadwalSelanjutnya As TextBox
    Friend WithEvents txtJenisKelamin As TextBox

End Class