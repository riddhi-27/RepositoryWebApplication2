Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';

Menu.prototype.cssFile = '/ppms/menus/skins/officexp/officexp.css';
var mP01= new Menu();var mS02= new Menu();var mP14= new Menu();
var tmp;
mP01.add(tmp = new MenuItem("Family Particulars",null,null, mP14) );
tmp.mnemonic = '';
mS02.add(tmp = new MenuItem("Application","/ppms/passes/applicationForPassPTO.aspx?mode=add"));tmp.mnemonic = '';mS02.add(tmp = new MenuItem("Issue","/ppms/passes/IssuePassPTO.aspx"));tmp.mnemonic = '';mS02.add(tmp = new MenuItem("Cancel","/ppms/passes/pass_application_delete.aspx?mode=cancel"));tmp.mnemonic = '';mS02.add(tmp = new MenuItem("Accountal Pass","/ppms/passes/applicationForPassPTO.aspx?mode=accountal"));tmp.mnemonic = '';mP14.add(tmp = new MenuItem("Add","/ppms/employee/employeeFamily.aspx?mode=add"));tmp.mnemonic = '';mP14.add(tmp = new MenuItem("Modify","/ppms/employee/employeeFamily.aspx?mode=edit"));tmp.mnemonic = '';mP14.add(tmp = new MenuItem("Delete","/ppms/employee/employeeFamily.aspx?mode=delete"));tmp.mnemonic = '';mP14.add(tmp = new MenuItem("Query","/ppms/employee/employeeFamily.aspx?mode=view"));tmp.mnemonic = '';mP14.add(tmp = new MenuItem("Check List","/ppms/Reports/formats/checklist/Checklist.aspx?mode=ChecklistFamilyDetails"));tmp.mnemonic = '';
var menuBar = new MenuBar();
menuBar.add( tmp = new MenuButton("Employee", mP01) );
tmp.mnemonic = '';
menuBar.add( tmp = new MenuButton("Pass Issues", mS02) );
tmp.mnemonic = '';

menuBar.write();