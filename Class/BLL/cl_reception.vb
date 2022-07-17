Public Class cl_reception

    Dim DS_Reception As New ds_receptionTableAdapters.Select_receptionTableAdapter
    Dim DS_CheckReception As New ds_receptionTableAdapters.Select_checkPreviouslyReceptionTableAdapter
    Dim DS_MoneyStatus As New ds_receptionTableAdapters.Select_getMoneyStatusTableAdapter
    Dim cl_exec As New ExecuteSP

    Public Function Insert_Receprion(ByVal Id_File As Long, ByVal Id_User As Long, ByVal Id_period As Long, ByVal Total_Pay As String, _
                                     ByVal Id_Insurance As Long, ByVal Payable As String, ByVal Discount As String, ByVal Received As String, _
                                     ByVal Serial_Card As String, ByVal Expire_Card As String, ByVal Number_Card As String, ByVal Detail As String, _
                                     ByVal Priority As Long, ByVal id_personal As Long) As Byte


        If Total_Pay = String.Empty Then Return 1 'f_name
        If Received = String.Empty Then Return 1 'l_name
        If Payable = String.Empty Then Return 1 'expertise

        Try
            DS_Reception.Insert_reception(Id_File, Id_User, Id_period, Total_Pay.Replace(",", Nothing).Trim, Id_Insurance, Payable.Replace(",", Nothing).Trim, Discount.Replace(",", Nothing).Trim, _
                                          Received.Replace(",", Nothing).Trim, Serial_Card.Trim, Expire_Card.Trim, Number_Card.Trim, Detail.Trim, Now)
            DS_Reception.Update_Period_afterReception(Priority, Id_period, id_personal)
            Return 0
        Catch ex As Exception
            Return 2
        End Try

    End Function

    Public Function Check_Reception(ByVal ID_Period As Long) As Boolean
        If DS_CheckReception.GetData(ID_Period).Rows(0)(0).ToString = "0" Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function Get_MoneyStatus(ByVal ID_File As Long) As String
        Return DS_MoneyStatus.GetData(ID_File).Rows(0)(0).ToString
    End Function

    Public Function Select_Reception(ByVal ID_Doctor As Long, ByVal date_ As String) As DataSet
        Return cl_exec.ReturnSelectFromSP("sp_select_reception " + ID_Doctor.ToString + ",'" + date_.Trim + "'")
    End Function

    Public Function Select_Reception_Reception(ByVal ID_Doctor As Long, ByVal date_ As String) As DataSet
        Return cl_exec.ReturnSelectFromSP("sp_select_reception_reception " + ID_Doctor.ToString + ",'" + date_.Trim + "'")
    End Function


    Public Function Delete_Reception(ByVal ID As Long) As Boolean
        Try
            DS_Reception.Delete_reception(ID)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Select_Information_Reception(ByVal ID As Long) As DataSet
        Return cl_exec.ReturnSelectFromSP("sp_Select_information_Reception " + ID.ToString)
    End Function

End Class
