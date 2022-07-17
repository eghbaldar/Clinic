Public Class cl_files

    Dim Ds_File As New ds_FileTableAdapters.Select_fileTableAdapter
    Dim DS_File_ID As New ds_FileTableAdapters.Select_file_withIDTableAdapter
    Dim DS_File_Check As New ds_FileTableAdapters.Select_File_CheckFileTableAdapter
    Dim DS_File_IdName_Doctor As New ds_FileTableAdapters.Select_ID_Name_DoctorTableAdapter
    Dim DS_Query As New ds_FileTableAdapters.Query
    Dim cl_exec As New ExecuteSP

    Public Function Insert_File(ByVal F_Name As String, ByVal L_Name As String, ByVal sex As Boolean _
                                , ByVal Avatar As Byte(), ByVal Phone As String, ByVal Mobile As String _
                                , ByVal Birth As String, ByVal Email As String, ByVal address As String, _
                                ByVal job As String, ByVal Marriage As String, ByVal Weight As Integer _
                                , ByVal Height As Integer, ByVal Presenter As String, ByVal Detail As String, _
                            ByVal Id_User As Long, ByVal id_groupSick As Integer, ByVal id_personal As Long, _
                            ByVal blood As String) As Boolean

        If F_Name = String.Empty Then Return 1
        If L_Name = String.Empty Then Return 1
        If Mobile = String.Empty Then Return 1

        Try
            Ds_File.Insert_file(F_Name.Trim, L_Name.Trim, sex, Avatar, Phone.Trim, Mobile.Trim, Birth.Trim, _
                                Email.Trim, address.Trim, job.Trim, Marriage, Weight, Height, Presenter.Trim, Detail.Trim, _
                                Id_User, Date.Now, id_groupSick, id_personal, blood.Trim)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Update_File(ByVal F_Name As String, ByVal L_Name As String, ByVal sex As Boolean _
                                , ByVal Avatar As Byte(), ByVal Phone As String, ByVal Mobile As String _
                                , ByVal Birth As String, ByVal Email As String, ByVal address As String, _
                                ByVal job As String, ByVal Marriage As String, ByVal Weight As Integer _
                                , ByVal Height As Integer, ByVal Presenter As String, ByVal Detail As String, _
                             ByVal id_groupSick As Integer, ByVal id_personal As Long, _
                            ByVal blood As String, ByVal ID_FILE As Long) As Boolean

        If F_Name = String.Empty Then Return 1
        If L_Name = String.Empty Then Return 1
        If Mobile = String.Empty Then Return 1

        Try
            Ds_File.Update_file(F_Name.Trim, L_Name.Trim, sex, Avatar, Phone.Trim, Mobile.Trim, Birth.Trim, _
                                Email.Trim, address.Trim, job.Trim, Marriage, Weight, Height, Presenter.Trim, Detail.Trim, _
                                id_groupSick, id_personal, blood.Trim, ID_FILE)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Get_NextIdFile() As Long
        Return DS_Query.Select_NextIdFile()
    End Function

    Public Function Get_ID_Doctor(ByVal ID_File As Long) As DataTable
        Return DS_File_IdName_Doctor.GetData(ID_File)
    End Function

    Public Function Get_Avatar_File(ByVal id As Long) As Byte()
        Return DS_Query.Select_Avatar_File(id)
    End Function

    Public Function Select_File_WithID(ByVal ID As Long) As DataTable
        Return DS_File_ID.GetData(ID)
    End Function

    Public Function Check_DuplicateFile(ByVal ID_Personal As Long, ByVal f_name As String, ByVal l_name As String) As Byte

        If f_name = String.Empty Then Return 1
        If l_name = String.Empty Then Return 1

        If DS_Query.Select_checkDuplicateFile(ID_Personal, f_name.Trim, l_name.Trim) > 0 Then
            Return 0 'این شخص برای این دکتر تکراری است
        Else
            Return 2 'تکراری نیست
        End If
    End Function

    Public Function GetLastIdFile() As Long
        Return DS_Query.Select_getLastIdFile
    End Function

    Public Function Select_File_Information_Complete(ByVal ID_File As Long) As DataSet
        Return cl_exec.ReturnSelectFromSP("sp_Select_information_file_Complete " + ID_File.ToString)
    End Function

    Public Function CheckFile(ByVal ID As Long) As Boolean
        If Val(DS_File_Check.GetData(ID).Rows(0)(0)) = 0 Then
            MessageBox.Show("بیماری با این شماره پرونده ثبت نشده است.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        Else
            Return True
        End If
    End Function

End Class
