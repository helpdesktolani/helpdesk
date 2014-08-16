Public Class Login

    Private Sub lbl_password_Click(sender As Object, e As EventArgs) Handles lbl_password.Click

    End Sub
    Private Sub Lbl_userid_Click(sender As Object, e As EventArgs) Handles Lbl_userid.Click

    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        complaint.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnpl_forgetpassword.LinkClicked

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Lnpl_changepassword.LinkClicked
        changepassword.Show()


    End Sub
End Class