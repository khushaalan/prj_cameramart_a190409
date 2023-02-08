Public Class frm_customerlist_a190409
    Private Sub frm_customerlist_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_CUSTOMER_IDENTIFICATION_NUMBER AS ID, FLD_CUSTOMER_NAME AS NAME, FLD_CUSTOMER_GENDER AS GENDER, FLD_CUSTOMER_ADDRESS AS ADDRESS, FLD_CUSTOMER_PHONE AS PHONE FROM TBL_CUSTOMER_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub pic_addbutton_Click(sender As Object, e As EventArgs) Handles pic_addbutton.Click
        frm_insertcustomer_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_updatebutton_Click(sender As Object, e As EventArgs) Handles pic_updatebutton.Click
        frm_updatecustomer_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_deletebutton_Click(sender As Object, e As EventArgs) Handles pic_deletebutton.Click
        frm_updatecustomer_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_CUSTOMER_IDENTIFICATION_NUMBER AS ID, FLD_CUSTOMER_NAME AS NAME, FLD_CUSTOMER_GENDER AS GENDER, FLD_CUSTOMER_ADDRESS AS ADDRESS, FLD_CUSTOMER_PHONE AS PHONE FROM TBL_CUSTOMER_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub pic_backbutton_Click(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub
End Class