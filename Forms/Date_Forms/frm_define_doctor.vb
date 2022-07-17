Imports System.IO

Public Class frm_define_doctor

    Dim cl As New cl_personal
    Dim FileNameAvatar As String
    Dim img As Byte()

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btn_Insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Insert.Click

        Dim sex As Boolean
        Try
            img = IO.File.ReadAllBytes(FileNameAvatar)
            If rb_male.Checked Then sex = True
            If rb_famale.Checked Then sex = False
        Catch ex As Exception
        End Try

        Select Case cl.Insert_Personal(txt_Fname.Text, txt_Lname.Text, sex, img, Val(txt_MedicalCode.Text), _
                                       cmb_expertise.Text _
                           , txt_phone.Text, txt_mobile.Text, txt_address.Text, 0, True)
            Case 0
                MessageBox.Show("پزشک جدید با موفقیت ثبت شد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
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

        Me.PersonalTableAdapter.Fill(Me.Ds_Personal.Personal, 0)

    End Sub

    Private Sub frm_define_doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Select_expertiseTableAdapter.Fill(Me.Ds_Expertise.Select_expertise, 0)
        Me.PersonalTableAdapter.Fill(Me.Ds_Personal.Personal, 0)
        Try
            cmb_expertise.SelectedIndex = 0
        Catch ex As Exception
        End Try

    End Sub

    Private Sub clear()
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

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub btn_Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Refresh.Click
        Me.PersonalTableAdapter.Fill(Me.Ds_Personal.Personal, 0)
    End Sub

    Private Sub btn_ShowInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ShowInfo.Click
        If dgv.RowCount > 0 Then
            Dim frm As New frm_information_personal
            frm.ID = dgv.SelectedCells(0).Value.ToString
            frm.ShowDialog()
        End If        
    End Sub

    Private Sub btn_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Open.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر پزشک"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar = open.FileName
            PictureBox.Image = Image.FromFile(FileNameAvatar)
            img = IO.File.ReadAllBytes(FileNameAvatar)
        End If
    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        img = Nothing
        FileNameAvatar = Nothing
        PictureBox.Image = Nothing
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

End Class