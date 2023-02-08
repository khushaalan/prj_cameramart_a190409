<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updatecustomer_a190409
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_updatecustomer_a190409))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.pic_addbutton = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_white = New System.Windows.Forms.PictureBox()
        Me.grd_customer = New System.Windows.Forms.DataGridView()
        Me.pic_refreshbutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.txt_address = New System.Windows.Forms.RichTextBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.lst_gender = New System.Windows.Forms.ListBox()
        Me.lbl_gender = New System.Windows.Forms.Label()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.lbl_phone = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_addbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pic_background.TabIndex = 87
        Me.pic_background.TabStop = False
        '
        'pic_addbutton
        '
        Me.pic_addbutton.BackColor = System.Drawing.Color.White
        Me.pic_addbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_addbutton.Image = CType(resources.GetObject("pic_addbutton.Image"), System.Drawing.Image)
        Me.pic_addbutton.Location = New System.Drawing.Point(1444, 16)
        Me.pic_addbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_addbutton.Name = "pic_addbutton"
        Me.pic_addbutton.Size = New System.Drawing.Size(71, 65)
        Me.pic_addbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_addbutton.TabIndex = 99
        Me.pic_addbutton.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(334, 16)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(787, 75)
        Me.lbl_title.TabIndex = 98
        Me.lbl_title.Text = "Update and Delete Customer"
        '
        'pic_white
        '
        Me.pic_white.Image = CType(resources.GetObject("pic_white.Image"), System.Drawing.Image)
        Me.pic_white.Location = New System.Drawing.Point(0, 0)
        Me.pic_white.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_white.Name = "pic_white"
        Me.pic_white.Size = New System.Drawing.Size(1548, 102)
        Me.pic_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_white.TabIndex = 97
        Me.pic_white.TabStop = False
        '
        'grd_customer
        '
        Me.grd_customer.AllowUserToAddRows = False
        Me.grd_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_customer.BackgroundColor = System.Drawing.Color.Indigo
        Me.grd_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_customer.Location = New System.Drawing.Point(539, 124)
        Me.grd_customer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_customer.Name = "grd_customer"
        Me.grd_customer.RowHeadersWidth = 51
        Me.grd_customer.RowTemplate.Height = 24
        Me.grd_customer.Size = New System.Drawing.Size(973, 394)
        Me.grd_customer.TabIndex = 101
        '
        'pic_refreshbutton
        '
        Me.pic_refreshbutton.BackColor = System.Drawing.SystemColors.Control
        Me.pic_refreshbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_refreshbutton.Image = CType(resources.GetObject("pic_refreshbutton.Image"), System.Drawing.Image)
        Me.pic_refreshbutton.Location = New System.Drawing.Point(488, 124)
        Me.pic_refreshbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_refreshbutton.Name = "pic_refreshbutton"
        Me.pic_refreshbutton.Size = New System.Drawing.Size(41, 39)
        Me.pic_refreshbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_refreshbutton.TabIndex = 103
        Me.pic_refreshbutton.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(17, 124)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(463, 394)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 102
        Me.PictureBox2.TabStop = False
        '
        'btn_done
        '
        Me.btn_done.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_done.Location = New System.Drawing.Point(17, 532)
        Me.btn_done.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(1495, 42)
        Me.btn_done.TabIndex = 104
        Me.btn_done.Text = "Done"
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(247, 295)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(215, 102)
        Me.txt_address.TabIndex = 114
        Me.txt_address.Text = ""
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.BackColor = System.Drawing.Color.Transparent
        Me.lbl_address.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(28, 291)
        Me.lbl_address.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(110, 34)
        Me.lbl_address.TabIndex = 113
        Me.lbl_address.Text = "Address"
        '
        'lst_gender
        '
        Me.lst_gender.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.lst_gender.Font = New System.Drawing.Font("Consolas", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_gender.ForeColor = System.Drawing.Color.White
        Me.lst_gender.FormattingEnabled = True
        Me.lst_gender.ItemHeight = 23
        Me.lst_gender.Location = New System.Drawing.Point(247, 228)
        Me.lst_gender.Name = "lst_gender"
        Me.lst_gender.Size = New System.Drawing.Size(215, 50)
        Me.lst_gender.TabIndex = 112
        '
        'lbl_gender
        '
        Me.lbl_gender.AutoSize = True
        Me.lbl_gender.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gender.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gender.Location = New System.Drawing.Point(28, 228)
        Me.lbl_gender.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_gender.Name = "lbl_gender"
        Me.lbl_gender.Size = New System.Drawing.Size(99, 34)
        Me.lbl_gender.TabIndex = 111
        Me.lbl_gender.Text = "Gender"
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(247, 404)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(215, 22)
        Me.txt_phone.TabIndex = 110
        '
        'lbl_phone
        '
        Me.lbl_phone.AutoSize = True
        Me.lbl_phone.BackColor = System.Drawing.Color.Transparent
        Me.lbl_phone.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_phone.Location = New System.Drawing.Point(28, 397)
        Me.lbl_phone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_phone.Name = "lbl_phone"
        Me.lbl_phone.Size = New System.Drawing.Size(188, 34)
        Me.lbl_phone.TabIndex = 109
        Me.lbl_phone.Text = "Phone Number"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(247, 187)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(215, 22)
        Me.txt_name.TabIndex = 108
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(247, 144)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(215, 22)
        Me.txt_id.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 180)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 34)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 34)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "ID"
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(247, 460)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(119, 42)
        Me.btn_delete.TabIndex = 116
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Demi", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(120, 460)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(119, 42)
        Me.btn_update.TabIndex = 115
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'frm_updatecustomer_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1528, 587)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.lst_gender)
        Me.Controls.Add(Me.lbl_gender)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.lbl_phone)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_done)
        Me.Controls.Add(Me.pic_refreshbutton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grd_customer)
        Me.Controls.Add(Me.pic_addbutton)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_white)
        Me.Controls.Add(Me.pic_background)
        Me.Name = "frm_updatecustomer_a190409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_updatecustomer_a190409"
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_addbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_background As PictureBox
    Friend WithEvents pic_addbutton As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_white As PictureBox
    Friend WithEvents grd_customer As DataGridView
    Friend WithEvents pic_refreshbutton As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_done As Button
    Friend WithEvents txt_address As RichTextBox
    Friend WithEvents lbl_address As Label
    Friend WithEvents lst_gender As ListBox
    Friend WithEvents lbl_gender As Label
    Friend WithEvents txt_phone As TextBox
    Friend WithEvents lbl_phone As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
End Class
