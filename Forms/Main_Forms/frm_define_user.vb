Imports System.IO

Public Class frm_define_user

    Dim cl As New cl_personal
    Dim cl_user As New cl_users
    Dim Id_personal As Long
    Dim exec As New ExecuteSP

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_define_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.PersonalTableAdapter.Fill(Me.Ds_Personal.Personal, 0)
        Me.PersonalTableAdapter_Personal.Fill(Me.Ds_Personal_.Personal, 1)
        dgv_Personal.Columns(0).Visible = False
        '--------------------------------------------------------------------

    End Sub

    Private Sub dgv_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        gp_attributes.Enabled = True
        gp_userpass.Enabled = True
        gp_rules.Enabled = True
        btn_InsertUpdate.Enabled = True
        Id_personal = dgv.SelectedCells(0).Value.ToString
        Call_Filling()
        dgv_Attributes.Rows(3).Visible = True
    End Sub

    Private Sub dgv_Personal_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_Personal.CellClick
        gp_attributes.Enabled = True
        gp_userpass.Enabled = True
        gp_rules.Enabled = True
        btn_InsertUpdate.Enabled = True
        Id_personal = dgv_Personal.SelectedCells(0).Value.ToString
        Call_Filling()
        dgv_Attributes.Rows(3).Visible = False
    End Sub

    Private Sub Call_Filling()

        dgv_Attributes.DataSource = exec.ReturnSelectFromSP("sp_Select_information_Personal " & Id_personal.ToString).Tables(0)
        dgv_Attributes.Columns(1).Width = 175

        Try
            Dim file() As Byte = cl.GetAvatarPersonal(Id_personal)
            If file Is Nothing Then
                PictureBox.Image = Nothing
                Exit Try
            End If
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox.Image = Bitmap.FromStream(MS)
        Catch ex As Exception
        End Try

        With exec.ReturnSelectFromSP("sp_select_users_withID " & Id_personal.ToString).Tables(0)
            If .Rows(0)(0).ToString <> "-1" Then
                Select Case .Rows(0)("type")
                    Case 0
                        rb_general_admin.Checked = True
                    Case 1
                        rb_admin.Checked = True
                    Case 2
                        rb_nurse.Checked = True
                End Select
                txt_username.Text = .Rows(0)("username").ToString
                txt_password.Text = .Rows(0)("password").ToString
                txt_confirm_Password.Text = txt_password.Text
            Else
                txt_confirm_Password.Text = ""
                txt_password.Text = ""
                txt_username.Text = ""
                rb_general_admin.Checked = False
                rb_admin.Checked = False
                rb_nurse.Checked = False
            End If
        End With



    End Sub

    Private Sub btn_InsertUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InsertUpdate.Click

        If txt_password.Text <> txt_confirm_Password.Text Then
            MessageBox.Show("کلمه عبور شما همخوانی ندارد. دوباره تلاش کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not rb_general_admin.Checked And Not rb_admin.Checked And Not rb_nurse.Checked Then
            MessageBox.Show("شما باید برای این کاربر نقشی را در نظر بگیرید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim type As Byte
        If rb_general_admin.Checked Then type = 0
        If rb_admin.Checked Then type = 1
        If rb_nurse.Checked Then type = 2

        Dim flag As Byte
        If rb_visible.Checked Then flag = 1
        If rb_invisible.Checked Then flag = 0

        Select Case cl_user.Insert_Update_User(Id_personal, txt_username.Text, txt_password.Text, flag, type)
            Case 0
                MessageBox.Show("نقش کاربر مورد نظر به درستی اعمال شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("فیلدهای کلیدی باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

End Class