Public Class Form_MDI
    Private Sub FormInputBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormInputBToolStripMenuItem.Click
        Biodata_Pegawai.MdiParent = Me
        Biodata_Pegawai.Show()
        Biodata_Pegawai.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub PerhitanganGajiPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerhitanganGajiPegawaiToolStripMenuItem.Click
        Form_gajiPegawai.MdiParent = Me
        Form_gajiPegawai.Show()
        Form_gajiPegawai.Focus()




    End Sub
End Class