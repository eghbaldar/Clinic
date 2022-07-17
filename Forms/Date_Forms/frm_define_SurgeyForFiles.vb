Imports System.IO

Public Class frm_define_SurgeyForFiles

    Dim cl_CodeFile As New CodeFile
    Dim cl_file As New cl_files
    Dim cl_surgery As New cl_Surgery
    Dim exec As New ExecuteSP
    Dim _ID_File As Long
    Dim ID_Record As Long

    Private Sub btn_SearchFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchFile.Click

        frm_Search_File_Advance._FormReturnly = True
        frm_Search_File_Advance.ShowDialog()
        _ID_File = frm_Search_File_Advance.CodeFile
        frm_Search_File_Advance.Close()

        If _ID_File <> 0 Then
            txt_CodeFile.Text = cl_CodeFile.CurrentCodeFile(_ID_File)
            FillSurgeryGrid(_ID_File)
            getInfo(_ID_File)

            gp_insert_Surgey.Enabled = True
            gp_list_surgey.Enabled = True
            gp_DetailSurgery.Enabled = False

            txt_dateDone.Text = "____/__/__"
            txt_detail_done.Text = ""
            txt_insert_date.Text = ""
            txt_insert_date.Text = "____/__/__"
            txt_insert_detail.Text = ""
            txt_insert_title.Text = ""
            txt_result.Text = ""
            lbl_DateSurgery.Text = ""
            lbl_Title.Text = ""
        End If

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub getInfo(ByVal ID_FILE As Long)

        dgv_attribiutes.DataSource = exec.ReturnSelectFromSP("sp_Select_information_File " & ID_FILE.ToString).Tables(0)
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

    Private Sub btn_showAttributes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_showAttributes.Click

        If txt_CodeFile.Text.Trim <> String.Empty Then
            Try
                Dim newID As Long = cl_CodeFile.GetID_via_CodeFile(Val(txt_CodeFile.Text))
                If cl_file.CheckFile(newID) Then
                    _ID_File = newID
                    FillSurgeryGrid(newID)
                    getInfo(newID)
                    gp_insert_Surgey.Enabled = True
                    gp_list_surgey.Enabled = True
                    gp_DetailSurgery.Enabled = False
                End If
            Catch ex As Exception
                If Err.Number = 6 Then
                    MessageBox.Show("شماره پرونده وارده شده خارج از محدوده می باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End Try
        End If

    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        If _ID_File = 0 Then
            MessageBox.Show("ابتدا بیمار مورد نظر را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf txt_insert_date.Text = "____/__/__" Then
            MessageBox.Show("تاریخ جراحی را مشخص کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Select Case cl_surgery.Insert_Surgery(_ID_File, txt_insert_title.Text.Trim, txt_insert_detail.Text.Trim, _
                                                  txt_insert_date.Text.Trim)
                Case 0
                    'MessageBox.Show("جراحی مورد نظر با موفقیت ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    txt_insert_date.Text = ""
                    txt_insert_title.Text = ""
                    txt_insert_detail.Text = ""
                    FillSurgeryGrid(_ID_File)
                Case 1
                    MessageBox.Show("فیلد های کلیدی باید پر شود." _
                                                   + vbCrLf _
                                                   + "(" _
                                                   + "عنوان،" _
                                                   + "توضیحات" _
                                                   + ")" _
                                                   , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    MessageBox.Show("خطایی رخ داده است")
            End Select

        End If

    End Sub

    Sub FillSurgeryGrid(ByVal ID_File As Long)
        Me.Select_SurgeryTableAdapter.Fill(Me.Ds_Surgery.Select_Surgery, ID_File)
    End Sub

    Private Sub frm_define_SurgeyForFiles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillSurgeryGrid(Nothing)
    End Sub

    Private Sub dgv_list_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_list.CellClick

        With cl_surgery.Select_SurgeryWithID(dgv_list.Rows(dgv_list.CurrentRow.Index).Cells(0).Value.ToString)

            gp_DetailSurgery.Enabled = True

            ID_Record = .Rows(0)("ID").ToString
            lbl_Title.Text = .Rows(0)("surgery_title").ToString
            lbl_DateSurgery.Text = ShamsiDate.Miladi2Shamsi(.Rows(0)("Surgery_Date").ToString, ShamsiDate.ShowType.LongDate)

            If .Rows(0)("type").ToString = "0" Then
                rb_NOK.Checked = True
                rb_OK.Checked = False
            ElseIf .Rows(0)("type").ToString = "1" Then
                rb_NOK.Checked = False
                rb_OK.Checked = True
            End If

            If Convert.ToDateTime(.Rows(0)("done_date").ToString).ToShortDateString = "1/1/1900" Then
                txt_dateDone.Text = "____/__/__"
            Else
                If .Rows(0)("done_date").ToString <> Nothing Then
                    txt_dateDone.Text = ShamsiDate.MiladiToShamsiFull(.Rows(0)("done_date").ToString)
                Else
                    txt_dateDone.Text = "____/__/__"
                End If
            End If

            txt_detail_done.Text = .Rows(0)("detail").ToString
            txt_result.Text = .Rows(0)("result").ToString
        End With

    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click

        If ID_Record = Nothing Then
            MessageBox.Show("جراحی انتخاب نشده است", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MessageBox.Show("آیا از حذف این عمل جراحی مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            cl_surgery.Delete_Surgery(ID_Record)
            FillSurgeryGrid(_ID_File)

            gp_DetailSurgery.Enabled = False
            ID_Record = Nothing
            lbl_DateSurgery.Text = ""
            lbl_Title.Text = ""
            txt_detail_done.Text = ""
            txt_dateDone.Text = "____/__/__"
            txt_result.Text = ""
        End If
        If dgv_list.Rows.Count = 0 Then
            gp_insert_Surgey.Enabled = False
            gp_list_surgey.Enabled = False
            gp_DetailSurgery.Enabled = False
        End If

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        Dim Type As String
        If rb_OK.Checked Then Type = 1
        If rb_NOK.Checked Then Type = 0

        If _ID_File = 0 Then
            MessageBox.Show("ابتدا بیمار مورد نظر را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        ElseIf txt_dateDone.Text = "____/__/__" Then
            MessageBox.Show("تاریخ جراحی انجام شده را مشخص کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Select Case cl_surgery.Update_Surgery(ID_Record, Type, txt_detail_done.Text, txt_dateDone.Text, txt_result.Text)
                Case 0
                    MessageBox.Show("جراحی مورد نظر با موفقیت اصلاح شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    txt_insert_date.Text = ""
                    txt_insert_title.Text = ""
                    txt_insert_detail.Text = ""
                    FillSurgeryGrid(_ID_File)
                Case 1
                    MessageBox.Show("فیلد کلیدی باید پر شود." _
                                                   + vbCrLf _
                                                   + "(" _
                                                   + "تویضحات" _
                                                   + ")" _
                                                   , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Case 2
                    MessageBox.Show("خطایی رخ داده است")
            End Select
        End If

    End Sub

End Class