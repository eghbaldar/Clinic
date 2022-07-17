Public Class cl_users

    Dim User As New ds_usersTableAdapters.Select_usersTableAdapter
    Dim CheckAnyUser_ As New ds_usersTableAdapters.Select_checkAnyUserTableAdapter

    Public Function Insert_Update_User(ByVal Id_Personnel As Long, ByVal username As String, _
                                       ByVal password As String, ByVal flag As Boolean, ByVal type As String) As Boolean

        If username = String.Empty Then Return 1
        If password = String.Empty Then Return 1

        Try
            User.Insert_Update_user(Id_Personnel, flag, username.Trim, password.Trim, type, Nothing, Date.Now, True)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Insert_FirstUser() As Boolean
        'Try
        User.Insert_FristUser()
        Return True
        'Catch ex As Exception
        'Return False
        'End Try
    End Function

    Public Function CheckAnyUser() As Boolean
        If Val(CheckAnyUser_.GetData().Rows(0)(0).ToString) > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

   

End Class
