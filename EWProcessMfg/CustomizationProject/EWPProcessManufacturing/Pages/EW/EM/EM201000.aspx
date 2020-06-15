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
        Width="100%" DataMember="Documents" TabIndex="3700" DefaultControlID="edPlanCD">
        <Template>
            <px:PXLayoutRule runat="server" StartRow="True" StartColumn="True" />
            <px:PXSelector ID="edFormulaID" runat="server" AlreadyLocalized="False" DataField="FormulaID" AutoRefresh="true" CommitChanges="True">
            </px:PXSelector>
            <px:PXTextEdit ID="edDescription" runat="server" AlreadyLocalized="False" DataField="Description">
            </px:PXTextEdit>
            <px:PXTextEdit ID="edRemarks" runat="server" AlreadyLocalized="False" DataField="Remarks" Height="50" TextMode="MultiLine">
            </px:PXTextEdit>
            <px:PXLayoutRule runat="server" StartColumn="True">
            </px:PXLayoutRule>
            <px:PXSelector ID="edRevisionNo" Enabled="true" runat="server" AutoRefresh="true" AlreadyLocalized="False" DataField="RevisionNo">
            </px:PXSelector>
            <px:PXDateTimeEdit ID="edEffectiveFromDate" runat="server" AlreadyLocalized="False" DataField="EffectiveFromDate">
            </px:PXDateTimeEdit>
            <px:PXDateTimeEdit ID="edEffectiveToDate" runat="server" AlreadyLocalized="False" DataField="EffectiveToDate">
            </px:PXDateTimeEdit>

            <px:PXDropDown ID="edStatusText" Enabled="false" ReadOnly="true" runat="server" DataField="Status">
            </px:PXDropDown>
            <px:PXLayoutRule runat="server" StartColumn="True">
            </px:PXLayoutRule>
            <px:PXSelector ID="PXDropDown1" Enabled="false" ReadOnly="true" runat="server" DataField="OwnerID">
            </px:PXSelector>
            <px:PXDropDown ID="edRMCostMethod" Enabled="false" ReadOnly="true" runat="server" DataField="RMCostMethod">
            </px:PXDropDown>

        </Template>
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
    <px:PXTab ID="tab" runat="server" Width="100%" Height="150px" DataSourceID="ds" DataMember="Documents">
        <Items>
            <px:PXTabItem Text="Operations"><Template>
                <px:PXSplitContainer runat="server" ID="sp1" SplitterPosition="300" SkinID="Horizontal" Height="600px" Panel1MinSize="100" Panel2MinSize="100">
                    <autosize container="Window" enabled="True" minheight="300" />
                    <template1>
    <px:PXGrid ID="grid" runat="server" DataSourceID="ds" Width="100%" Height="100%" SkinID="Details" Caption="Operations" AutoAdjustColumns="True" SyncPosition="true">
        <Levels>
            <px:PXGridLevel DataMember="FormulaOperRecords" >
                <RowTemplate>
                    <px:PXMaskEdit ID="edOperationCD" runat="server" DataField="OperationCD" />
                    <px:PXSelector ID="edWcID" runat="server" DataField="WcID" AllowEdit="True" />
                    <px:PXTextEdit ID="edTemp" runat="server" DataField="Temp" MaxLength="60" />
                    <px:PXMaskEdit ID="edSetupTime" runat="server" DataField="SetupTime" CommitChanges="True" />
                    <px:PXNumberEdit ID="edRunUnits" runat="server" DataField="RunUnits" CommitChanges="True" />
                    <px:PXMaskEdit ID="edRunUnitTime" runat="server" DataField="RunUnitTime" CommitChanges="True" />
                    <px:PXNumberEdit ID="edMachineUnits" runat="server" DataField="MachineUnits" CommitChanges="True" />
                    <px:PXMaskEdit ID="edMachineUnitTime" runat="server" DataField="MachineUnitTime" CommitChanges="True" />
                    <px:PXMaskEdit ID="edQueueTime" runat="server" DataField="QueueTime" CommitChanges="True" />
                    <px:PXDropDown ID="edScrapAction" runat="server" DataField="ScrapAction" />
                </RowTemplate>
                <Columns>
                   
                    <px:PXGridColumn DataField="OperationCD" Width="70px" AutoCallBack="True" />
                      <px:PXGridColumn DataField="Temp" MaxLength="60" Width="250px" />
                    <px:PXGridColumn DataField="WcID" Width="81px" AutoCallBack="True" />
                    <px:PXGridColumn DataField="SetupTime" TextAlign="Right" Width="99px" AutoCallBack="True" />
                    <px:PXGridColumn DataField="RunUnits" TextAlign="Right" Width="90px" AutoCallBack="True" />
                    <px:PXGridColumn DataField="RunUnitTime" TextAlign="Right" Width="99px" AutoCallBack="True" />
                    <px:PXGridColumn DataField="MachineUnits" TextAlign="Right" Width="90px" AutoCallBack="True" />
                    <px:PXGridColumn DataField="MachineUnitTime" TextAlign="Right" Width="99px" AutoCallBack="True" />
                    <px:PXGridColumn DataField="QueueTime" TextAlign="Right" Width="99px" />
                    <px:PXGridColumn DataField="BFlush" TextAlign="Center" Type="CheckBox" />
                    <px:PXGridColumn DataField="ScrapAction" Width="80px" MaxLength="1" RenderEditorText="True" TextAlign="Left" />
                </Columns>
            </px:PXGridLevel>
        </Levels>
        <Mode AllowUpload="True"/>
        <AutoSize Enabled="True" />
        <ActionBar ActionsText="False">
        </ActionBar>
       <AutoCallBack Command="Refresh" Target="gridmatl" ActiveBehavior="true">
            <Behavior RepaintControlsIDs="gridmatl,gridOvhd" />
        </AutoCallBack>
    </px:PXGrid>
</template1>
                    <template2>
    <px:PXTab ID="PXTab1" runat="server" Width="100%" Height="100%">
<Items>
    <px:PXTabItem Text="Materials" LoadOnDemand="True" RepaintOnDemand="True"><Template>
            <px:PXGrid ID="gridMatl" runat="server" DataSourceID="ds" Width="100%" SkinID="DetailsInTab" SyncPosition="True">
                <Levels>
                    <px:PXGridLevel DataMember="FormulaMatlRecords">
                        <RowTemplate>
                            <px:PXLayoutRule ID="PXLayoutRule5" runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                            <px:PXSegmentMask ID="edInventoryID" runat="server" DataField="InventoryID" AllowEdit="True" />
                            <px:PXSegmentMask ID="edSubItemID" runat="server" DataField="SubItemID" />
                            <px:PXTextEdit ID="edDescrMat" runat="server" DataField="Descr" MaxLength="60" />
                            <px:PXNumberEdit ID="edQtyReq" runat="server" DataField="QtyReq" />
                            <px:PXSelector ID="edUOM" runat="server" DataField="UOM" AutoRefresh="True" />
                            <px:PXNumberEdit ID="edUnitCost" runat="server" DataField="UnitCost" />
                            <px:PXCheckBox ID="chkBFlush1" runat="server" DataField="BFlush" />
                            <px:PXLayoutRule ID="PXLayoutRule6" runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                            <px:PXSegmentMask ID="edSiteID" runat="server" DataField="SiteID" CommitChanges="true" />
                            <px:PXSegmentMask ID="edLocationID" runat="server" DataField="LocationID" />
                            <px:PXNumberEdit ID="edScrapFactor" runat="server" DataField="ScrapFactor" />
                            <px:PXLayoutRule ID="PXLayoutRule7" runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                            
                        </RowTemplate>
                        <Columns>
                            <px:PXGridColumn DataField="LineID" TextAlign="Right" Width="54px" />
                            <px:PXGridColumn DataField="SortOrder" TextAlign="Right" Width="54px" />
                            <px:PXGridColumn DataField="InventoryID" Width="130px" AutoCallBack="True" />
                            <px:PXGridColumn DataField="SubItemID" Width="81px" />
                            <px:PXGridColumn DataField="Descr" MaxLength="255" Width="200px" />
                            <px:PXGridColumn DataField="QtyReq" TextAlign="Right" Width="108px" AutoCallBack="True" />                            
                            <px:PXGridColumn DataField="UOM" Width="81px" AutoCallBack="True" />
                            <px:PXGridColumn DataField="UnitCost" TextAlign="Right" Width="108px" />
                            <px:PXGridColumn DataField="BFlush" TextAlign="Center" Type="CheckBox" Width="85px" />
                            <px:PXGridColumn DataField="SiteID" TextAlign="Left" Width="130px" CommitChanges="true" />
                            <px:PXGridColumn DataField="LocationID" TextAlign="Right" Width="130px" />
                            <px:PXGridColumn DataField="ScrapFactor" TextAlign="Right" Width="108px" />
                           
                        </Columns>
                    </px:PXGridLevel>
                </Levels>
                <Mode AllowUpload="True" AllowDragRows="true"/>
                <AutoSize Enabled="True" />
               <%-- <ActionBar ActionsText="False">
                    <CustomItems>
                        <px:PXToolBarButton Text="Reference Designators" PopupPanel="PanelRef" Enabled="true">
                        </px:PXToolBarButton>
                        <px:PXToolBarButton DependOnGrid="gridMatl" Key="cmdResetOrder">
                            <AutoCallBack Command="ResetOrder" Target="ds" />
                        </px:PXToolBarButton>
                        <px:PXToolBarButton Text="Insert Row" SyncText="false" ImageSet="main" ImageKey="AddNew">
                            <AutoCallBack Target="gridMatl" Command="AddNew" Argument="1"></AutoCallBack>
                            <ActionBar ToolBarVisible="External" MenuVisible="true" />
                        </px:PXToolBarButton>
                        <px:PXToolBarButton Text="Cut Row" SyncText="false" ImageSet="main" ImageKey="Copy">
                            <AutoCallBack Target="gridMatl" Command="Copy"></AutoCallBack>
                            <ActionBar ToolBarVisible="External" MenuVisible="true" />
                        </px:PXToolBarButton>
                        <px:PXToolBarButton Text="Insert Cut Row" SyncText="false" ImageSet="main" ImageKey="Paste">
                            <AutoCallBack Target="gridMatl" Command="Paste"></AutoCallBack>
                            <ActionBar ToolBarVisible="External" MenuVisible="true" />
                        </px:PXToolBarButton>
                    </CustomItems>
                </ActionBar>--%>
               
                <Parameters>
					<px:PXSyncGridParam ControlID="grid" />
				</Parameters>
                <ActionBar ActionsText="False"></ActionBar>
                <CallbackCommands PasteCommand="PasteLine">
                    <Save PostData="Container" />
                </CallbackCommands>
            </px:PXGrid>
        
   
         </Template>
    </px:PXTabItem>   
   
</Items>
<AutoSize Enabled="True" />
</px:PXTab>
</template2>
                </px:PXSplitContainer></Template>
            </px:PXTabItem>
            <px:PXTabItem Text="Details" BindingContext="form">
                <Template>
                    <px:PXFormView ID="formN" runat="server" DataSourceID="ds" DataMember="Documents" CaptionVisible="False" SkinID="Transparent" MarkRequired="Dynamic">
                        <Template>
                            <px:PXLayoutRule runat="server" ControlSize="XM" StartColumn="True"></px:PXLayoutRule>
                            <px:PXSelector ID="edFormulaClassID" runat="server" AlreadyLocalized="False" DataField="FormulaClassID" CommitChanges="True">
                            </px:PXSelector>
                            <px:PXSelector ID="edFormulaPolicyID" runat="server" AlreadyLocalized="False" DataField="FormulaPolicyID" CommitChanges="True">
                            </px:PXSelector>
                            <px:PXDropDown ID="edApprovalStatus" Enabled="false" ReadOnly="true" runat="server" DataField="ApprovalStatus">
                            </px:PXDropDown>
                            <px:PXDropDown ID="edApprovedBy" Enabled="false" ReadOnly="true" runat="server"  DataField="ApprovedBy">
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
            
        </Items>
        <AutoSize Container="Window" Enabled="True" MinHeight="150" />
    </px:PXTab>
</asp:Content>
