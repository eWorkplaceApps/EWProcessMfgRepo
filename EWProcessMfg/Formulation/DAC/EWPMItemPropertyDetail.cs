using System;
using PX.Data;


namespace EW.PM
{

  [Serializable]
  [PXCacheName("EWPMItemPropertyDetail")]
  public class EWPMItemPropertyDetail : IBqlTable
  {
    #region ItemPropertyDetailID
    [PXDBIdentity(IsKey = true)]
    public virtual int? ItemPropertyDetailID { get; set; }
    public abstract class itemPropertyDetailID : PX.Data.BQL.BqlInt.Field<itemPropertyDetailID> { }
    #endregion

    #region ItemPropertyID
    [PXDBInt()]
    [PXUIField(DisplayName = "Item Property ")]
    [PXDBDefault(typeof(EWPMItemProperty.itemPropertyID))]
    [PXParent(typeof(Select<EWPMItemProperty, Where<EWPMItemProperty.itemPropertyID, Equal<Current<itemPropertyID>>>>))]
    public virtual int? ItemPropertyID { get; set; }
    public abstract class itemPropertyID : PX.Data.BQL.BqlInt.Field<itemPropertyID> { }

    #endregion

    #region PropertyLineNbr
    [PXDBInt()]
    [PXUIField(DisplayName = "Property Line Nbr")]
    public virtual int? PropertyLineNbr { get; set; }
    public abstract class propertyLineNbr : PX.Data.BQL.BqlInt.Field<propertyLineNbr> { }
    #endregion

    #region PropertyID
    [PXDBInt()]
    [PXUIField(DisplayName = "Property ID")]
    [PXSelector(typeof(EWPMProperty.proprtyID),
            typeof(EWPMProperty.proprtyID),
            typeof(EWPMProperty.description), SubstituteKey  =  typeof(EWPMProperty.description)
            )]
    public virtual int? PropertyID { get; set; }
    public abstract class propertyID : PX.Data.BQL.BqlInt.Field<propertyID> { }
    #endregion

    #region PropertyType

    [PXString(500, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Type", Enabled = false)]
    public virtual string PropertyType {
      get; set;
    }
    public abstract class propertyType : PX.Data.BQL.BqlString.Field<propertyType> { }

    #endregion

    #region PropertyUnit

    [PXString(500, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Unit", Enabled = false)]
    public virtual string PropertyUnit {
      get; set;
    }
    public abstract class propertyUnit : PX.Data.BQL.BqlString.Field<propertyUnit> { }

    #endregion

    #region PropertyGroup

    [PXString(500, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Group", Enabled = false)]
    public virtual string PropertyGroup {
      get; set;
    }
    public abstract class propertyGroup : PX.Data.BQL.BqlString.Field<propertyGroup> { }

    #endregion

    #region PropertyValue
    [PXDBString(1000, IsUnicode = true, InputMask = "")]
    [PXUIField(DisplayName = "Property Value")]
    public virtual string PropertyValue { get; set; }
    public abstract class propertyValue : PX.Data.BQL.BqlString.Field<propertyValue> { }
    #endregion

    #region GroupLineNbr
    [PXDBInt()]
    [PXUIField(DisplayName = "Group Line Nbr")]
    public virtual int? GroupLineNbr { get; set; }
    public abstract class groupLineNbr : PX.Data.BQL.BqlInt.Field<groupLineNbr> { }
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
