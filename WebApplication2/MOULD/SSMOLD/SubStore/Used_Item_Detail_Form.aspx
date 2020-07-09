﻿<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Used_Item_Detail_Form.aspx.vb" Inherits="WebApplication2.Used_Item_Detail_Form" %>

<!DOCTYPE html>
<link href="Content/bootstrap.css" rel="stylesheet" />
<html>
<head runat="server">
		<title>Used Item Detail Form</title>
	   <link rel="stylesheet" type="text/css" href="css/jquery-ui.css">
   <LINK id="mss" href="/wap.css" rel="stylesheet"/>
		<META content="Microsoft Visual Studio.NET 7.0" name="GENERATOR"/>
		<META content="Visual Basic 7.0" name="CODE_LANGUAGE"/>
		<META content="JavaScript" name="vs_defaultClientScript"/>
		<META content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema"/>
         <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"/>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"></script>
         <link type="text/css" rel="stylesheet" href="https://cdn.datatables.net/1.10.9/css/dataTables.bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="https://cdn.datatables.net/responsive/1.0.7/css/responsive.bootstrap.min.css" />
        <link href="jQuery.datetimepicker.min.css" rel="stylesheet" />
        <script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/responsive/1.0.7/js/dataTables.responsive.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/dataTables.bootstrap.min.js"></script>
            <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
        <script type="text/javascript" src= "https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js">  </script>
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
<script type="text/javascript" src="//ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js"></script>
<script type="text/javascript" src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
 
     <style type="text/css">
         .ui-datepicker {
    background: #333;
    border: 1px solid #555;
    color: #EEE;
    
}
</style>

	</head>
	<body style="overflow-x:hidden">

      <nav class="mb-1 navbar navbar-expand-sm bg-dark navbar-dark " >
  <a class="navbar-brand p-0" href="#"><img src="../../../NewFolder1/unnamed.png" class="rounded-circle z-depth-0"  height="45"/> </a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-333"
    aria-controls="navbarSupportedContent-333" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse " id="navbarSupportedContent-333">
      <ul class="navbar-nav ml-auto  navbar-center">
          <li class="nav-item" style="font-weight: bold">
             <h1 style="color:white; font-size:30px; margin-left:430px; margin-top:5px">Rail Wheel Plant, Bela</h1> 
       
         </li>
          <%--<li class="nav-item"> <a class="nav-link" href="#" style="color:white; font-size:25px;">Rail Wheel Plant Bela</a></li>--%>
      </ul>
    <ul class="navbar-nav ml-auto  navbar-right">
        <li class="nav-item">
        <a class="nav-link waves-effect waves-light" style="{color:white; }:hover{color:grey;}" href="../../../wapframeset.aspx">
          <i class="fab glyphicon glyphicon-home " style="font-size:30px;"></i>
        </a></li>
       <li class="nav-item">
        <a class="nav-link waves-effect waves-light" style="{color:white; }:hover{color:grey;}" href="../../../logon.aspx">
          <i class="fab glyphicon glyphicon-log-out" style="font-size:30px;"></i>
        </a></li>
    
        <li class="nav-item ">
        <a class="nav-link p-0" href="#">
          <%--<img src="../../NewFolder1/CRIS-Recruitment.jpg" class="rounded-circle z-depth-0"  height="45"/>--%>
            <img src="../../../NewFolder1/CRIS-Recruitment.jpg" height="45" style="border-radius:43%"/>
        </a>
      </li>
     </ul>
      
  </div>
</nav>
<!--/.Navbar -->
         <script>
              $(document).ready(function () {
                       $('#UDate').datepicker({
         dateFormat: "dd/mm/yy",

         onSelect: function (date) {
             var date1 = $('#UDate').datepicker('getDate');
         }


                  });
                    $('#D_Date').datepicker({
         dateFormat: "dd/mm/yy",

         onSelect: function (date) {
             var date1 = $('#D_Date').datepicker('getDate');
         }

     });

                    function getDate( element ) {
    var date;
    var dateFormat = "dd/MM/yyyy";
    try {
      date = $.datepicker.parseDate( dateFormat, element.value );
    } catch( error ) {
      date = null;
    }

    return date;
  }
             });
   </script>
         <div class="container">
   <form id="Form1" method="post" runat="server">
            <asp:Panel ID="Panel1" runat="server">
                <div class="container-fluid">
                <div class="row">
                        <div class="table">
                            <div class="row">
                                <div class="col-12" align="center"> <h1>Used Item Details(Scrap/Disposal)</h1><hr />
                                </div >
                            </div>
                            <br />
      <div class="row">
      <div class="col-2"> <asp:Label ID="L_Item_Desc" runat="server" Text="Item Desc" style="width:103px;"></asp:Label></div>
          <div class="col-2"> <asp:DropDownList ID="DD2" runat="server" style="width:103px;" CssClass="form-control" >
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                        </asp:DropDownList></div>

            <div class="col-2" >
                     <asp:Label ID="L_Pl_No" runat="server" Text="Pl No" style="width:103px;" ></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="Pl_No" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
            </div>
            <div class="col-2">
                     <asp:Label ID="L_Date" runat="server" Text="Date" style="width:103px;"></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="UDate" runat="server" style="width:103px;" CssClass="form-control"  placeholder="yyyy-mm-dd" ></asp:TextBox>
            </div>
        </div>
                <br />
          <div class="row">
            <div class="col-2">
                     <asp:Label ID="L_B_Qty" runat="server" Text="Balance Qty" style="width:103px;" ></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="B_Qty" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
           </div>
             <div class="col-2" >
                     <asp:Label ID="L_Location" runat="server" Text="Location" style="width:103px;" ></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="Location" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
             </div>
           <div class="col-2">
                     <asp:Label ID="L_D_Qty" runat="server" Text="Disposal Qty" style="width:103px;" ></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="D_Qty" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
           </div>
            </div>     
                <br />
             <div class="row">
               <div class="col-2">
           <asp:Label ID="L_D_Date" runat="server" Text="Disposal Date" style="width:103px;"  ></asp:Label></div>
          <div class="col-2">
                   <asp:TextBox ID="D_Date" runat="server" style="width:103px;" CssClass="form-control"   placeholder="yyyy-mm-dd"></asp:TextBox>
           </div>
                   <div class="col-2">
                         <asp:Label ID="L_PO_Qty" runat="server" Text="PO Qty" style="width:103px;"  ></asp:Label></div>
          <div class="col-2">
                         <asp:TextBox ID="PO_Qty" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
                  </div>
                 <div class="col-2">
                     <asp:Label ID="L_Firm_Name" runat="server" Text="Firm Name" style="width:103px;" ></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="Firm_Name" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
                </div>
               </div>
                            <br />
           <div class="row">
               <div class="col-2">
                      <asp:Label ID="L_D_L_No" runat="server" Text="Disposal L No" style="width:103px;"  ></asp:Label></div>
          <div class="col-2">
                     <asp:TextBox ID="D_L_No" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
                </div>
                <div class="col-2">
                         <asp:Label ID="L_D_Remarks" runat="server" Text="Disposal Remarks" style="width:103px;"></asp:Label></div>
          <div class="col-2">
                         <asp:TextBox ID="D_Remarks" runat="server" style="width:103px;" CssClass="form-control" ></asp:TextBox>
                 </div>
           </div>
            <br />
            <br />
                             <div class="row">
                    <div class="col-12" align="center">
            <asp:Button ID="Submit" runat="server" Text="Submit"   CssClass="btn btn-dark" Font-Bold="True" Font-Names="Arial" Font-Size="Medium"/>
                 </div></div> 
            </div>
            </div>
            </div>
        </asp:Panel>
    </form>
              </div>
      <%-- <div class="card-footer" style="text-align:right;"><h4>MAINTAINED BY CRIS </h4></div>--%>
        <div class="card-footer" style="text-align:right;background-color:#cccccc;vertical-align:middle;height:45px; width:100%; bottom:0;position:absolute;"><h4 style="color: black;font-size:15px;">MAINTAINED BY CRIS</h4></div>
</body>
</html>
