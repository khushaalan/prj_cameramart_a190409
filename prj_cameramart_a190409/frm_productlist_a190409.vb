Imports System.IO
Imports System.Windows.Forms.Form

Public Class frm_productlist_a190409
    'Dim rs As New Resizer()
    Private Sub frm_productlist_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A190409 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_product.Text)
        refresh_search()
        'rs.FindAllControls(Me)
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A190409 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text("C001")
    End Sub



    Private Sub refresh_text(productID As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A190409 WHERE FLD_PRODUCT_ID='" & productID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_product_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        lbl_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_brand.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        lbl_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
        lbl_warranty.Text = mydatatable.Rows(0).Item("FLD_WARRANTYLENGTH")

        Try
            Dim stream As New FileStream("pictures/" & lbl_id.Text & ".jpg", FileMode.Open)
            Dim image As Image = Image.FromStream(stream)
            pic_product.BackgroundImage = image
            stream.Close()
        Catch e As Exception
            Beep()
        End Try
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub

    Private Sub pic_backbutton_Click(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_mainmenu_a190409.Show()


        Me.Close()
    End Sub

    Private Sub refresh_search()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A190409 WHERE FLD_PRODUCT_ID like '%" & txt_search.Text & "%'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        refresh_search()
    End Sub

    Private Sub pic_addbutton_Click(sender As Object, e As EventArgs) Handles pic_addbutton.Click
        frm_insertproduct_a190409.Show()
        Me.Close()
    End Sub

    Private Sub pic_updatebutton_Click(sender As Object, e As EventArgs) Handles pic_updatebutton.Click
        frm_updateproduct_a190409.Show()
        Me.Close()
    End Sub

    Private Sub pic_deletebutton_Click(sender As Object, e As EventArgs) Handles pic_deletebutton.Click
        frm_updateproduct_a190409.Show()
        Me.Close()
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub

    Private Sub frm_productlist_a190409_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'rs.FindAllControls(Me)
    End Sub
End Class