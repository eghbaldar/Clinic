Public Class cl_ManualFile

    Dim DS_SelectManualFile As New ds_ManualFileTableAdapters.Select_ManualFileTableAdapter

    Public Function Select_ManualFile(ByVal Id_File As Long) As DataTable
        Return DS_SelectManualFile.GetData(Id_File)
    End Function

    Public Function Insert_Update_ManualFile(ByVal id_file As Long, ByVal Code_Manual As String, _
                                      ByVal file_1 As Byte(), ByVal file_2 As Byte()) As Boolean

        'Try
        DS_SelectManualFile.Insert_update_ManualFile(id_file, Code_Manual.Trim, file_1, file_2)
        Return True
        'Catch ex As Exception
        'Return False
        'End Try


    End Function

End Class
