Public Class cl_Login

    Dim DS_Query As New ds_LoginTableAdapters.Query
    Dim DS_SelectInfoUSerAfterLogin As New ds_LoginTableAdapters.Select_InfoUserAfterLoginTableAdapter

    Public Function CheckLogin(ByVal username As String, ByVal password As String) As Integer
        Return DS_Query.Select_checkLogin(username.Trim, password.Trim)
    End Function

    Public Function GetInfoUserAfterLogin() As DataTable
        Return DS_SelectInfoUSerAfterLogin.GetData(Keep_ID_USER.ID_USER)
    End Function

End Class
