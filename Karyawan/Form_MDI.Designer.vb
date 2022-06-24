<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BiodataPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormInputBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerhitanganGajiPegawaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BiodataPegawaiToolStripMenuItem, Me.PerhitanganGajiPegawaiToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BiodataPegawaiToolStripMenuItem
        '
        Me.BiodataPegawaiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormInputBToolStripMenuItem})
        Me.BiodataPegawaiToolStripMenuItem.Name = "BiodataPegawaiToolStripMenuItem"
        Me.BiodataPegawaiToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.BiodataPegawaiToolStripMenuItem.Text = "Biodata Pegawai"
        '
        'FormInputBToolStripMenuItem
        '
        Me.FormInputBToolStripMenuItem.Name = "FormInputBToolStripMenuItem"
        Me.FormInputBToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.FormInputBToolStripMenuItem.Text = "Form Input Biodata Pegawai"
        '
        'PerhitanganGajiPegawaiToolStripMenuItem
        '
        Me.PerhitanganGajiPegawaiToolStripMenuItem.Name = "PerhitanganGajiPegawaiToolStripMenuItem"
        Me.PerhitanganGajiPegawaiToolStripMenuItem.Size = New System.Drawing.Size(153, 20)
        Me.PerhitanganGajiPegawaiToolStripMenuItem.Text = "Perhitangan Gaji Pegawai"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Form_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_MDI"
        Me.Text = "Form_MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BiodataPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormInputBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerhitanganGajiPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
