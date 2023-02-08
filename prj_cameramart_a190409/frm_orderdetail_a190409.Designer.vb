<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdetail_a190409
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_orderdetail_a190409))
        Me.pic_background = New System.Windows.Forms.PictureBox()
        Me.pic_backbutton = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_white = New System.Windows.Forms.PictureBox()
        Me.grd_orderdetail = New System.Windows.Forms.DataGridView()
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_backbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_orderdetail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pic_background.TabIndex = 35
        Me.pic_background.TabStop = False
        '
        'pic_backbutton
        '
        Me.pic_backbutton.BackColor = System.Drawing.Color.White
        Me.pic_backbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_backbutton.Image = CType(resources.GetObject("pic_backbutton.Image"), System.Drawing.Image)
        Me.pic_backbutton.Location = New System.Drawing.Point(13, 13)
        Me.pic_backbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.pic_backbutton.Name = "pic_backbutton"
        Me.pic_backbutton.Size = New System.Drawing.Size(71, 65)
        Me.pic_backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_backbutton.TabIndex = 39
        Me.pic_backbutton.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(259, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.White
        Me.lbl_title.Font = New System.Drawing.Font("Franklin Gothic Demi", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(345, 13)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(375, 75)
        Me.lbl_title.TabIndex = 37
        Me.lbl_title.Text = "Order Details"
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
        Me.pic_white.TabIndex = 36
        Me.pic_white.TabStop = False
        '
        'grd_orderdetail
        '
        Me.grd_orderdetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderdetail.BackgroundColor = System.Drawing.Color.Indigo
        Me.grd_orderdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderdetail.Location = New System.Drawing.Point(13, 156)
        Me.grd_orderdetail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.grd_orderdetail.Name = "grd_orderdetail"
        Me.grd_orderdetail.RowHeadersWidth = 51
        Me.grd_orderdetail.RowTemplate.Height = 24
        Me.grd_orderdetail.Size = New System.Drawing.Size(973, 394)
        Me.grd_orderdetail.TabIndex = 40
        '
        'frm_orderdetail_a190409
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(997, 561)
        Me.Controls.Add(Me.grd_orderdetail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic_backbutton)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.pic_white)
        Me.Controls.Add(Me.pic_background)
        Me.Name = "frm_orderdetail_a190409"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_orderdetail_a190409"
        CType(Me.pic_background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_backbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_white, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_orderdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_background As PictureBox
    Friend WithEvents pic_backbutton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_white As PictureBox
    Friend WithEvents grd_orderdetail As DataGridView
End Class
