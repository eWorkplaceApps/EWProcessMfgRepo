using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;
using PX.Objects.IN;

namespace EW.PM {
    public class EWPMItemPropertyMaint:PXGraph<EWPMItemPropertyMaint, EWPMItemProperty> {

        #region Data Veiws

        public PXSelectJoin<EWPMItemProperty, LeftJoin<InventoryItem,On<EWPMItemProperty.inventoryID, Equal<InventoryItem.inventoryID>>>> ItemProperty;

        public PXSelectJoin<EWPMItemPropertyDetail, InnerJoin<EWPMProperty, On<EWPMItemPropertyDetail.propertyID, Equal<EWPMProperty.proprtyID>>>, Where<EWPMItemPropertyDetail.itemPropertyID, Equal<Current<EWPMItemProperty.itemPropertyID>>>> ItemPropertyDetails;


        #endregion Data Views
    }
}



#region ItemProperty Events

// public PXSelect<InventoryItem, Where<InventoryItem.inventoryID, Equal<Current<EWPMItemProperty.inventoryID>>>> SelectInventoryItem;
//protected virtual void _(Events.FieldUpdated<EWPMItemProperty, EWPMItemProperty.inventoryID> e) {
//    InventoryItem result = SelectInventoryItem.SelectSingle();
//    if(result != null) {
//        ItemProperty.Current.Description = result.Descr;
//    }
//}

//protected virtual void _(Events.FieldUpdated<EWPMItemPropertyDetail, EWPMItemPropertyDetail.propertyID> e) {
//    //EWPMProperty property= SelectPropertyItem.SelectSingle();
//    EWPMProperty property = PXSelect<EWPMProperty, Where<EWPMProperty.proprtyID, Equal<Required<EWPMProperty.proprtyID>>>>.Select(this, new object[] { e.Row.PropertyID}).TopFirst;
//    if(property != null) {
//        e.Row.PropertyType = property.Type;
//        e.Row.PropertyGroup = property.Group;
//        e.Row.PropertyUnit = property.PropertyUnit;
//    }
//    else {
//        e.Row.PropertyType = null;
//        e.Row.PropertyGroup = null;
//        e.Row.PropertyUnit = null;
//    }
//}

#endregion ItemProperty Events