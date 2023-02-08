<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_a190409
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updateproduct_a190409))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.pic_refreshbutton = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_white = New System.Windows.Forms.PictureBox()
        Me.grd_products = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.txt_warranty = New System.Windows.Forms.TextBox()
        Me.txt_quantity = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_addbutton = New System.Windows.Forms.PictureBox()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_addbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_background
        '
        Me.pic_background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_background.Image = CType(resources.GetObject("pic_background.Image"), System.Drawing.Image)
        Me.pic_background.Location = New System.Drawing.Point(0, 0)
        Me.pic_background.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_background.Name = "pic_background"
        Me.pic_background.Size = New System.Drawing.Size(1924, 610)
        Me.pic_background.TabIndex = 59
        Me.pic_background.TabStop = False
        '
        'pic_refreshbutton
        '
        Me.pic_refreshbutton.BackColor = System.Drawing.SystemColors.Control
        Me.pic_refreshbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_refreshbutton.Image = CType(resources.GetObject("pic_refreshbutton.Image"), System.Drawing.Image)
        Me.pic_refreshbutton.Location = New System.Drawing.Point(579, 111)
        Me.pic_refreshbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_refreshbutton.Name = "pic_refreshbutton"
        Me.pic_refreshbutton.Size = New System.Drawing.Size(41, 39)
        Me.pic_refreshbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_refreshbutton.TabIndex = 91
        Me.pic_refreshbutton.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(577, 21)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(739, 75)
        Me.lbl_title.TabIndex = 89
        Me.lbl_title.Text = "Update and Delete Product"
        '
        'pic_white
        '
        Me.pic_white.Image = CType(resources.GetObject("pic_white.Image"), System.Drawing.Image)
        Me.pic_white.Location = New System.Drawing.Point(0, 0)
        Me.pic_white.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_white.Name = "pic_white"
        Me.pic_white.Size = New System.Drawing.Size(1964, 102)
        Me.pic_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_white.TabIndex = 90
        Me.pic_white.TabStop = False
        '
        'grd_products
        '
        Me.grd_products.AllowUserToAddRows = False
        Me.grd_products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_products.BackgroundColor = System.Drawing.Color.Indigo
        Me.grd_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_products.Location = New System.Drawing.Point(628, 111)
        Me.grd_products.Margin = New System.Windows.Forms.Padding(4)
        Me.grd_products.Name = "grd_products"
        Me.grd_products.RowHeadersWidth = 51
        Me.grd_products.Size = New System.Drawing.Size(1283, 421)
        Me.grd_products.TabIndex = 92
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(16, 111)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(555, 421)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 93
        Me.PictureBox2.TabStop = False
        '
        'btn_done
        '
        Me.btn_done.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done.Location = New System.Drawing.Point(16, 554)
        Me.btn_done.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(1895, 42)
        Me.btn_done.TabIndex = 94
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(295, 481)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(119, 42)
        Me.btn_delete.TabIndex = 110
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'txt_price
        '
        Me.txt_price.Location = New System.Drawing.Point(168, 234)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(384, 22)
        Me.txt_price.TabIndex = 109
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(168, 481)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(119, 42)
        Me.btn_update.TabIndex = 108
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'txt_warranty
        '
        Me.txt_warranty.Location = New System.Drawing.Point(168, 438)
        Me.txt_warranty.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Size = New System.Drawing.Size(384, 22)
        Me.txt_warranty.TabIndex = 107
        '
        'txt_quantity
        '
        Me.txt_quantity.Location = New System.Drawing.Point(168, 388)
        Me.txt_quantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_quantity.Name = "txt_quantity"
        Me.txt_quantity.Size = New System.Drawing.Size(384, 22)
        Me.txt_quantity.TabIndex = 106
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(168, 336)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(384, 22)
        Me.txt_brand.TabIndex = 105
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(168, 283)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(384, 22)
        Me.txt_type.TabIndex = 104
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(168, 183)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(384, 22)
        Me.txt_name.TabIndex = 103
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(168, 134)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(384, 22)
        Me.txt_id.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 431)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 34)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Warranty"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 380)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 34)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 34)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Brand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 276)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 34)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 227)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 34)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 34)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 34)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "ID"
        '
        'pic_addbutton
        '
        Me.pic_addbutton.BackColor = System.Drawing.Color.White
        Me.pic_addbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_addbutton.Image = CType(resources.GetObject("pic_addbutton.Image"), System.Drawing.Image)
        Me.pic_addbutton.Location = New System.Drawing.Point(1840, 21)
        Me.pic_addbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_addbutton.Name = "pic_addbutton"
        Me.pic_addbutton.Size = New System.Drawing.Size(71, 65)
        Me.pic_addbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_addbutton.TabIndex = 111
        Me.pic_addbutton.TabStop = False
        '
        'frm_updateproduct_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1924, 610)
        Me.Controls.Add(Me.pic_addbutton)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_warranty)
        Me.Controls.Add(Me.txt_quantity)
        Me.Controls.Add(Me.txt_brand)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grd_products)
        Me.Controls.Add(Me.pic_refreshbutton)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_white)
        Me.Controls.Add(Me.pic_background)
        Me.Name = "frm_updateproduct_a190409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_updateproduct_a190409"
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_products, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_addbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_background As PictureBox
    Friend WithEvents pic_refreshbutton As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_white As PictureBox
    Friend WithEvents grd_products As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_done As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_price As TextBox
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_warranty As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_type As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_addbutton As PictureBox
End Class
