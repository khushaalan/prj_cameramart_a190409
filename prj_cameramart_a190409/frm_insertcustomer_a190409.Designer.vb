<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertcustomer_a190409
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_insertcustomer_a190409))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.pic_updatebutton = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_white = New System.Windows.Forms.PictureBox()
        Me.pic_refreshbutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.lst_gender = New System.Windows.Forms.ListBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_updatebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_background
        '
        Me.pic_background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_background.Image = CType(resources.GetObject("pic_background.Image"), System.Drawing.Image)
        Me.pic_background.Location = New System.Drawing.Point(0, 0)
        Me.pic_background.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_background.Name = "pic_background"
        Me.pic_background.Size = New System.Drawing.Size(1528, 587)
        Me.pic_background.TabIndex = 62
        Me.pic_background.TabStop = False
        '
        'pic_updatebutton
        '
        Me.pic_updatebutton.BackColor = System.Drawing.Color.White
        Me.pic_updatebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_updatebutton.Image = CType(resources.GetObject("pic_updatebutton.Image"), System.Drawing.Image)
        Me.pic_updatebutton.Location = New System.Drawing.Point(1444, 13)
        Me.pic_updatebutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_updatebutton.Name = "pic_updatebutton"
        Me.pic_updatebutton.Size = New System.Drawing.Size(71, 65)
        Me.pic_updatebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_updatebutton.TabIndex = 74
        Me.pic_updatebutton.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(547, 17)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(452, 75)
        Me.lbl_title.TabIndex = 73
        Me.lbl_title.Text = "Insert Customer"
        '
        'pic_white
        '
        Me.pic_white.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_white.Image = CType(resources.GetObject("pic_white.Image"), System.Drawing.Image)
        Me.pic_white.Location = New System.Drawing.Point(0, 0)
        Me.pic_white.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_white.Name = "pic_white"
        Me.pic_white.Size = New System.Drawing.Size(1528, 102)
        Me.pic_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_white.TabIndex = 72
        Me.pic_white.TabStop = False
        '
        'pic_refreshbutton
        '
        Me.pic_refreshbutton.BackColor = System.Drawing.SystemColors.Control
        Me.pic_refreshbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_refreshbutton.Image = CType(resources.GetObject("pic_refreshbutton.Image"), System.Drawing.Image)
        Me.pic_refreshbutton.Location = New System.Drawing.Point(485, 126)
        Me.pic_refreshbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_refreshbutton.Name = "pic_refreshbutton"
        Me.pic_refreshbutton.Size = New System.Drawing.Size(41, 39)
        Me.pic_refreshbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_refreshbutton.TabIndex = 87
        Me.pic_refreshbutton.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(15, 126)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(463, 394)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 86
        Me.PictureBox2.TabStop = False
        '
        'btn_done
        '
        Me.btn_done.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done.Location = New System.Drawing.Point(15, 535)
        Me.btn_done.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(1495, 42)
        Me.btn_done.TabIndex = 88
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.Location = New System.Drawing.Point(177, 465)
        Me.btn_insert.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(119, 42)
        Me.btn_insert.TabIndex = 93
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'grd_customer
        '
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.Color.Indigo
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(536, 126)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(973, 394)
        Me.grd_customer.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 34)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 182)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 34)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Name"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(242, 146)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(215, 22)
        Me.txt_id.TabIndex = 91
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(242, 189)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(215, 22)
        Me.txt_name.TabIndex = 92
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.Location = New System.Drawing.Point(23, 399)
        Me.lbl_phone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(188, 34)
        Me.lbl_phone.TabIndex = 94
        Me.lbl_phone.Text = "Phone Number"
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(242, 406)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(215, 22)
        Me.txt_phone.TabIndex = 95
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(23, 230)
        Me.lbl_gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(99, 34)
        Me.lbl_gender.TabIndex = 96
        Me.lbl_gender.Text = "Gender"
        '
        'lst_gender
        '
        Me.lst_gender.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lst_gender.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_gender.FormattingEnabled = True
        Me.lst_gender.ItemHeight = 23
        Me.lst_gender.Location = New System.Drawing.Point(242, 230)
        Me.lst_gender.Name = "lst_gender"
        Me.lst_gender.Size = New System.Drawing.Size(215, 50)
        Me.lst_gender.TabIndex = 97
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(23, 293)
        Me.lbl_address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(110, 34)
        Me.lbl_address.TabIndex = 98
        Me.lbl_address.Text = "Address"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(242, 297)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(215, 102)
        Me.txt_address.TabIndex = 99
        Me.txt_address.Text = ""
        '
        'frm_insertcustomer_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1528, 587)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lst_gender)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.pic_refreshbutton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.pic_updatebutton)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_white)
        Me.Controls.Add(Me.pic_background)
        Me.Name = "frm_insertcustomer_a190409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_insertcustomer_a190409"
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_updatebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_background As PictureBox
    Friend WithEvents pic_updatebutton As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_white As PictureBox
    Friend WithEvents pic_refreshbutton As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_done As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents lbl_phone As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents lbl_gender As Label
    Friend WithEvents lst_gender As ListBox
    Friend WithEvents lbl_address As Label
    Friend WithEvents txt_address As RichTextBox
End Class
