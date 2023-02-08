<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderlist_a190409
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderlist_a190409))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.btn_vieworder = New System.Windows.Forms.Button()
        Me.pic_backbutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_white = New System.Windows.Forms.PictureBox()
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.pic_refreshbutton = New System.Windows.Forms.PictureBox()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_backbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_background
        '
        Me.pic_background.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pic_background.Image = CType(resources.GetObject("pic_background.Image"), System.Drawing.Image)
        Me.pic_background.Location = New System.Drawing.Point(0, 0)
        Me.pic_background.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_background.Name = "pic_background"
        Me.pic_background.Size = New System.Drawing.Size(997, 561)
        Me.pic_background.TabIndex = 21
        Me.pic_background.TabStop = False
        '
        'btn_vieworder
        '
        Me.btn_vieworder.Font = New System.Drawing.Font("Franklin Gothic Book", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_vieworder.Location = New System.Drawing.Point(524, 522)
        Me.btn_vieworder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_vieworder.Name = "btn_vieworder"
        Me.btn_vieworder.Size = New System.Drawing.Size(151, 34)
        Me.btn_vieworder.TabIndex = 33
        Me.btn_vieworder.Text = "View Order"
        Me.btn_vieworder.UseVisualStyleBackColor = True
        '
        'pic_backbutton
        '
        Me.pic_backbutton.BackColor = System.Drawing.Color.White
        Me.pic_backbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_backbutton.Image = CType(resources.GetObject("pic_backbutton.Image"), System.Drawing.Image)
        Me.pic_backbutton.Location = New System.Drawing.Point(14, 23)
        Me.pic_backbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_backbutton.Name = "pic_backbutton"
        Me.pic_backbutton.Size = New System.Drawing.Size(71, 65)
        Me.pic_backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_backbutton.TabIndex = 32
        Me.pic_backbutton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(386, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(463, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(176, 75)
        Me.lbl_title.TabIndex = 30
        Me.lbl_title.Text = "Order"
        '
        'pic_white
        '
        Me.pic_white.Dock = System.Windows.Forms.DockStyle.Top
        Me.pic_white.Image = CType(resources.GetObject("pic_white.Image"), System.Drawing.Image)
        Me.pic_white.Location = New System.Drawing.Point(0, 0)
        Me.pic_white.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_white.Name = "pic_white"
        Me.pic_white.Size = New System.Drawing.Size(997, 102)
        Me.pic_white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_white.TabIndex = 29
        Me.pic_white.TabStop = False
        '
        'btn_makeorder
        '
        Me.btn_makeorder.Font = New System.Drawing.Font("Franklin Gothic Book", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.Location = New System.Drawing.Point(346, 522)
        Me.btn_makeorder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(162, 34)
        Me.btn_makeorder.TabIndex = 34
        Me.btn_makeorder.Text = "Make Order"
        Me.btn_makeorder.UseVisualStyleBackColor = True
        '
        'grd_order
        '
        Me.grd_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_order.BackgroundColor = System.Drawing.Color.Indigo
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(14, 166)
        Me.grd_order.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(973, 336)
        Me.grd_order.TabIndex = 35
        '
        'pic_refreshbutton
        '
        Me.pic_refreshbutton.BackColor = System.Drawing.SystemColors.Control
        Me.pic_refreshbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_refreshbutton.Image = CType(resources.GetObject("pic_refreshbutton.Image"), System.Drawing.Image)
        Me.pic_refreshbutton.Location = New System.Drawing.Point(14, 112)
        Me.pic_refreshbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_refreshbutton.Name = "pic_refreshbutton"
        Me.pic_refreshbutton.Size = New System.Drawing.Size(41, 39)
        Me.pic_refreshbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_refreshbutton.TabIndex = 88
        Me.pic_refreshbutton.TabStop = False
        '
        'frm_orderlist_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(997, 561)
        Me.Controls.Add(Me.pic_refreshbutton)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.btn_makeorder)
        Me.Controls.Add(Me.btn_vieworder)
        Me.Controls.Add(Me.pic_backbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_white)
        Me.Controls.Add(Me.pic_background)
        Me.Name = "frm_orderlist_a190409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_orderlist_a190409"
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_backbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_refreshbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_background As PictureBox
    Friend WithEvents btn_vieworder As Button
    Friend WithEvents pic_backbutton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_white As PictureBox
    Friend WithEvents btn_makeorder As Button
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents pic_refreshbutton As PictureBox
End Class
