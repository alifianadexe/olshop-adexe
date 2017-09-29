<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementBarang
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
        Me.components = New System.ComponentModel.Container()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_deleye = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_sve = New System.Windows.Forms.Button()
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.data_grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_kategori = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_distributor = New System.Windows.Forms.ComboBox()
        Me.TbldistributorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbolshopDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_olshopDataSet = New Olshop_App.db_olshopDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_jumlah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_harga = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tbl_distributorTableAdapter = New Olshop_App.db_olshopDataSetTableAdapters.tbl_distributorTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TbldistributorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbolshopDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_olshopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(433, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Search"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(482, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 41
        '
        'btn_deleye
        '
        Me.btn_deleye.Location = New System.Drawing.Point(589, 182)
        Me.btn_deleye.Name = "btn_deleye"
        Me.btn_deleye.Size = New System.Drawing.Size(110, 47)
        Me.btn_deleye.TabIndex = 3
        Me.btn_deleye.Text = "Delete"
        Me.btn_deleye.UseVisualStyleBackColor = True
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(589, 130)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(110, 47)
        Me.btn_edit.TabIndex = 2
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'btn_sve
        '
        Me.btn_sve.Location = New System.Drawing.Point(589, 77)
        Me.btn_sve.Name = "btn_sve"
        Me.btn_sve.Size = New System.Drawing.Size(110, 47)
        Me.btn_sve.TabIndex = 1
        Me.btn_sve.Text = "Save"
        Me.btn_sve.UseVisualStyleBackColor = True
        '
        'btn_tambah
        '
        Me.btn_tambah.Location = New System.Drawing.Point(589, 25)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(110, 47)
        Me.btn_tambah.TabIndex = 0
        Me.btn_tambah.Text = "Tambah"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'data_grid
        '
        Me.data_grid.AllowUserToAddRows = False
        Me.data_grid.AllowUserToDeleteRows = False
        Me.data_grid.AllowUserToOrderColumns = True
        Me.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_grid.Location = New System.Drawing.Point(14, 261)
        Me.data_grid.Name = "data_grid"
        Me.data_grid.ReadOnly = True
        Me.data_grid.Size = New System.Drawing.Size(689, 255)
        Me.data_grid.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.btn_browse)
        Me.GroupBox2.Location = New System.Drawing.Point(346, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 204)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Picture"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Olshop_App.My.Resources.Resources.anonymous_user_profile
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'btn_browse
        '
        Me.btn_browse.Enabled = False
        Me.btn_browse.Location = New System.Drawing.Point(6, 175)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(175, 23)
        Me.btn_browse.TabIndex = 0
        Me.btn_browse.Text = "Browser"
        Me.btn_browse.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_kategori)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_distributor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_nama)
        Me.GroupBox1.Controls.Add(Me.txt_jumlah)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_harga)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 187)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Barang"
        '
        'txt_kategori
        '
        Me.txt_kategori.Enabled = False
        Me.txt_kategori.FormattingEnabled = True
        Me.txt_kategori.Items.AddRange(New Object() {"Makanan", "Pakaian", "Elektronik", "Furniture", ""})
        Me.txt_kategori.Location = New System.Drawing.Point(94, 123)
        Me.txt_kategori.Name = "txt_kategori"
        Me.txt_kategori.Size = New System.Drawing.Size(214, 21)
        Me.txt_kategori.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "ID Barang"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(94, 19)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(138, 20)
        Me.txt_id.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Distributor"
        '
        'txt_distributor
        '
        Me.txt_distributor.DataSource = Me.TbldistributorBindingSource
        Me.txt_distributor.DisplayMember = "nama_distributor"
        Me.txt_distributor.Enabled = False
        Me.txt_distributor.FormattingEnabled = True
        Me.txt_distributor.Location = New System.Drawing.Point(94, 150)
        Me.txt_distributor.Name = "txt_distributor"
        Me.txt_distributor.Size = New System.Drawing.Size(214, 21)
        Me.txt_distributor.TabIndex = 5
        Me.txt_distributor.ValueMember = "id_distributor"
        '
        'TbldistributorBindingSource
        '
        Me.TbldistributorBindingSource.DataMember = "tbl_distributor"
        Me.TbldistributorBindingSource.DataSource = Me.DbolshopDataSetBindingSource
        '
        'DbolshopDataSetBindingSource
        '
        Me.DbolshopDataSetBindingSource.DataSource = Me.Db_olshopDataSet
        Me.DbolshopDataSetBindingSource.Position = 0
        '
        'Db_olshopDataSet
        '
        Me.Db_olshopDataSet.DataSetName = "db_olshopDataSet"
        Me.Db_olshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama Barang"
        '
        'txt_nama
        '
        Me.txt_nama.Enabled = False
        Me.txt_nama.Location = New System.Drawing.Point(94, 46)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(214, 20)
        Me.txt_nama.TabIndex = 1
        '
        'txt_jumlah
        '
        Me.txt_jumlah.Enabled = False
        Me.txt_jumlah.Location = New System.Drawing.Point(94, 72)
        Me.txt_jumlah.Name = "txt_jumlah"
        Me.txt_jumlah.Size = New System.Drawing.Size(61, 20)
        Me.txt_jumlah.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jumlah Barang"
        '
        'txt_harga
        '
        Me.txt_harga.Enabled = False
        Me.txt_harga.Location = New System.Drawing.Point(94, 98)
        Me.txt_harga.Name = "txt_harga"
        Me.txt_harga.Size = New System.Drawing.Size(138, 20)
        Me.txt_harga.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Harga Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Kategori"
        '
        'Tbl_distributorTableAdapter
        '
        Me.Tbl_distributorTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ManagementBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 533)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_deleye)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_sve)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.data_grid)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ManagementBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagementBarang"
        CType(Me.data_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TbldistributorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbolshopDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_olshopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_deleye As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_sve As Button
    Friend WithEvents btn_tambah As Button
    Friend WithEvents data_grid As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_browse As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_distributor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_jumlah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_harga As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_kategori As ComboBox
    Friend WithEvents DbolshopDataSetBindingSource As BindingSource
    Friend WithEvents Db_olshopDataSet As db_olshopDataSet
    Friend WithEvents TbldistributorBindingSource As BindingSource
    Friend WithEvents Tbl_distributorTableAdapter As db_olshopDataSetTableAdapters.tbl_distributorTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
