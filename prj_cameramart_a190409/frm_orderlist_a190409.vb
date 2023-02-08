Public Class frm_orderlist_a190409
    Private Sub frm_orderlist_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID AS ORDER_ID, FLD_STAFF_ID AS STAFF_ID, FLD_CUSTOMER_ID AS CUST_ID, FLD_ORDER_DATE AS ORDER_DATE, FLD_SHIPPED_DATE AS SHIPPING_DATE FROM TBL_ORDER_A190409 ORDER BY FLD_ORDER_DATE DESC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable
    End Sub
    Private Sub pic_backbutton_Click(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_mainmenu_a190409.Show()
        Me.Close()
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a190409.Show()
        Me.Close()
    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        frm_vieworder_a190409.Show()
        Me.Close()
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_ORDER_ID AS ORDER_ID, FLD_STAFF_ID AS STAFF_ID, FLD_CUSTOMER_ID AS CUST_ID, FLD_ORDER_DATE AS ORDER_DATE, FLD_SHIPPED_DATE AS SHIPPING_DATE FROM TBL_ORDER_A190409 ORDER BY FLD_ORDER_DATE DESC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_order.DataSource = mydatatable
    End Sub
End Class