Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration



Public Class ExecuteSP


    Public Function ReturnSelectFromSP(ByVal sp_name_parameters As String) As DataSet

        Dim Con As New SqlConnection
        Dim Com As New SqlCommand
        Dim Da As New SqlDataAdapter
        Dim ds As New DataSet

        Con.ConnectionString = ConfigurationManager.ConnectionStrings("Clinic.My.MySettings.ClinicConnectionString").ConnectionString
        Con.Open()
        Com.Connection = Con
        Com.CommandText = "exec " & sp_name_parameters
        Da.SelectCommand = Com
        Da.Fill(ds)
        Return ds
        Con.Close()


    End Function

End Class
