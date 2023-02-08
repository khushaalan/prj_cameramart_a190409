Public Class frm_updateproduct_a190409
    Dim current_code As String
    Private Sub frm_updateproduct_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        frm_productlist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A190409 ORDER BY FLD_PRODUCT_ID ASC"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_products.DataSource = mydatatable
    End Sub

    Private Sub clear_fields()
        txt_id.Text = ""
        txt_name.Text = ""
        txt_price.Text = ""
        txt_type.Text = ""
        txt_brand.Text = ""
        txt_quantity.Text = ""
        txt_warranty.Text = ""
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_products.CurrentRow.Index
        current_code = grd_products(0, current_row).Value

        txt_id.Text = current_code
        txt_name.Text = grd_products(1, current_row).Value
        txt_price.Text = grd_products(2, current_row).Value
        txt_type.Text = grd_products(3, current_row).Value
        txt_brand.Text = grd_products(4, current_row).Value
        txt_quantity.Text = grd_products(5, current_row).Value
        txt_warranty.Text = grd_products(6, current_row).Value
    End Sub

    Private Sub grd_products_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_products.CellClick
        get_current_code()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim mysql As String = "UPDATE TBL_PRODUCTS_A190409 SET FLD_PRODUCT_NAME='" & txt_name.Text & "', FLD_PRICE='" & txt_price.Text & "', FLD_TYPE='" & txt_type.Text & "', FLD_BRAND='" & txt_brand.Text & "', FLD_QUANTITY='" & txt_quantity.Text & "', FLD_WARRANTYLENGTH='" & txt_warranty.Text & "'  WHERE FLD_PRODUCT_ID='" & current_code & "'"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            MsgBox("You have successfully updated the product """ & current_code & """.")
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
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)

        If delete_confirmation = MsgBoxResult.Yes Then

            My.Computer.FileSystem.DeleteFile("pictures\" & current_code & ".jpg")
            run_sql_command("DELETE FROM TBL_PRODUCTS_A190409 WHERE FLD_PRODUCT_ID='" & current_code & "'")
            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    Private Sub pic_addbutton_Click(sender As Object, e As EventArgs) Handles pic_addbutton.Click
        frm_insertproduct_a190409.Show()
        Me.Close()
    End Sub
End Class