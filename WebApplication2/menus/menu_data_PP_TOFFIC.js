Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';

Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';
var mA04= new Menu();var mN12= new Menu();var mL02= new Menu();var mA03= new Menu();var mO20= new Menu();var mTO00= new Menu();var mQYM= new Menu();var mL03= new Menu();var mL50= new Menu();var mTO01= new Menu();var mTO02= new Menu();var mTO03= new Menu();var mL04= new Menu();var mTO05= new Menu();var mTO06= new Menu();var mTO07= new Menu();var mTO25= new Menu();var mTO26= new Menu();var mTO30= new Menu();var mTO31= new Menu();var mTO32= new Menu();
var tmp;
mA03.add(tmp = new MenuItem("Create Noting","/ppms/miscEDs/miscErngDeductionNoting.aspx?mode=add"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Add Employee","/ppms/miscEDs/miscErngDeductionNoting.aspx?mode=add"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Modify Employee","/ppms/miscEDs/miscErngDeductionNoting.aspx?mode=edit"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Delete Employee","/ppms/miscEDs/miscErngDeductionNoting.aspx?mode=delete"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("View Noting","/ppms/miscEDs/miscErngDeductionNotingQuery.aspx"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Print Noting","/ppms/Reports/Formats/miscEDs/miscEdPrintNoting.aspx?mode=miscEdNoting.rpt"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Generate Memorandum","/ppms/miscEDs/miscEDOffOrdNumber.aspx"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Print Memorandum","/ppms/Reports/Formats/miscEds/miscEdPrintMemorandum.aspx?mode=miscEdMemorandum.rpt"));tmp.mnemonic = '';mA03.add(tmp = new MenuItem("Print Unposted","/ppms/Reports/Formats/miscEds/miscEdUnPostedEntries.aspx?mode=miscEdUnPosted.rpt"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Create Recomend Noting","/ppms/awards/awardNoting.aspx?mode=add"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Add Employee","/ppms/awards/awardNoting.aspx?mode=add"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Delete Employee","/ppms/awards/awardNoting.aspx?mode=delete"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Query Noting","/ppms/awards/awardNoting.aspx?mode=view"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Print Noting","/ppms/awards/awardReports.aspx?mode=note_number"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Generate Memorandum","/ppms/awards/awardOfficeOrdNumber.aspx"));tmp.mnemonic = '';mA04.add(tmp = new MenuItem("Print Memorandum","/ppms/awards/awardReports.aspx?mode=memorandum"));tmp.mnemonic = '';mL02.add(tmp = new MenuItem("Leave Application",null,null, mL03) );
tmp.mnemonic = '';
mL02.add(tmp = new MenuItem("Leave/Absence",null,null, mL50) );
tmp.mnemonic = '';
mN12.add(tmp = new MenuItem("Create Noting","/ppms/hoer/creatingHoerNoting.aspx"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("Add Employee","/ppms/hoer/miscAttandance.aspx?mode=add"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("Modify","/ppms/hoer/miscAttandance.aspx?mode=edit"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("View","/ppms/hoer/miscAttandance.aspx?mode=view"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("Delete","/ppms/hoer/miscAttandance.aspx?mode=delete"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("Print Noting","/ppms/hoer/printNotingHoer.aspx"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("Generate Memorandum","/ppms/hoer/MemoGeneration.aspx"));tmp.mnemonic = '';mN12.add(tmp = new MenuItem("Print Memorandum","/ppms/hoer/printMemorandum.aspx"));tmp.mnemonic = '';mO20.add(tmp = new MenuItem("Enter Booking","/ppms/ot/NonPunchOTBookingEntry.aspx?mode=add"));tmp.mnemonic = '';mO20.add(tmp = new MenuItem("Delete Booking","/ppms/ot/NonPunchOTBookingDeletion.aspx?mode=delete"));tmp.mnemonic = '';mO20.add(tmp = new MenuItem("Query Bookings","/ppms/ot/NonPunchOTBookingQuery.aspx"));tmp.mnemonic = '';mO20.add(tmp = new MenuItem("OT Booking List","/ppms/ot/overTimeCheckList.aspx"));tmp.mnemonic = '';mO20.add(tmp = new MenuItem("OT Statement","/ppms/ot/overTimeStatement.aspx"));tmp.mnemonic = '';mQYM.add(tmp = new MenuItem("HR-General Queries","/ppms/hrquery.aspx"));tmp.mnemonic = '';mTO00.add(tmp = new MenuItem("Daily",null,null, mTO01) );
tmp.mnemonic = '';
mTO00.add(tmp = new MenuItem("Weekly",null,null, mTO02) );
tmp.mnemonic = '';
mTO00.add(tmp = new MenuItem("Monthly",null,null, mTO03) );
tmp.mnemonic = '';
mL03.add(tmp = new MenuItem("Application Posting",null,null, mL04) );
tmp.mnemonic = '';
mL03.add(tmp = new MenuItem("Posting Leave Sanction","/ppms/leave/postSanctionToApplicationForLeave.aspx?mode=post"));tmp.mnemonic = '';mL04.add(tmp = new MenuItem("Add","/ppms/leave/leaveApplicationform.aspx?mode=add&task_id=L05"));tmp.mnemonic = '';mL04.add(tmp = new MenuItem("Delete","/ppms/leave/editApplicationForLeave.aspx?mode=delete"));tmp.mnemonic = '';mL04.add(tmp = new MenuItem("Application Printing","/ppms/Reports/formats/ApplicationForms/rptLeaveApplication.aspx?mode=rptLeaveApplication"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("GenerateMemorandum","/ppms/leave/leaveMemorandum.aspx"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Print Memorandum","/ppms/leave/rptLeaveMemorandum.aspx?mode=memorandum"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("CheckList(Leave posting)","/ppms/Reports/formats/leave/leavePostingCheckList.aspx?mode=leaveAbsenseCheckList.rpt"));tmp.mnemonic = '';mL50.add(tmp = new MenuItem("Leave Query","/ppms/leave/leaveQuery.aspx"));tmp.mnemonic = '';mTO01.add(tmp = new MenuItem("Database Maintenance",null,null, mTO05) );
tmp.mnemonic = '';
mTO01.add(tmp = new MenuItem("Query",null,null, mTO06) );
tmp.mnemonic = '';
mTO01.add(tmp = new MenuItem("Reports",null,null, mTO07) );
tmp.mnemonic = '';
mTO02.add(tmp = new MenuItem("Regular Jobs",null,null, mTO25) );
tmp.mnemonic = '';
mTO02.add(tmp = new MenuItem("Reports",null,null, mTO26) );
tmp.mnemonic = '';
mTO03.add(tmp = new MenuItem("Regular Jobs",null,null, mTO30) );
tmp.mnemonic = '';
mTO03.add(tmp = new MenuItem("Query",null,null, mTO31) );
tmp.mnemonic = '';
mTO03.add(tmp = new MenuItem("Reports",null,null, mTO32) );
tmp.mnemonic = '';
mTO05.add(tmp = new MenuItem("Attendance Modification", "/toffice_form/attendenceModification.aspx")); tmp.mnemonic = ''; mTO05.add(tmp = new MenuItem("Employee Details Modification", "/toffice_form/modificationOfEmployeeParticulars.aspx?mode=add")); tmp.mnemonic = ''; mTO05.add(tmp = new MenuItem("Current Week Shift Details", "/toffice_form/editshiftmaster.aspx?mode=edit")); tmp.mnemonic = ''; mTO05.add(tmp = new MenuItem("Next Week Shift Details", "/toffice_form/editnextweekshift.aspx?mode=edit")); tmp.mnemonic = ''; mTO05.add(tmp = new MenuItem("Inout Code Modification", "/toffice_form/editmast.aspx?mode=edit")); tmp.mnemonic = ''; mTO06.add(tmp = new MenuItem("Day's Punches Query", "/toffice_form/DailyPunchesQuery.aspx")); tmp.mnemonic = ''; mTO07.add(tmp = new MenuItem("Shift Attendance", "/toffice_form/rptShifts.aspx?mode=rptShiftAttendance")); tmp.mnemonic = ''; mTO07.add(tmp = new MenuItem("Full Day Abscence Statement", "/toffice_form/rptDailyAbsenceStatement.rpt?user0=report&

0=report")); tmp.mnemonic = ''; mTO07.add(tmp = new MenuItem("Shift Abscence", "/toffice_form/rptShifts.aspx?mode=rptShiftABSENCE")); tmp.mnemonic = ''; mTO07.add(tmp = new MenuItem("Full Day Rejected Punches", "/toffice_form/rptRejPunches.rpt?user0=report&password0=report")); tmp.mnemonic = ''; mTO07.add(tmp = new MenuItem("Full Day Abscence Statistics", "/toffice_form/toFullDayStats.aspx?user0=report&password0=report")); tmp.mnemonic = ''; mTO07.add(tmp = new MenuItem("Full Day Attendance", "/toffice_form/rptDaily.aspx?mode=rptDailyAttendanceStatement")); tmp.mnemonic = ''; mTO25.add(tmp = new MenuItem("Weekly Attendance Generation", "/toffice_form/WeeklyAttendanceGeneration.aspx?mode=edit")); tmp.mnemonic = ''; mTO26.add(tmp = new MenuItem("Weekly Attendance", "/toffice_form/rptshops.aspx?mode=rptWeekly")); tmp.mnemonic = ''; mTO26.add(tmp = new MenuItem("Next Week Roster", "/toffice_form/rptshops.aspx?mode=rptWeeklyRoaster")); tmp.mnemonic = ''; mTO30.add(tmp = new MenuItem("Artisans File Generation", "/toffice_form/ARTISANSFILEGENERATION.aspx")); tmp.mnemonic = ''; mTO30.add(tmp = new MenuItem("Supervisors File Generation", "/toffice_form/SUPERVISORSSFILEGENERATION.aspx")); tmp.mnemonic = ''; mTO30.add(tmp = new MenuItem("Monthly Statistics Generation", "/toffice_form/MonthlyStatisticsGeneration.aspx")); tmp.mnemonic = ''; mTO30.add(tmp = new MenuItem("Punch Data Backup", "")); tmp.mnemonic = ''; mTO30.add(tmp = new MenuItem("Monthly Attendance Generation Process", "/toffice_form/monthly_attendance.aspx")); tmp.mnemonic = ''; mTO31.add(tmp = new MenuItem("View Employee Wise", "")); tmp.mnemonic = ''; mTO31.add(tmp = new MenuItem("View Punches Datewise", "/toffice_form/monthlyPunchesQuery.aspx")); tmp.mnemonic = ''; mTO32.add(tmp = new MenuItem("Monthly Attendance Statement", "/toffice_form/repMonthlyAttendanceGeneration.aspx")); tmp.mnemonic = ''; mTO32.add(tmp = new MenuItem("Monthly Artisans Statement", "/toffice_form/repMonthlyAtisansStatement.aspx?mode=rptArtisansMonthlyStatement")); tmp.mnemonic = ''; mTO32.add(tmp = new MenuItem("Abscence Statement", "/toffice_form/rptArtAbs.rpt?user0=report&password0=report")); tmp.mnemonic = ''; mTO32.add(tmp = new MenuItem("Monthly Supervisors Statement", "/toffice_form/repMonthlySupervisorsStatement.aspx?mode=rptSupervisorsMonthlyStatement")); tmp.mnemonic = ''; mTO32.add(tmp = new MenuItem("Emp. List Tickt. No Wise", "/toffice_form/rptEmployeeList.aspx?mode=rptEmplist_E")); tmp.mnemonic = ''; mTO32.add(tmp = new MenuItem("Emp. List Shop Wise","/toffice_form/rptEmployeeList.aspx?mode=rptListofemployees"));tmp.mnemonic = '';
var menuBar = new MenuBar();
menuBar.add( tmp = new MenuButton("Awards", mA04) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("HOER OT/NDA", mN12) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Leave Accounting", mL02) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Misc. E/Ds", mA03) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Factory OT", mO20) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Time Office", mTO00) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("HR-QUERIES", mQYM) );
tmp.mnemonic = '';

menuBar.write();
