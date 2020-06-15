<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true"
    ValidateRequest="false" CodeFile="EM201200.aspx.cs" Inherits="Page_EM201200" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
    <px:PXDataSource ID="ds" runat="server" TypeName="EW.PM.EWPMItemPropertyMaint" PrimaryView="ItemProperty" Visible="True" Width="100%">
        <CallbackCommands>
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
    <px:PXFormView ID="form" runat="server" DataSourceID="ds" DataMember="ItemProperty" Style="z-index: 100" Width="100%">
        <Template>
            <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="S" ControlSize="S" />
            <px:PXSelector ID="edInventoryID" runat="server" DataField="InventoryID" CommitChanges="true" Width="250">
            </px:PXSelector>
            <px:PXTextEdit ID="edDescription" runat="server" DataField="Description" Enabled="false" Width="450" />
        </Template>
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
    <px:PXTab ID="tab" runat="server" Width="100%" Height="150px" DataSourceID="ds" DataMember="ItemPropertyDetails" NoteIndicator="True" FilesIndicator="True">
        <Items>
            <px:PXTabItem Text="Property Details" BindingContext="form">
                <Template>
                    <px:PXGrid ID="formPropertyDetails" runat="server" DataSourceID="ds" Width="100%" SkinID="Details" BorderStyle="None" SyncPosition="true">

                        <EmptyMsg AnonFilteredAddMessage="No records found.
Try to change filter to see records here."
                            AnonFilteredMessage="No records found.
Try to change filter to see records here."
                            ComboAddMessage="No records found.
Try to change filter or modify parameters above to see records here."
                            FilteredAddMessage="No records found.
Try to change filter to see records here."
                            FilteredMessage="No records found.
Try to change filter to see records here."
                            NamedComboAddMessage="No records found as '{0}'.
Try to change filter or modify parameters above to see records here."
                            NamedComboMessage="No records found as '{0}'.
Try to change filter or modify parameters above to see records here."
                            NamedFilteredAddMessage="No records found as '{0}'.
Try to change filter to see records here."
                            NamedFilteredMessage="No records found as '{0}'.
Try to change filter to see records here." />
                        <Levels>

                            <px:PXGridLevel DataKeyNames="ItemPropertyDetailID" DataMember="ItemPropertyDetails">

                                <RowTemplate>

                                    <px:PXNumberEdit ID="edPropertyLineNbr" runat="server" AlreadyLocalized="False" DataField="PropertyLineNbr">
                                    </px:PXNumberEdit>

                                      <px:PXSelector ID="edPropertyID" runat="server" AlreadyLocalized="False" DataField="PropertyID" AutoRefresh="true" CommitChanges="true" SyncStateWithCommand="true">
                                 </px:PXSelector>

                                 <px:PXMaskEdit ID="edPropertyType" runat="server" AlreadyLocalized="False" DataField="PropertyType">
                                  </px:PXMaskEdit>   

                                 <px:PXMaskEdit ID="edPropertyValue" runat="server" AlreadyLocalized="False" DataField="PropertyValue">
                                  </px:PXMaskEdit>   

                                 <px:PXMaskEdit ID="edPropertyUnit" runat="server" AlreadyLocalized="False" DataField="PropertyUnit">
                                  </px:PXMaskEdit>  

                                  <px:PXMaskEdit ID="edPropertyGroup" runat="server" AlreadyLocalized="False" DataField="PropertyGroup">
                                  </px:PXMaskEdit>  

                                  <px:PXMaskEdit ID="edPropertyGroupLineNbr" runat="server" AlreadyLocalized="False" DataField="GroupLineNbr">
                                  </px:PXMaskEdit>                                   
                                    
                                </RowTemplate>
                                <Columns>
                                    <px:PXGridColumn DataField="PropertyLineNbr" Width="150" CommitChanges="true" />
                                      <px:PXGridColumn DataField="PropertyID"  Width="150" CommitChanges="true"/>
                                    <px:PXGridColumn DataField="PropertyType"  CommitChanges="true"/>
                                    <px:PXGridColumn DataField="PropertyValue"  Width="150" CommitChanges="true"/>
                                    <px:PXGridColumn DataField="PropertyUnit"  Width="150" CommitChanges="true"/>
                                    <px:PXGridColumn DataField="PropertyGroup" Width="150" CommitChanges="true"/>
                                    <px:PXGridColumn DataField="GroupLineNbr" Width="150" CommitChanges="true"/>
                                </Columns>
                            </px:PXGridLevel>

                        </Levels>
                        <Mode InitNewRow="True" />
                        <AutoSize Enabled="True" MinHeight="150" />
                    </px:PXGrid>
                </Template>
            </px:PXTabItem>            
        </Items>
        <autosize container="Window" enabled="True" minheight="150" />
    </px:PXTab>
</asp:Content>
