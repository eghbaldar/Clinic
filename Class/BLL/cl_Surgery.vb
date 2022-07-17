Public Class cl_Surgery

    Dim DS_Surgery As New ds_SurgeryTableAdapters.Select_SurgeryTableAdapter
    Dim DS_Surgery_WithID As New ds_SurgeryTableAdapters.Select_SurgeryWithIDTableAdapter

    Public Function Insert_Surgery(ByVal Id_File As Long, ByVal Surgery_Title As String, ByVal detail As String, _
                                   ByVal Surgery_Date As String) As Byte

        If Surgery_Title = String.Empty Then Return 1
        If detail = String.Empty Then Return 1

        Dim dt As Date = ShamsiDate.ShamsiToMiladi(Surgery_Date)
        'Try
        DS_Surgery.Insert_Surgery(Id_File, Surgery_Title.Trim, _
                                  dt, 0, detail.Trim, _
                                  "", "")
        Return 0
        'Catch ex As Exception
        'Return 2
        'End Try

    End Function

    Public Function Select_SurgeryWithID(ByVal id As Long) As DataTable
        Return DS_Surgery_WithID.GetData(id)
    End Function

    Public Function Update_Surgery(ByVal ID As Long, ByVal Type As String, ByVal detail As String, _
                                   ByVal Done_Date As String, ByVal Result As String) As Byte

        If detail = String.Empty Then Return 1

        Try
            Dim dt As Date = ShamsiDate.ShamsiToMiladi(Done_Date)
            DS_Surgery.Update_Surgery(ID, Type, detail.Trim, dt, Result.Trim)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Delete_Surgery(ByVal ID As Long) As Boolean
        Try
            DS_Surgery.Delete_Surgery(ID)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
