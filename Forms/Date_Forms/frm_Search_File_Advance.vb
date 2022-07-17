Public Class frm_Search_File_Advance

    Dim cl_searchFile As New cl_SearchFile

    ''' <summary>
    ''' این فرم دو عملکرد دارد
    ''' 1: وقتی که بصورت مستقل باز شده که کارکرد جستجو و تغییر مشخصات بیماران را دارد
    ''' 2: وقتی از فرم دیگر صدا زده می شود که در آن صورت پس از دابل-کلیک روی رکورد مورد نظر
    ''' و یا کلیک برای دگمه پایین صفحه بسته شده و شماره پرونده از طریق پروپرتی کدفایل به فرم اول باز می گردد
    ''' </summary>
    ''' <remarks></remarks>
#Region "Form_Returnly"

    Private _CodeFile As Long
    ''' <summary>
    ''' 'وقتی این فرم از فرم دیگری به منظور اخذ شماره پرونده فراخوانی میشود، شماره پرونده در این متغیر برگشت داده می شود
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property CodeFile() As Long
        Get
            Return _CodeFile
        End Get
        Set(ByVal value As Long)
            value = _CodeFile
        End Set
    End Property


    ''' <summary>
    ''' وقتی این فرم از فرم دیگری فراخوانی میشود این گزینه فعال شده تا دگمه بازگشت فعال شود 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public _FormReturnly As Boolean

    Private Sub btn_returnValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_returnValue.Click
        Try
            _CodeFile = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString
            _FormReturnly = False
            Me.Close()
        Catch ex As Exception
            If Err.Number = 91 Then
                MessageBox.Show("ابتدا بیمار را انتخاب کنید.", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        End Try
    End Sub

    Private Sub dgv_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If Not _FormReturnly Then
            Dim frm As New frm_Edit_File
            frm.ID_File = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString
            frm.ShowDialog()
        Else
            _CodeFile = dgv.Rows(dgv.CurrentRow.Index).Cells(0).Value.ToString
            _FormReturnly = False
            Me.Close()
        End If
    End Sub

    Private Sub setFormReturnly()
        If _FormReturnly Then
            btn_returnValue.Visible = True
        ElseIf Not _FormReturnly Then
            btn_returnValue.Visible = False
        End If
    End Sub

#End Region

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub frm_SearchFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '''''''''''''''''''''''''''''
        cmb_doctors.DataSource = cl_searchFile.ListOfDoctor
        cmb_doctors.DisplayMember = "doctor_name"
        cmb_doctors.ValueMember = "id"
        cmb_doctors.SelectedIndex = -1
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        CallSearching()
        setGridSetting()
        setFormReturnly()

    End Sub

    Private Sub CallSearching()

        Dim sex As String = String.Empty
        If rb_male.Checked Then sex = "1"
        If rb_famale.Checked Then sex = "0"
        If Not rb_male.Checked And Not rb_famale.Checked Then sex = String.Empty

        Dim Marriage As String = String.Empty
        If rb_single.Checked Then Marriage = "0"
        If rb_marriage.Checked Then Marriage = "1"
        If rb_divorced.Checked Then Marriage = "2"
        If Not rb_single.Checked And Not rb_marriage.Checked And Not rb_divorced.Checked Then Marriage = String.Empty

        Dim height As String = String.Empty
        height = txt_height.Text.ToString
        Dim weight As String = String.Empty
        weight = txt_weight.Text.ToString

        Dim GROUP As String = String.Empty
        If cmb_group.Text.Trim = "-- همه موارد --" Then
            GROUP = String.Empty
        Else
            If String.IsNullOrEmpty(cmb_group.SelectedValue) Then
                GROUP = String.Empty
            Else
                GROUP = cmb_group.SelectedValue.ToString
            End If
        End If

        Dim DOCTOR As String = String.Empty
        If cmb_doctors.Text.Trim = "-- همه موارد --" Then
            DOCTOR = String.Empty
        Else
            If String.IsNullOrEmpty(cmb_doctors.SelectedValue) Then
                DOCTOR = String.Empty
            Else
                DOCTOR = cmb_doctors.SelectedValue.ToString
            End If
        End If

        Dim BLOOD As String = String.Empty
        If cmb_Blood.Text.Trim = "-- همه موارد --" Then
            BLOOD = String.Empty
        Else
            If String.IsNullOrEmpty(cmb_Blood.Text) Then
                BLOOD = String.Empty
            Else
                BLOOD = cmb_Blood.Text.Replace("-", " ").Replace("+", " ")
            End If
        End If

        Dim Brith As String
        If txt_Birth.Text = "____/__/__" Then
            Brith = String.Empty
        Else
            Brith = txt_Birth.Text.Replace("/", "")
        End If

        'Dim Date_ As String
        'If txt__date.Text = "____/__/__" Then
        '    Date_ = String.Empty
        'Else
        '    'Date_ = ShamsiDate.ShamsiToMiladi(txt__date.Text.Replace("/", ""))
        '    Date_ = String.Empty
        'End If

        dgv.DataSource = cl_searchFile.SearchFileMain(txt_Fname.Text, txt_Lname.Text, sex, txt_mobile.Text, _
                                                      Brith, txt_job.Text, Marriage, weight, height, txt_presenter.Text, _
                                                      "", GROUP, DOCTOR, BLOOD)
        lbl_searchedFiles.Text = dgv.RowCount


    End Sub

    Private Sub setGridSetting()
        dgv.Columns(0).Visible = False
        dgv.Columns(1).Visible = False
        dgv.Columns(17).Visible = False
        dgv.Columns(18).Width = 150
        dgv.Columns(19).Visible = False
        dgv.Columns(20).Visible = False
        dgv.Columns(4).DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f0f2cf")
    End Sub

    'Private Sub chk_showAvatar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_showAvatar.CheckedChanged
    '    If chk_showAvatar.Checked Then
    '        dgv.Columns(1).Visible = True
    '        dgv.Rows(1).Height = 100
    '    Else
    '        dgv.Columns(1).Visible = False
    '        dgv.Rows(1).Height = 70
    '    End If
    'End Sub

    Private Sub txt_Fname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Fname.TextChanged
        CallSearching()
    End Sub
    Private Sub txt_Lname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Lname.TextChanged
        CallSearching()
    End Sub
    Private Sub txt_mobile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mobile.TextChanged
        CallSearching()
    End Sub
    Private Sub txt_job_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_job.TextChanged
        CallSearching()
    End Sub
    Private Sub txt_presenter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_presenter.TextChanged
        CallSearching()
    End Sub

    Private Sub cmb_doctor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_doctors.SelectedIndexChanged
        CallSearching()
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        cmb_group.DataSource = cl_searchFile.ListOfGroupSick(cmb_doctors.SelectedValue)
        cmb_group.DisplayMember = "name"
        cmb_group.ValueMember = "id"
        cmb_group.SelectedIndex = -1
    End Sub
    Private Sub cmb_group_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_group.SelectedIndexChanged
        CallSearching()
    End Sub
    Private Sub cmb_Blood_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Blood.SelectedIndexChanged
        CallSearching()
    End Sub

    Private Sub txt_height_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_height.TextChanged
        CallSearching()
    End Sub
    Private Sub txt_weight_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_weight.TextChanged
        CallSearching()
    End Sub

    Private Sub rb_male_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_male.CheckedChanged
        CallSearching()
    End Sub
    Private Sub rb_famale_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_famale.CheckedChanged
        CallSearching()
    End Sub
    Private Sub rb_sex_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_sex_all.CheckedChanged
        rb_male.Checked = False
        rb_famale.Checked = False
        CallSearching()
    End Sub
    Private Sub rb_single_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_single.CheckedChanged
        CallSearching()
    End Sub
    Private Sub rb_marriage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_marriage.CheckedChanged
        CallSearching()
    End Sub
    Private Sub rb_divorced_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_divorced.CheckedChanged
        CallSearching()
    End Sub
    Private Sub rb_all_marriage_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_all_marriage.CheckedChanged
        rb_divorced.Checked = False
        rb_single.Checked = False
        rb_marriage.Checked = False
        CallSearching()
    End Sub

    Private Sub txt_Birth_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Birth.KeyUp
        CallSearching()
    End Sub

    Private Sub btnUpdateGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateGrid.Click
        CallSearching()
    End Sub

End Class