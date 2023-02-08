Public Class frm_splashscreen_a190409
    Dim rs As New Resizer()
    Private Sub frm_splashscreen_a190409_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        rs.FindAllControls(Me)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_percentage.Text = ProgressBar1.Value & "%"
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
        Else
            Timer1.Stop()
            frm_mainmenu_a190409.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:khushaalanarjunan@gmail.com")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://www.google.com/search?q=primecameramart")
    End Sub

    Private Sub frm_splashscreen_a190409_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        rs.FindAllControls(Me)
    End Sub
End Class
