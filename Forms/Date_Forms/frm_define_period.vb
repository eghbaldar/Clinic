Imports System.IO

Public Class frm_define_period

    Dim cl_Period As New cl_period
    Dim _ID_File As Long
    Dim cl_CodeFile As New CodeFile
    Dim cl_file As New cl_files
    Dim exec As New ExecuteSP

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btn_Consideration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Consideration.Click
        If txt_date_Considration.Text <> "____/__/__" Then
            Me.Select_Period_ByDateTableAdapter.Fill(Me.Ds_Period.Select_Period_ByDate, ShamsiDate.ShamsiToMiladi(txt_date_Considration.Text), _
                                         Cmb_Considration.SelectedValue)
        Else
            MessageBox.Show("لطفا تاریخ بررسی را وارد کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frm_define_period_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Me.Select_GroupSick_for_doctorTableAdapter.Fill(Me.Ds_GroupSick.Select_GroupSick_for_doctor, cmb_doctors.SelectedValue)
    End Sub

    Private Sub getInfo(ByVal ID_FILE As Long)

        dgv_attribiutes.DataSource = exec.ReturnSelectFromSP("sp_Select_information_File " & _ID_File.ToString).Tables(0)
        dgv_attribiutes.Columns(1).Width = 320
        dgv_attribiutes.Refresh()

        Try
            Dim file() As Byte = cl_file.Get_Avatar_File(ID_FILE)
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox.Image = Bitmap.FromStream(MS)

        Catch ex As Exception
            PictureBox.Image = My.Resources.ResourceManager.GetObject("avatar")
        End Try

    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click

        If txt_inseret_Date.Text = "____/__/__" Or txt_Insert_Time.Text.Trim.Length <> 5 Then
            MessageBox.Show("پر کردن فیلد های تاریخ و زمان اجباری است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Else
            If CheckTime(txt_Insert_Time.Text.Trim) Then
                Dim type As Byte
                If rb_insert_absent.Checked Then type = 1
                If rb_insert_Tel.Checked Then type = 0
                '''''''''''''''''''''''''''''''''''''''''''''''''''
                Select Case cl_Period.Insert_Period(_ID_File, type, cmb_insert_doctor.SelectedValue, GetContactDate(txt_inseret_Date.Text, txt_Insert_Time.Text))
                    Case True
                        MessageBox.Show("نوبت شما با موفقیت اضافه گردید", "توحه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        '''''' open window with this datetime
                        frm_show_period_today._FlagPage = True
                        frm_show_period_today._Date_Period = txt_inseret_Date.Text
                        frm_show_period_today._ID_Personal = cmb_insert_doctor.SelectedValue
                        frm_show_period_today.ShowDialog()
                        frm_show_period_today._FlagPage = False
                        '''''''
                        clear()
                    Case False
                        MessageBox.Show("خطایی رخ داده است")
                End Select
            Else
                MessageBox.Show("زمان وارده صحیح نمی باشد.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If

    End Sub

    Public Function GetContactDate(ByVal dt As String, ByVal tm As String) As DateTime
        Return DateTime.Parse(ShamsiDate.ShamsiToMiladi(dt) + " " + tm)
    End Function

    Private Function CheckTime(ByVal tm As String) As Boolean
        If Val(tm.Substring(0, 2)) >= 24 Then Return False
        If Val(tm.Substring(3, 2)) > 59 Then Return False
        Return True
    End Function

    Sub clear()
        txt_inseret_Date.Text = "____/__/__"
        txt_Insert_Time.Text = ""
    End Sub

    Sub clear2()
        txt_f_name.Text = ""
        txt_l_name.Text = ""
        txt_mobile.Text = ""
    End Sub

    Private Sub btn_SearchFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchFile.Click
        frm_Search_File_Advance._FormReturnly = True
        frm_Search_File_Advance.ShowDialog()
        _ID_File = frm_Search_File_Advance.CodeFile
        frm_Search_File_Advance.Close()

        If _ID_File <> 0 Then
            txt_CodeFile.Text = cl_CodeFile.CurrentCodeFile(_ID_File)
            If _ID_File <> 0 Then
                getInfo(_ID_File)
                gp.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnInsertFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertFile.Click

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

        Select Case cl_file.Insert_File(txt_f_name.Text, txt_l_name.Text, 0, Nothing, 0, txt_mobile.Text, "", "", "", "", 0, 0, 0, "", _
                             "", Keep_ID_USER.ID_USER, cmb_groupSick.SelectedValue, cmb_doctors.SelectedValue, "")
            Case 0
                clear2()
                TabControl.SelectedIndex = 0
                _ID_File = cl_file.GetLastIdFile
                txt_CodeFile.Text = cl_CodeFile.CurrentCodeFile(cl_file.GetLastIdFile)
                getInfo(cl_file.GetLastIdFile)
                gp.Enabled = True
                MessageBox.Show("بیمار مورد نظر با موفقیت ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("فیلدهای کلیدی (نام-نام خانوادگی-موبایل) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub cmb_doctors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctors.SelectedIndexChanged
        Me.Select_GroupSick_for_doctorTableAdapter.Fill(Me.Ds_GroupSick.Select_GroupSick_for_doctor, cmb_doctors.SelectedValue)
    End Sub


    Private Sub btnShowPeriodToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPeriodToday.Click
        frm_show_period_Todday.ShowDialog()
    End Sub

    Private Sub btnShowPeriodTomorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPeriodTomorrow.Click
        frm_show_period_Tomorrow.ShowDialog()
    End Sub

    Private Sub btnShowPeriodAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowPeriodAll.Click
        frm_show_period_All.ShowDialog()
    End Sub

    Private Sub btn_showAttributes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_showAttributes.Click
        If txt_CodeFile.Text.Trim <> String.Empty Then
            Try
                Dim newID As Long = cl_CodeFile.GetID_via_CodeFile(Val(txt_CodeFile.Text))
                If cl_file.CheckFile(newID) Then
                    _ID_File = newID
                    getInfo(_ID_File)
                    gp.Enabled = True
                End If
            Catch ex As Exception
                If Err.Number = 6 Then
                    MessageBox.Show("شماره پرونده وارده شده خارج از محدوده می باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End Try
        End If
    End Sub

End Class