Imports Microsoft.ApplicationBlocks.Data
Imports System.Data.SqlClient
Imports System.Data

Public Class leaveQuery
    Inherits System.Web.UI.Page
    Protected WithEvents txtEmployeeCode As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
    Protected WithEvents lblName As System.Web.UI.WebControls.Label
    Protected WithEvents txtjoiningDate As System.Web.UI.WebControls.TextBox
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents txtDesignation As System.Web.UI.WebControls.Label
    Protected WithEvents Datagrid2 As System.Web.UI.WebControls.DataGrid
    Private con As New SqlConnection(ConfigurationManager.AppSettings("DBcon"))
    Protected WithEvents Dd1 As System.Web.UI.WebControls.DropDownList

    Shared themeValue As String

    Public Sub New()

        AddHandler PreInit, New EventHandler(AddressOf Page_PreInit)
    End Sub

    Private Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs)

        Page.Theme = themeValue
    End Sub


    Protected Sub Dd1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        themeValue = Dd1.SelectedItem.Value
        Response.Redirect(Request.Url.ToString())

    End Sub


#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''If Session("UserId") Is Nothing Then
        ''    Response.Redirect("InvalidSession.aspx")
        ''End If
        'redirecting during leave credits'
        'Response.Redirect("/wapleavemessage.htm")
        'redirecting during leave credits'

        If Not IsPostBack Then
            txtEmployeeCode.Text = Session("Ecode")
            If Len(Trim(txtEmployeeCode.Text)) > 0 Then txtEmployeeCode.ReadOnly = True
            con.Open()
            showLeave()
        End If
    End Sub

    Private Sub txtEmployeeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEmployeeCode.TextChanged
        showLeave()
    End Sub
    Private Sub showLeave()
        Dim strSQL As String
        Dim rdr As SqlDataReader
        strSQL = "Select empname,RLYJOINDATE,desigcode from employee_master  where empno='" & Trim(txtEmployeeCode.Text) & "'"
        rdr = SqlHelper.ExecuteReader(ConfigurationSettings.AppSettings("DBcon"), CommandType.Text, strSQL)
        While rdr.Read
            lblName.Text = IIf(IsDBNull(rdr.Item("empname")), "", rdr.Item("empname"))
            txtjoiningDate.Text = IIf(IsDBNull(rdr.Item("RLYJOINDATE")), "", rdr.Item("RLYJOINDATE"))
            txtDesignation.Text = IIf(IsDBNull(rdr.Item("desigcode")), "", rdr.Item("desigcode"))
            bind_grid1()
            bind_grid2()
        End While
        rdr.Close()
    End Sub

    Private Sub bind_grid2()
        'Dim sqlstring2 As String = "select leave_code, total_leave_availed, (total_leave_accumulated + total_leave_eligibility - total_leave_availed) AS balance from hr_leave_header where employee_code='" & Trim(txtEmployeeCode.Text) & "'"
        'sqlstring2 &= " and leave_code in (select distinct  leave_code from hr_leave_master where leave_eligibility='T')"
        Dim sqlstring2 As String
        sqlstring2 = "select a.leavecode as lc, description as leave_code, leaveavailed leave_availed,"
        'sqlstring2 &= "  (isnull(total_leave_accumulated,0) + isnull(total_leave_eligibility,0) - isnull(total_leave_availed,0)) AS balance "
        sqlstring2 &= "  balance ="
        sqlstring2 &= "  case b.leave_eligibility"
        sqlstring2 &= "  when 'T' then"
        sqlstring2 &= "  (isnull(leaveob,0) + isnull(leavecredited,0) - isnull(leaveavailed,0)) "
        sqlstring2 &= "  else 0"
        sqlstring2 &= "  end "
        sqlstring2 &= " from leave_header a, hr_leave_master b"
        sqlstring2 &= " where empno='" & Trim(txtEmployeeCode.Text) & "'"
        sqlstring2 &= " and a.leavecode = b.leave_code and b.leave_code <> '00' "
        'sqlstring2 &= " and b.leave_eligibility='T'"
        sqlstring2 &= " and pay_category in (select paycategory from employee_master where empno='" & Trim(txtEmployeeCode.Text) & "')"
        sqlstring2 &= " order by lc"
        Dim myCommand As New SqlDataAdapter(sqlstring2, con)
        Dim ds As New DataSet()
        myCommand.Fill(ds)
        Datagrid2.DataSource = ds
        Datagrid2.DataBind()
    End Sub

    Private Sub bind_grid1()
        'Dim sqlstring2 As String = "select distinct from_f_a_indicator, to_f_a_indicator, a.from_date as fd,application_number,a.leave_code,a.application_type,b.description,convert(varchar,a.from_date,103) [from_date],convert(varchar,a.to_date,103) [to_date],a.number_of_days from hr_leave_details a, hr_leave_master b where a.leave_code=b.leave_code and a.employee_code='" & Trim(txtEmployeeCode.Text) & "'"
        'below line corrected on 22072015'
        Dim sqlstring2 As String = "select distinct a.from_date as fd,application_number,a.leavecode,a.application_type,b.description,convert(varchar,a.from_date,103) [from_date],convert(varchar,a.to_date,103) [to_date],a.number_of_days,a.l_confirm,a.applied_to,c.empname from hr_leave_application_details a, hr_leave_master b, employee_master c where a.leavecode=b.leave_code and a.empno='" & Trim(txtEmployeeCode.Text) & "' and a.applied_to=c.empno"
        sqlstring2 &= " and year(from_date) between '" & Year(Now) - 1 & "' and '" & Year(Now) & "'"
        'sqlstring2 &= " and leave_code in (select distinct  leave_code from hr_leave_master where leave_eligibility='T')"
        sqlstring2 &= " order by fd desc,a.leavecode,a.application_type"

        Dim myCommand As New SqlDataAdapter(sqlstring2, con)
        Dim ds As New DataSet()
        myCommand.Fill(ds)
        DataGrid1.DataSource = ds
        DataGrid1.DataBind()
    End Sub

    Private Sub DataGrid1_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DataGrid1.PageIndexChanged
        DataGrid1.CurrentPageIndex = e.NewPageIndex
        bind_grid1()
    End Sub

    Private Sub Datagrid2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Datagrid2.SelectedIndexChanged

    End Sub

    Private Sub txtjoiningDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjoiningDate.TextChanged

    End Sub

    Private Sub DataGrid1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.SelectedIndexChanged

    End Sub
End Class
