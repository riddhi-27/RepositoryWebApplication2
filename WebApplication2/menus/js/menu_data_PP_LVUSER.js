Menu.prototype.cssFile = '/wap/menus/skins/officexp/officexp.css';

Menu.prototype.cssFile = '/wap/menus/skins/officexp/officexp.css';
var mP01= new Menu();var mL02= new Menu();var mL03= new Menu();var mL10= new Menu();var mL50= new Menu();var mP101= new Menu();var mL04= new Menu();
var tmp;
mL02.add(tmp = new MenuItem("Leave Application",null,null, mL03) );
tmp.mnemonic = '';
mL02.add(tmp = new MenuItem("Leave Master",null,null, mL10) );
tmp.mnemonic = '';
mL02.add(tmp = new MenuItem("Leave/Absence",null,null, mL50) );
tmp.mnemonic = '';
mL02.add(tmp = new MenuItem("Officer Leave Memorandum","/wap/ppms/leave/ofcrmemo.rpt?user0=wap&password0=wap"));tmp.mnemonic = '';mP01.add(tmp = new MenuItem("View Brief Details",null,null, mP101) );
tmp.mnemonic = ' ';
mL03.add(tmp = new MenuItem("Application Posting",null,null, mL04) );
tmp.mnemonic = '';
mL04.add(tmp = new MenuItem("Add","/wap/ppms/leave/leaveApplicationform.aspx?mode=add&task_id=L05"));tmp.mnemonic = '';mL04.add(tmp = new MenuItem("Cancel Leave","/wap/ppms/leave/editApplicationForLeave.aspx?mode=cancel"));tmp.mnemonic = '';mL04.add(tmp = new MenuItem("Delete","/wap/ppms/leave/editApplicationForLeave.aspx?mode=delete"));tmp.mnemonic = '';mL04.add(tmp = new MenuItem("Application Printing","/wap/ppms/Reports/formats/ApplicationForms/rptLeaveApplication.aspx?mode=rptLeaveApplication"));tmp.mnemonic = '';mL10.add(tmp = new MenuItem("Add","/wap/ppms/leave/employeeLeaveMaster.aspx?mode=add"));tmp.mnemonic = '';mL10.add(tmp = new MenuItem("Leave Master Report","/wap/ppms/Reports/formats/leave/leaveMaster.rpt?user0=report&password0=report"));tmp.mnemonic = '';mL10.add(tmp = new MenuItem("Retrospective Leave Cr/Db","/wap/ppms/leave/leaveRetrospectivePosting.aspx"));tmp.mnemonic = '';mL10.add(tmp = new MenuItem("Leave Opening Balance Correction","/wap/ppms/leave/leave.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("GenerateMemorandum","/wap/ppms/leave/leaveMemorandum.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Print Memorandum","/wap/ppms/leave/rptLeaveMemorandum.aspx?mode=memorandum"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("CheckList(Leave posting)","/wap/ppms/Reports/formats/leave/leavePostingCheckList.aspx?mode=leaveAbsenseCheckList.rpt"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Leave Account Statement","/wap/ppms/leave/frmLeaveAnnualStatement.aspx?mode=employee"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Leave Ann Statement","/wap/ppms/leave/frmLeaveAnnualStatement.aspx?mode=paycategory"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Print Memo Bill unit","/wap/ppms/Reports/formats/leave/FrmLVbuEmp.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Post Unpaid holiday","/wap/ppms/leave/leaveUpdationForUnpaidHoliday.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Print leave clash unpaid","/wap/ppms/leave/lavanya.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Leave Query","/wap/ppms/leave/leaveQuery.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Last Pay Certificate","/wap/ppms/lpc/rptLastCertificate.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Print Regularisation","/wap/ppms/Reports/formats/leave/leavePostingCheckList1.aspx?mode=leaveREG"));tmp.mnemonic = ' ';mL50.add(tmp = new MenuItem("Leave Regularisation For a Particular Employee","/wap/ppms/Reports/formats/leave/leavePostingCheckList2.aspx"));tmp.mnemonic = ' ';mP101.add(tmp = new MenuItem("On Code","/wap/ppms/employee/EmployeeDetailsOnCode.aspx"));tmp.mnemonic = ' ';mP101.add(tmp = new MenuItem("On Name","/wap/ppms/employee/EmployeeDetailsOnName.aspx"));tmp.mnemonic = ' ';mP101.add(tmp = new MenuItem("Special Search","/wap/ppms/employee/frmEmpDetails.aspx"));tmp.mnemonic = ' ';
var menuBar = new MenuBar();
menuBar.add( tmp = new MenuButton("Employee", mP01) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Leave Accounting", mL02) );
tmp.mnemonic = '';

menuBar.write();