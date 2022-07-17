Imports System.IO

Public Class frm_define_file

    Dim cl_file As New cl_files
    Dim codeG As New CodeFile
    Dim FileNameAvatar As String
    Dim img As Byte()

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_define_sick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Me.Select_GroupSick_for_doctorTableAdapter.Fill(Me.Ds_GroupSick.Select_GroupSick_for_doctor, cmb_doctors.SelectedValue)

        txt_Code.Text = codeG.NextCodeFile

        txt_DateRegister.Text = ShamsiDate.Miladi2Shamsi(Now, ShamsiDate.ShowType.ShortDate)

    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click

        Select Case cl_file.Check_DuplicateFile(cmb_doctors.SelectedValue, txt_f_name.Text.Trim, txt_l_name.Text.Trim)
            Case 1
                MessageBox.Show("فیلدهای کلیدی (نام-نام خانوادگی-موبایل) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Case 0
                MessageBox.Show("این بیمار قبلا برای این پزشک ثبت شده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
        End Select

        If cmb_groupSick.Text.Trim = "" Then
            MessageBox.Show("گروه بیمار باید مشخص باشد. در صورت فقدان آن برای پزشک حاضر، از قسمت گروه بیماران، گروهی اضافه کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sex As Boolean
        If rb_male.Checked Then sex = True
        If rb_famale.Checked Then sex = False

        Dim Marriage As Byte
        If rb_single.Checked Then Marriage = 0
        If rb_marriage.Checked Then Marriage = 1
        If rb_divorced.Checked Then Marriage = 2

        Try
            If FileNameAvatar <> "" Then img = IO.File.ReadAllBytes(FileNameAvatar)
        Catch ex As Exception
            img = Nothing
        End Try

        Select Case cl_file.Insert_File(txt_f_name.Text, txt_l_name.Text, sex, img, txt_phone.Text, txt_mobile.Text, _
                             txt_dateBirth.Text, txt_email.Text, txt_address.Text, txt_job.Text, _
                             Marriage, Val(txt_weight_.Value.ToString), Val(txt_height.Value.ToString), txt_presenter.Text, _
                             txt_detail.Text, Keep_ID_USER.ID_USER, cmb_groupSick.SelectedValue, cmb_doctors.SelectedValue, _
                             cmb_blood.SelectedText)
            Case 0
                clear()
                MessageBox.Show("بیمار مورد نظر با موفقیت ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("فیلدهای کلیدی (نام-نام خانوادگی-موبایل) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub clear()
        txt_address.Text = ""
        txt_dateBirth.Text = ""
        txt_detail.Text = ""
        txt_email.Text = ""
        txt_f_name.Text = ""
        txt_height.Value = "20"
        txt_job.Text = ""
        txt_l_name.Text = ""
        txt_mobile.Text = ""
        txt_phone.Text = ""
        txt_presenter.Text = ""
        txt_weight_.Value = "20"
        PictureBox.Image = Nothing
        FileNameAvatar = ""
        img = Nothing
    End Sub

    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر بیمار"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar = open.FileName
            PictureBox.Image = Image.FromFile(FileNameAvatar)
        End If
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        PictureBox.Image = Nothing
        img = Nothing
    End Sub

    Private Sub cmb_doctors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctors.SelectedIndexChanged
        Me.Select_GroupSick_for_doctorTableAdapter.Fill(Me.Ds_GroupSick.Select_GroupSick_for_doctor, cmb_doctors.SelectedValue)
    End Sub

    Private Sub btn_CreateNewFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CreateNewFile.Click

        If MessageBox.Show("برای تشکیل پرونده تکراری، ابتدا باید پرونده قبلی بیمار را یافته و اطلاعات را به فیلد های جدید منتقل کنید." + vbCrLf + "متوجه شده ام", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

            frm_Search_File_Advance._FormReturnly = True
            frm_Search_File_Advance.ShowDialog()

            If frm_Search_File_Advance.CodeFile <> 0 Then

                With cl_file.Select_File_WithID(frm_Search_File_Advance.CodeFile)
                    Dim sex As Boolean = .Rows(0)("sex")
                    If sex = True Then rb_male.Checked = True
                    If sex = False Then rb_famale.Checked = True

                    Dim Marriage As Char = .Rows(0)("Marriage")
                    If Marriage = "0" Then rb_single.Checked = True
                    If Marriage = "1" Then rb_marriage.Checked = True
                    If Marriage = "2" Then rb_divorced.Checked = True

                    txt_f_name.Text = .Rows(0)("F_Name")
                    txt_l_name.Text = .Rows(0)("L_Name")
                    txt_address.Text = .Rows(0)("Address")
                    txt_detail.Text = .Rows(0)("Detail")
                    txt_phone.Text = .Rows(0)("Phone")
                    txt_mobile.Text = .Rows(0)("Mobile")
                    txt_email.Text = .Rows(0)("Email")
                    txt_job.Text = .Rows(0)("Job")
                    Select Case .Rows(0)("Blood").ToString.Trim
                        Case "-O"
                            cmb_blood.SelectedIndex = 0
                        Case "+O"
                            cmb_blood.SelectedIndex = 1
                        Case "-A"
                            cmb_blood.SelectedIndex = 2
                        Case "+A"
                            cmb_blood.SelectedIndex = 3
                        Case "-B"
                            cmb_blood.SelectedIndex = 4
                        Case "+B"
                            cmb_blood.SelectedIndex = 5
                        Case "-AB"
                            cmb_blood.SelectedIndex = 6
                        Case "+AB"
                            cmb_blood.SelectedIndex = 7
                    End Select
                    If .Rows(0)("Birth") <> "____/__/__" Then txt_dateBirth.Text = .Rows(0)("Birth")
                    txt_height.Value = Str(.Rows(0)("Height"))
                    txt_weight_.Value = Str(.Rows(0)("Weight"))
                    txt_presenter.Text = .Rows(0)("Presenter")

                    Try
                        Dim file() As Byte = .Rows(0)("Avatar")
                        Dim MS As New MemoryStream()
                        MS.Write(file, 0, file.Length)
                        img = file
                        PictureBox.Image = Bitmap.FromStream(MS)
                    Catch ex As Exception
                        PictureBox.Image = Nothing
                    End Try

                End With
            End If
            frm_Search_File_Advance.Close()
        End If

    End Sub

End Class
