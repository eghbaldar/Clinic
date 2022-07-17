Public Class cl_period

    Dim cl_exec As New ExecuteSP
    Dim DS_Period As New ds_PeriodTableAdapters.Select_Period_200TableAdapter

    Public Function Select_Period_ByDate(ByVal ID_Doctor As Long, ByVal DatePeriod As String) As DataSet
        Return cl_exec.ReturnSelectFromSP("sp_select_Period_ByDate '" + ID_Doctor.ToString + "','" + DatePeriod + "'")
    End Function

    Public Function Select_Period_All(ByVal ID_Doctor As Long) As DataSet
        Return cl_exec.ReturnSelectFromSP("sp_select_Period_200 " + ID_Doctor.ToString)
    End Function

    Public Function Insert_Period(ByVal Id_File As Long, ByVal Type As String, ByVal Id_personal As Long, ByVal Date_Period As Date) As Boolean
        Try
            DS_Period.Insert_Period(Id_File, 0, Type, Id_personal, Keep_ID_USER.ID_USER, Date_Period, Now, 0)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Delete_Period(ByVal ID As Long) As Boolean
        Try
            DS_Period.Delete_period(ID)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
