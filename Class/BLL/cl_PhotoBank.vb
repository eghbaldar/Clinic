Public Class cl_PhotoBank

    Dim ds_PhotoBank As New ds_PhotoBankTableAdapters.Select_PhotoBankTableAdapter
    Dim ds_PhotoBank_photo As New ds_PhotoBankTableAdapters.Select_PhotoBank_PhotoTableAdapter

    Public Function Insert_PhotoBank(ByVal ID_File As Long, ByVal title As String, ByVal photo As Byte(), ByVal detail As String) As Byte
        If title.Trim = String.Empty Then Return 1
        Try
            ds_PhotoBank.Insert_PhotoBank(ID_File, title.Trim, photo, Now, detail.Trim)
            Return 0
        Catch ex As Exception
            Return 2
        End Try
    End Function

    Public Function Delete_PhotoBank(ByVal ID As Long) As Boolean
        Try
            ds_PhotoBank.Delete_PhotoBank(ID)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Select_PhotoBank(ByVal ID_File As Long) As DataTable
        Return ds_PhotoBank.GetData(ID_File)
    End Function

    Public Function Get_PhotoBank(ByVal ID As Long) As DataTable
        Return ds_PhotoBank_photo.GetData(ID)
    End Function

End Class
