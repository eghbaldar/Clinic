Imports System.IO

Public Class frm_information_personal

    Dim exec As New ExecuteSP
    Dim ID_personal As Long
    Dim cl As New cl_personal

    Public Property ID As String
        Get
            Return ID_personal
        End Get
        Set(ByVal value As String)
            ID_personal = value
        End Set
    End Property

    Private Sub frm_information_personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv.DataSource = exec.ReturnSelectFromSP("sp_Select_information_Personal " & ID_personal.ToString).Tables(0)
        dgv.Columns(1).Width = 400
        dgv.Refresh()

        Try
            Dim file() As Byte = cl.GetAvatarPersonal(ID_personal)
            Dim MS As New MemoryStream()
            MS.Write(file, 0, file.Length)
            PictureBox.Image = Bitmap.FromStream(MS)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

End Class

