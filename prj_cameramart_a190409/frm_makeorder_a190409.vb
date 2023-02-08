Public Class frm_makeorder_a190409
    Dim ordertotal = 0
    Private temp = 0
    Private Sub frm_makeorder_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"
        refresh_text(lst_product.Text)
        refresh_search()

        lbl_order_id.Text = generate_id()

        Dim mysql1 As String = "SELECT FLD_CUSTOMER_IDENTIFICATION_NUMBER FROM TBL_CUSTOMER_A190409 ORDER BY FLD_CUSTOMER_IDENTIFICATION_NUMBER ASC"
        Dim mydatatable1 As New DataTable
        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql1, myconnection)
        myreader1.Fill(mydatatable1)
        cmb_cust_ID.DataSource = mydatatable1
        cmb_cust_ID.DisplayMember = "FLD_CUSTOMER_IDENTIFICATION_NUMBER"
        cmb_cust_ID.SelectedIndex = 0

        Dim mysql2 As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A190409 ORDER BY FLD_STAFF_ID ASC"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        cmb_staff_ID.DataSource = mydatatable2
        cmb_staff_ID.DisplayMember = "FLD_STAFF_ID"
        cmb_staff_ID.SelectedIndex = 0

        cmb_payment_method.Items.Add("CARD")
        cmb_payment_method.Items.Add("ONLINE BANKING/FPX")
        cmb_payment_method.Items.Add("CASH ON DELIVERY")
        cmb_payment_method.SelectedIndex = 0


        refresh_subtotal()

        grd_cart.ColumnCount = 4
        grd_cart.Columns(0).HeaderText = "Product ID"
        grd_cart.Columns(1).HeaderText = "Amount"
        grd_cart.Columns(2).HeaderText = "Price"
        grd_cart.Columns(3).HeaderText = "Total Price"
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_PRODUCT_ID FROM TBL_PRODUCTS_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
        refresh_subtotal()
    End Sub

    Private Sub refresh_text(productID As String)
        Dim mysql As String = "Select * FROM TBL_PRODUCTS_A190409 WHERE FLD_PRODUCT_ID='" & productID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lbl_id.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        lbl_product_name.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        lbl_price.Text = mydatatable.Rows(0).Item("FLD_PRICE")
        lbl_type.Text = mydatatable.Rows(0).Item("FLD_TYPE")
        lbl_colour.Text = mydatatable.Rows(0).Item("FLD_BRAND")
        lbl_quantity.Text = mydatatable.Rows(0).Item("FLD_QUANTITY")
        temp = mydatatable.Rows(0).Item("FLD_QUANTITY")
        lbl_warranty.Text = mydatatable.Rows(0).Item("FLD_WARRANTYLENGTH")
        Try
            pic_product.BackgroundImage = Image.FromFile("pictures/" & lbl_id.Text & ".jpg")
        Catch ex As Exception
            'pic_product.BackgroundImage = Image.FromFile("pictures/nophoto.png")
            Beep()
        End Try
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

    Private Function generate_id() As String
        Dim newid As String
        Try
            Dim lastid As String = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTID FROM TBL_ORDER_A190409").Rows(0).Item("LASTID")
            newid = "O" & Mid(lastid, 2) + 1
        Catch ex As Exception
            newid = "O101"
        End Try
        Return newid
    End Function

    Private Sub refresh_subtotal()
        Dim subtotal = lbl_price.Text * nud_amount.Value
        lbl_subtotal.Text = subtotal
    End Sub

    Private Sub nud_amount_ValueChanged(sender As Object, e As EventArgs) Handles nud_amount.ValueChanged
        refresh_subtotal()
    End Sub

    Private Sub btn_addtocart_Click(sender As Object, e As EventArgs) Handles btn_addtocart.Click
        If nud_amount.Value = 0 Then
            MsgBox("The amount can't be zero!")
        ElseIf nud_amount.Value > lbl_quantity.Text Then
            MsgBox("The amount is over the quantity of the stock!")
        Else
            grd_cart.RowCount = grd_cart.RowCount + 1
            grd_cart(0, grd_cart.RowCount - 1).Value = lbl_id.Text
            grd_cart(1, grd_cart.RowCount - 1).Value = nud_amount.Value
            grd_cart(2, grd_cart.RowCount - 1).Value = lbl_price.Text
            grd_cart(3, grd_cart.RowCount - 1).Value = lbl_subtotal.Text
            refresh_totalorder()
            'refresh_stock()
            'refresh_text(lst_product.Text)
        End If
    End Sub

    Private Sub btn_confirmorder_Click(sender As Object, e As EventArgs) Handles btn_confirmorder.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try
            For i As Integer = 0 To grd_cart.RowCount - 1
                Dim productID As String = grd_cart(0, i).Value
                Dim amount As String = grd_cart(1, i).Value
                Dim price As String = grd_cart(2, i).Value
                Dim totalprice As String = grd_cart(3, i).Value
                refresh_stock(productID, amount)


                Dim mysql As String = "INSERT INTO TBL_ORDERDETAILS_A190409 VALUES ('" & lbl_order_id.Text & "','" & productID & "','" & amount & "','" & price & "','" & totalprice & "','" & cmb_payment_method.Text & "')"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)
                mywriter.ExecuteNonQuery()
            Next

            mytransaction.Commit()
            myconnection2.Close()

            Beep()
            MsgBox("Order has been placed!")
            refresh_text(lbl_id.Text)
            refresh_grid()
            grd_cart.Rows.Clear()
            lbl_order_id.Text = generate_id()
            lbl_totalorder.Text = 0

        Catch ex As Exception

            Beep()
            MsgBox("You need to fill in the details first and press confirm!")

            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()
        End Try
    End Sub

    Private Sub btn_confirmdetails_Click(sender As Object, e As EventArgs) Handles btn_confirmdetails.Click
        Dim mysql As String = "INSERT INTO TBL_ORDER_A190409 VALUES ('" & lbl_order_id.Text & "','" & cmb_staff_ID.Text & "','" & cmb_cust_ID.Text & "','" & dtp_date.Value & "','" & dtp_date.Value & "')"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            MsgBox("You can now make your order!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub refresh_totalorder()
        Dim totalorder As Double = lbl_totalorder.Text
        Dim subtotal As Double = lbl_subtotal.Text
        lbl_totalorder.Text = totalorder + subtotal
    End Sub

    Private Sub pic_historybutton_Click(sender As Object, e As EventArgs) Handles pic_historybutton.Click
        frm_vieworder_a190409.Show()
        Me.Close()
    End Sub

    Private Sub btn_deleteall_Click(sender As Object, e As EventArgs) Handles btn_deleteall.Click
        grd_cart.Rows.Clear()
        lbl_totalorder.Text = 0
    End Sub

    Private Sub pic_backbutton_Click(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_orderlist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub refresh_stock(product_id As String, amount As String)
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection3.Open()
        mytransaction = myconnection3.BeginTransaction

        Try
            refresh_text(product_id)
            Dim mysql As String = "UPDATE TBL_PRODUCTS_A190409 SET FLD_QUANTITY='" & lbl_quantity.Text - amount & "' WHERE FLD_PRODUCT_ID='" & product_id & "'"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection3, mytransaction)
            lst_product.SelectedIndex = 0

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection3.Close()

        Catch ex As Exception
            Beep()
        End Try

    End Sub
End Class