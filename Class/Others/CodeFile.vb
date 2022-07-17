Public Class CodeFile


    Dim cl_CodeFile As New ds_FileTableAdapters.Query
    ''' <summary>
    ''' تولید کد همیشه ثابت براساس شماره پرونده بیمار
    ''' بدست آوردن شماره پرونده بعدی بیمار که ثبت نشده است
    ''' </summary>
    Public Function NextCodeFile() As Long
        Return (cl_CodeFile.Select_NextIdFile + 100)
    End Function

    ''' <summary>
    ''' برای حالتی که آیدی بیمار را داریم ولی شماره پرونده میخواهیم
    ''' </summary>
    ''' <param name="ID_File"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CurrentCodeFile(ByVal ID_File As Long) As Long
        Return (ID_File + 100)
    End Function


    ''' <summary>
    ''' برای حالتی که شماره پرونده را داریم آیدی بیمار را میخواهیم
    ''' </summary>
    ''' <param name="ID_File"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetID_via_CodeFile(ByVal CodeFile As Long) As Long
        Return (CodeFile - 100)
    End Function

End Class
