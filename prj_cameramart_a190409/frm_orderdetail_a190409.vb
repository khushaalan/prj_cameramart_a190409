Public Class frm_orderdetail_a190409
    Private Sub pic_backbutton_Click_1(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_mainmenu_a190409.Show()
        Me.Close()
    End Sub

    Private Sub frm_orderdetail_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_ORDERDETAILS_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_orderdetail.DataSource = mydatatable
    End Sub
End Class