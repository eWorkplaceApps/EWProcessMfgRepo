<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="EM201100.aspx.cs" Inherits="Page_EM201100" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
    <px:PXDataSource ID="ds" TypeName="EW.PM.EWPMFormulaClassMaint" PrimaryView="FormulaClasses" runat="server" Visible="True" Width="100%">
        <CallbackCommands>
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
    <px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" Style="z-index: 100"
        AllowPaging="True" AllowSearch="true" AdjustPageSize="Auto" DataSourceID="ds" SkinID="Primary">
        <Levels>
            <px:PXGridLevel DataMember="FormulaClasses" DataKeyNames="FormulaClassCD">
                <RowTemplate>
                    <px:PXMaskEdit ID="edformulaClassCD" runat="server" AlreadyLocalized="False" DataField="FormulaClassCD">
                    </px:PXMaskEdit>
                    <px:PXTextEdit ID="edDescription" runat="server" AlreadyLocalized="False" DataField="Description">
                    </px:PXTextEdit>
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="FormulaClassCD" Width="180px">
                    </px:PXGridColumn>
                    <px:PXGridColumn DataField="Description" Width="280px">
                    </px:PXGridColumn>
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXGrid>
</asp:Content>
