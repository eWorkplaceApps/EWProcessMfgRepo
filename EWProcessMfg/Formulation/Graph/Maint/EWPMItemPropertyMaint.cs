using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;
using PX.Objects.IN;

namespace EW.PM
{
  public class EWPMItemPropertyMaint : PXGraph<EWPMItemPropertyMaint, EWPMItemProperty>
  {
    #region Data Veiws

    public PXSelect<EWPMItemProperty> ItemProperty;
    public PXSelect<EWPMItemPropertyDetail> ItemPropertyDetails;
    public PXSelect<InventoryItem, Where<InventoryItem.inventoryID, Equal<Current<EWPMItemProperty.inventoryID>>>> InventoryItemQuery;

    #endregion Data Views

    #region ItemProperty Events

    protected virtual void  _(Events.FieldUpdated<EWPMItemProperty, EWPMItemProperty.inventoryID> e)
    {
      
      InventoryItem result = InventoryItemQuery.Select(e.Row.InventoryID);

      if (result != null)
      {
        e.Row.Description = result.Descr;        
      }
    }
    #endregion ItemProperty Events
  }
}