<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetak))
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintDocument1 = New Printing.PrintDocument()
        lblJudul = New Label()
        pnlKuitansi = New Panel()
        lblSubJudul = New Label()
        lblGaris = New Label()
        lblStaticId = New Label()
        lblIdDonasi = New Label()
        btnCetak = New Button()
        lblStatic2 = New Label()
        lblNama = New Label()
        lblStatic3 = New Label()
        lblGolDarah = New Label()
        lblStatic4 = New Label()
        lblJumlah = New Label()
        lblStatic5 = New Label()
        lblTanggal = New Label()
        lblStatic6 = New Label()
        lblJadwalKembali = New Label()
        pnlKuitansi.SuspendLayout()
        SuspendLayout()
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Crimson
        lblJudul.Location = New Point(89, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(267, 27)
        lblJudul.TabIndex = 0
        lblJudul.Text = "BUKTI DONOR DARAH"
        lblJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pnlKuitansi
        ' 
        pnlKuitansi.BackColor = Color.White
        pnlKuitansi.BorderStyle = BorderStyle.FixedSingle
        pnlKuitansi.Controls.Add(lblJadwalKembali)
        pnlKuitansi.Controls.Add(lblStatic6)
        pnlKuitansi.Controls.Add(lblTanggal)
        pnlKuitansi.Controls.Add(lblStatic5)
        pnlKuitansi.Controls.Add(lblJumlah)
        pnlKuitansi.Controls.Add(lblStatic4)
        pnlKuitansi.Controls.Add(lblGolDarah)
        pnlKuitansi.Controls.Add(lblStatic3)
        pnlKuitansi.Controls.Add(lblNama)
        pnlKuitansi.Controls.Add(lblStatic2)
        pnlKuitansi.Controls.Add(lblIdDonasi)
        pnlKuitansi.Controls.Add(lblStaticId)
        pnlKuitansi.Controls.Add(lblGaris)
        pnlKuitansi.Controls.Add(lblSubJudul)
        pnlKuitansi.Controls.Add(lblJudul)
        pnlKuitansi.Location = New Point(20, 20)
        pnlKuitansi.Name = "pnlKuitansi"
        pnlKuitansi.Size = New Size(444, 330)
        pnlKuitansi.TabIndex = 1
        ' 
        ' lblSubJudul
        ' 
        lblSubJudul.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSubJudul.Location = New Point(2, 42)
        lblSubJudul.Name = "lblSubJudul"
        lblSubJudul.Size = New Size(440, 15)
        lblSubJudul.TabIndex = 1
        lblSubJudul.Text = "SIFODARAH - Universitas Mulawarman"
        lblSubJudul.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblGaris
        ' 
        lblGaris.BorderStyle = BorderStyle.Fixed3D
        lblGaris.Location = New Point(16, 70)
        lblGaris.Name = "lblGaris"
        lblGaris.Size = New Size(410, 2)
        lblGaris.TabIndex = 2
        ' 
        ' lblStaticId
        ' 
        lblStaticId.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStaticId.Location = New Point(30, 90)
        lblStaticId.Name = "lblStaticId"
        lblStaticId.Size = New Size(120, 20)
        lblStaticId.TabIndex = 3
        lblStaticId.Text = "No. Bukti / ID"
        ' 
        ' lblIdDonasi
        ' 
        lblIdDonasi.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblIdDonasi.Location = New Point(159, 88)
        lblIdDonasi.Name = "lblIdDonasi"
        lblIdDonasi.Size = New Size(250, 20)
        lblIdDonasi.TabIndex = 4
        lblIdDonasi.Text = "[ID]"
        ' 
        ' btnCetak
        ' 
        btnCetak.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.LightGreen
        btnCetak.Location = New Point(180, 370)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(120, 40)
        btnCetak.TabIndex = 2
        btnCetak.Text = "Cetak Bukti"
        btnCetak.UseVisualStyleBackColor = True
        ' 
        ' lblStatic2
        ' 
        lblStatic2.AutoSize = True
        lblStatic2.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatic2.Location = New Point(30, 130)
        lblStatic2.Name = "lblStatic2"
        lblStatic2.Size = New Size(135, 19)
        lblStatic2.TabIndex = 5
        lblStatic2.Text = "Nama Pendonor"
        ' 
        ' lblNama
        ' 
        lblNama.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(160, 130)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(250, 20)
        lblNama.TabIndex = 6
        lblNama.Text = "[Nama]"
        ' 
        ' lblStatic3
        ' 
        lblStatic3.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatic3.Location = New Point(30, 165)
        lblStatic3.Name = "lblStatic3"
        lblStatic3.Size = New Size(120, 20)
        lblStatic3.TabIndex = 7
        lblStatic3.Text = "Golongan Darah"
        ' 
        ' lblGolDarah
        ' 
        lblGolDarah.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGolDarah.Location = New Point(160, 165)
        lblGolDarah.Name = "lblGolDarah"
        lblGolDarah.Size = New Size(250, 20)
        lblGolDarah.TabIndex = 8
        lblGolDarah.Text = "[Gol]"
        ' 
        ' lblStatic4
        ' 
        lblStatic4.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatic4.Location = New Point(30, 200)
        lblStatic4.Name = "lblStatic4"
        lblStatic4.Size = New Size(120, 20)
        lblStatic4.TabIndex = 9
        lblStatic4.Text = "Jumlah Donor"
        ' 
        ' lblJumlah
        ' 
        lblJumlah.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJumlah.Location = New Point(160, 200)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Size = New Size(250, 20)
        lblJumlah.TabIndex = 10
        lblJumlah.Text = "[Qty]"
        ' 
        ' lblStatic5
        ' 
        lblStatic5.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatic5.Location = New Point(30, 235)
        lblStatic5.Name = "lblStatic5"
        lblStatic5.Size = New Size(120, 20)
        lblStatic5.TabIndex = 11
        lblStatic5.Text = "Tanggal Donor"
        ' 
        ' lblTanggal
        ' 
        lblTanggal.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTanggal.Location = New Point(160, 235)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(250, 20)
        lblTanggal.TabIndex = 12
        lblTanggal.Text = "[Tgl]"
        ' 
        ' lblStatic6
        ' 
        lblStatic6.Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatic6.Location = New Point(30, 270)
        lblStatic6.Name = "lblStatic6"
        lblStatic6.Size = New Size(120, 20)
        lblStatic6.TabIndex = 13
        lblStatic6.Text = "Jadwal Kembali"
        ' 
        ' lblJadwalKembali
        ' 
        lblJadwalKembali.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJadwalKembali.ForeColor = Color.ForestGreen
        lblJadwalKembali.Location = New Point(160, 270)
        lblJadwalKembali.Name = "lblJadwalKembali"
        lblJadwalKembali.Size = New Size(250, 20)
        lblJadwalKembali.TabIndex = 14
        lblJadwalKembali.Text = "[Tgl]"
        ' 
        ' FormCetak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 433)
        Controls.Add(btnCetak)
        Controls.Add(pnlKuitansi)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormCetak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cetak Bukti Donor Darah"
        pnlKuitansi.ResumeLayout(False)
        pnlKuitansi.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents lblJudul As Label
    Friend WithEvents pnlKuitansi As Panel
    Friend WithEvents lblSubJudul As Label
    Friend WithEvents lblGaris As Label
    Friend WithEvents lblStaticId As Label
    Friend WithEvents lblIdDonasi As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents lblStatic2 As Label
    Friend WithEvents lblGolDarah As Label
    Friend WithEvents lblStatic3 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblStatic4 As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents lblStatic5 As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents lblJadwalKembali As Label
    Friend WithEvents lblStatic6 As Label
End Class