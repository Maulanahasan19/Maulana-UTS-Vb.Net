Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'menentukan format tanggal
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim JK As String
        Dim Menu As String
        Dim MieRebus, MieGoreng, NasiGoreng, NasiCapcay, NasiBebek, SateAyam As Integer
        Dim Jumlah As String

        'menentukan jenis kelamin
        If RbLaki.Checked = True Then
            JK = RbLaki.Text
        Else
            JK = RbPerempuan.Text
        End If

        'menentukan menu yang dipilih dan harga menu
        If CheckMieRebus.Checked = True Then
            Menu = Menu & CheckMieRebus.Text & ", "
            MieRebus = "10000"
        End If
        If CheckMieGoreng.Checked = True Then
            Menu = Menu & CheckMieGoreng.Text & ", "
            MieGoreng = "10000"
        End If
        If CheckNasiGoreng.Checked = True Then
            Menu = Menu & CheckNasiGoreng.Text & ", "
            NasiGoreng = "15000"
        End If
        If CheckNasiCapcay.Checked = True Then
            Menu = Menu & CheckNasiCapcay.Text & ", "
            NasiCapcay = "17000"
        End If
        If CheckSateAyam.Checked = True Then
            Menu = Menu & CheckSateAyam.Text & ", "
            SateAyam = "12000"
        End If

        'menghitung jumlah menu yg dibayar
        Jumlah = "Rp. " & MieRebus + MieGoreng + NasiGoreng + NasiCapcay + NasiBebek + SateAyam

        'menampilkan hasil pengisian
        MessageBox.Show("Nama Customer : " & TxtNama.Text & vbCrLf & "Jenis Kelamin : " & JK & vbCrLf & "Nomor : " & CmbNoMeja.Text & vbCrLf & "Pilihan Menu : " & Menu & vbCrLf & "Total : " & Jumlah & vbCrLf & "Tanggal Pembayaran : " & DateTimePicker1.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtNama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNama.KeyDown
        'validasi hanya huruf
        If e.KeyCode = 48 Or e.KeyCode = 49 Or e.KeyCode = 50 Or e.KeyCode = 51 Or e.KeyCode = 52 Or e.KeyCode = 53 Or e.KeyCode = 54 Or e.KeyCode = 55 Or e.KeyCode = 56 Or e.KeyCode = 57 Then
            TxtNama.ReadOnly = True
        Else
            TxtNama.ReadOnly = False
        End If
    End Sub

End Class
