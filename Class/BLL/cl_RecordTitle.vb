Public Class cl_RecordTitle

    Dim DS_RecordTitle As New ds_RecordTitleTableAdapters.Select_RecordTitleTableAdapter
    Dim DS_RecordTitleForFile As New ds_RecordTitleTableAdapters.Select_RecordTitleForFileTableAdapter
    Dim DS_RecordTitleFile As New ds_RecordTitleTableAdapters.Select_RecordForFileTableAdapter

    Public Function Insert_RecordTitle(
                                ByVal id_personal As Long, _
                                ByVal title As String) As Byte

        If title = String.Empty Then Return 1

        Try
            DS_RecordTitle.Insert_recordTitle(id_personal, title.Trim, Keep_ID_USER.ID_USER)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Delete_RecordTitle(ByVal id As Long) As Boolean
        Try
            DS_RecordTitle.Delete_RecordTitle(id)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Insert_RecordTitle_ToFile(
                              ByVal id_File As Long, _
                              ByVal id_Record As Long) As Boolean

        Try
            DS_RecordTitleForFile.Insert_RecordTitleToFile(id_File, id_Record)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function Delete_RecordFromFile(ByVal id_file As Long, ByVal id_record As Long) As Boolean
        Try
            DS_RecordTitleFile.Delete_RecordFromFile(id_file, id_record)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Update_RecordFromFile(ByVal id_file As Long, ByVal Id_record As Long, ByVal detail As String) As Boolean
        Try
            DS_RecordTitleFile.Update_RecordFromFile(id_file, Id_record, detail.Trim)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
