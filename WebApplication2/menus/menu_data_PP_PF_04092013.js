Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';

Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';
var mPF01= new Menu();var mP01= new Menu();var mF00= new Menu();var mF01= new Menu();var mF06= new Menu();var mF11= new Menu();var mF37= new Menu();var mF43= new Menu();var mF03= new Menu();var mF36= new Menu();var mP101= new Menu();
var tmp;
mF00.add(tmp = new MenuItem("P.F. Master",null,null, mF01) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("PF Final Withdrawals",null,null, mF06) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("PF Temporary Withdrawal",null,null, mF11) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("PF Sanctioning",null,null, mF37) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("Application Prints","/ppms/Reports/Formats/rptPF/pfPrintApplications.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("PF Reports",null,null, mF43) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("Accounts Transaction",null,null, mF03) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("Control Totals Report","/ppms/Reports/Formats/rptpf/PFControlTotalsReport.rpt?user0=report&password0=report&user0@pf_ob.rpt=report&password0@pf_ob.rpt=report"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("PFNotingSanctionPrints","/ppms/Reports/Formats/rptPF/pfSanctionPrints.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("PF Check List","/ppms/Reports/formats/rptpf/frmPfTransactionMonthwiseReport.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("Monthly Combined Check List","/ppms/Reports/Formats/rptpf/PFCheckList07.rpt?user0=report&password0=report"));tmp.mnemonic = ' ';mF00.add(tmp = new MenuItem("PF Ledger Closing","/ppms/pf/PfLedgerClosing.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("Statement of Accounts","/ppms/Reports/formats/rptpf/pfAccountStatement.aspx?mode=pfaccst.rpt"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("PF Ledger Abstract Report","/ppms/pf/pFAbstractLedgerReport.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("Interest Calculation","/ppms/pf/pfInterestCalculation.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("Annual Ledger","/ppms/Reports/formats/rptpf/PFAnnualLedger.aspx?mode=PFAnnLedger.rpt"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("Cum.Bal.Updation(Annual)","/ppms/pf/pfCumulativeBalanceUpdation.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("PF Annual Slip",null,null, mF36) );
tmp.mnemonic = '';
mF00.add(tmp = new MenuItem("FinalWith.Updt Cal. Yr.","/ppms/pf/pfNewFinancialYear.aspx"));tmp.mnemonic = '';mF00.add(tmp = new MenuItem("PF Final Settlement","/ppms/pf/pf_Final_Settlement.aspx?mode=post"));tmp.mnemonic = '';mP01.add(tmp = new MenuItem("View Brief Details",null,null, mP101) );
tmp.mnemonic = ' ';
mPF01.add(tmp = new MenuItem("View PF Login","/ppms/reports/formats/rptQuest/pfLogonDetails.aspx"));tmp.mnemonic = ' ';mF01.add(tmp = new MenuItem("Create","/ppms/pf/pfMaster.aspx?mode=add"));tmp.mnemonic = '';mF01.add(tmp = new MenuItem("Modify","/ppms/pf/pfMaster.aspx?mode=edit"));tmp.mnemonic = '';mF01.add(tmp = new MenuItem("Delete","/ppms/pf/pfMaster.aspx?mode=delete"));tmp.mnemonic = '';mF01.add(tmp = new MenuItem("View","/ppms/pf/pfMaster.aspx?mode=view"));tmp.mnemonic = '';mF03.add(tmp = new MenuItem("View","/ppms/pf/pfAccountsTransactionMaintenance.aspx?mode=view"));tmp.mnemonic = '';mF03.add(tmp = new MenuItem("Check List","/ppms/Reports/formats/rptpf/pfTransactionCheckList.aspx?mode=PFCheckList.rpt"));tmp.mnemonic = '';mF03.add(tmp = new MenuItem("Error List","/ppms/reports/formats/rptpf/pfTransactionErrorList.aspx?mode=PFErrorList.rpt"));tmp.mnemonic = '';mF06.add(tmp = new MenuItem("PF Withdrawal - Marriage","/ppms/reports/formats/rptQuest/rptPFLogin.aspx?task_id=F38"));tmp.mnemonic = '';mF06.add(tmp = new MenuItem("PF Withdrawal - Medical","/ppms/reports/formats/rptQuest/rptPFLogin.aspx?task_id=F39"));tmp.mnemonic = '';mF06.add(tmp = new MenuItem("PF Withdrawal - HBA","/ppms/reports/formats/rptQuest/rptPFLogin.aspx?task_id=F40"));tmp.mnemonic = '';mF06.add(tmp = new MenuItem("Pf Withdrawal - Others","/ppms/reports/formats/rptQuest/rptPFLogin.aspx?task_id=F41"));tmp.mnemonic = '';mF11.add(tmp = new MenuItem("PF Withdrawal - Temporary","/ppms/reports/formats/rptQuest/rptPFLogin.aspx?task_id=F42"));tmp.mnemonic = '';mF36.add(tmp = new MenuItem("Process","/ppms/Reports/formats/rptpf/PfAnnualStatement.aspx"));tmp.mnemonic = ' ';mF36.add(tmp = new MenuItem("Report","/ppms/Reports/formats/rptpf/pfaccst_annual.rpt?user0=report&password0=report"));tmp.mnemonic = ' ';mF37.add(tmp = new MenuItem("PF Withdrawal-Marriage","/ppms/pf/applicationForFinalWithdrawalFrom PFForMeetingTheBetrothalMarriageExpenses.aspx?mode=post"));tmp.mnemonic = '';mF37.add(tmp = new MenuItem("PF Withdrawal-Medical","/ppms/pf/applicationForFinalWithdrawalFromPFForMedicalExpenses.aspx?mode=post"));tmp.mnemonic = '';mF37.add(tmp = new MenuItem("PF Withdrawal-HBA","/ppms/pf/applicationForFinalWithdrawalOf PFMoneyForPurchaseOfHouse.aspx?mode=post"));tmp.mnemonic = '';mF37.add(tmp = new MenuItem("PF Withdrawal-Others","/ppms/pf/applicationForFinalWithdrawalOfPfForOthers.aspx?mode=post"));tmp.mnemonic = '';mF37.add(tmp = new MenuItem("PF Withdrawal-Temporary","/ppms/pf/applicationForTemporaryAdvanceWithdrawalFromPFDeposit.aspx?mode=post"));tmp.mnemonic = '';mP101.add(tmp = new MenuItem("On Code","/ppms/employee/EmployeeDetailsOnCode.aspx"));tmp.mnemonic = ' ';mP101.add(tmp = new MenuItem("On Name","/ppms/employee/EmployeeDetailsOnName.aspx"));tmp.mnemonic = ' ';mP101.add(tmp = new MenuItem("Special Search","/ppms/employee/frmEmpDetails.aspx"));tmp.mnemonic = ' ';
var menuBar = new MenuBar();
menuBar.add( tmp = new MenuButton("PF Login", mPF01) );
tmp.mnemonic = ' ';
menuBar.add( tmp = new MenuButton("Employee", mP01) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Provident Fund", mF00) );
tmp.mnemonic = '';

menuBar.write();
