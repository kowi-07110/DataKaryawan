Public Class Biodata_Pegawai

    Dim mymsgbox As New Hasil_BiodataPegawai



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Biodata_Pegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Islam")
        ComboBox1.Items.Add("Kristen")
        ComboBox1.Items.Add("Protestan")
        ComboBox1.Items.Add("Hindu")
        ComboBox1.Items.Add("Buddha")

        ComboBox2.Items.Add("A")
        ComboBox2.Items.Add("B")
        ComboBox2.Items.Add("AB")
        ComboBox2.Items.Add("O")

        ComboBox3.Items.Add("Production")
        ComboBox3.Items.Add("Human Resources Management")
        ComboBox3.Items.Add("Finance and Accounting")
        ComboBox3.Items.Add("Information Technology")

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Production" Then
            RadioButton3.Text = "Operator Produksi"
            RadioButton4.Text = "Leader Produksi"
            RadioButton5.Text = "Foreman Produksi"
            RadioButton6.Text = "Supervisor Produksi"
        ElseIf ComboBox3.SelectedItem = "Human Resources Management" Then
            RadioButton3.Text = "Payroll Staff"
            RadioButton4.Text = "Welfare Staff"
            RadioButton5.Text = "Non Material Warehouse Staff"
            RadioButton6.Text = "General Affair Supervisor"
        ElseIf ComboBox3.SelectedItem = "Finance and Accounting" Then
            RadioButton3.Text = "Manajer Keuangan"
            RadioButton4.Text = "Administrasi"
            RadioButton5.Text = "Akutansi"
            RadioButton6.Text = "Asuransi"
        ElseIf ComboBox3.SelectedItem = "Information Technology" Then
            RadioButton3.Text = "Programer"
            RadioButton4.Text = "Full Stack Developer"
            RadioButton5.Text = "Cloud Computing Engineering"
            RadioButton6.Text = "UI/UX Designer"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        RadioButton3.Checked = False
        RadioButton3.Text = "Jabatan 1"
        RadioButton4.Checked = False
        RadioButton4.Text = "Jabatan 2"
        RadioButton5.Checked = False
        RadioButton5.Text = "Jabatan 3"
        RadioButton6.Checked = False
        RadioButton6.Text = "Jabatan 4"
        L.Checked = False
        P.Checked = False
        RichTextBox1.Text = ""
        PictureBox1.ImageLocation = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "*.jpg, *.png|"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.ImageLocation = OpenFileDialog1.FileName
            mymsgbox.foto.load(Me.OpenFileDialog1.FileName)
        End If

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage



    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim cb1, cb2, cb3, jns, rb As String

        mymsgbox.Label1.Text = TextBox2.Text
        mymsgbox.Label10.Text = TextBox1.Text


        If TextBox1.Text = String.Empty Or TextBox2.Text = String.Empty Then
            MsgBox("Silahkan Isi Data Terlebih Dahulu", MsgBoxStyle.Information, "Pemberitahuan")


        Else
            If ComboBox1.SelectedItem = "Islam" Then
                cb1 &= ComboBox1.Text
            ElseIf ComboBox1.SelectedItem = "Kristen" Then
                cb1 &= ComboBox1.Text
            ElseIf ComboBox1.SelectedItem = "Protestan" Then
                cb1 &= ComboBox1.Text
            ElseIf ComboBox1.SelectedItem = "Hindu" Then
                cb1 &= ComboBox1.Text
            ElseIf ComboBox1.SelectedItem = "Buddha" Then
                cb1 &= ComboBox1.Text
            End If

            If ComboBox2.SelectedItem = "A" Then
                cb2 &= ComboBox2.Text
            ElseIf ComboBox2.SelectedItem = "B" Then
                cb2 &= ComboBox2.Text
            ElseIf ComboBox2.SelectedItem = "AB" Then
                cb2 &= ComboBox2.Text
            ElseIf ComboBox2.SelectedItem = "O" Then
                cb2 &= ComboBox2.Text
            End If


            If ComboBox3.SelectedItem = "Production" Then
                cb3 &= ComboBox3.Text
            ElseIf ComboBox3.SelectedItem = "Human Resources Management" Then
                cb3 &= ComboBox3.Text
            ElseIf ComboBox3.SelectedItem = "Finance and Accounting" Then
                cb3 &= ComboBox3.Text
            ElseIf ComboBox3.SelectedItem = "Information Technology" Then
                cb3 &= ComboBox3.Text
            End If


            If L.Checked Then
                jns &= L.Text
            End If
            If P.Checked Then
                jns &= P.Text
            End If

            If RadioButton3.Checked Then
                rb &= RadioButton3.Text
            ElseIf RadioButton4.Checked Then
                rb &= RadioButton4.Text
            ElseIf RadioButton5.Checked Then
                rb &= RadioButton5.Text
            ElseIf RadioButton6.Checked Then
                rb &= RadioButton6.Text
            End If

            mymsgbox.Label11.Text = jns
            mymsgbox.Label12.Text = cb1
            mymsgbox.Label13.Text = RichTextBox1.Text
            mymsgbox.Label14.Text = cb2
            mymsgbox.Label15.Text = cb3
            mymsgbox.Label16.Text = rb
            mymsgbox.Label17.Text = "Data Pegawai Dengan NIK: " + TextBox1.Text
            mymsgbox.Button1.Text = "Close"
            mymsgbox.foto.SizeMode = PictureBoxSizeMode.StretchImage
            mymsgbox.ShowDialog()


















        End If


    End Sub
End Class