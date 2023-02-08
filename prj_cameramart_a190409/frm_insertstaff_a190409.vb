Public Class frm_insertstaff_a190409
    Private Sub frm_insertstaff_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID AS ID, FLD_STAFF_NAME AS NAME, FLD_STAFF_POSITION AS STAFF_POSITION FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC")
        txt_id.Text = generate_id()
    End Sub

    Private Function generate_id() As String
        Dim lastid As String = run_sql_query("SELECT MAX(FLD_STAFF_ID) AS LASTID FROM TBL_STAFF_A190409").Rows(0).Item("LASTID")
        Dim newid As String = "PM" & Mid(lastid, 3) + 1
        Return newid
    End Function

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        frm_stafflist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_STAFF_A190409 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & txt_position.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()


            grd_staff.DataSource = run_sql_query("SELECT FLD_STAFF_ID AS ID, FLD_STAFF_NAME AS NAME, FLD_STAFF_POSITION AS STAFF_POSITION FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC")

            txt_id.Text = generate_id()
            txt_name.Text = ""
            txt_position.Text = ""
            MsgBox("You have successfully entered a staff!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub pic_updatestaff_Click(sender As Object, e As EventArgs)
        frm_updatestaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_updatebutton_Click(sender As Object, e As EventArgs) Handles pic_updatebutton.Click
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