<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormDetail.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="EM201500.aspx.cs" Inherits="Page_EM201500" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormDetail.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" Runat="Server">
	<px:PXDataSource ID="ds" runat="server" PrimaryView ="Property" Visible="True" Width="100%"  TypeName ="EW.PM.EWPMPropertyMaint">
		<CallbackCommands>
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>

<asp:Content ID="cont2" ContentPlaceHolderID="phG" Runat="Server">
	<px:PXGrid ID="grid" runat="server" DataSourceID="ds" Style="z-index: 100" 
		Width="100%" Height="150px" SkinID="Details">
		<Levels>
		<px:PXGridLevel  DataMember="Property">
                 <Columns>
 <px:PXGridColumn DataField="SequenceNo" Width="72" />
<px:PXGridColumn DataField="GroupCode" Width="72" />
 <px:PXGridColumn DataField="Description" Width="72" />
  <px:PXGridColumn DataField="Factor" Width="72" />
 <px:PXGridColumn DataField="Type" Width="72" />
 <px:PXGridColumn DataField="TagName" Width="72" />
 <px:PXGridColumn DataField="PropertyUnit" Width="72" />
 <px:PXGridColumn DataField="Group" Width="72" />
                     
 </Columns>

			</px:PXGridLevel>
		</Levels>
		<AutoSize Container="Window" Enabled="True" MinHeight="150" />
	</px:PXGrid>
</asp:Content>
