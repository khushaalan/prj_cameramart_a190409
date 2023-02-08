Public Class frm_stafflist_a190409
    Private Sub frm_stafflist_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_STAFF_ID AS ID, FLD_STAFF_NAME AS NAME, FLD_STAFF_POSITION AS STAFF_POSITION FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub pic_backbutton_Click(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_mainmenu_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_addbutton_Click(sender As Object, e As EventArgs) Handles pic_addbutton.Click
        frm_insertstaff_a190409.Show()
        Me.Show()
    End Sub

    Private Sub pic_updatebutton_Click(sender As Object, e As EventArgs) Handles pic_updatebutton.Click
        frm_updatestaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_deletebutton_Click(sender As Object, e As EventArgs) Handles pic_deletebutton.Click
        frm_updatestaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_STAFF_ID AS ID, FLD_STAFF_NAME AS NAME, FLD_STAFF_POSITION AS STAFF_POSITION FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub
End Class