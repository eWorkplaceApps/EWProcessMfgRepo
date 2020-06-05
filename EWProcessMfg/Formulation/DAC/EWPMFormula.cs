/* Copyright © 2020 eWorkplace Apps (https://www.eworkplaceapps.com/). All Rights Reserved.
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
*
* Author: Asha Sharda
* Date: 1 June 2020
*
*Last Updated By :
*Last Updated Date:
*
*Reviewed By :
*Review Date
*/

using System;
using JAMS.AM.Attributes;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;

namespace EW.PM
{
	
	[System.SerializableAttribute()]
  [PXCacheName("Formula")]
  [PXPrimaryGraph(typeof(EWPMFormulaMaint))]
  public class EWPMFormula : PX.Data.IBqlTable
	{
		#region FormulaID
		public abstract class formulaID : PX.Data.IBqlField
		{
		}
		protected int? _FormulaID;
    [PXDBIdentity()]
    [PXReferentialIntegrityCheck]
    public virtual int? FormulaID
		{
			get
			{
				return this._FormulaID;
			}
			set
			{
				this._FormulaID = value;
			}
		}
		#endregion
		#region FormulaCD
		public abstract class formulaCD : PX.Data.IBqlField
		{
		}
		protected string _FormulaCD;
    [ID(IsKey = true, Required = true)]
    [PXDefault]
    [Rev.Key(typeof(EWPMSetup.formulaNumberSequenceID),
                 typeof(formulaCD),
                 typeof(revisionNo),
                 typeof(formulaCD),
                 typeof(revisionNo),
                  typeof(description)
                 )]
    public virtual string FormulaCD
		{
			get
			{
				return this._FormulaCD;
			}
			set
			{
				this._FormulaCD = value;
			}
		}
		#endregion
		#region RevisionNo
		public abstract class revisionNo : PX.Data.IBqlField
		{
		}
		protected string _RevisionNo;
    [Revision(IsKey = true, Required = true)]
    [PXDefault("A")]
    [Rev.ID(typeof(defaultRevisionNo),
             typeof(formulaCD),
             typeof(revisionNo),
             typeof(revisionNo),
             typeof(description),
             typeof(effectiveFromDate),
             typeof(effectiveToDate))]
    public virtual string RevisionNo
		{
			get
			{
				return this._RevisionNo;
			}
			set
			{
				this._RevisionNo = value;
			}
		}
		#endregion
		#region Description
		public abstract class description : PX.Data.IBqlField
		{
		}
		protected string _Description;
		[PXDBString(255, IsUnicode = true)]
		[PXUIField(DisplayName = "Description")]
		public virtual string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				this._Description = value;
			}
		}
		#endregion
		#region Remarks
		public abstract class remarks : PX.Data.IBqlField
		{
		}
		protected string _Remarks;
		[PXDBString(4000, IsUnicode = true)]
		[PXUIField(DisplayName = "Remarks")]
		public virtual string Remarks
		{
			get
			{
				return this._Remarks;
			}
			set
			{
				this._Remarks = value;
			}
		}
		#endregion
		#region Status
		public abstract class status : PX.Data.IBqlField
		{
		}
		protected string _Status;
		[PXDBString(1, IsUnicode = true)]
		[PXUIField(DisplayName = "Status")]
    [PXDefault(FormulaStatus.Development)]
    [FormulaStatus.List()]
    public virtual string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}
    #endregion
    #region Hold
    public abstract class hold:PX.Data.IBqlField {
    }
    protected bool? _Hold;
    [PXDBBool()]
    [PXUIField(DisplayName = "Hold")]
    public virtual bool? Hold {
      get {
        return this._Hold;
      }
      set {
        this._Hold = value;
      }
    }
    #endregion

    #region EffectiveFromDate
    public abstract class effectiveFromDate:PX.Data.IBqlField {
    }
    protected DateTime? _EffectiveFromDate;
    [PXDBDate()]
    [PXDefault(typeof(AccessInfo.businessDate))]
    [PXUIField(DisplayName = "Effective From Date")]
    public virtual DateTime? EffectiveFromDate {
      get {
        return this._EffectiveFromDate;
      }
      set {
        this._EffectiveFromDate = value;
      }
    }
    #endregion
    #region EffectiveToDate
    public abstract class effectiveToDate:PX.Data.IBqlField {
    }
    protected DateTime? _EffectiveToDate;
    [PXDBDate()]
    [PXUIField(DisplayName = "Effective To Date")]
    public virtual DateTime? EffectiveToDate {
      get {
        return this._EffectiveToDate;
      }
      set {
        this._EffectiveToDate = value;
      }
    }
    #endregion

    #region OwnerID
    public abstract class ownerID:PX.Data.IBqlField {
    }
    protected int? _OwnerID;
    [PXDBInt()]
    [PXUIField(DisplayName = "OwnerID")]
    public virtual int? OwnerID {
      get {
        return this._OwnerID;
      }
      set {
        this._OwnerID = value;
      }
    }
    #endregion

    #region System Fields

    #region CreatedDateTime
    public abstract class createdDateTime:PX.Data.BQL.BqlDateTime.Field<createdDateTime> {
    }
    protected DateTime? _CreatedDateTime;
    [PXDBCreatedDateTime()]
    [PXUIField(DisplayName = PXDBLastModifiedByIDAttribute.DisplayFieldNames.CreatedDateTime, Enabled = false, IsReadOnly = true)]
    public virtual DateTime? CreatedDateTime {
      get {
        return this._CreatedDateTime;
      }
      set {
        this._CreatedDateTime = value;
      }
    }
    #endregion

    #region CreatedByScreenID
    public abstract class createdByScreenID:PX.Data.BQL.BqlString.Field<createdByScreenID> {
    }
    protected String _CreatedByScreenID;
    [PXDBCreatedByScreenID()]
    public virtual String CreatedByScreenID {
      get {
        return this._CreatedByScreenID;
      }
      set {
        this._CreatedByScreenID = value;
      }
    }
    #endregion

    #region CreatedByID
    public abstract class createdByID:PX.Data.BQL.BqlGuid.Field<createdByID> {
    }
    protected Guid? _CreatedByID;
    [PXDBCreatedByID()]
    public virtual Guid? CreatedByID {
      get {
        return this._CreatedByID;
      }
      set {
        this._CreatedByID = value;
      }
    }
    #endregion

    #region LastModifiedDateTime
    public abstract class lastModifiedDateTime:PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> {
    }
    protected DateTime? _LastModifiedDateTime;
    [PXDBLastModifiedDateTime()]
    [PXUIField(DisplayName = PXDBLastModifiedByIDAttribute.DisplayFieldNames.LastModifiedDateTime, Enabled = false, IsReadOnly = true)]
    public virtual DateTime? LastModifiedDateTime {
      get {
        return this._LastModifiedDateTime;
      }
      set {
        this._LastModifiedDateTime = value;
      }
    }
    #endregion

    #region LastModifiedByScreenID
    public abstract class lastModifiedByScreenID:PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> {
    }
    protected String _LastModifiedByScreenID;
    [PXDBLastModifiedByScreenID()]
    public virtual String LastModifiedByScreenID {
      get {
        return this._LastModifiedByScreenID;
      }
      set {
        this._LastModifiedByScreenID = value;
      }
    }
    #endregion

    #region LastModifiedByID
    public abstract class lastModifiedByID:PX.Data.BQL.BqlGuid.Field<lastModifiedByID> {
    }
    protected Guid? _LastModifiedByID;
    [PXDBLastModifiedByID()]
    public virtual Guid? LastModifiedByID {
      get {
        return this._LastModifiedByID;
      }
      set {
        this._LastModifiedByID = value;
      }
    }
    #endregion

    #region NoteID
    [PXNote()]
    public virtual Guid? Noteid {
      get; set;
    }
    public abstract class noteid:PX.Data.BQL.BqlGuid.Field<noteid> {
    }
    #endregion

    #region tstamp
    public abstract class Tstamp:PX.Data.BQL.BqlByteArray.Field<Tstamp> {
    }
    protected Byte[] _tstamp;
    [PXDBTimestamp]
    public virtual Byte[] tstamp {
      get {
        return this._tstamp;
      }
      set {
        this._tstamp = value;
      }
    }
    #endregion

    #endregion

    #region DEfault revision
    public abstract class defaultRevisionNo:PX.Data.BQL.BqlString.Field<defaultRevisionNo> {
    }
    protected string _DefaultRevisionNo;
    [PXString(10, IsUnicode = true)]
    public virtual string DefaultRevisionNo {
      get {
        return "A";
      }

    }
    #endregion

  }
}
