Public Class frm_mainmenu_a190409
    Dim rs As New Resizer()
    Private Sub frm_mainmenu_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_insertproducts.Visible = False
        btn_updateproducts.Visible = False
        btn_deleteproducts.Visible = False
        btn_collapse.Visible = False
        btn_insertcustomer.Visible = False
        btn_updatecustomer.Visible = False
        btn_deletecustomer.Visible = False
        btn_collapse2.Visible = False
        btn_insertstaff.Visible = False
        btn_updatestaff.Visible = False
        btn_deletestaff.Visible = False
        btn_collapse3.Visible = False
        btn_makeorder.Visible = False
        btn_vieworder.Visible = False
        btn_collapse4.Visible = False
        btn_orderdetail.Visible = False

        rs.FindAllControls(Me)
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        frm_productlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_product_Click(sender As Object, e As EventArgs) Handles pic_product.Click, pic_background.Click
        frm_productlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_customer_Click(sender As Object, e As EventArgs) Handles pic_customer.Click
        frm_customerlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_customerlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_staff_Click(sender As Object, e As EventArgs) Handles pic_staff.Click
        frm_stafflist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_staff_Click(sender As Object, e As EventArgs) Handles btn_staff.Click
        frm_stafflist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub pic_order_Click(sender As Object, e As EventArgs) Handles pic_order.Click
        frm_orderlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        frm_orderlist_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_orderdetail_Click(sender As Object, e As EventArgs) Handles btn_orderdetail.Click
        frm_orderdetail_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim delete_confirmation = MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub lbl_title_MouseHover(sender As Object, e As EventArgs) Handles lbl_title.MouseHover
        lbl_title.Text = "Welcome!"
    End Sub

    Private Sub lbl_title_MouseLeave(sender As Object, e As EventArgs) Handles lbl_title.MouseLeave
        lbl_title.Text = "Prime Camera Mart"
    End Sub

    Private Sub btn_drop_Click(sender As Object, e As EventArgs) Handles btn_drop.Click
        btn_insertproducts.Visible = True
        btn_updateproducts.Visible = True
        btn_deleteproducts.Visible = True
        btn_collapse.Visible = True
    End Sub

    Private Sub btn_collapse_Click(sender As Object, e As EventArgs) Handles btn_collapse.Click
        btn_insertproducts.Visible = False
        btn_updateproducts.Visible = False
        btn_deleteproducts.Visible = False
        btn_collapse.Visible = False
    End Sub

    Private Sub btn_updateproducts_Click(sender As Object, e As EventArgs) Handles btn_updateproducts.Click
        frm_updateproduct_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_insertproducts_Click(sender As Object, e As EventArgs) Handles btn_insertproducts.Click
        frm_insertproduct_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_deleteproducts_Click(sender As Object, e As EventArgs) Handles btn_deleteproducts.Click
        frm_updateproduct_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_collapse2_Click(sender As Object, e As EventArgs) Handles btn_collapse2.Click
        btn_insertcustomer.Visible = False
        btn_updatecustomer.Visible = False
        btn_deletecustomer.Visible = False
        btn_collapse2.Visible = False
    End Sub

    Private Sub btn_drop2_Click(sender As Object, e As EventArgs) Handles btn_drop2.Click
        btn_insertcustomer.Visible = True
        btn_updatecustomer.Visible = True
        btn_deletecustomer.Visible = True
        btn_collapse2.Visible = True
    End Sub

    Private Sub btn_insertcustomer_Click(sender As Object, e As EventArgs) Handles btn_insertcustomer.Click
        frm_insertcustomer_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatecustomer_Click(sender As Object, e As EventArgs) Handles btn_updatecustomer.Click
        frm_updatecustomer_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_deletecustomer_Click(sender As Object, e As EventArgs) Handles btn_deletecustomer.Click
        frm_updatecustomer_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_drop3_Click(sender As Object, e As EventArgs) Handles btn_drop3.Click
        btn_insertstaff.Visible = True
        btn_updatestaff.Visible = True
        btn_deletestaff.Visible = True
        btn_collapse3.Visible = True
    End Sub

    Private Sub btn_collapse3_Click(sender As Object, e As EventArgs) Handles btn_collapse3.Click
        btn_insertstaff.Visible = False
        btn_updatestaff.Visible = False
        btn_deletestaff.Visible = False
        btn_collapse3.Visible = False
    End Sub

    Private Sub btn_insertstaff_Click(sender As Object, e As EventArgs) Handles btn_insertstaff.Click
        frm_insertstaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updatestaff_Click(sender As Object, e As EventArgs) Handles btn_updatestaff.Click
        frm_updatestaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_deletestaff_Click(sender As Object, e As EventArgs) Handles btn_deletestaff.Click
        frm_updatestaff_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_drop4_Click(sender As Object, e As EventArgs) Handles btn_drop4.Click
        btn_makeorder.Visible = True
        btn_vieworder.Visible = True
        btn_orderdetail.Visible = True
        btn_collapse4.Visible = True
    End Sub

    Private Sub btn_collapse4_Click(sender As Object, e As EventArgs) Handles btn_collapse4.Click
        btn_makeorder.Visible = False
        btn_vieworder.Visible = False
        btn_orderdetail.Visible = False
        btn_collapse4.Visible = False
    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub btn_vieworder_Click(sender As Object, e As EventArgs) Handles btn_vieworder.Click
        frm_vieworder_a190409.Show()
        Me.Hide()
    End Sub

    Private Sub frm_mainmenu_a190409_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class