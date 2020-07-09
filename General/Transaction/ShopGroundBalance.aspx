<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ShopGroundBalance.aspx.vb" Inherits="WebApplication2.ShopGroundBalance" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<title>ShopGroundBalance</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio.NET 7.0"/>
		<meta name="CODE_LANGUAGE" content="Visual Basic 7.0"/>
		<meta name="vs_defaultClientScript" content="JavaScript"/>
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5"/>
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

        
	</head>
	<body>
         <nav class="mb-1 navbar navbar-expand-sm bg-dark navbar-dark " >
  <a class="navbar-brand p-0" href="#"><img src="../../NewFolder1/unnamed.png" class="rounded-circle z-depth-0"  height="45"/> </a>
  <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent-333"
    aria-controls="navbarSupportedContent-333" aria-expanded="false" aria-label="Toggle navigation">
    <span class="navbar-toggler-icon"></span>
  </button>
  <div class="collapse navbar-collapse " id="navbarSupportedContent-333">
      <ul class="navbar-nav ml-auto  navbar-center">
          <li class="nav-item"> <a class="nav-link" href="#" style="color:white; font-size:25px;">Rail Wheel Plant Bela</a></li>
      </ul>
    <ul class="navbar-nav ml-auto  navbar-right">
        <li class="nav-item">
        <a class="nav-link waves-effect waves-light" style="{color:white; }:hover{color:grey;}" href="../../wapframeset.aspx">
          <i class="fab glyphicon glyphicon-home "style="font-size:30px;" ></i>
        </a></li>
       <li class="nav-item">
        <a class="nav-link waves-effect waves-light" style="{color:white; }:hover{color:grey;}" href="../../logon.aspx">
          <i class="fab glyphicon glyphicon-log-out" style="font-size:30px;"></i>
        </a></li>
    
        <li class="nav-item ">
        <a class="nav-link p-0" href="#">
          <img src="../../NewFolder1/CRIS-Recruitment.jpg" class="rounded-circle z-depth-0"  height="45"/>
        </a>
      </li>
     </ul>
      
  </div>
</nav>
<!--/.Navbar -->

         <div class="container">
             
		
		<form id="Form1" method="post" runat="server">
            <%--<div class="row">
    
                  <h4>Select Your Theme : &nbsp&nbsp&nbsp </h4>
            
                 <asp:DropDownList ID="Dd1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="dd1_SelectedIndexChanged" CssClass="form-control ll" Width="400px">
                     <asp:ListItem>select</asp:ListItem>
                     <asp:ListItem>Theme1</asp:ListItem>
                     <asp:ListItem>Theme2</asp:ListItem>
                     <asp:ListItem>Theme3</asp:ListItem>
                 </asp:DropDownList>
                 <br />
      </div>--%>
            <div class="row">
                 <div class="table-responsive">
			<asp:Panel id="Panel1"  runat="server">
				<table id="Table1" class="table"  DESIGNTIMEDRAGDROP="64">
					<TR>
						<TD>
							<asp:Label id="lblShop" runat="server" CssClass="form-control"></asp:Label>Ground Balance for <hr class="prettyline" />
								<asp:Label id="lblMonth" runat="server"></asp:Label>
								<asp:label id="lblyear" runat="server"></asp:label>
								<asp:checkbox id="chkGoNextMonth" runat="server" Visible="False" AutoPostBack="True" Text="Go Next Month?"></asp:checkbox></FONT></TD>
					</TR>
				</table>
				<table id="Table2" class="table">
				</table>
				<table id="Table4" class="table">
					<TR>
						<TD>
							<asp:Label id="lblMessage" runat="server" ForeColor="Red"></asp:Label></TD>
					</TR>
					<TR>
						<TD>
							<asp:Label id="lblGroup" runat="server" Visible="False"></asp:Label>
							<asp:textbox id="txtDate" runat="server" Visible="False" AutoPostBack="True"  CssClass="form-control"></asp:textbox>
							<asp:Label id="lblShopCode" runat="server" Visible="False"></asp:Label>
							<asp:Label id="lblConsignee" runat="server" Visible="False"></asp:Label>
							<asp:Label id="lblCostCentre" runat="server"></asp:Label>
							<asp:Label id="lblUserID" runat="server" Visible="False"></asp:Label></TD>
					</TR>
					<TR>
						<TD>Select any PL from grid below to transact</TD>
					</TR>
				</table>
				<asp:DataGrid id="dgItems" runat="server" BorderColor="#CC9966" BorderStyle="None" CssClass="table">
					<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:ButtonColumn Text="Select" CommandName="Select"></asp:ButtonColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:DataGrid>
				<table id="Table5" class="table">
					<TR>
						<TD>
							<asp:Label id="lblPlNo" runat="server"></asp:Label></TD>
						<TD>
							<asp:Label id="lblItem" runat="server"  Font-Bold="True"></asp:Label></TD>
					</TR>
				</table>
				<table id="Table6" class="table"></table>
					
							<table id="Table3" class="table">
									<tr><td colspan="2"> <asp:RadioButtonList id="rblTrnType" CssClass="rbl" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" RepeatLayout="Flow" >
											<asp:ListItem Value="Receipt" Selected="True">Receipt</asp:ListItem>
											<asp:ListItem Value="Consumption">Consumption</asp:ListItem>
										</asp:RadioButtonList></td></tr>
				
                   <tr><td colspan="2"><asp:Label id="lblTranDt" runat="server"></asp:Label></td></tr>
										
								
								<tr><td  colspan="2">		<asp:RadioButtonList id="rblWO" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="rbl"></asp:RadioButtonList></td></tr>
						<tr><td>Trans Qty</td>	
								<td>		<asp:TextBox id="txtTrnQty" runat="server" CssClass="form-control" Width="300px"></asp:TextBox></td></tr>
								
                      <tr><td colspan="2">  <asp:Button id="btnSave" runat="server" Text="Save" CssClass="button button2"></asp:Button></td></tr></table>
							
						
							<asp:DataGrid id="DataGrid2" runat="server" ForeColor="Black" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" BackColor="White" CellPadding="3" GridLines="Vertical" CssClass="table">
								<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#000099"></SelectedItemStyle>
								<AlternatingItemStyle BackColor="#CCCCCC"></AlternatingItemStyle>
								<HeaderStyle Font-Bold="True" ForeColor="White" BackColor="Black"></HeaderStyle>
								<FooterStyle BackColor="#CCCCCC"></FooterStyle>
								<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999"></PagerStyle>
							</asp:DataGrid>
					
				<asp:DataGrid id="DataGrid1" runat="server" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" CssClass="table">
					<SelectedItemStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedItemStyle>
					<ItemStyle ForeColor="#003399" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="#CCCCFF" BackColor="#003399"></HeaderStyle>
					<FooterStyle ForeColor="#003399" BackColor="#99CCCC"></FooterStyle>
					<PagerStyle HorizontalAlign="Left" ForeColor="#003399" BackColor="#99CCCC" Mode="NumericPages"></PagerStyle>
				</asp:DataGrid>
			</asp:Panel>
		</div></div></form>
                     </div>
          <div class="card-footer" style="text-align:right;"><h4>MAINTAINED BY CRIS</h4></div>
	</body>
</html>
