Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';

Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';
var mPD01= new Menu();var mTO00= new Menu();var mPD03= new Menu();var mTO01= new Menu();var mTO02= new Menu();var mTO03= new Menu();var mTO04= new Menu();var mTO05= new Menu();var mTO06= new Menu();var mTO07= new Menu();var mTO25= new Menu();var mTO26= new Menu();var mTO30= new Menu();var mTO31= new Menu();var mTO32= new Menu();
var tmp;
mPD01.add(tmp = new MenuItem("Authority Selection",null,null, mPD03) );
tmp.mnemonic = ' ';
mTO00.add(tmp = new MenuItem("Daily",null,null, mTO01) );
tmp.mnemonic = '';
mTO00.add(tmp = new MenuItem("Weekly",null,null, mTO02) );
tmp.mnemonic = '';
mTO00.add(tmp = new MenuItem("Monthly",null,null, mTO03) );
tmp.mnemonic = '';
mTO01.add(tmp = new MenuItem("Regular Jobs",null,null, mTO04) );
tmp.mnemonic = '';
mTO01.add(tmp = new MenuItem("Database Maintenance",null,null, mTO05) );
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
mTO04.add(tmp = new MenuItem("Unload Punches","/ppms/timeoffice/unloadPunches.aspx"));tmp.mnemonic = '';mTO04.add(tmp = new MenuItem("Shift Attendance Generation","/ppms/timeoffice/frmShiftAttendance.aspx"));tmp.mnemonic = '';mTO04.add(tmp = new MenuItem("Full Day Attd. Generation","/ppms/timeoffice/timeoffice.aspx"));tmp.mnemonic = '';mTO05.add(tmp = new MenuItem("Attendance Modification","/ppms/timeoffice/attendenceModification.aspx"));tmp.mnemonic = '';mTO05.add(tmp = new MenuItem("Employee Details Modification","/ppms/timeoffice/modificationOfEmployeeParticulars.aspx?mode=add"));tmp.mnemonic = '';mTO05.add(tmp = new MenuItem("Current Week Shift Details","/ppms/timeoffice/editshiftmaster.aspx?mode=edit"));tmp.mnemonic = '';mTO05.add(tmp = new MenuItem("Next Week Shift Details","/ppms/timeoffice/editnextweekshift.aspx?mode=edit"));tmp.mnemonic = '';mTO05.add(tmp = new MenuItem("Inout Code Modification","/ppms/timeoffice/editmast.aspx?mode=edit"));tmp.mnemonic = '';mTO06.add(tmp = new MenuItem("Day's Punches Query","/ppms/timeoffice/DailyPunchesQuery.aspx"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Shift Attendance","/ppms/Reports/formats/rptTimeoffice/rptShifts.aspx?mode=rptShiftAttendance"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Full Day Abscence Statement","/ppms/Reports/formats/rptTimeoffice/rptDailyAbsenceStatement.rpt?user0=report&password0=report"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Shift Abscence","/ppms/Reports/formats/rptTimeoffice/rptShifts.aspx?mode=rptShiftABSENCE"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Full Day Rejected Punches","/ppms/Reports/formats/rptTimeoffice/rptRejPunches.rpt?user0=report&password0=report"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Full Day Abscence Statistics","/ppms/Reports/formats/rptTimeoffice/toFullDayStats.aspx?user0=report&password0=report"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Shift Statistics","/ppms/Reports/formats/rptTimeoffice/rptLeaveAbsencePercentage.rpt?user0=report&password0=report"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Full Day Attendance","/ppms/Reports/formats/rptTimeoffice/rptDaily.aspx?mode=rptDailyAttendanceStatement"));tmp.mnemonic = '';mTO07.add(tmp = new MenuItem("Shift Abscence Statistics","/ppms/Reports/formats/rptTimeoffice/rptShifts.aspx?mode=rptLeaveAbsencePercentage"));tmp.mnemonic = '';mTO25.add(tmp = new MenuItem("Weekly Attendance Generation","/ppms/timeoffice/WeeklyAttendanceGeneration.aspx?mode=edit"));tmp.mnemonic = '';mTO26.add(tmp = new MenuItem("Weekly Attendance","/ppms/Reports/formats/rptTimeoffice/rptshops.aspx?mode=rptWeekly"));tmp.mnemonic = '';mTO26.add(tmp = new MenuItem("Next Week Roster","/ppms/Reports/formats/rptTimeOffice/rptshops.aspx?mode=rptWeeklyRoaster"));tmp.mnemonic = '';mTO30.add(tmp = new MenuItem("Artisans File Generation","/ppms/timeoffice/ARTISANSFILEGENERATION.aspx"));tmp.mnemonic = '';mTO30.add(tmp = new MenuItem("Supervisors File Generation","/ppms/timeoffice/SUPERVISORSSFILEGENERATION.aspx"));tmp.mnemonic = '';mTO30.add(tmp = new MenuItem("Monthly Statistics Generation","/ppms/timeoffice/MonthlyStatisticsGeneration.aspx"));tmp.mnemonic = '';mTO30.add(tmp = new MenuItem("Punch Data Backup",""));tmp.mnemonic = '';mTO30.add(tmp = new MenuItem("Monthly Attendance Generation Process","/ppms/timeoffice/monthly_attendance.aspx"));tmp.mnemonic = '';mTO31.add(tmp = new MenuItem("View Punches Datewise","/ppms/timeoffice/monthlyPunchesQuery.aspx"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Monthly Attendance Statement","/ppms/Reports/Formats/rptTimeOffice/repMonthlyAttendanceGeneration.aspx"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Monthly Artisans Statement","/ppms/Reports/Formats/rptTimeOffice/repMonthlyAtisansStatement.aspx?mode=rptArtisansMonthlyStatement"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Abscence Statement","/ppms/Reports/Formats/rptTimeOffice/rptArtAbs.rpt?user0=report&password0=report"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Monthly Supervisors Statement","/ppms/Reports/Formats/rptTimeOffice/repMonthlySupervisorsStatement.aspx?mode=rptSupervisorsMonthlyStatement"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Emp. List Tickt. No Wise","/ppms/Reports/Formats/rptTimeOffice/rptEmployeeList.aspx?mode=rptEmplist_E"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Emp. List Shop Wise","/ppms/Reports/Formats/rptTimeOffice/rptEmployeeList.aspx?mode=rptListofemployees"));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Abscence Statistics",""));tmp.mnemonic = '';mTO32.add(tmp = new MenuItem("Supervisors Abscence Statement","/ppms/Reports/Formats/rptTimeOffice/repSupervisorsAbsenceStatement.aspx?mode=rptSupervisorsAbsenceStatement"));tmp.mnemonic = '';
var menuBar = new MenuBar();
menuBar.add( tmp = new MenuButton("DAR", mPD01) );
tmp.mnemonic = ' ';
menuBar.add( tmp = new MenuButton("Time Office", mTO00) );
tmp.mnemonic = '';

menuBar.write();