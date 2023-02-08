Public Class frm_updatestaff_a190409
    Dim current_code As String
    Private Sub frm_updatestaff_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_STAFF_ID AS ID, FLD_STAFF_NAME AS NAME, FLD_STAFF_POSITION AS STAFF_POSITION FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        frm_stafflist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_STAFF_ID AS ID, FLD_STAFF_NAME AS NAME, FLD_STAFF_POSITION AS STAFF_POSITION FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_staff.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_position.Text = ""
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_staff.CurrentRow.Index
        current_code = grd_staff(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_staff(1, current_row).Value
        txt_position.Text = grd_staff(2, current_row).Value
    End Sub

    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim mysql As String = "UPDATE TBL_STAFF_A190409 SET FLD_STAFF_NAME='" & txt_name.Text & "', FLD_STAFF_POSITION='" & txt_position.Text & "' WHERE FLD_STAFF_ID ='" & current_code & "'"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            MsgBox("You have successfully updated staff """ & current_code & """.")
        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete staff """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_STAFF_A190409 WHERE FLD_STAFF_ID='" & current_code & "'")
            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub pic_addbutton_Click(sender As Object, e As EventArgs) Handles pic_addbutton.Click
        frm_insertstaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        refresh_grid()
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub
End Class