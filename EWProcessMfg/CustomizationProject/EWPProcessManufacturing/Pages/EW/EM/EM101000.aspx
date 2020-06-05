<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="EM101000.aspx.cs" Inherits="Page_EM101000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormView.master" %>



<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
    <px:PXDataSource ID="ds" runat="server" Visible="True" TypeName="EW.PM.EWPMSetupMaint" PageLoadBehavior="InsertRecord" AttributesFound="False" EnableAttributes="False" PrimaryView="Setup" SuspendUnloading="False">
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
 <px:PXFormView ID="form" runat="server" DataSourceID="ds" Style="z-index: 100"
        Width="100%" DataMember="Setup" TabIndex="1400">
        <Template>
            <px:PXLayoutRule runat="server" StartRow="True" StartColumn="True" />
             <px:PXSelector ID="edFormulaNumberSequenceID" runat="server" DataField="FormulaNumberSequenceID" Size="XL" LabelWidth="250">
            </px:PXSelector>
            <px:PXSelector ID="PXSystemVolumne" runat="server" DataField="SystemVolumeUnit" Size="XL" LabelWidth="250">
            </px:PXSelector>
            <px:PXSelector ID="PXSystemWeight" runat="server" DataField="SystemWeightUnit" Size="XL" LabelWidth="250">
            </px:PXSelector>
            
		</Template>
	</px:PXFormView>
</asp:Content>

