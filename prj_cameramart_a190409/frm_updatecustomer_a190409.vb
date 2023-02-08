Public Class frm_updatecustomer_a190409
    Dim current_code As String
    Private Sub frm_updatecustomer_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A190409"
        lst_gender.DataSource = run_sql_query("SELECT DISTINCT FLD_CUSTOMER_GENDER FROM TBL_CUSTOMER_A190409 ORDER BY FLD_CUSTOMER_GENDER DESC")
        lst_gender.DisplayMember = "FLD_CUSTOMER_GENDER"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        frm_customerlist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_phone.Text = ""
        txt_address.Text = ""
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_customer(1, current_row).Value
        lst_gender.Text = grd_customer(2, current_row).Value
        txt_address.Text = grd_customer(3, current_row).Value
        txt_phone.Text = grd_customer(4, current_row).Value
    End Sub

    Private Sub grd_customer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim mysql As String = "UPDATE TBL_CUSTOMER_A190409 SET FLD_CUSTOMER_NAME='" & txt_name.Text & "', FLD_CUSTOMER_GENDER='" & lst_gender.Text & "', FLD_CUSTOMER_ADDRESS='" & txt_address.Text & "', FLD_CUSTOMER_PHONE= '" & txt_phone.Text & "' WHERE FLD_CUSTOMER_IDENTIFICATION_NUMBER ='" & current_code & "'"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            MsgBox("You have successfully updated customer """ & current_code & """.")
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
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete customer """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            run_sql_command("DELETE FROM TBL_CUSTOMER_A190409 WHERE FLD_CUSTOMER_IDENTIFICATION_NUMBER='" & current_code & "'")
            Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub pic_addbutton_Click(sender As Object, e As EventArgs) Handles pic_addbutton.Click
        frm_insertcustomer_a190409.Show()
        Me.Hide()
    End Sub


    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub

    Private Sub lst_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_gender.SelectedIndexChanged

    End Sub
End Class