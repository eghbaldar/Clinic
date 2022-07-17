Public Class cl_priority

    Dim DS_Query As New ds_PriorityTableAdapters.Query
    Dim exec As New ExecuteSP

    Public Function Select_Period_SetPriority(ByVal ID_Doctor As Long) As DataSet
        Return exec.ReturnSelectFromSP("sp_Select_period_setPriority " + Str(ID_Doctor))
    End Function

    Public Function Update_Priority(ByVal id_period As Long, ByVal priority As Long)
        DS_Query.Update_period_setPriority(id_period, priority)
    End Function

End Class
