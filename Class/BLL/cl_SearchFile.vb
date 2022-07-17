Public Class cl_SearchFile

    Dim cl_exec As New ExecuteSP


    Public Function SearchFileMain(ByVal F_Name As String _
           , ByVal L_Name As String _
           , ByVal Sex As String _
           , ByVal Mobile As String _
           , ByVal Birth As String _
           , ByVal Job As String _
           , ByVal Marriage As String _
           , ByVal Weight As String _
           , ByVal Height As String _
           , ByVal Presenter As String _
           , ByVal Date_ As String _
           , ByVal Id_GroupSick As String _
           , ByVal Id_Personal As String _
           , ByVal Blood As String) As DataTable

        If String.IsNullOrEmpty(F_Name.Trim) Then F_Name = "''"
        If String.IsNullOrEmpty(L_Name.Trim) Then L_Name = "''"
        If String.IsNullOrEmpty(Sex.Trim) Then Sex = "null"
        If String.IsNullOrEmpty(Mobile.Trim) Then Mobile = "null"
        If String.IsNullOrEmpty(Birth.Trim) Then Birth = "null"
        If String.IsNullOrEmpty(Job.Trim) Then Job = "null"
        If String.IsNullOrEmpty(Marriage.Trim) Then Marriage = "null"
        If String.IsNullOrEmpty(Weight.Trim) Then Weight = "null"
        If String.IsNullOrEmpty(Height.Trim) Then Height = "null"
        If String.IsNullOrEmpty(Presenter.Trim) Then Presenter = "null"
        If String.IsNullOrEmpty(Date_.Trim) Then Date_ = "null"
        If String.IsNullOrEmpty(Id_GroupSick.Trim) Then Id_GroupSick = "null"
        If String.IsNullOrEmpty(Id_Personal.Trim) Then Id_Personal = "null"
        If String.IsNullOrEmpty(Blood.Trim) Then Blood = "null"

        Return cl_exec.ReturnSelectFromSP _
            ("sp_select_search_main " + F_Name.Trim + "," + L_Name.Trim + "," + Sex + "," + Mobile.Trim + "," + Birth.Trim + "" & _
             "," + Job.Trim + "," + Marriage + "," + Weight.Trim + "," + Height.Trim + "," + Presenter.Trim + "," + Date_.Trim + "," + _
             Id_GroupSick + "," + Id_Personal + "," + Blood.Trim + "").Tables(0)
    End Function

    Public Function ListOfDoctor() As DataTable
        Return cl_exec.ReturnSelectFromSP("sp_select_search_DoctorList").Tables(0)
    End Function

    Public Function ListOfGroupSick(ByVal Id_personal As Long) As DataTable
        Return cl_exec.ReturnSelectFromSP("sp_select_search_GroupSickList " & Str(Id_personal)).Tables(0)
    End Function

End Class
