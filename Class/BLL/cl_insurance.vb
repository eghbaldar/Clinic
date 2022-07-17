Public Class cl_insurance

    Dim DS_Insurance As New ds_insuranceTableAdapters.Select_insuranceTableAdapter

    Public Function Insert_Insurance(ByVal name As String, ByVal percentage As String) As Byte

        If name = String.Empty Then Return 1
        If percentage = String.Empty Then Return 1

        Try
            DS_Insurance.Insert_insurance(name.Trim, percentage.Trim)
            Return 0
        Catch ex As Exception
            Return 2
        End Try
    End Function

    Public Function Update_Insurance(ByVal ID As Long, ByVal name As String, ByVal percentage As String) As Byte

        If name = String.Empty Then Return 1
        If percentage = String.Empty Then Return 1

        Try
            DS_Insurance.Update_insurance(ID, name.Trim, percentage.Trim)
            Return 0
        Catch ex As Exception
            Return 2
        End Try
    End Function

End Class
