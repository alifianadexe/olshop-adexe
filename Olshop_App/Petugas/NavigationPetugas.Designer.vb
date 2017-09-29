<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NavigationPetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_barang = New System.Windows.Forms.Button()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_pembelian = New System.Windows.Forms.Button()
        Me.btn_dist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_log = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.lbl_tgl = New System.Windows.Forms.Label()
        Me.lbl_jabatan = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_barang
        '
        Me.btn_barang.Location = New System.Drawing.Point(6, 19)
        Me.btn_barang.Name = "btn_barang"
        Me.btn_barang.Size = New System.Drawing.Size(231, 56)
        Me.btn_barang.TabIndex = 0
        Me.btn_barang.Text = "Management Barang"
        Me.btn_barang.UseVisualStyleBackColor = True
        '
        'btn_order
        '
        Me.btn_order.Location = New System.Drawing.Point(6, 81)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(231, 56)
        Me.btn_order.TabIndex = 1
        Me.btn_order.Text = "Management Order"
        Me.btn_order.UseVisualStyleBackColor = True
        '
        'btn_pembelian
        '
        Me.btn_pembelian.Location = New System.Drawing.Point(243, 19)
        Me.btn_pembelian.Name = "btn_pembelian"
        Me.btn_pembelian.Size = New System.Drawing.Size(231, 56)
        Me.btn_pembelian.TabIndex = 2
        Me.btn_pembelian.Text = "Management Pembelian"
        Me.btn_pembelian.UseVisualStyleBackColor = True
        '
        'btn_dist
        '
        Me.btn_dist.Location = New System.Drawing.Point(243, 81)
        Me.btn_dist.Name = "btn_dist"
        Me.btn_dist.Size = New System.Drawing.Size(231, 56)
        Me.btn_dist.TabIndex = 3
        Me.btn_dist.Text = "Management Distributor"
        Me.btn_dist.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selamat Datang"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btn_barang)
        Me.GroupBox1.Controls.Add(Me.btn_order)
        Me.GroupBox1.Controls.Add(Me.btn_pembelian)
        Me.GroupBox1.Controls.Add(Me.btn_dist)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 206)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(231, 56)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Management User"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_id)
        Me.GroupBox2.Controls.Add(Me.lbl_tgl)
        Me.GroupBox2.Controls.Add(Me.lbl_jabatan)
        Me.GroupBox2.Controls.Add(Me.lbl_nama)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(476, 175)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Profile"
        '
        'lbl_log
        '
        Me.lbl_log.AutoSize = True
        Me.lbl_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_log.Location = New System.Drawing.Point(78, 450)
        Me.lbl_log.Name = "lbl_log"
        Me.lbl_log.Size = New System.Drawing.Size(71, 13)
        Me.lbl_log.TabIndex = 15
        Me.lbl_log.Text = "Username :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 450)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID Log : "
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(239, 19)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(28, 13)
        Me.lbl_id.TabIndex = 13
        Me.lbl_id.Text = "ID :"
        '
        'lbl_tgl
        '
        Me.lbl_tgl.AutoSize = True
        Me.lbl_tgl.Location = New System.Drawing.Point(239, 89)
        Me.lbl_tgl.Name = "lbl_tgl"
        Me.lbl_tgl.Size = New System.Drawing.Size(81, 13)
        Me.lbl_tgl.TabIndex = 12
        Me.lbl_tgl.Text = "Tanggal Login :"
        '
        'lbl_jabatan
        '
        Me.lbl_jabatan.AutoSize = True
        Me.lbl_jabatan.Location = New System.Drawing.Point(239, 66)
        Me.lbl_jabatan.Name = "lbl_jabatan"
        Me.lbl_jabatan.Size = New System.Drawing.Size(51, 13)
        Me.lbl_jabatan.TabIndex = 11
        Me.lbl_jabatan.Text = "Jabatan :"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Location = New System.Drawing.Point(239, 42)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(41, 13)
        Me.lbl_nama.TabIndex = 10
        Me.lbl_nama.Text = "Nama :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tanggal Login :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Jabatan :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(17, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Firebrick
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(374, 440)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(120, 32)
        Me.btn_logout.TabIndex = 8
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'NavigationPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_log)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NavigationPetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NavigationPetugas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_barang As Button
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_pembelian As Button
    Friend WithEvents btn_dist As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_logout As Button
    Friend WithEvents lbl_id As Label
    Friend WithEvents lbl_tgl As Label
    Friend WithEvents lbl_jabatan As Label
    Friend WithEvents lbl_nama As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_log As Label
    Friend WithEvents Label6 As Label
End Class
