Public Class frm_edit_insurance

    Dim cl As New cl_insurance

    Private _ID_Insurance As Long
    Private _Name_Insurance As String
    Private _Percentage_Insurance As String

    Public Property ID_Insurance As Long
        Get
            Return _ID_Insurance
        End Get
        Set(ByVal value As Long)
            _ID_Insurance = value
        End Set
    End Property

    Public Property Name_Insurance As String
        Get
            Return _Name_Insurance
        End Get
        Set(ByVal value As String)
            _Name_Insurance = value
        End Set
    End Property

    Public Property Percentage_Insurance As String
        Get
            Return _Percentage_Insurance
        End Get
        Set(ByVal value As String)
            _Percentage_Insurance = value
        End Set
    End Property

    Private Sub frm_edit_insurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Text = _Name_Insurance
        txt_name.Text = _Name_Insurance
        txt_percentage.Text = _Percentage_Insurance.Trim
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click

        If txt_percentage.Text.Length > 2 Then
            MessageBox.Show("مقدار درصد نمی تواند عددی بیش از دو رقم باشد.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Select Case cl.Update_Insurance(_ID_Insurance, txt_name.Text, txt_percentage.Text)
            Case 0
                Me.Close()
            Case 1
                MessageBox.Show("فیلدهای کلیدی باید پر شود.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Case 2
                MessageBox.Show("خطایی رخ داده است")
        End Select


    End Sub

End Class
