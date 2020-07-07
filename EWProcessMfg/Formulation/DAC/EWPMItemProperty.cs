using System;
using PX.Data;
using PX.Objects.IN;

namespace EW.PM
{
  [Serializable]
  [PXCacheName("EWPMItemProperty")]
  public class EWPMItemProperty : IBqlTable
  {
    #region ItemPropertyID
    [PXDBIdentity(IsKey = true)]
    public virtual int? ItemPropertyID { get; set; }
    public abstract class itemPropertyID : PX.Data.BQL.BqlInt.Field<itemPropertyID> { }
    #endregion

    #region InventoryID
    [PXDBString(50, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Inventory ID")]
    // [PXSelector(typeof(Search2<InventoryItem.inventoryID,
    // InnerJoin<EWQCInventoryDetail,
    // On<EWQCInventoryDetail.inventoryID,
    // Equal<InventoryItem.inventoryID>, And<EWQCInventoryDetail.adhocQC,
    //Equal<True>>>>>), new Type[] { typeof(InventoryItem.inventoryCD), typeof(InventoryItem.descr) },
    // SubstituteKey = typeof(InventoryItem.inventoryCD))]
    [PXSelector(typeof(InventoryItem.inventoryID),
             typeof(InventoryItem.inventoryID),
            SubstituteKey =  typeof(InventoryItem.inventoryCD)
             )]
    public virtual string InventoryID { get; set; }
    public abstract class inventoryID : PX.Data.BQL.BqlString.Field<inventoryID> { }
    #endregion

    #region Description

    [PXString(500, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Description")]
    public virtual string Description {
      get; set;
    }
    public abstract class description : PX.Data.BQL.BqlString.Field<description> { }
    #endregion

    #region CreatedDateTime
    [PXDBCreatedDateTime()]
    public virtual DateTime? CreatedDateTime { get; set; }
    public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
    #endregion

    #region CreatedByScreenID
    [PXDBCreatedByScreenID()]
    public virtual string CreatedByScreenID { get; set; }
    public abstract class createdByScreenID : PX.Data.BQL.BqlString.Field<createdByScreenID> { }
    #endregion

    #region CreatedByID
    [PXDBCreatedByID()]
    public virtual Guid? CreatedByID { get; set; }
    public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID> { }
    #endregion

    #region LastModifiedDateTime
    [PXDBLastModifiedDateTime()]
    public virtual DateTime? LastModifiedDateTime { get; set; }
    public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
    #endregion

    #region LastModifiedByScreenID
    [PXDBLastModifiedByScreenID()]
    public virtual string LastModifiedByScreenID { get; set; }
    public abstract class lastModifiedByScreenID : PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> { }
    #endregion

    #region LastModifiedByID
    [PXDBLastModifiedByID()]
    public virtual Guid? LastModifiedByID { get; set; }
    public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID> { }
    #endregion

    #region Tstamp
    [PXDBTimestamp()]
    [PXUIField(DisplayName = "Tstamp")]
    public virtual byte[] Tstamp { get; set; }
    public abstract class tstamp : PX.Data.BQL.BqlByteArray.Field<tstamp> { }




    #endregion
  }
}
