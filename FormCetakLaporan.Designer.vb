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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(50, 50)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(200, 50)
        Me.btnCetak.Text = "Cetak Laporan Stok"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'FormCetakLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 150)
        Me.Controls.Add(Me.btnCetak)
        Me.Name = "FormCetakLaporan"
        Me.Text = "Cetak Laporan"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnCetak As System.Windows.Forms.Button
End Class