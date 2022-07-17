Imports System.IO

Public Class frm_Show_doctors

    Dim Exec As New ExecuteSP
    Dim cl As New cl_personal
    Dim FileNameAvatar As String 'اسم فایل عکس
    Dim ID As Long   'آیدی دکتر انتخاب شده
    Dim img As Byte()

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frm_Show_doctors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calling_dgv()
        dgv_show.Columns(0).Visible = False
        dgv_show.Columns(1).HeaderText = "نام"
        dgv_show.Columns(1).Width = 85
        dgv_show.Columns(2).HeaderText = "نام خانوادگی"
        dgv_show.Columns(2).Width = 140
        dgv_show.Columns(3).Visible = False
        dgv_show.Columns(4).Visible = False
        dgv_show.Columns(5).Visible = False
        dgv_show.Columns(6).Visible = False
        dgv_show.Columns(7).Visible = False
        dgv_show.Columns(8).Visible = False
        dgv_show.Columns(9).Visible = False
        dgv_show.Columns(10).Visible = False
        dgv_show.Columns(11).Visible = False
        Me.Select_expertiseTableAdapter.Fill(Me.Ds_Expertise.Select_expertise, 0)
    End Sub

    Private Sub txt_Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Search.TextChanged
        Calling_dgv()
    End Sub

    Private Sub Calling_dgv()
        dgv_show.DataSource = Exec.ReturnSelectFromSP("sp_select_Doctors '" & txt_Search.Text & "'").Tables(0)
    End Sub

    Private Sub dgv_show_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_show.CellClick

        ID = dgv_show.SelectedCells(0).Value.ToString
        gb_Edit.Enabled = True
        Call_Filling()
       
    End Sub

    Private Sub btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Update.Click

        If FileNameAvatar <> "" Then img = IO.File.ReadAllBytes(FileNameAvatar)

        Dim sex As Boolean
        If rb_male.Checked Then sex = True
        If rb_famale.Checked Then sex = False

        Dim visibe As Boolean
        If rb_visible.Checked Then visibe = True
        If rb_invisible.Checked Then
            MessageBox.Show("با غیرفعال کردن پزشک، وی از لیست ها خارج شده و پرونده های وی  به آرشیو منتقل می شود", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            visibe = False
        End If

        Select Case cl.Update_Personal(ID, txt_Fname.Text, txt_Lname.Text, sex, img, txt_MedicalCode.Text, cmb_expertise.Text, _
                                        txt_phone.Text, txt_mobile.Text, txt_address.Text, 0, visibe)
            Case 0
                MessageBox.Show("اطلاعات پزشک مورد نظر با موفقیت اصلاح شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Call_Filling()
            Case 1
                MessageBox.Show("فیلد های کلیدی باید پر شود." _
                                + vbCrLf _
                                + "(" _
                                + "نام،" _
                                + "نام خانوادگی،" _
                                + "موبایل،" _
                                + "تخصص" _
                                + ")" _
                                , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select

    End Sub

    Private Sub Call_Filling()

        img = Nothing
        FileNameAvatar = Nothing
        '----------------- پر شدن قسمت نمایش
        dgv_Info.DataSource = Exec.ReturnSelectFromSP("sp_Select_information_Personal " & ID.ToString).Tables(0)
        dgv_Info.Columns(1).Width = 203
        Try
            Dim file() As Byte = cl.GetAvatarPersonal(ID)
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox.Image = Bitmap.FromStream(MS)
        Catch ex As Exception
            PictureBox.Image = Nothing
        End Try
        '------------------- پر شدن قسمت ویرایش 
        If Convert.ToString(cl.Select_Personal_withID(ID).Rows(0)("avatar")) <> "" Then img = cl.Select_Personal_withID(ID).Rows(0)("avatar")
        txt_Fname.Text = cl.Select_Personal_withID(ID).Rows(0)("f_name").ToString
        txt_Lname.Text = cl.Select_Personal_withID(ID).Rows(0)("l_name").ToString
        cmb_expertise.Text = cl.Select_Personal_withID(ID).Rows(0)("expertise").ToString
        Select Case Convert.ToBoolean(cl.Select_Personal_withID(ID).Rows(0)("sex"))
            Case True
                rb_male.Checked = True
            Case False
                rb_famale.Checked = True
        End Select
        txt_MedicalCode.Text = cl.Select_Personal_withID(ID).Rows(0)("medical_code").ToString
        txt_mobile.Text = cl.Select_Personal_withID(ID).Rows(0)("mobile").ToString
        txt_phone.Text = cl.Select_Personal_withID(ID).Rows(0)("phone").ToString
        txt_address.Text = cl.Select_Personal_withID(ID).Rows(0)("address").ToString
        Select Case Convert.ToBoolean(cl.Select_Personal_withID(ID).Rows(0)("visible"))
            Case True
                rb_visible.Checked = True
            Case False
                rb_invisible.Checked = True
        End Select
        Try
            Dim file() As Byte = cl.GetAvatarPersonal(ID)
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox_Edit.Image = Bitmap.FromStream(MS)
        Catch ex As Exception
            PictureBox_Edit.Image = Nothing
        End Try

    End Sub

    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر پزشک"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar = open.FileName
            PictureBox_Edit.Image = Image.FromFile(FileNameAvatar)
        End If
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        img = Nothing
        PictureBox_Edit.Image = Nothing
        FileNameAvatar = Nothing
    End Sub

    Private Sub btn_FullScreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FullScreen.Click
        Try
            Dim file() As Byte = img
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
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_DeleteDoctor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DeleteDoctor.Click
        If MessageBox.Show("با حذف این پزشک تمامی اطلاعات مرتبط با آن حذف می گردد، آیا مطمئن هستید؟.", "توجه بسیار مهم", _
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            cl.Delete_Personal(ID)
            clear()
        End If
    End Sub

    Private Sub clear()
        gb_Edit.Enabled = False
        Calling_dgv()
        dgv_Info.DataSource = Nothing
        PictureBox.Image = Nothing
        txt_address.Text = String.Empty
        txt_Fname.Text = String.Empty
        txt_Lname.Text = String.Empty
        txt_MedicalCode.Text = String.Empty
        txt_mobile.Text = String.Empty
        txt_phone.Text = String.Empty
        PictureBox.Image = Nothing
        img = Nothing
        FileNameAvatar = ""
    End Sub

End Class