Imports System.IO

Public Class frm_define_PhotoBank

    Dim cl_CodeFile As New CodeFile
    Dim cl_file As New cl_files
    Dim cl_photobank As New cl_PhotoBank
    Dim _ID_File As Long
    Dim exec As New ExecuteSP
    Dim FileNameAvatar As String
    Dim img As Byte()

    Private Sub btn_SearchFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchFile.Click

        frm_Search_File_Advance._FormReturnly = True
        frm_Search_File_Advance.ShowDialog()
        _ID_File = frm_Search_File_Advance.CodeFile
        frm_Search_File_Advance.Close()

        If _ID_File <> 0 Then
            txt_CodeFile.Text = cl_CodeFile.CurrentCodeFile(_ID_File)

            getInfo(_ID_File)

            gp_Photos.Enabled = True
            gp_insert_photos.Enabled = True

            txt_insert_detail.Text = ""
            txt_insert_title.Text = ""

            pnl.Controls.Clear()
            FillPhotos()
        End If

    End Sub

    Private Sub btn_insert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_insert.Click

        If FileNameAvatar = String.Empty Then
            MessageBox.Show("عکس مورد نظر خود را انتخاب کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If _ID_File = 0 Then
                MessageBox.Show("ابتدا بیمار مورد نظر را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else

                Try
                    img = IO.File.ReadAllBytes(FileNameAvatar)
                Catch ex As Exception
                End Try

                Select Case cl_photobank.Insert_PhotoBank(_ID_File, txt_insert_title.Text, img, txt_insert_detail.Text)
                    Case 0

                        txt_insert_title.Text = ""
                        txt_insert_detail.Text = ""
                        FileNameAvatar = Nothing
                        img = Nothing
                        pic.Image = Nothing

                        pnl.Controls.Clear()
                        FillPhotos()

                    Case 1
                        MessageBox.Show("فیلد های کلیدی باید پر شود." _
                                                       + vbCrLf _
                                                       + "(" _
                                                       + "عنوان" _
                                                       + ")" _
                                                       , "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Case 2
                        MessageBox.Show("خطایی رخ داده است")
                End Select

            End If
        End If

    End Sub

    Private Sub btnl_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnl_open.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر پزشک"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar = open.FileName
            pic.Image = Image.FromFile(FileNameAvatar)
            img = IO.File.ReadAllBytes(FileNameAvatar)
        End If
    End Sub

    Private Sub btn_Manual_Delete_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Manual_Delete_1.Click
        FileNameAvatar = Nothing
        img = Nothing
        pic.Image = Nothing
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub FillPhotos()

        Dim Count_Object As Integer = cl_photobank.Select_PhotoBank(_ID_File).Rows.Count
        lbl_CountPics.Text = Count_Object

        For i As Integer = 1 To Count_Object

            Dim FLP As New FlowLayoutPanel
            Dim lbl As New Label
            Dim pic As New PictureBox
            Dim btnDel As New PictureBox

            With FLP
                .Size = New Size(167, 225)
            End With
            With lbl
                If cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)("title").ToString.Length >= 25 Then
                    .Text = cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)("title").ToString.Substring(0, 25) & "..."
                Else
                    .Text = cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)("title")
                End If
                .AutoSize = False
                .Width = 180
                ToolTip.SetToolTip(lbl, cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)("title"))
            End With
            With pic
                .Size = New Size(167, 167)
                .BackColor = Color.Gray
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = Color.White
                .BorderStyle = BorderStyle.Fixed3D
                .Cursor = Cursors.Hand
                .Tag = cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)("id")
                AddHandler pic.Click, AddressOf btnFullScreen
                Try
                    Dim file() As Byte = cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)("photo")
                    Dim MS As New MemoryStream()
                    MS.Write(file, 0, file.Length)
                    pic.Image = Bitmap.FromStream(MS)
                Catch ex As Exception
                End Try
            End With
            With btnDel
                .Size = New Size(100, 50)
                .Image = My.Resources.ResourceManager.GetObject("delete")
                .Cursor = Cursors.Hand
                AddHandler btnDel.Click, AddressOf btnDelClick
                btnDel.Tag = cl_photobank.Select_PhotoBank(_ID_File).Rows(i - 1)(0).ToString
            End With

            FLP.Controls.Add(lbl)
            FLP.Controls.Add(pic)
            FLP.Controls.Add(btnDel)
            pnl.Controls.Add(FLP)

        Next

    End Sub

    Private Sub btnDelClick(ByVal sender As Object, ByVal e As EventArgs)
        If MessageBox.Show("آیا از حذف این تصویر مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            pnl.Controls.Clear()
            cl_photobank.Delete_PhotoBank(Val(CType(sender, PictureBox).Tag))
            FillPhotos()
        End If
    End Sub

    Private Sub btnFullScreen(ByVal sender As Object, ByVal e As EventArgs)


        Dim file() As Byte = cl_photobank.Get_PhotoBank(CType(sender, PictureBox).Tag).Rows(0)(0)
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
                _ID_File = newID

                getInfo(newID)
                gp_Photos.Enabled = True
                gp_insert_photos.Enabled = True

                txt_insert_detail.Text = ""
                txt_insert_title.Text = ""

                pnl.Controls.Clear()
                FillPhotos()

            Catch ex As Exception
                If Err.Number = 6 Then
                    MessageBox.Show("شماره پرونده وارده شده خارج از محدوده می باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End If
            End Try
        End If
    End Sub

    Private Sub btn_full_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_full.Click
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