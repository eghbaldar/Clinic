Imports System.IO
Imports System.Configuration

Public Class CreateDatabaseInfo

    'Public Sub CreateDbInfo()
    '    Dim file As System.IO.StreamWriter
    '    file = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath() + "\system-db.bat", True)
    '    file.WriteLine("eghbaldar2")
    '    file.Close()
    'End Sub

    'Dim line(2) As String
    'Public Function GetDbInfo() As String
    '    Try
    '        Dim FILE_NAME As String = Application.StartupPath() + "\system-db.bat"
    '        If System.IO.File.Exists(FILE_NAME) = True Then
    '            Dim objReader As New System.IO.StreamReader(FILE_NAME)

    '            For i As Byte = 0 To objReader.ReadLine().Length - 1
    '                line(i) = objReader.ReadLine(i + 1)
    '            Next            
    '        Else
    '            Return line(0)
    '        End If
    '    Catch e As Exception
    '        Console.WriteLine("The file could not be read:")
    '        Console.WriteLine(e.Message)
    '    End Try
    'End Function

    'Public Sub SetConnectionString_AppConfig()
    '    Dim config As System.Configuration.Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '    config.ConnectionStrings.ConnectionStrings("Clinic.My.MySettings.ClinicConnectionString").ConnectionString = _
    '        "Data Source=eghbaldar-pc;Initial Catalog=Clinic;Integrated Security=True"
    '    config.Save(ConfigurationSaveMode.Modified)
    'End Sub

End Class
