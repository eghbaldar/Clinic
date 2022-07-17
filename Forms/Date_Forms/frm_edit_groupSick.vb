Public Class frm_edit_groupSick

    Dim cl As New cl_GroupSick

    Private _ID_GroupSick As Long
    Private _Name_GroupSick As String
    Private _ID_Personal As Long

    Public Property ID_GroupSick As Long
        Get
            Return _ID_GroupSick
        End Get
        Set(ByVal value As Long)
            _ID_GroupSick = value
        End Set
    End Property

    Public Property ID_Personal As Long
        Get
            Return _ID_Personal
        End Get
        Set(ByVal value As Long)
            _ID_Personal = value
        End Set
    End Property

    Public Property Name_GroupSick As String
        Get
            Return _Name_GroupSick
        End Get
        Set(ByVal value As String)
            _Name_GroupSick = value
        End Set
    End Property

    Private Sub frm_edit_GroupSick_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select_doctor_for_GroupSickTableAdapter.Fill(Me.Ds_Personal.Select_doctor_for_GroupSick)
        Text = _Name_GroupSick
        cmb_doctor.SelectedValue = _ID_Personal
        txt_groupName.Text = _Name_GroupSick.Trim
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        Select Case cl.Update_GroupSick(txt_groupName.Text, _ID_GroupSick, cmb_doctor.SelectedValue)
            Case 0
                Me.Close()
            Case 1
                MessageBox.Show("فیلدهای کلیدی باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select


    End Sub

End Class
