Public Class cl_personal

    Dim Query As New ds_PersonalTableAdapters.Query
    Dim Personal As New ds_PersonalTableAdapters.PersonalTableAdapter
    Dim Select_Personal As New ds_PersonalTableAdapters.Personal_withIDTableAdapter

    Public Function Insert_Personal(
                                ByVal f_name As String, _
                                ByVal l_name As String, _
                                ByVal sex As Boolean, _
                                ByVal avatar As Byte(), _
                                ByVal medical_code As Integer, _
                                ByVal expertise As String, _
                                ByVal phone As String, _
                                ByVal mobile As String, _
                                ByVal address As String, _
                                ByVal type As String, _
                                ByVal visible As Boolean) As Byte

        If f_name.Trim = String.Empty Then Return 1 'f_name
        If l_name.Trim = String.Empty Then Return 1 'l_name
        If expertise = String.Empty Then Return 1 'expertise
        If mobile.Trim = "" Then Return 1 'mobile

        Try
            Personal.Insert_Personal(f_name.Trim, l_name.Trim, sex, avatar, medical_code, expertise.Trim, phone.Trim, mobile.Trim, address.Trim, type, visible)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function GetAvatarPersonal(ByVal id As Long) As Byte()
        Return Query.get_Avatar_Personal(id)
    End Function

    Public Function Select_Personal_withID(ByVal id As Long) As DataTable
        Return Select_Personal.GetData(id)
    End Function

    Public Function Update_Personal(ByVal Id As Long,
                                ByVal f_name As String, _
                                ByVal l_name As String, _
                                ByVal sex As Boolean, _
                                ByVal avatar As Byte(), _
                                ByVal medical_code As String, _
                                ByVal expertise As String, _
                                ByVal phone As String, _
                                ByVal mobile As String, _
                                ByVal address As String, _
                                ByVal type As String, _
                                ByVal visible As Boolean) As Byte

        If f_name = String.Empty Then Return 1 'f_name
        If l_name = String.Empty Then Return 1 'l_name
        If expertise = String.Empty Then Return 1 'expertise
        If mobile = String.Empty Then Return 1 'mobile

        Try
            Personal.Update_personal(Id, f_name.Trim, l_name.Trim, sex, avatar, medical_code, expertise.Trim, phone.Trim, mobile.Trim, address.Trim, type, visible)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Delete_Personal(ByVal ID As Long) As Boolean
        Try
            Personal.Delete_personal(ID)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
