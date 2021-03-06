<%@ Page Language="vb" AutoEventWireup="false" Codebehind="magnaglowTestingEdit.aspx.vb" Inherits="WebApplication2.magnaglowTestingEdit" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>MagnaglowEdit</title>
		<meta content="Microsoft Visual Studio.NET 7.0" name="GENERATOR">
		<meta content="Visual Basic 7.0" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">

          <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"/>
  <script  src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js"></script>

         <link type="text/css" rel="stylesheet" href="https://cdn.datatables.net/1.10.9/css/dataTables.bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css" />
    <link type="text/css" rel="stylesheet" href="https://cdn.datatables.net/responsive/1.0.7/css/responsive.bootstrap.min.css" />
    <script type="text/javascript" src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/jquery.dataTables.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/responsive/1.0.7/js/dataTables.responsive.min.js"></script>
    <script type="text/javascript" src="https://cdn.datatables.net/1.10.9/js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>
     <link rel="stylesheet" href="../../StyleSheet1.css" />
	</HEAD>
	<body >
          <nav class="mb-1 navbar navbar-expand-sm bg-dark navbar-dark " >
  <a class="navbar-brand p-0" href="#"><img src="../../../NewFolder1/unnamed.png" class="rounded-circle z-depth-0"  height="45"/> </a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-333"
    aria-controls="navbarSupportedContent-333" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse " id="navbarSupportedContent-333" >
      <ul class="navbar-nav ml-auto navbar-center">
         <li class="nav-item" style="font-weight: bold">
             <h1 style="color:white; font-size:30px; margin-left:430px; margin-top:5px">Rail Wheel Plant, Bela</h1> 
       
         </li>
          </ul>
    <ul class="navbar-nav ml-auto  navbar-right">
        <li class="nav-item">
        <a class="nav-link waves-effect waves-light" style="{color:white; }:hover{color:grey;}" href="../../../wapframeset.aspx">
          <i class="fab glyphicon glyphicon-home " style="font-size:30px"></i>
        </a></li>

       <li class="nav-item">
        <a class="nav-link waves-effect waves-light" style="{color:white; }:hover{color:grey;}" href="../../../logon.aspx">
          <i class="fab glyphicon glyphicon-log-out" style="font-size:30px"></i>
        </a></li>
    
        <li class="nav-item ">
        <a class="nav-link p-0" href="#">
         
        <img src="../../../NewFolder1/CRIS-Recruitment.jpg" height="45" style="border-radius:43%"/>
       </a>
      </li>
     </ul>
      
  </div>
</nav>
  <br />
<!--/.Navbar -->
        <div class="container">
		<form id="Form1" method="post" runat="server">
            <div class="row"><div class="table">
			<asp:panel id="Panel1"  runat="server">
				<TABLE id="Table1" class="table">
					<div class="row" >
						<div class="col" vAlign="top" align="middle" colSpan="6"><FONT size="5">Magnaglow Inspection - Edit</FONT>
							<asp:Label id="lblEmpCode" runat="server" Visible="False"></asp:Label></div>
					</div>
                    <br />
					<div class="row" >
						<div class="col" colSpan="6">
							<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label>
							<asp:label id="lblbhnInfo" runat="server" ForeColor="Red"></asp:label>
							<asp:label id="lblWheelTypeChanged" runat="server" ForeColor="Red"></asp:label></div>
					</div>
                     <br />
					<div class="row" >
						<div class="col">Wheel No</div>
						
						<div class="col">
							<asp:textbox id="txtWhl" runat="server" BorderStyle="Groove" AutoPostBack="True" CssClass="form-control" Width="120px"></asp:textbox></div>
						<div class="col">Wheel Type</div>
						
						<div class="col">
							<asp:DropDownList id="ddlwo" accessKey="T" runat="server" AutoPostBack="True" CssClass="form-control ll" Width="120px"></asp:DropDownList></div>
						<div class="col">
							<asp:checkbox id="chkTypeOverride" runat="server" AutoPostBack="True" Text="Override"></asp:checkbox></div>
					</div>
                    <br />
					<div class="row" >
						<div class="col">Grind Status</div>
						
						<div class="col">
							<asp:textbox id="txtGrindStatus" runat="server" BorderStyle="Groove" AutoPostBack="True" CssClass="form-control" Width="120px"></asp:textbox></div>
						<div class="col">MCN Open</div>
						
						<div class="col">
							<asp:textbox id="txtMcnOperation" runat="server" BorderStyle="Groove" AutoPostBack="True" CssClass="form-control" Width="120px"></asp:textbox></div>
					    <div class="col"></div>
                    </div>
                     <br />
					<div class="row" >
						<div class="col">BHN</div>
						
						<div class="col">
							<asp:textbox id="txtBHN0Value" runat="server" BorderStyle="Groove" AutoPostBack="True" CssClass="form-control" Width="120px"></asp:textbox></div>
						<div class="col">
							<asp:checkbox id="chkUTPassed" runat="server" AutoPostBack="True" Text="UT Pass ?" ></asp:checkbox></div>
						
						<div class="col">
							<asp:checkbox id="chkPlatePass" runat="server" AutoPostBack="True" Text="Plate Pass ?" ></asp:checkbox></div>
					     <div class="col"></div>
                    </div>
                     <br />
					<div class="row" >
						<div class="col">XC/Wheel Status</div>
						
						<div class="col">
							<asp:textbox id="txtWheelStatus" runat="server" BorderStyle="Groove" AutoPostBack="True" CssClass="form-control" Width="120px"></asp:textbox></div>
						<div class="col">Remarks</div>
						
						<div class="col">
							<asp:textbox id="txtRemarks" runat="server" BorderStyle="Groove" AutoPostBack="True" CssClass="form-control" Width="120px"></asp:textbox></div>
					    <div class="col"></div>
                    </div>
                     <br />
                     <br />
                     <br />
					<div class="row" >
						<div class="col">
                        <asp:Label id="lblWheel" runat="server" Visible="False"></asp:Label></div>
						<div class="col">
							<asp:button id="btnSave" accessKey="s" runat="server" Text="Update" Font-Size="16px"  BorderStyle="Solid" Font-Bold="True"  CssClass="btn btn-dark" style="margin-left:120px"></asp:button></div>
					    
						
						
						<div class="col">
							<asp:button id="btnClear" accessKey="c" runat="server"  Text="Clear" Font-Size="16px"  BorderStyle="Solid" Font-Bold="True"  CssClass="btn btn-dark" CausesValidation="False"></asp:button></div>
					<div class="col">
							<asp:Label id="lblHeat" runat="server" Visible="False"></asp:Label></div>
                    </div>
                     <br />
				</TABLE>
				<asp:DataGrid id="grdMagnaGlow" runat="server" BorderStyle="None" BorderColor="#CC9966" CssClass="table" BorderWidth="1px" BackColor="White" CellPadding="4">
					<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:DataGrid>
			</asp:panel>
                </div></div></form></div>
        <div class="card-footer" style="text-align:right;background-color:#cccccc;vertical-align:middle;position:absolute;bottom:0;width:100%;height:60px"><h4 style="color: black;font-size:15px">MAINTAINED BY CRIS</h4></div>

	</body>
</HTML>
