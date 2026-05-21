<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCetakLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetakLaporan))
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        gbFilter = New GroupBox()
        Label1 = New Label()
        dtpMulai = New DateTimePicker()
        Label2 = New Label()
        dtpSelesai = New DateTimePicker()
        btnFilter = New Button()
        btnCetakLaporan = New Button()
        dgvLaporan = New DataGridView()
        pnlSum = New Panel()
        lblTotalKantong = New Label()
        gbFilter.SuspendLayout()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PrintDocument1
        ' 
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
        ' gbFilter
        ' 
        gbFilter.Controls.Add(Label1)
        gbFilter.Location = New Point(20, 60)
        gbFilter.Name = "gbFilter"
        gbFilter.Size = New Size(800, 75)
        gbFilter.TabIndex = 0
        gbFilter.TabStop = False
        gbFilter.Text = "Filter Periode"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 20)
        Label1.TabIndex = 0
        Label1.Text = "Dari :"
        ' 
        ' dtpMulai
        ' 
        dtpMulai.Format = DateTimePickerFormat.Short
        dtpMulai.Location = New Point(70, 29)
        dtpMulai.Name = "dtpMulai"
        dtpMulai.Size = New Size(150, 27)
        dtpMulai.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(240, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 20)
        Label2.TabIndex = 2
        Label2.Text = "s/d"
        ' 
        ' dtpSelesai
        ' 
        dtpSelesai.Format = DateTimePickerFormat.Short
        dtpSelesai.Location = New Point(280, 29)
        dtpSelesai.Name = "dtpSelesai"
        dtpSelesai.Size = New Size(150, 27)
        dtpSelesai.TabIndex = 3
        ' 
        ' btnFilter
        ' 
        btnFilter.Location = New Point(450, 26)
        btnFilter.Name = "btnFilter"
        btnFilter.Size = New Size(100, 30)
        btnFilter.TabIndex = 4
        btnFilter.Text = "Filter Data"
        btnFilter.UseVisualStyleBackColor = True
        ' 
        ' btnCetakLaporan
        ' 
        btnCetakLaporan.ForeColor = Color.Orange
        btnCetakLaporan.Location = New Point(650, 26)
        btnCetakLaporan.Name = "btnCetakLaporan"
        btnCetakLaporan.Size = New Size(130, 30)
        btnCetakLaporan.TabIndex = 5
        btnCetakLaporan.Text = "Cetak ke PDF"
        btnCetakLaporan.UseVisualStyleBackColor = True
        ' 
        ' dgvLaporan
        ' 
        dgvLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLaporan.Location = New Point(20, 150)
        dgvLaporan.Name = "dgvLaporan"
        dgvLaporan.RowHeadersWidth = 51
        dgvLaporan.Size = New Size(800, 350)
        dgvLaporan.TabIndex = 6
        ' 
        ' pnlSum
        ' 
        pnlSum.BackColor = Color.Gainsboro
        pnlSum.Location = New Point(20, 510)
        pnlSum.Name = "pnlSum"
        pnlSum.Size = New Size(800, 40)
        pnlSum.TabIndex = 7
        ' 
        ' lblTotalKantong
        ' 
        lblTotalKantong.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalKantong.Location = New Point(15, 10)
        lblTotalKantong.Name = "lblTotalKantong"
        lblTotalKantong.Size = New Size(400, 20)
        lblTotalKantong.TabIndex = 8
        lblTotalKantong.Text = "Total: 0 Kantong"
        ' 
        ' FormCetakLaporan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(832, 553)
        Controls.Add(lblTotalKantong)
        Controls.Add(pnlSum)
        Controls.Add(dgvLaporan)
        Controls.Add(btnCetakLaporan)
        Controls.Add(btnFilter)
        Controls.Add(dtpSelesai)
        Controls.Add(Label2)
        Controls.Add(dtpMulai)
        Controls.Add(gbFilter)
        Name = "FormCetakLaporan"
        Text = "Laporan Aktivitas Donor"
        gbFilter.ResumeLayout(False)
        gbFilter.PerformLayout()
        CType(dgvLaporan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents gbFilter As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpMulai As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpSelesai As DateTimePicker
    Friend WithEvents btnFilter As Button
    Friend WithEvents btnCetakLaporan As Button
    Friend WithEvents dgvLaporan As DataGridView
    Friend WithEvents pnlSum As Panel
    Friend WithEvents lblTotalKantong As Label
End Class