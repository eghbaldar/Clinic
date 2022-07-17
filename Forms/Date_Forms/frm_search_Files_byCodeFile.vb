Imports System.IO

Public Class frm_search_Files_byCodeFile

    Dim _ID_File As Long
    Dim cl_CodeFile As New CodeFile
    Dim cl_file As New cl_files
    Dim exec As New ExecuteSP

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_SearchFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SearchFile.Click
        frm_Search_File_Advance._FormReturnly = True
        frm_Search_File_Advance.ShowDialog()
        _ID_File = frm_Search_File_Advance.CodeFile
        frm_Search_File_Advance.Close()
        txt_CodeFile.Text = cl_CodeFile.CurrentCodeFile(_ID_File)
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub txt_CodeFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CodeFile.TextChanged
        Try
            getInfo(cl_CodeFile.GetID_via_CodeFile((Val(txt_CodeFile.Text))))
            _ID_File = cl_CodeFile.GetID_via_CodeFile((Val(txt_CodeFile.Text)))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub getInfo(ByVal ID_FILE As Long)

        dgv_attribiutes.DataSource = exec.ReturnSelectFromSP("sp_Select_information_file_Complete " & ID_FILE.ToString).Tables(0)
        dgv_attribiutes.Columns(1).Width = 468
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

    Private Sub btnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        If exec.ReturnSelectFromSP("sp_Select_information_file_Complete " & _ID_File).Tables(0).Rows(0)(1).ToString <> "" Then
            Dim frm As New frm_Edit_File
            frm.ID_File = _ID_File
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txt_CodeFile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CodeFile.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Dim frm As New frm_Edit_File
            frm.ID_File = _ID_File
            frm.ShowDialog()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _ID_File = cl_CodeFile.GetID_via_CodeFile((Val(txt_CodeFile.Text)))
    End Sub

End Class