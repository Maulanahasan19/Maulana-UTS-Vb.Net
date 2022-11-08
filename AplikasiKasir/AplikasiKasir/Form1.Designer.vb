<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbPerempuan = New System.Windows.Forms.RadioButton()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.CmbNoMeja = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckSateAyam = New System.Windows.Forms.CheckBox()
        Me.CheckNasiBebek = New System.Windows.Forms.CheckBox()
        Me.CheckNasiCapcay = New System.Windows.Forms.CheckBox()
        Me.CheckNasiGoreng = New System.Windows.Forms.CheckBox()
        Me.CheckMieRebus = New System.Windows.Forms.CheckBox()
        Me.CheckMieGoreng = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Kasir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Customer"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nomor Meja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Menu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tanggal Pembayaran"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(127, 50)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(200, 20)
        Me.TxtNama.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPerempuan)
        Me.GroupBox1.Controls.Add(Me.RbLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 50)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan"
        '
        'RbPerempuan
        '
        Me.RbPerempuan.AutoSize = True
        Me.RbPerempuan.Location = New System.Drawing.Point(90, 23)
        Me.RbPerempuan.Name = "RbPerempuan"
        Me.RbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.RbPerempuan.TabIndex = 0
        Me.RbPerempuan.TabStop = True
        Me.RbPerempuan.Text = "Perempuan"
        Me.RbPerempuan.UseVisualStyleBackColor = True
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Location = New System.Drawing.Point(10, 23)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(74, 17)
        Me.RbLaki.TabIndex = 0
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki - Laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'CmbNoMeja
        '
        Me.CmbNoMeja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNoMeja.FormattingEnabled = True
        Me.CmbNoMeja.Items.AddRange(New Object() {"Meja 1", "Meja 2", "Meja 3", "Meja 4", "Meja 5", "Meja 6", "Meja 7", "Meja 8", "Meja 9", "Meja 10"})
        Me.CmbNoMeja.Location = New System.Drawing.Point(127, 135)
        Me.CmbNoMeja.Name = "CmbNoMeja"
        Me.CmbNoMeja.Size = New System.Drawing.Size(200, 21)
        Me.CmbNoMeja.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckSateAyam)
        Me.GroupBox2.Controls.Add(Me.CheckNasiBebek)
        Me.GroupBox2.Controls.Add(Me.CheckNasiCapcay)
        Me.GroupBox2.Controls.Add(Me.CheckNasiGoreng)
        Me.GroupBox2.Controls.Add(Me.CheckMieRebus)
        Me.GroupBox2.Controls.Add(Me.CheckMieGoreng)
        Me.GroupBox2.Location = New System.Drawing.Point(127, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilihan"
        '
        'CheckSateAyam
        '
        Me.CheckSateAyam.AutoSize = True
        Me.CheckSateAyam.Location = New System.Drawing.Point(107, 65)
        Me.CheckSateAyam.Name = "CheckSateAyam"
        Me.CheckSateAyam.Size = New System.Drawing.Size(77, 17)
        Me.CheckSateAyam.TabIndex = 0
        Me.CheckSateAyam.Text = "Sate Ayam"
        Me.CheckSateAyam.UseVisualStyleBackColor = True
        '
        'CheckNasiBebek
        '
        Me.CheckNasiBebek.AutoSize = True
        Me.CheckNasiBebek.Location = New System.Drawing.Point(107, 42)
        Me.CheckNasiBebek.Name = "CheckNasiBebek"
        Me.CheckNasiBebek.Size = New System.Drawing.Size(81, 17)
        Me.CheckNasiBebek.TabIndex = 0
        Me.CheckNasiBebek.Text = "Nasi Bebek"
        Me.CheckNasiBebek.UseVisualStyleBackColor = True
        '
        'CheckNasiCapcay
        '
        Me.CheckNasiCapcay.AutoSize = True
        Me.CheckNasiCapcay.Location = New System.Drawing.Point(107, 19)
        Me.CheckNasiCapcay.Name = "CheckNasiCapcay"
        Me.CheckNasiCapcay.Size = New System.Drawing.Size(86, 17)
        Me.CheckNasiCapcay.TabIndex = 0
        Me.CheckNasiCapcay.Text = "Nasi Capcay"
        Me.CheckNasiCapcay.UseVisualStyleBackColor = True
        '
        'CheckNasiGoreng
        '
        Me.CheckNasiGoreng.AutoSize = True
        Me.CheckNasiGoreng.Location = New System.Drawing.Point(10, 65)
        Me.CheckNasiGoreng.Name = "CheckNasiGoreng"
        Me.CheckNasiGoreng.Size = New System.Drawing.Size(85, 17)
        Me.CheckNasiGoreng.TabIndex = 0
        Me.CheckNasiGoreng.Text = "Nasi Goreng"
        Me.CheckNasiGoreng.UseVisualStyleBackColor = True
        '
        'CheckMieRebus
        '
        Me.CheckMieRebus.AutoSize = True
        Me.CheckMieRebus.Location = New System.Drawing.Point(10, 42)
        Me.CheckMieRebus.Name = "CheckMieRebus"
        Me.CheckMieRebus.Size = New System.Drawing.Size(77, 17)
        Me.CheckMieRebus.TabIndex = 0
        Me.CheckMieRebus.Text = "Mie Rebus"
        Me.CheckMieRebus.UseVisualStyleBackColor = True
        '
        'CheckMieGoreng
        '
        Me.CheckMieGoreng.AutoSize = True
        Me.CheckMieGoreng.Location = New System.Drawing.Point(10, 19)
        Me.CheckMieGoreng.Name = "CheckMieGoreng"
        Me.CheckMieGoreng.Size = New System.Drawing.Size(81, 17)
        Me.CheckMieGoreng.TabIndex = 0
        Me.CheckMieGoreng.Text = "Mie Goreng"
        Me.CheckMieGoreng.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 272)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 43)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 371)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmbNoMeja)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Kasir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents CmbNoMeja As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckSateAyam As System.Windows.Forms.CheckBox
    Friend WithEvents CheckNasiBebek As System.Windows.Forms.CheckBox
    Friend WithEvents CheckNasiCapcay As System.Windows.Forms.CheckBox
    Friend WithEvents CheckNasiGoreng As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMieRebus As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMieGoreng As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
