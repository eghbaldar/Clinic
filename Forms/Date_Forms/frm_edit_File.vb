Imports System.IO

Public Class frm_Edit_File

    Dim cl_file As New cl_files
    Dim Code As New CodeFile

    Private _ID_File As Long
    Public Property ID_File As Long
        Get
            Return _ID_File
        End Get
        Set(ByVal value As Long)
            _ID_File = value
        End Set
    End Property

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub frm_Edit_File_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '----------------------------File Attribiute --------------------------
        '----------------------------------------------------------------------
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Me.Select_GroupSick_for_doctorTableAdapter.Fill(Me.Ds_GroupSick.Select_GroupSick_for_doctor, cmb_doctors.SelectedValue)

        With cl_file.Select_File_WithID(_ID_File)
            txt_Code.Text = Code.CurrentCodeFile(.Rows(0)("id").ToString)
            txt_f_name.Text = .Rows(0)("F_Name").ToString
            txt_l_name.Text = .Rows(0)("l_Name").ToString
            txt_address.Text = .Rows(0)("Address").ToString
            txt_detail.Text = .Rows(0)("Detail").ToString
            txt_phone.Text = .Rows(0)("Phone").ToString
            txt_mobile.Text = .Rows(0)("Mobile").ToString
            txt_email.Text = .Rows(0)("Email").ToString
            txt_job.Text = .Rows(0)("Job").ToString
            txt_height.Text = .Rows(0)("Height").ToString
            txt_wieght.Text = .Rows(0)("Weight").ToString
            txt_presenter.Text = .Rows(0)("Presenter").ToString
            txt_dateBirth.Text = .Rows(0)("Birth").ToString
            txt_DateRegister.Text = ShamsiDate.Miladi2Shamsi(.Rows(0)("Date_").ToString, ShamsiDate.ShowType.ShortDate)

            cmb_doctors.SelectedValue = Val(.Rows(0)("Id_Personal").ToString)
            cmb_groupSick.SelectedValue = Val(.Rows(0)("Id_GroupSick").ToString)
            Select Case .Rows(0)("Blood").ToString.Trim.ToUpper 'توجه: به دلایل نامعلوم پس از درج جای + و - جابجا می شود
                Case "O-"
                    cmb_blood.SelectedIndex = 0
                Case "O+"
                    cmb_blood.SelectedIndex = 1
                Case "A-"
                    cmb_blood.SelectedIndex = 2
                Case "A+"
                    cmb_blood.SelectedIndex = 3
                Case "B-"
                    cmb_blood.SelectedIndex = 4
                Case "B+"
                    cmb_blood.SelectedIndex = 5
                Case "AB-"
                    cmb_blood.SelectedIndex = 6
                Case "AB+"
                    cmb_blood.SelectedIndex = 7
            End Select

            Dim sex As Boolean = Convert.ToBoolean(.Rows(0)("sex").ToString)
            If sex = True Then rb_male.Checked = True
            If sex = False Then rb_famale.Checked = True

            Dim Marriage As Byte = .Rows(0)("Marriage").ToString
            If Marriage = 0 Then rb_single.Checked = True
            If Marriage = 1 Then rb_marriage.Checked = True
            If Marriage = 2 Then rb_divorced.Checked = True

            Try
                Dim file() As Byte = .Rows(0)("avatar")
                Dim MS As New MemoryStream()
                MS.Write(file, 0, file.Length)
                img = file
                PictureBox.Image = Bitmap.FromStream(MS)
            Catch ex As Exception
                PictureBox.Image = Nothing
            End Try

        End With
        '----------------------------File_manual-------------------------------
        '----------------------------------------------------------------------
        With cl_ManualFile.Select_ManualFile(_ID_File)
            If .Rows.Count > 0 Then
                txt_CodeManual.Text = .Rows(0)("code_manual").ToString

                '------------------ file 1
                Try
                    Dim file_1() As Byte = .Rows(0)("file_1")
                    img_manual_1 = file_1
                    Dim MS As New MemoryStream()
                    MS.Write(file_1, 0, file_1.Length)
                    pic_Manual_1.Image = Bitmap.FromStream(MS)
                Catch ex As Exception
                    pic_Manual_1.Image = Nothing
                End Try
                '------------------ file 2
                Try
                    Dim file_2() As Byte = .Rows(0)("file_2")
                    img_manual__2 = file_2
                    Dim MS As New MemoryStream()
                    MS.Write(file_2, 0, file_2.Length)
                    pic_Manual_2.Image = Bitmap.FromStream(MS)
                Catch ex As Exception
                    pic_Manual_2.Image = Nothing
                End Try
            End If
        End With

        '------------------------------Record-----------------------------
        '-----------------------------------------------------------
        Me.Select_RecordTitleForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitleForFile, _
                                                      cl_file.Get_ID_Doctor(_ID_File).Rows(0)("id_personal"), _ID_File)
        Me.Select_RecordForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordForFile, _ID_File)
        lbl_Record_Doctor.Text = cl_file.Get_ID_Doctor(_ID_File).Rows(0)("Doctor_Name")
        dgv_RecordForTitle.Columns(0).Visible = False
        '-----------------------------------------------------------
        '----------------------------Surgery------------------------
        FillSurgeryGrid(_ID_File)
        dgv_list_surgery.Columns(0).Visible = False
        '-----------------------------------------------------------
        '----------------------------BankPhoto----------------------
        Me.Select_PhotoBankTableAdapter.Fill(Me.Ds_PhotoBank.Select_PhotoBank, _ID_File)
        '----------------------------Prescription
        Me.Select_prescription_FileTableAdapter.Fill(Me.Ds_prescription.Select_prescription_File, _ID_File)
        Dgv_Prescription.Columns(0).Visible = False
        '-------------------------------------------------------------

    End Sub

#Region "Manual__File"

    Dim FileNameAvatar_manual__1 As String
    Dim FileNameAvatar_manual__2 As String
    Dim img_manual_1 As Byte()
    Dim img_manual__2 As Byte()
    Dim cl_ManualFile As New cl_ManualFile

    Private Sub btn_open_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual_open_1.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر پزشک"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar_manual__1 = open.FileName
            pic_Manual_1.Image = Image.FromFile(FileNameAvatar_manual__1)
        End If
    End Sub

    Private Sub btn_open_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual_open_2.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر پزشک"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar_manual__2 = open.FileName
            pic_Manual_2.Image = Image.FromFile(FileNameAvatar_manual__2)
        End If
    End Sub

    Private Sub btn_Update_ManualFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_ManualFile.Click

        If FileNameAvatar_manual__1 <> "" Then img_manual_1 = IO.File.ReadAllBytes(FileNameAvatar_manual__1)
        If FileNameAvatar_manual__2 <> "" Then img_manual__2 = IO.File.ReadAllBytes(FileNameAvatar_manual__2)

        'If txt_CodeManual.Text.Trim = "" Then
        '    MessageBox.Show("شماره پرونده دستی باید تکمیل گردد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        If cl_ManualFile.Insert_Update_ManualFile(_ID_File, txt_CodeManual.Text, img_manual_1, img_manual__2) Then
            MessageBox.Show("پرونده دستی با موفقیت تثب شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Manual_Delete_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual_Delete_1.Click
        FileNameAvatar_manual__1 = Nothing
        img_manual_1 = Nothing
        pic_Manual_1.Image = Nothing
    End Sub

    Private Sub btn_Manual_delete_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual_delete_2.Click
        FileNameAvatar_manual__2 = Nothing
        img_manual__2 = Nothing
        pic_Manual_2.Image = Nothing
    End Sub

#End Region

#Region "Record"

    Dim cl_RecordTitle As New cl_RecordTitle

    Private Sub btn_InsertRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_InsertRecord.Click
        If lst_Records.Items.Count > 0 Then
            If cl_RecordTitle.Insert_RecordTitle_ToFile(_ID_File, lst_Records.SelectedValue) Then
                Me.Select_RecordTitleForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitleForFile, _
                                                          cl_file.Get_ID_Doctor(_ID_File).Rows(0)("id_personal"), _ID_File)
                Me.Select_RecordForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordForFile, _ID_File)
            End If
        End If
    End Sub

    Private Sub dgv_RecordForTitle_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_RecordForTitle.CellContentClick
        If e.ColumnIndex = 4 Then
            If MessageBox.Show("آیا از حذف این سابقه مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                cl_RecordTitle.Delete_RecordFromFile(_ID_File, dgv_RecordForTitle.CurrentRow.Cells(0).Value)
                Me.Select_RecordTitleForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordTitleForFile, _
                                                         cl_file.Get_ID_Doctor(_ID_File).Rows(0)("id_personal"), _ID_File)
                Me.Select_RecordForFileTableAdapter.Fill(Me.Ds_RecordTitle.Select_RecordForFile, _ID_File)
            End If
        End If
    End Sub

    Private Sub dgv_RecordForTitle_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_RecordForTitle.CellEndEdit

        If cl_RecordTitle.Update_RecordFromFile(_ID_File, dgv_RecordForTitle.Rows(e.RowIndex).Cells(0).Value.ToString, _
                                             dgv_RecordForTitle.Rows(e.RowIndex).Cells(3).Value.ToString) Then
            MessageBox.Show("توضیح سابقه مورد نظر بدرستی ثبت شد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

#End Region

#Region "Surgery"

    Sub FillSurgeryGrid(ByVal ID_File As Long)
        Me.Select_SurgeryTableAdapter.Fill(Me.Ds_Surgery.Select_Surgery, ID_File)
    End Sub

    Private Sub btnShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowInfo.Click

        frm_information_surgery.ID_Surgery = dgv_list_surgery.Rows(dgv_list_surgery.CurrentRow.Index).Cells(1).Value.ToString()
        frm_information_surgery.ShowDialog()

    End Sub

#End Region

#Region "BankPhoto"

    Private Sub btn_showPhotoBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_showPhotoBank.Click

        Dim file() As Byte = dgv_BankPhoto.Rows(dgv_BankPhoto.CurrentRow.Index).Cells(3).Value
        Dim MS As New MemoryStream()
        MS.Write(file, 0, file.Length)

        Dim frm As New Form
        Dim pic As New PictureBox
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.MinimizeBox = False
        pic.SizeMode = PictureBoxSizeMode.Zoom
        pic.Dock = DockStyle.Fill
        pic.Image = Bitmap.FromStream(MS)
        frm.Controls.Add(pic)
        frm.ShowDialog()

    End Sub

#End Region

#Region "File Attribiute"

    Dim FileNameAvatar As String
    Dim img As Byte()

    Private Sub cmb_doctors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctors.SelectedIndexChanged
        Me.Select_GroupSick_for_doctorTableAdapter.Fill(Me.Ds_GroupSick.Select_GroupSick_for_doctor, cmb_doctors.SelectedValue)
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

    Private Sub btn_Update_OriginalInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update_OriginalInfo.Click

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

        Select Case         cl_file.Update_File(txt_f_name.Text, txt_l_name.Text, sex, img, txt_phone.Text, txt_mobile.Text, txt_dateBirth.Text, _
                            txt_email.Text, txt_address.Text, txt_job.Text, Marriage, txt_wieght.Text, txt_height.Text, txt_presenter.Text, txt_detail.Text, _
                            cmb_groupSick.SelectedValue, cmb_doctors.SelectedValue, cmb_blood.Text, _ID_File)
            Case 0
                MessageBox.Show("اطلاعات بیمار مورد نظر با موفقیت اصلاح شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 1
                MessageBox.Show("فیلدهای کلیدی (نام-نام خانوادگی-موبایل) باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select


    End Sub

#End Region
    


End Class