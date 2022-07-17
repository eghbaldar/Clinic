Public Class frm_Login

    Dim cl As New cl_Login

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txt_User.Text = "" Or txt_pass.Text = "" Then
            MessageBox.Show("نام کاربری و کلمه عبور باید تکمیل شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If cl.CheckLogin(txt_User.Text, txt_pass.Text) = -1 Then
            MessageBox.Show("اطلاعات کاربری مورد نظر اشتباه است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Keep_ID_USER.ID_USER = cl.CheckLogin(txt_User.Text, txt_pass.Text)
            Me.Close()
        End If

    End Sub

    Private Sub frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------- remove
        txt_User.Text = "mohammadi"
        txt_pass.Text = "12"
        '------------- remove
    End Sub
End Class