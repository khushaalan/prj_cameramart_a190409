Public Class frm_insertproduct_a190409
    Dim defaultpicture As String = Application.StartupPath & "\pictures\nophoto.jpg"
    Dim rs As New Resizer()
    Private Sub pic_refreshbutton_Click(sender As Object, e As EventArgs) Handles pic_refreshbutton.Click
        refresh_grid()
    End Sub
    Private Sub refresh_grid()
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A190409 ORDER BY FLD_PRODUCT_ID")
    End Sub
    Private Sub frm_insertproduct_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A190409 ORDER BY FLD_PRODUCT_ID")
        txt_directory.Text = defaultpicture
        pic_product.BackgroundImage = Image.FromFile(defaultpicture)
        rs.FindAllControls(Me)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A190409 VALUES ('" & txt_id.Text & "', '" & txt_name.Text & "','" & txt_price.Text & "','" & txt_type.Text & "','" & txt_brand.Text & "','" & txt_quantity.Text & "','" & txt_warranty.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(txt_directory.Text, "pictures\" & txt_id.Text & ".jpg")

            grd_products.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A190409 ORDER BY FLD_PRODUCT_ID")

            txt_id.Text = ""
            txt_name.Text = ""
            txt_price.Text = ""
            txt_type.Text = ""
            txt_brand.Text = ""
            txt_quantity.Text = ""
            txt_warranty.Text = ""
            txt_directory.Text = defaultpicture
            pic_product.BackgroundImage = Image.FromFile(defaultpicture)
            MsgBox("You have successfully entered a product!")

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()
        End Try
    End Sub

    Private Sub pic_buttonuploadpic_Click(sender As Object, e As EventArgs) Handles pic_buttonuploadpic.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop

        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPG files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()
        Try
            pic_product.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            txt_directory.Text = OpenFileDialog1.FileName
        Catch ex As Exception
            Beep()
        End Try

    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        frm_productlist_a190409.Show()
        Me.Close()
    End Sub

    Private Sub pic_updatebutton_Click(sender As Object, e As EventArgs) Handles pic_updatebutton.Click
        frm_updateproduct_a190409.Show()
        Me.Close()
    End Sub

    Private Sub frm_insertproduct_a190409_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.FindAllControls(Me)
    End Sub
End Class