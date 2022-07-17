Public Class frm_edit_Priority

    Public _Priority As Long
    Public _ID_Period As Long
    Dim cl_Priority As New cl_priority

    Private Sub frm_edit_Priority_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtP.Text = _Priority
    End Sub

    Private Sub txtP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtP.KeyDown
        If e.KeyCode = Keys.Enter Then
            cl_Priority.Update_Priority(_ID_Period, txtP.Text)
            Me.Close()
        End If
    End Sub

End Class