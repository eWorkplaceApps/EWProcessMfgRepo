<%@ Page Language="C#" MasterPageFile="~/MasterPages/ListView.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="EM201600.aspx.cs" Inherits="Page_EM201600" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/ListView.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
    <px:PXDataSource ID="ds" runat="server" TypeName="EW.PM.EWPMBiolerplateMaint" PrimaryView="Boilerplates" Visible="True" Width="100%">
        <CallbackCommands>
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phL" runat="Server">
    <px:PXGrid ID="grid" runat="server" Height="400px" Width="100%" Style="z-index: 100"
        AllowPaging="True" AllowSearch="true" AdjustPageSize="Auto" DataSourceID="ds" SkinID="Primary">
        <Levels>
            <px:PXGridLevel DataMember="Boilerplates" DataKeyNames="BoilerplateCD">
                <RowTemplate>
                    <px:PXMaskEdit ID="edBoilerplateCD" runat="server" AlreadyLocalized="False" DataField="BoilerplateCD">
                    </px:PXMaskEdit>
                    <px:PXTextEdit ID="edDescription" runat="server" AlreadyLocalized="False" DataField="Description">
                    </px:PXTextEdit>
                    <px:PXSelector ID="edBoilerplateGroupID" runat="server" DataField="BoilerplateGroupID">
                    </px:PXSelector>
                </RowTemplate>
                <Columns>
                    <px:PXGridColumn DataField="BoilerplateCD" Width="180px">
                    </px:PXGridColumn>
                    <px:PXGridColumn DataField="Description" Width="500px">
                    </px:PXGridColumn>
                    <px:PXGridColumn DataField="BoilerplateGroupID" >
                    </px:PXGridColumn>
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <AutoSize Container="Window" Enabled="True" MinHeight="200" />
    </px:PXGrid>
</asp:Content>
