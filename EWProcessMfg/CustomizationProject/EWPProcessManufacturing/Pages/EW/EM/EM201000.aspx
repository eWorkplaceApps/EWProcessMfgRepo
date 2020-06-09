<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true"
    ValidateRequest="false" CodeFile="EM201000.aspx.cs" Inherits="Page_EM201000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" TypeName="EW.PM.EWPMFormulaMaint" Width="100%" PrimaryView="Documents">
		<CallbackCommands>
              
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
	 <px:PXFormView ID="form" runat="server" DataSourceID="ds" Style="z-index: 100"
        Width="100%" DataMember="Documents" TabIndex="3700" DefaultControlID="edPlanCD" >
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
            
            <px:PXDropDown ID="edStatusText" Enabled="false" ReadOnly="true" runat="server" DataField="Status">
            </px:PXDropDown>
            <px:PXLayoutRule runat="server" StartColumn="True">
            </px:PXLayoutRule>
           <px:PXSelector ID="PXDropDown1" Enabled="false" ReadOnly="true"  runat="server" DataField="OwnerID">
            </px:PXSelector>
            <px:PXDropDown ID="edRMCostMethod" Enabled="false" ReadOnly="true" runat="server" DataField="RMCostMethod">
            </px:PXDropDown>

        </Template>
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
	<px:PXTab ID="tab" runat="server" Width="100%" Height="150px" DataSourceID="ds" DataMember="Documents">
		<Items>
			<px:PXTabItem Text="Details" BindingContext="form" > <Template>
                <px:PXFormView ID="formN" runat="server" DataSourceID="ds" DataMember="Documents" CaptionVisible="False" SkinID="Transparent" MarkRequired="Dynamic">
                        <Template>
                            <px:PXLayoutRule runat="server" ControlSize="XM" LabelsWidth="S" StartColumn="True" ></px:PXLayoutRule>
                 <px:PXSelector ID="edFormulaClassID" runat="server" AlreadyLocalized="False" DataField="FormulaClassID" CommitChanges="True">
                 </px:PXSelector>
                <px:PXSelector ID="edFormulaPolicyID" runat="server" AlreadyLocalized="False" DataField="FormulaPolicyID" CommitChanges="True">
                 </px:PXSelector>
                  <px:PXDropDown ID="edApprovalStatus" Enabled="false" ReadOnly="true" runat="server" DataField="ApprovalStatus">
            </px:PXDropDown>
                <px:PXDropDown ID="PXDropDown1"  runat="server" DataField="ApprovedBy">
            </px:PXDropDown>
                 <px:PXDateTimeEdit ID="edLastUpdatedOn" runat="server" AlreadyLocalized="False" DataField="LastModifiedDateTime">
            </px:PXDateTimeEdit>
 <px:PXSelector ID="edWarehouse" runat="server" AlreadyLocalized="False" DataField="DefaultRMWarehouse" CommitChanges="True">
                 </px:PXSelector>
                 <px:PXTextEdit ID="edRevisionReason" runat="server" AlreadyLocalized="False" DataField="RevisionReason" Height="50" TextMode="MultiLine">
            </px:PXTextEdit>
                </Template>
                    </px:PXFormView>
                </Template>
			</px:PXTabItem>
			<px:PXTabItem Text="Tab item 2">
			</px:PXTabItem>
		</Items>
		<AutoSize Container="Window" Enabled="True" MinHeight="150" />
	</px:PXTab>
</asp:Content>
