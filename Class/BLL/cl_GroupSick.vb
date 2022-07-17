Public Class cl_GroupSick

    Dim DS_GroupSick As New ds_GroupSickTableAdapters.Select_Group_SickTableAdapter

    Public Function Insert_GroupSick(ByVal name As String, ByVal id_personal As Long) As Byte

        If name = "" Then Return 1
        Try
            DS_GroupSick.Insert_Group_Sick(name.Trim, id_personal)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Update_GroupSick(ByVal name As String, ByVal id As Integer, ByVal id_personal As Long) As Byte

        If name = "" Then Return 1
        Try
            DS_GroupSick.Update_Group_Sick(id, name.Trim, id_personal)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Delete_GroupSick(ByVal id As Integer) As Boolean
        Try
            DS_GroupSick.Delete_Group_Sick(id)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
