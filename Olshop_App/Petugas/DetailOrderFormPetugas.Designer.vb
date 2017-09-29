<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailOrderFormPetugas
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
        Me.lb_id = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_beli = New System.Windows.Forms.Label()
        Me.lbl_satuan = New System.Windows.Forms.Label()
        Me.lbl_jumlah = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_nama_pemesan = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_tanggal_order = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_no_hp = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_alamat = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_terima = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_petugas = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_id
        '
        Me.lb_id.AutoSize = True
        Me.lb_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_id.Location = New System.Drawing.Point(117, 25)
        Me.lb_id.Name = "lb_id"
        Me.lb_id.Size = New System.Drawing.Size(47, 13)
        Me.lb_id.TabIndex = 40
        Me.lb_id.Text = "asdasd"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "ID Order"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Maiandra GD", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(98, 16)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(56, 18)
        Me.lbl_total.TabIndex = 38
        Me.lbl_total.Text = "asdasd"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_beli
        '
        Me.lbl_beli.AutoSize = True
        Me.lbl_beli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_beli.Location = New System.Drawing.Point(87, 482)
        Me.lbl_beli.Name = "lbl_beli"
        Me.lbl_beli.Size = New System.Drawing.Size(66, 13)
        Me.lbl_beli.TabIndex = 36
        Me.lbl_beli.Text = "Harga Beli"
        '
        'lbl_satuan
        '
        Me.lbl_satuan.AutoSize = True
        Me.lbl_satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_satuan.Location = New System.Drawing.Point(87, 460)
        Me.lbl_satuan.Name = "lbl_satuan"
        Me.lbl_satuan.Size = New System.Drawing.Size(85, 13)
        Me.lbl_satuan.TabIndex = 35
        Me.lbl_satuan.Text = "Harga Satuan"
        '
        'lbl_jumlah
        '
        Me.lbl_jumlah.AutoSize = True
        Me.lbl_jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumlah.Location = New System.Drawing.Point(87, 437)
        Me.lbl_jumlah.Name = "lbl_jumlah"
        Me.lbl_jumlah.Size = New System.Drawing.Size(71, 13)
        Me.lbl_jumlah.TabIndex = 34
        Me.lbl_jumlah.Text = "Jumlah Beli"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(87, 413)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(83, 13)
        Me.lbl_nama.TabIndex = 33
        Me.lbl_nama.Text = "Nama Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Harga Beli"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Harga Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 437)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Jumlah Beli"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nama Barang"
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(12, 12)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(284, 239)
        Me.data_grid.TabIndex = 27
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Red
        Me.btn_logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(355, 390)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(146, 46)
        Me.btn_logout.TabIndex = 26
        Me.btn_logout.Text = "Batalkan Pesanan"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 257)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(282, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lbl_nama_pemesan
        '
        Me.lbl_nama_pemesan.AutoSize = True
        Me.lbl_nama_pemesan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama_pemesan.Location = New System.Drawing.Point(117, 47)
        Me.lbl_nama_pemesan.Name = "lbl_nama_pemesan"
        Me.lbl_nama_pemesan.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nama_pemesan.TabIndex = 42
        Me.lbl_nama_pemesan.Text = "asdasd"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Nama Pemesan"
        '
        'lbl_tanggal_order
        '
        Me.lbl_tanggal_order.AutoSize = True
        Me.lbl_tanggal_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal_order.Location = New System.Drawing.Point(117, 69)
        Me.lbl_tanggal_order.Name = "lbl_tanggal_order"
        Me.lbl_tanggal_order.Size = New System.Drawing.Size(47, 13)
        Me.lbl_tanggal_order.TabIndex = 44
        Me.lbl_tanggal_order.Text = "asdasd"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Tanggal Pemesanan"
        '
        'lbl_no_hp
        '
        Me.lbl_no_hp.AutoSize = True
        Me.lbl_no_hp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no_hp.Location = New System.Drawing.Point(117, 172)
        Me.lbl_no_hp.Name = "lbl_no_hp"
        Me.lbl_no_hp.Size = New System.Drawing.Size(47, 13)
        Me.lbl_no_hp.TabIndex = 50
        Me.lbl_no_hp.Text = "asdasd"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "No HP"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.Location = New System.Drawing.Point(117, 148)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(47, 13)
        Me.lbl_email.TabIndex = 48
        Me.lbl_email.Text = "asdasd"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 148)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Email"
        '
        'lbl_alamat
        '
        Me.lbl_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_alamat.Location = New System.Drawing.Point(117, 92)
        Me.lbl_alamat.Name = "lbl_alamat"
        Me.lbl_alamat.Size = New System.Drawing.Size(139, 56)
        Me.lbl_alamat.TabIndex = 46
        Me.lbl_alamat.Text = "asdasd"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Alamat"
        '
        'btn_terima
        '
        Me.btn_terima.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_terima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_terima.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_terima.Location = New System.Drawing.Point(355, 327)
        Me.btn_terima.Name = "btn_terima"
        Me.btn_terima.Size = New System.Drawing.Size(146, 46)
        Me.btn_terima.TabIndex = 51
        Me.btn_terima.Text = "Terima Pesanan"
        Me.btn_terima.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lb_id)
        Me.GroupBox1.Controls.Add(Me.lbl_no_hp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_nama_pemesan)
        Me.GroupBox1.Controls.Add(Me.lbl_email)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.lbl_tanggal_order)
        Me.GroupBox1.Controls.Add(Me.lbl_alamat)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 207)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Order"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_total)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(302, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 48)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(441, 492)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "ID Petugas"
        '
        'lbl_petugas
        '
        Me.lbl_petugas.AutoSize = True
        Me.lbl_petugas.Location = New System.Drawing.Point(507, 492)
        Me.lbl_petugas.Name = "lbl_petugas"
        Me.lbl_petugas.Size = New System.Drawing.Size(39, 13)
        Me.lbl_petugas.TabIndex = 55
        Me.lbl_petugas.Text = "Label6"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'DetailOrderFormPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 514)
        Me.Controls.Add(Me.lbl_petugas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_terima)
        Me.Controls.Add(Me.lbl_beli)
        Me.Controls.Add(Me.lbl_satuan)
        Me.Controls.Add(Me.lbl_jumlah)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.btn_logout)
        Me.Name = "DetailOrderFormPetugas"
        Me.Text = "DetailOrderFormPetugas"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb_id As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_beli As Label
    Friend WithEvents lbl_satuan As Label
    Friend WithEvents lbl_jumlah As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents btn_logout As Button
    Friend WithEvents lbl_nama_pemesan As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_tanggal_order As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_no_hp As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_alamat As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_terima As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_petugas As Label
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
