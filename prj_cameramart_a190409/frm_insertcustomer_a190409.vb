Public Class frm_insertcustomer_a190409
    Private Sub frm_insertcustomer_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A190409")
        lst_gender.DataSource = run_sql_query("SELECT DISTINCT FLD_CUSTOMER_GENDER FROM TBL_CUSTOMER_A190409 ORDER BY FLD_CUSTOMER_GENDER DESC")
        lst_gender.DisplayMember = "FLD_CUSTOMER_GENDER"
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        frm_customerlist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A190409 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "', '" & lst_gender.Text & "', '" & txt_address.Text & "', '" & txt_phone.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()


            grd_customer.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A190409")

            txt_id.Text = ""
            txt_name.Text = ""
            txt_phone.Text = ""
            txt_address.Text = ""
            MsgBox("You have successfully entered a customer!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub


    Private Sub pic_updatebutton_Click(sender As Object, e As EventArgs) Handles pic_updatebutton.Click
        frm_updatecustomer_a190409.Show()
        Me.Close()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_customer.DataSource = mydatatable
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub

    Private Sub lst_gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_gender.SelectedIndexChanged

    End Sub
End Class