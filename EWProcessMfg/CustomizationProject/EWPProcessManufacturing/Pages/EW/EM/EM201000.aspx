<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true"
    ValidateRequest="false" CodeFile="EM201000.aspx.cs" Inherits="Page_EM201000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" TypeName="EW.PM.EWPMFormulaMaint" Width="100%">
		<CallbackCommands>
               <px:PXDSCallbackCommand Name="Insert" PostData="Self" />
            <px:PXDSCallbackCommand CommitChanges="True" Name="Save" />
            <px:PXDSCallbackCommand Name="First" PostData="Self" StartNewGroup="True" />
            <px:PXDSCallbackCommand Name="Last" PostData="Self" />
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
	 <px:PXFormView ID="form" runat="server" DataSourceID="ds" Style="z-index: 100"
        Width="100%" DataMember="Documents" TabIndex="3700" DefaultControlID="edPlanCD">
        <Template>
            <px:PXLayoutRule runat="server" StartRow="True" StartColumn="True" />
            <px:PXSelector ID="edFormulaCD" runat="server" AlreadyLocalized="False" DataField="FormulaCD" AutoRefresh="true" CommitChanges="True">
            </px:PXSelector>
            <px:PXTextEdit ID="edDescription" runat="server" AlreadyLocalized="False" DataField="Description">
            </px:PXTextEdit>
            <px:PXTextEdit ID="edRemarks" runat="server" AlreadyLocalized="False" DataField="Remarks" Height="50" TextMode="MultiLine">
            </px:PXTextEdit>
            <px:PXLayoutRule runat="server" StartColumn="True">
            </px:PXLayoutRule>
            <px:PXSelector ID="edRevisionNo" Enabled="true"  runat="server" AutoRefresh="true" AlreadyLocalized="False" DataField="RevisionNo">
            </px:PXSelector>
             <px:PXDateTimeEdit ID="edEffectiveFromDate" runat="server" AlreadyLocalized="False" DataField="EffectiveFromDate">
            </px:PXDateTimeEdit>
            <px:PXDateTimeEdit ID="edEffectiveToDate" runat="server" AlreadyLocalized="False" DataField="EffectiveToDate">
            </px:PXDateTimeEdit>
            <px:PXCheckBox ID="edStatus" CommitChanges="true" runat="server" AlreadyLocalized="False" DataField="Hold" Text="Hold">
            </px:PXCheckBox>
            <px:PXDropDown ID="edStatusText" Enabled="false" ReadOnly="true" runat="server" DataField="Status">
            </px:PXDropDown>
            <px:PXLayoutRule runat="server" StartColumn="True">
            </px:PXLayoutRule>
           <px:PXDropDown ID="PXDropDown1"  runat="server" DataField="OwnerID">
            </px:PXDropDown>

        </Template>
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
	<px:PXTab ID="tab" runat="server" Width="100%" Height="150px" DataSourceID="ds">
		<Items>
			<px:PXTabItem Text="Tab item 1">
			</px:PXTabItem>
			<px:PXTabItem Text="Tab item 2">
			</px:PXTabItem>
		</Items>
		<AutoSize Container="Window" Enabled="True" MinHeight="150" />
	</px:PXTab>
</asp:Content>
