<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertproduct_a190409
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertproduct_a190409))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.pic_updatebutton = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.pic_refreshbutton = New System.Windows.Forms.PictureBox()
        Me.pic_buttonuploadpic = New System.Windows.Forms.PictureBox()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.pic_search = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_directory = New System.Windows.Forms.Label()
        Me.txt_directory = New System.Windows.Forms.TextBox()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pic_white = New System.Windows.Forms.PictureBox()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_updatebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_buttonuploadpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_background
        '
        Me.pic_background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_background.Image = CType(resources.GetObject("pic_background.Image"), System.Drawing.Image)
        Me.pic_background.Location = New System.Drawing.Point(0, 102)
        Me.pic_background.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_background.Name = "pic_background"
        Me.pic_background.Size = New System.Drawing.Size(1877, 899)
        Me.pic_background.TabIndex = 24
        Me.pic_background.TabStop = False
        '
        'pic_updatebutton
        '
        Me.pic_updatebutton.BackColor = System.Drawing.Color.White
        Me.pic_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_updatebutton.Image = CType(resources.GetObject("pic_updatebutton.Image"), System.Drawing.Image)
        Me.pic_updatebutton.Location = New System.Drawing.Point(1792, 20)
        Me.pic_updatebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_updatebutton.Name = "pic_updatebutton"
        Me.pic_updatebutton.Size = New System.Drawing.Size(71, 65)
        Me.pic_updatebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_updatebutton.TabIndex = 59
        Me.pic_updatebutton.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(665, 20)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(404, 75)
        Me.lbl_title.TabIndex = 58
        Me.lbl_title.Text = "Insert Product"
        '
        'grd_products
        '
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_products.BackgroundColor = System.Drawing.Color.Indigo
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(568, 114)
        Me.grd_products.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.Size = New System.Drawing.Size(1293, 798)
        Me.grd_products.TabIndex = 60
        '
        'pic_refreshbutton
        '
        Me.pic_refreshbutton.BackColor = System.Drawing.SystemColors.Control
        Me.pic_refreshbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_refreshbutton.Image = CType(resources.GetObject("pic_refreshbutton.Image"), System.Drawing.Image)
        Me.pic_refreshbutton.Location = New System.Drawing.Point(517, 114)
        Me.pic_refreshbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_refreshbutton.Name = "pic_refreshbutton"
        Me.pic_refreshbutton.Size = New System.Drawing.Size(41, 39)
        Me.pic_refreshbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_refreshbutton.TabIndex = 90
        Me.pic_refreshbutton.TabStop = False
        '
        'pic_buttonuploadpic
        '
        Me.pic_buttonuploadpic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_buttonuploadpic.Image = CType(resources.GetObject("pic_buttonuploadpic.Image"), System.Drawing.Image)
        Me.pic_buttonuploadpic.Location = New System.Drawing.Point(405, 114)
        Me.pic_buttonuploadpic.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_buttonuploadpic.Name = "pic_buttonuploadpic"
        Me.pic_buttonuploadpic.Size = New System.Drawing.Size(68, 62)
        Me.pic_buttonuploadpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_buttonuploadpic.TabIndex = 89
        Me.pic_buttonuploadpic.TabStop = False
        '
        'pic_product
        '
        Me.pic_product.BackColor = System.Drawing.Color.White
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_product.Cursor = System.Windows.Forms.Cursors.Default
        Me.pic_product.Location = New System.Drawing.Point(110, 114)
        Me.pic_product.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(287, 282)
        Me.pic_product.TabIndex = 88
        Me.pic_product.TabStop = False
        '
        'pic_search
        '
        Me.pic_search.Location = New System.Drawing.Point(5, 417)
        Me.pic_search.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_search.Name = "pic_search"
        Me.pic_search.Size = New System.Drawing.Size(555, 52)
        Me.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_search.TabIndex = 91
        Me.pic_search.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(3, 491)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(555, 421)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 92
        Me.PictureBox2.TabStop = False
        '
        'lbl_directory
        '
        Me.lbl_directory.AutoSize = True
        Me.lbl_directory.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_directory.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_directory.Location = New System.Drawing.Point(13, 431)
        Me.lbl_directory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_directory.Name = "lbl_directory"
        Me.lbl_directory.Size = New System.Drawing.Size(122, 34)
        Me.lbl_directory.TabIndex = 94
        Me.lbl_directory.Text = "Directory"
        '
        'txt_directory
        '
        Me.txt_directory.Location = New System.Drawing.Point(148, 435)
        Me.txt_directory.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_directory.Name = "txt_directory"
        Me.txt_directory.Size = New System.Drawing.Size(392, 22)
        Me.txt_directory.TabIndex = 93
        '
        'btn_done
        '
        Me.btn_done.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done.Location = New System.Drawing.Point(3, 931)
        Me.btn_done.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(1856, 42)
        Me.btn_done.TabIndex = 102
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(226, 856)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(119, 42)
        Me.btn_insert.TabIndex = 101
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(149, 812)
        Me.txt_warranty.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(392, 22)
        Me.txt_warranty.TabIndex = 100
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(149, 761)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(392, 22)
        Me.txt_quantity.TabIndex = 99
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(149, 709)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(392, 22)
        Me.txt_brand.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 804)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 34)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Warranty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 754)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 34)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 702)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 34)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Brand"
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(149, 613)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(392, 22)
        Me.txt_price.TabIndex = 110
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(149, 662)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(392, 22)
        Me.txt_type.TabIndex = 109
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(149, 563)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(392, 22)
        Me.txt_name.TabIndex = 108
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(149, 514)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(392, 22)
        Me.txt_id.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 655)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 34)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 606)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 34)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 555)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 34)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 506)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 34)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "ID"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pic_white
        '
        Me.pic_white.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_white.Image = CType(resources.GetObject("pic_white.Image"), System.Drawing.Image)
        Me.pic_white.Location = New System.Drawing.Point(0, 0)
        Me.pic_white.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_white.Name = "pic_white"
        Me.pic_white.Size = New System.Drawing.Size(1877, 102)
        Me.pic_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_white.TabIndex = 111
        Me.pic_white.TabStop = False
        '
        'frm_insertproduct_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1877, 1001)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_directory)
        Me.Controls.Add(Me.txt_directory)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.pic_search)
        Me.Controls.Add(Me.pic_refreshbutton)
        Me.Controls.Add(Me.pic_buttonuploadpic)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.pic_updatebutton)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_background)
        Me.Controls.Add(Me.pic_white)
        Me.Name = "frm_insertproduct_a190409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_insertproduct_a190409"
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_updatebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_buttonuploadpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_background As PictureBox
    Friend WithEvents pic_updatebutton As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents pic_refreshbutton As PictureBox
    Friend WithEvents pic_buttonuploadpic As PictureBox
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents pic_search As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_directory As Label
    Friend WithEvents txt_directory As TextBox
    Friend WithEvents btn_done As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pic_white As PictureBox
End Class
