Public Class cl_prescription

    Dim DS_Prescription As New ds_prescriptionTableAdapters.Select_prescriptionTableAdapter

    Public Function Insert_Prescription(ByVal Id_Reception As Long, ByVal Id_Personal As Long, ByVal Prescription As String, ByVal Detail As String) As Byte
        Try
            If Prescription = String.Empty Then Return 1
            If Detail = String.Empty Then Return 1
            DS_Prescription.Insert_prescription(Id_Reception, Id_Personal, Prescription.Trim, Detail.Trim)
            Return 0
        Catch ex As Exception
            Return 2
        End Try
    End Function

    Public Function Update_Prescription(ByVal id As Long, ByVal Prescription As String, ByVal checkDrug As String, ByVal Detail As String) As Byte
        If Prescription = String.Empty Then Return 1
        If Detail = String.Empty Then Return 1
        Try
            If Prescription = String.Empty Then Return 1
            If Detail = String.Empty Then Return 1
            DS_Prescription.Update_prescription(Prescription.Trim, checkDrug.Trim, Detail.Trim, id)
            Return 0
        Catch ex As Exception
            Return 2
        End Try
    End Function

    Public Function Delete_Prescription(ByVal id As Long) As Boolean
        Try
            DS_Prescription.Delete_prescription(id)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
