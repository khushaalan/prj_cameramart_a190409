Public Class frm_vieworder_a190409
    Private Sub frm_vieworder_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_orderhistory.DataSource = mydatatable
        lst_orderhistory.DisplayMember = "FLD_ORDER_ID"
        refresh_text(lst_orderhistory.Text)
        refresh_details(lst_orderhistory.Text)
    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A190409"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_orderhistory.DataSource = mydatatable
        lst_orderhistory.DisplayMember = "FLD_ORDER_ID"
        refresh_text(lst_orderhistory.Text)
        refresh_details(lst_orderhistory.Text)
    End Sub

    Private Sub refresh_text(orderID As String)
        'Dim mysql As String = "Select * FROM TBL_PRODUCTS_A190409 WHERE FLD_PRODUCT_ID='" & productID & "'"
        Dim mysql1 As String = "SELECT FLD_PRODUCT_ID AS PRODUCT_CODE, FLD_QUANTITY AS QUANTITY, FLD_PRICE AS UNIT_PRICE, FLD_TOTAL_PRICE AS TOTAL_PRICE, FLD_PAYMENT_METHOD AS PAYMENT_METHOD FROM TBL_ORDERDETAILS_A190409 WHERE FLD_ORDER_ID_1 = '" & orderID & "'"
        Dim mydatatable1 As New DataTable
        Dim myreader1 As New OleDb.OleDbDataAdapter(mysql1, myconnection)
        myreader1.Fill(mydatatable1)
        grd_details.DataSource = mydatatable1
    End Sub

    Private Sub lst_orderhistory_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_orderhistory.MouseClick
        refresh_text(lst_orderhistory.Text)
        refresh_details(lst_orderhistory.Text)
    End Sub

    Private Sub refresh_details(orderID As String)
        Try
            Dim mysql2 As String = "Select * FROM TBL_ORDER_A190409 WHERE FLD_ORDER_ID='" & orderID & "'"
            Dim mydatatable2 As New DataTable
            Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
            myreader2.Fill(mydatatable2)
            lbl_order_id.Text = mydatatable2.Rows(0).Item("FLD_ORDER_ID")
            lbl_date.Text = mydatatable2.Rows(0).Item("FLD_ORDER_DATE")
            lbl_customerid.Text = mydatatable2.Rows(0).Item("FLD_CUSTOMER_ID")
            lbl_staffID.Text = mydatatable2.Rows(0).Item("FLD_STAFF_ID")

            Dim mysql3 As String = "SELECT FLD_CUSTOMER_NAME, FLD_CUSTOMER_ADDRESS, FLD_CUSTOMER_PHONE FROM TBL_CUSTOMER_A190409 WHERE FLD_CUSTOMER_IDENTIFICATION_NUMBER='" & lbl_customerid.Text & "'"
            Dim mydatatable3 As New DataTable
            Dim myreader3 As New OleDb.OleDbDataAdapter(mysql3, myconnection)
            myreader3.Fill(mydatatable3)
            lbl_customer_name.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_NAME")
            lbl_customer_address.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_ADDRESS")
            lbl_customer_phonenumber.Text = mydatatable3.Rows(0).Item("FLD_CUSTOMER_PHONE")

            Dim totalorder As String = run_sql_query("SELECT SUM(FLD_TOTAL_PRICE) AS TOTALORDER FROM TBL_ORDERDETAILS_A190409 WHERE FLD_ORDER_ID_1='" & orderID & "'").Rows(0).Item("TOTALORDER")
            lbl_totalorder.Text = totalorder
        Catch Ex As Exception
            MsgBox("You haven't made any orders yet!" & vbCrLf)
        End Try
    End Sub

    Private Sub pic_savereceiptbutton_Click(sender As Object, e As EventArgs) Handles pic_savereceiptbutton.Click
        'frm_makeorder_a190409.Show()
        'Me.Close()
        Dim bmp As New Bitmap(PictureBox1.Width, PictureBox1.Height)

        'For Xcount As Integer = 0 To bmp.Width - 1
        'For Ycount As Integer = 0 To bmp.Height - 1
        'bmp.SetPixel(Xcount, Ycount, Color.AntiqueWhite)
        'Next
        'Next

        Dim Rectangle As New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height)
        PictureBox1.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(pic_lg.Location.X - PictureBox1.Location.X, pic_lg.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        pic_lg.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label2.Location.X - PictureBox1.Location.X, Label2.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label2.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label3.Location.X - PictureBox1.Location.X, Label3.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label3.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label4.Location.X - PictureBox1.Location.X, Label4.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label4.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label5.Location.X - PictureBox1.Location.X, Label5.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label5.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label6.Location.X - PictureBox1.Location.X, Label6.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label6.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label7.Location.X - PictureBox1.Location.X, Label7.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label7.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label8.Location.X - PictureBox1.Location.X, Label8.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label8.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_order_id.Location.X - PictureBox1.Location.X, lbl_order_id.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_order_id.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label9.Location.X - PictureBox1.Location.X, Label9.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label9.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_date.Location.X - PictureBox1.Location.X, lbl_date.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_date.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(grd_details.Location.X - PictureBox1.Location.X, grd_details.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        grd_details.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label10.Location.X - PictureBox1.Location.X, Label10.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label10.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_customerid.Location.X - PictureBox1.Location.X, lbl_customerid.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_customerid.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label11.Location.X - PictureBox1.Location.X, Label11.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label11.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_staffID.Location.X - PictureBox1.Location.X, lbl_staffID.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_staffID.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label13.Location.X - PictureBox1.Location.X, Label13.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label13.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label12.Location.X - PictureBox1.Location.X, Label12.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label12.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_totalorder.Location.X - PictureBox1.Location.X, lbl_totalorder.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_totalorder.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label14.Location.X - PictureBox1.Location.X, Label14.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label14.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(Label15.Location.X - PictureBox1.Location.X, Label15.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        Label15.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_customer_name.Location.X - PictureBox1.Location.X, lbl_customer_name.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_customer_name.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_customer_address.Location.X - PictureBox1.Location.X, lbl_customer_address.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_customer_address.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_customer_phonenumber.Location.X - PictureBox1.Location.X, lbl_customer_phonenumber.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_customer_phonenumber.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_note.Location.X - PictureBox1.Location.X, lbl_note.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_note.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_nosign.Location.X - PictureBox1.Location.X, lbl_nosign.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_nosign.DrawToBitmap(bmp, Rectangle)
        Rectangle = New Rectangle(lbl_nosign1.Location.X - PictureBox1.Location.X, lbl_nosign1.Location.Y - PictureBox1.Location.Y, PictureBox1.Width, PictureBox1.Height)
        lbl_nosign1.DrawToBitmap(bmp, Rectangle)

        bmp.Save(Application.StartupPath & "\receipt.jpg", System.Drawing.Imaging.ImageFormat.Bmp)
        MsgBox("Your receipt has been saved")
        Dim filePath As String = Application.StartupPath & "\receipt.jpg"
        Process.Start(filePath)


    End Sub

    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs)
        refresh_grid()
    End Sub

    Private Sub pic_backbutton_Click(sender As Object, e As EventArgs) Handles pic_backbutton.Click
        frm_mainmenu_a190409.Show()
        Me.Close()
    End Sub
End Class