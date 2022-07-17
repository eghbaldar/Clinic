Public Class frm_management

    Dim FileNameAvatar As String
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChoiceBG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChoiceBG.Click
        Dim open As New OpenFileDialog
        open.Filter = "Jpge|*.jpg|Gif|*.gif|Bitmap|*.bmp|PNG|*.png|All Images|*.bmp;*.gif;*.jpg;*.png"
        open.Title = "الصاق تصویر پزشک"
        open.Multiselect = False
        open.RestoreDirectory = True
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileNameAvatar = open.FileName
        End If
    End Sub

    Dim _bgMainForm As String
    Public Property SetBgMainForm() As String
        Get
            Return _bgMainForm
        End Get
        Set(ByVal value As String)
            _bgMainForm = value
        End Set
    End Property

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        _bgMainForm = FileNameAvatar
        Me.Close()
    End Sub

End Class