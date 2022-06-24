Public Class Form_gajiPegawai

    Dim gajipokok, pajak, total, tunjanganAnak, tunjanganJabatan, lamaKerja, totalGaji As Integer
    Dim hasil As New Hasil_formGajiPegawai
    Dim detail As New Detail_gajiPegawai



    Private Sub Form_gajiPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1A")
        ComboBox1.Items.Add("1B")
        ComboBox1.Items.Add("2A")
        ComboBox1.Items.Add("2B")
        ComboBox1.Items.Add("3A")
        ComboBox1.Items.Add("3B")

        ComboBox2.Items.Add("1")
        ComboBox2.Items.Add("2")
        ComboBox2.Items.Add("3")

        ComboBox3.Items.Add("2")
        ComboBox3.Items.Add("3")
        ComboBox3.Items.Add("4")
        ComboBox3.Items.Add("5")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label4.Enabled = True
        ComboBox3.Enabled = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label4.Enabled = False
        ComboBox3.Enabled = False
        ComboBox3.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = String.Empty Then
            MsgBox("Silahkan Isi NIK Pegawai Terlebih Dahulu", MsgBoxStyle.Information, "pemberitahuan")
        Else
            If ComboBox1.SelectedItem = "1A" Then
                gajipokok = 2000000
            ElseIf ComboBox1.SelectedItem = "1B" Then
                gajipokok = 2200000
            ElseIf ComboBox1.SelectedItem = "2A" Then
                gajipokok = 2800000
            ElseIf ComboBox1.SelectedItem = "2B" Then
                gajipokok = 3300000
            ElseIf ComboBox1.SelectedItem = "3A" Then
                gajipokok = 3600000
            ElseIf ComboBox1.SelectedItem = "3B" Then
                gajipokok = 4000000
            End If

            If ComboBox2.SelectedItem = "1" Then
                tunjanganAnak = 200000
            ElseIf ComboBox2.SelectedItem = "2" Then
                tunjanganAnak = 400000
            ElseIf ComboBox2.SelectedItem = "3" Then
                tunjanganAnak = 600000
            End If

            If ComboBox3.Enabled = True Then
                If ComboBox3.SelectedItem = "2" Then
                    lamaKerja = 2
                ElseIf ComboBox3.SelectedItem = "3" Then
                    lamaKerja = 3
                ElseIf ComboBox3.SelectedItem = "4" Then
                    lamaKerja = 4
                ElseIf ComboBox3.SelectedItem = "5" Then
                    lamaKerja = 5
                End If

            Else
                lamaKerja = 0
                End If

            If RadioButton1.Checked Then
                tunjanganJabatan = (10 / 100 * gajipokok) * lamaKerja
            Else
                tunjanganJabatan = 0
            End If

            total = (gajipokok + tunjanganJabatan + tunjanganAnak)
            pajak = 5 / 100 * total
            totalGaji = total - pajak


            hasil.Label1.Text = "Total Gaji Pegawai Dengan NIK : " + TextBox1.Text
            hasil.Label2.Text = "Rp. " + totalGaji.ToString
            hasil.Button1.Text = "Detail Gaji"

            detail.Label8.Text = "Rp. " + gajipokok.ToString
            detail.Label9.Text = "Rp. " + tunjanganAnak.ToString
            detail.Label10.Text = lamaKerja.ToString + " Tahun"
            detail.Label11.Text = "Rp. " + tunjanganJabatan.ToString
            detail.Label12.Text = "Rp. " + total.ToString
            detail.Label13.Text = "Rp. " + pajak.ToString
            detail.Label14.Text = "Rp. " + totalGaji.ToString
            detail.Button1.Text = "Close"


            hasil.ShowDialog()
            detail.ShowDialog()
        End If

    End Sub
End Class