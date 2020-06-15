using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.CM;
using PX.Objects.CS;
using PX.Objects.IN;

namespace EW.PM {
  /// <summary>
  /// Formula Operation Material
  /// </summary>
  [Serializable]
  [PXCacheName("FormulaOprMatl")]
  public class EWPMFormulaMatl:IBqlTable, ISortOrder {

    #region primary key fields
    public abstract class operationID:PX.Data.BQL.BqlInt.Field<operationID> {
    }
    [OperationIDField(IsKey = true, Visible = false, Enabled = false)]
    [PXDBDefault(typeof(EWPMFormulaOper.operationID))]
    [PXParent(typeof(Select<EWPMFormulaOper, Where<EWPMFormulaOper.formulaID, Equal<Current<formulaID>>, And<EWPMFormulaOper.revisionNo, Equal<Current<revisionNo>>, And<EWPMFormulaOper.operationID, Equal<Current<operationID>>>>>>))]
    [PXParent(typeof(Select<EWPMFormula, Where<EWPMFormula.formulaID, Equal<Current<formulaID>>, And<EWPMFormula.revisionNo, Equal<Current<revisionNo>>>>>))]
    public virtual int? OperationID {
      get;
      set;
    }

    public abstract class formulaID:PX.Data.BQL.BqlString.Field<formulaID> {
    }

    [ID(IsKey = true, Visible = false, Enabled = false)]
    [PXDBDefault(typeof(EWPMFormulaOper.formulaID))]

    public virtual string FormulaID {
      get;
      set;
    }
    public abstract class revisionNo:PX.Data.BQL.BqlString.Field<revisionNo> {
    }
    [PXDBDefault(typeof(EWPMFormulaOper.revisionNo ))]
    [Revision(IsKey = true, Visibility = PXUIVisibility.SelectorVisible, Visible = false, Enabled = false)]
    public virtual string RevisionNo{
      get;
      set;
    }
    public abstract class lineID:PX.Data.BQL.BqlInt.Field<lineID> {
    }
    [PXDBInt(IsKey = true)]
    [PXLineNbr(typeof(EWPMFormulaOper.lineCntrMatl))]
    [PXUIField(DisplayName = "Line Nbr.", Visibility = PXUIVisibility.Visible, Visible = false, Enabled = false)]
    public virtual int? LineID {
      get;
      set;
    }
    public abstract class lineNbr:PX.Data.BQL.BqlInt.Field<lineNbr> {
    }
    [PXInt]
    [PXUIField(DisplayName = "Line Nbr. 2", Visibility = PXUIVisibility.Invisible, Visible = false, Enabled = false)]
    public virtual int? LineNbr {
      get;
    }
    public abstract class sortOrder:PX.Data.BQL.BqlInt.Field<sortOrder> {
    }
    [PXDBInt]
    [PXUIField(DisplayName = "Line Order", Visible = false, Enabled = false)]
    public virtual int? SortOrder {
      get;
      set;
    }

    #endregion

  
    #region SystemFields
    public abstract class lastModifiedDateTime:PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> {
    }
    [PXDBLastModifiedDateTime]
    public virtual DateTime? LastModifiedDateTime {
      get;
      set;
    }

    public abstract class lastModifiedByID:PX.Data.BQL.BqlGuid.Field<lastModifiedByID> {
    }
    [PXDBLastModifiedByID]
    public virtual Guid? LastModifiedByID {
      get;
      set;
    }

    public abstract class Tstamp:PX.Data.BQL.BqlByte.Field<Tstamp> {
    }
    [PXDBTimestamp]
    public virtual byte[] tstamp {
      get;
      set;
    }

    public abstract class createdByID:PX.Data.BQL.BqlGuid.Field<createdByID> {
    }
    [PXDBCreatedByID]
    public virtual Guid? CreatedByID {
      get;
      set;
    }

    public abstract class createdByScreenID:PX.Data.BQL.BqlString.Field<createdByScreenID> {
    }
    [PXDBCreatedByScreenID]
    public virtual string CreatedByScreenID {
      get;
      set;
    }

    public abstract class createdDateTime:PX.Data.BQL.BqlDateTime.Field<createdDateTime> {
    }
    [PXDBCreatedDateTime]
    public virtual DateTime? CreatedDateTime {
      get;
      set;
    }

    public abstract class lastModifiedByScreenID:PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> {
    }
    [PXDBLastModifiedByScreenID]
    public virtual string LastModifiedByScreenID {
      get;
      set;
    }
    #endregion

    
    public abstract class lineCntrRef:PX.Data.BQL.BqlInt.Field<lineCntrRef> {
    }
    [PXDBInt]
    [PXDefault(0)]
    public virtual int? LineCntrRef {
      get;
      set;
    }

    public abstract class bFlush:PX.Data.BQL.BqlBool.Field<bFlush> {
    }
    [PXDBBool]
    [PXDefault(false)]
    [PXUIField(DisplayName = "Backflus")]
    public virtual bool? BFlush {
      get;
      set;
    }

    public abstract class isStockItem:PX.Data.BQL.BqlBool.Field<isStockItem> {
    }
    [PXDBBool]
    [PXDefault(false, typeof(Search<InventoryItem.stkItem, Where<InventoryItem.inventoryID, Equal<Current<inventoryID>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
    [PXFormula(typeof(Default<inventoryID>))]
    [PXUIField(DisplayName = "Is stock", Enabled = false)]
    public virtual bool? IsStockItem {
      get;
      set;
    }

    

    //public abstract class batchSize:PX.Data.BQL.BqlDecimal.Field<batchSize> {
    //}
    //[BatchSize]
    //[PXDefault(TypeCode.Decimal, "1.0")]
    //public virtual decimal? BatchSize {
    //  get;
    //  set;
    //}

    //public abstract class rowStatus:PX.Data.BQL.BqlInt.Field<rowStatus> {
    //}
    //[AMRowStatus.List]
    //[PXDBInt]
    //[PXUIField(DisplayName = "Change Status", Enabled = false)]
    //public virtual int? RowStatus {
    //  get;
    //  set;
    //}

    //public abstract class subcontractSource:PX.Data.BQL.BqlInt.Field<subcontractSource> {
    //}
    //[AMSubcontractSource.List]
    //[PXDBInt]
    //[PXDefault(0)]
    //[PXUIField(DisplayName = "Subcontract Source")]
    //public virtual int? SubcontractSource {
    //  get;
    //  set;
    //}
    public abstract class scrapFactor:PX.Data.BQL.BqlDecimal.Field<scrapFactor> {
    }
    [PXDBDecimal(6, MinValue = 0)]
    [PXDefault(TypeCode.Decimal, "0.0")]
    [PXUIField(DisplayName = "Scrap Factor")]
    public virtual decimal? ScrapFactor {
      get;
      set;
    }

    //public abstract class bubbleNbr:PX.Data.BQL.BqlString.Field<bubbleNbr> {
    //}
    //[PXDBString(10)]
    //[PXUIField(DisplayName = "Bubble Nbr")]
    //public virtual string BubbleNbr {
    //  get;
    //  set;
    //}

    public abstract class locationID:PX.Data.BQL.BqlInt.Field<locationID> {
    }
   // [MfgLocationAvail(typeof(inventoryID), typeof(subItemID), typeof(siteID), typeof(Where<qtyReq, GreaterEqual<decimal0>>), typeof(Where<qtyReq, Less<decimal0>>))]
    [PXForeignReference(typeof(CompositeKey<Field<siteID>.IsRelatedTo<INLocation.siteID>, Field<locationID>.IsRelatedTo<INLocation.locationID>>))]
    public virtual int? LocationID {
      get;
      set;
    }

    public abstract class inventoryID:PX.Data.BQL.BqlInt.Field<inventoryID> {
    }
    [Inventory(Visibility = PXUIVisibility.SelectorVisible)]
    [PXForeignReference(typeof(Field<inventoryID>.IsRelatedTo<InventoryItem.inventoryID>))]
    public virtual int? InventoryID {
      get;
      set;
    }
    public abstract class subItemID:PX.Data.BQL.BqlInt.Field<subItemID> {
    }
    [PXDefault(typeof(Search<InventoryItem.defaultSubItemID, Where<InventoryItem.inventoryID, Equal<Current<inventoryID>>, And<InventoryItem.defaultSubItemOnEntry, Equal<boolTrue>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
    [PXFormula(typeof(Default<inventoryID>))]
    [SubItem(typeof(inventoryID))]
    public virtual int? SubItemID {
      get;
      set;
    }

    public abstract class descr:PX.Data.BQL.BqlString.Field<descr> {
    }
    [PXDBString(256, IsUnicode = true)]
    [PXDefault(typeof(Search<InventoryItem.descr, Where<InventoryItem.inventoryID, Equal<Current<inventoryID>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Description")]
    public virtual string Descr {
      get;
      set;
    }

    public abstract class qtyReq:PX.Data.BQL.BqlDecimal.Field<qtyReq> {
    }
    [PXDBQuantity(typeof(uOM), typeof(baseQty))]
    [PXDefault(TypeCode.Decimal, "1.0")]
    [PXUIField(DisplayName = "Qty Required")]
    public virtual decimal? QtyReq {
      get;
      set;
    }

    public abstract class baseQty:PX.Data.BQL.BqlDecimal.Field<baseQty> {
    }
    [PXDBDecimal(6)]
    [PXDefault(TypeCode.Decimal, "1.0")]
    [PXUIField(DisplayName = "Base Qty")]
    public virtual decimal? BaseQty {
      get;
      set;
    }

    public abstract class unitCost:PX.Data.BQL.BqlDecimal.Field<unitCost> {
    }
   // [MatlUnitCostDefault(typeof(inventoryID), typeof(siteID), typeof(uOM), typeof(EWQCBomItem), typeof(EWQCBomItem.siteID))]
    [PXDBPriceCost]
    [PXDefault]
    [PXFormula(typeof(Default<inventoryID, siteID, uOM>))]
    [PXUIField(DisplayName = "Unit Cost")]
    public virtual decimal? UnitCost {
      get;
      set;
    }

  //  public abstract class materialType:PX.Data.BQL.BqlDecimal.Field<materialType> {
  //  }
  ////  [AMMaterialType.List]
  //  [PXDBInt]
  //  [PXDefault(1)]
  //  [PXUIField(DisplayName = "Material Type")]
  //  public virtual int? MaterialType {
  //    get;
  //    set;
  //  }

  //  public abstract class phantomRouting:PX.Data.BQL.BqlInt.Field<phantomRouting> {
  //  }
  //  [PhantomRoutingOptions.List]
  //  [PXDBInt]
  //  [PXDefault(1)]
  //  [PXUIField(DisplayName = "Phantom Routing")]
  //  public virtual int? PhantomRouting {
  //    get;
  //    set;
  //  }

    public abstract class siteID:PX.Data.BQL.BqlInt.Field<siteID> {
    }

    [PXForeignReference(typeof(Field<siteID>.IsRelatedTo<INSite.siteID>))]
    [PXRestrictor(typeof(Where<INSite.active, Equal<True>>), "Warehouse '{0}' is inactive", new[] { typeof(INSite.siteCD) }, CacheGlobal = true)]
    [Site]
    public virtual int? SiteID {
      get;
      set;
    }

    public abstract class uOM:PX.Data.BQL.BqlString.Field<uOM> {
    }
    [INUnit(typeof(inventoryID))]
    [PXDefault(typeof(Search<InventoryItem.baseUnit, Where<InventoryItem.inventoryID, Equal<Current<inventoryID>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
    public virtual string UOM {
      get;
      set;
    }
  }
}
