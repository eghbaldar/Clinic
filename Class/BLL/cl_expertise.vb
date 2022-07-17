Public Class cl_expertise

    Dim Expertise As New ds_ExpertiseTableAdapters.Select_expertiseTableAdapter

    Public Function Insert_Expertise(ByVal name As String, ByVal type As Boolean) As Byte

        'Type:0  تخصص های دکتری وارد می شود
        'Type:1  حرفه های مشغول در کلینیک، پرستاران، دستیار و...
        If name = String.Empty Then Return 1

        Try
            Expertise.Insert_expertise(name.Trim, type)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Delete_Expertise(ByVal Id As Integer) As Boolean

        Try
            Expertise.Delete_expertise(Id)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
