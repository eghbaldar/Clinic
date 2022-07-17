Imports System.IO

Public Class frm_main

    Dim cl As New cl_personal
    Dim cl_Login As New cl_Login
    Dim cl_user As New cl_users
    Dim FileNameAvatar As String 'تصویر کاربر پس از لاگین
    Dim img As Byte() 'تصویر کاربر پس از لاگین

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ''''''''''''''''''''''''''''''''''''''''''''''
        If cl_user.CheckAnyUser() Then
            frm_Login.ShowDialog()
            FillInformationUser()
        Else
            FirstUser()
        End If
        frm_show_period_QuickTask.MdiParent = Me
        frm_show_period_QuickTask.Show()

    End Sub

    Private Sub FillInformationUser()

        Try
            With cl_Login.GetInfoUserAfterLogin()
                lbl_username.Text = .Rows(0)("username").ToString
                lbl_name.Text = .Rows(0)("f_name").ToString
                lbl_family.Text = .Rows(0)("l_name").ToString
                lbl_job.Text = .Rows(0)("job").ToString
                lbl_Rule.Text = .Rows(0)("rule").ToString
            End With
        Catch ex As Exception
            lbl_username.Text = "خطا در بارگزاری"
            lbl_name.Text = "خطا در بارگزاری"
            lbl_family.Text = "خطا در بارگزاری"
            lbl_job.Text = "خطا در بارگزاری"
            lbl_Rule.Text = "خطا در بارگزاری"
        End Try

            Try
                Dim file() As Byte = cl.GetAvatarPersonal(Keep_ID_USER.ID_USER)
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                img_User.Image = Bitmap.FromStream(MS)
            Catch ex As Exception
            End Try

    End Sub

    Private Sub FirstUser()

        If MessageBox.Show("کاربری به سیستم معرفی نشده است." _
                                       + vbCrLf _
                                       + " آیا مایل هستید که کاربر پیشفرض ساخته شود؟" _
                                       , "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then

            If cl_user.Insert_FirstUser Then
                If MessageBox.Show("کاربر پیشفرض ساخته شده است. لطفا یکبار برنامه را بسته و دوباره باز کنید." + _
                                   vbCrLf + _
                                   "مشخصات کاربر جدید:" + _
                                   vbCrLf + _
                                   "نام کاربری: admin" + _
                                   vbCrLf + _
                                   "کلمه عبور: admin" _
                                   , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information) = Windows.Forms.DialogResult.OK Then
                    End
                End If
            End If
        Else
            End
        End If
    End Sub
    '----------------------------------------------------------------

    Private Sub mnu_define_doctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_define_doctor.Click
        frm_define_doctor.MdiParent = Me
        frm_define_doctor.Show()
    End Sub

    Private Sub mnu_doctors_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_doctors.Click
        frm_Show_doctors.MdiParent = Me
        frm_Show_doctors.Show()
    End Sub

    Private Sub mnu_Expertise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Expertise.Click
        frm_define_Expertise.MdiParent = Me
        frm_define_Expertise.Show()
    End Sub

    Private Sub mnu_define_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_define_personal.Click
        frm_define_Personal.MdiParent = Me
        frm_define_Personal.Show()
    End Sub

    Private Sub mnu_careers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_careers.Click
        frm_define_careers.MdiParent = Me
        frm_define_careers.Show()
    End Sub

    Private Sub mnu_personal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_personal.Click
        frm_show_personal.MdiParent = Me
        frm_show_personal.Show()
    End Sub

    Private Sub mnu_manage_users_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_manage_users.Click
        frm_define_user.MdiParent = Me
        frm_define_user.Show()
    End Sub

    Private Sub mnu_insurance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_insurance.Click
        frm_define_insurance.MdiParent = Me
        frm_define_insurance.Show()
    End Sub

    Private Sub mnu_define_sick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_define_sick.Click
        frm_define_file.MdiParent = Me
        frm_define_file.Show()
    End Sub

    Private Sub mnu_GroupSick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_GroupSick.Click
        frm_define_GroupSick.MdiParent = Me
        frm_define_GroupSick.Show()
    End Sub

    Private Sub mnu_RecordTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_RecordTitle.Click
        frm_define_recordTitle.MdiParent = Me
        frm_define_recordTitle.Show()
    End Sub

    Private Sub mnu_Files_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Files.Click
        frm_search_Files_byCodeFile.MdiParent = Me
        frm_search_Files_byCodeFile.Show()
    End Sub

    Private Sub mnu_Define_Surgey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Define_Surgey.Click
        frm_define_SurgeyForFiles.MdiParent = Me
        frm_define_SurgeyForFiles.Show()
    End Sub

    Private Sub mnu_SearchFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_SearchFile.Click
        frm_Search_File_Advance.MdiParent = Me
        frm_Search_File_Advance.Show()
    End Sub

    Private Sub mnu_PhotoBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_PhotoBank.Click
        frm_define_PhotoBank.MdiParent = Me
        frm_define_PhotoBank.Show()
    End Sub

    Private Sub mnu_period_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_period.Click
        frm_define_period.MdiParent = Me
        frm_define_period.Show()
    End Sub

    Private Sub mnu_Backup_Resotre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Backup_Resotre.Click
        frm_BackupDB.MdiParent = Me
        frm_BackupDB.Show()
    End Sub


    Private Sub mnuManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManagement.Click
        Dim frm As New frm_management
        frm.ShowDialog()
    End Sub

    Private Sub mnu_search_PeriodByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_search_PeriodByDate.Click
        frm_show_period_today.MdiParent = Me
        frm_show_period_today.Show()
    End Sub

    Private Sub mnu_PeriodToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_PeriodToday.Click
        frm_show_period_Todday.MdiParent = Me
        frm_show_period_Todday.Show()
    End Sub

    Private Sub btnPeriodTomorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodTomorrow.Click
        frm_show_period_Tomorrow.MdiParent = Me
        frm_show_period_Tomorrow.Show()
    End Sub

    Private Sub btnPeriodAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodAll.Click
        frm_show_period_today.MdiParent = Me
        frm_show_period_All.Show()
    End Sub

    Private Sub mnu_reception_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_reception.Click
        frm_define_reception.MdiParent = Me
        frm_define_reception.Show()
    End Sub

    Private Sub mnu_Priority_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Priority.Click
        frm_define_priority.MdiParent = Me
        frm_define_priority.Show()
    End Sub

    Private Sub mnu_Done_Reception_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Done_Reception.Click
        frm_show_reception.MdiParent = Me
        frm_show_reception.Show()
    End Sub

    Private Sub mnu_Define_Visit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Define_Visit.Click
        frm_define_prescription.MdiParent = Me
        frm_define_prescription.Show()
    End Sub

    Private Sub mnu_Done_Prescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Done_Prescription.Click
        frm_show_prescription.MdiParent = Me
        frm_show_prescription.Show()
    End Sub

End Class
