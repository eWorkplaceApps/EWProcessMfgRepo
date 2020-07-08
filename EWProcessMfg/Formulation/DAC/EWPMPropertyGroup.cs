/* Copyright © 2020 eWorkplace Apps (https://www.eworkplaceapps.com/). All Rights Reserved.
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
*
* Author: Sourabh Agrawal
* Date: 12 June 2020
*
*Last Updated By :
*Last Updated Date:
*
*Reviewed By :
*Review Date
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Data.ReferentialIntegrity.Attributes;

namespace EW.PM
{

  [System.SerializableAttribute()]
  public class EWPMPropertyGroup : PX.Data.IBqlTable
  {

    #region ProprtyGroupID
    public abstract class proprtyGroupID : PX.Data.BQL.BqlInt.Field<proprtyGroupID>
    {
    }
    protected int? _ProprtyGroupID;
    [PXDBIdentity()]
    [PXReferentialIntegrityCheck]
    public virtual int? ProprtyGroupID
    {
      get
      {
        return this._ProprtyGroupID;
      }
      set
      {
        this._ProprtyGroupID = value;
      }
    }

    #endregion ProprtyGroupID

    #region SequenceNo
    public abstract class sequenceNo : PX.Data.BQL.BqlString.Field<sequenceNo>
    {
    }
    protected string _SequenceNo;
    [PXDBString(10, IsKey = true, IsUnicode = true, InputMask = "")]
    [PXDefault()]
    [PXUIField(DisplayName = "Seq. no.")]
    [PXCheckUnique(typeof(sequenceNo))]
    public virtual string SequenceNo
    {
      get
      {
        return this._SequenceNo;
      }
      set
      {
        this._SequenceNo = value;
      }
    }
    #endregion

    #region GroupCode
    public abstract class groupCode : PX.Data.BQL.BqlString.Field<groupCode>
    {
    }
    protected string _GroupCode;
    [PXDBString(10, IsUnicode = true)]
    [PXUIField(DisplayName = "Group Code")]
    public virtual string GroupCode
    {
      get
      {
        return this._GroupCode;
      }
      set
      {
        this._GroupCode = value;
      }
    }
    #endregion
    #region Description
    public abstract class description : PX.Data.IBqlField
    {
    }
    protected string _Description;
    [PXDBString(100, IsUnicode = true)]
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

    #region System Fields

    #region CreatedDateTime
    public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime>
    {
    }
    protected DateTime? _CreatedDateTime;
    [PXDBCreatedDateTime()]
    [PXUIField(DisplayName = PXDBLastModifiedByIDAttribute.DisplayFieldNames.CreatedDateTime, Enabled = false, IsReadOnly = true)]
    public virtual DateTime? CreatedDateTime
    {
      get
      {
        return this._CreatedDateTime;
      }
      set
      {
        this._CreatedDateTime = value;
      }
    }
    #endregion

    #region CreatedByScreenID
    public abstract class createdByScreenID : PX.Data.BQL.BqlString.Field<createdByScreenID>
    {
    }
    protected String _CreatedByScreenID;
    [PXDBCreatedByScreenID()]
    public virtual String CreatedByScreenID
    {
      get
      {
        return this._CreatedByScreenID;
      }
      set
      {
        this._CreatedByScreenID = value;
      }
    }
    #endregion

    #region CreatedByID
    public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID>
    {
    }
    protected Guid? _CreatedByID;
    [PXDBCreatedByID()]
    public virtual Guid? CreatedByID
    {
      get
      {
        return this._CreatedByID;
      }
      set
      {
        this._CreatedByID = value;
      }
    }
    #endregion

    #region LastModifiedDateTime
    public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime>
    {
    }
    protected DateTime? _LastModifiedDateTime;
    [PXDBLastModifiedDateTime()]
    [PXUIField(DisplayName = PXDBLastModifiedByIDAttribute.DisplayFieldNames.LastModifiedDateTime, Enabled = false, IsReadOnly = true)]
    public virtual DateTime? LastModifiedDateTime
    {
      get
      {
        return this._LastModifiedDateTime;
      }
      set
      {
        this._LastModifiedDateTime = value;
      }
    }
    #endregion

    #region LastModifiedByScreenID
    public abstract class lastModifiedByScreenID : PX.Data.BQL.BqlString.Field<lastModifiedByScreenID>
    {
    }
    protected String _LastModifiedByScreenID;
    [PXDBLastModifiedByScreenID()]
    public virtual String LastModifiedByScreenID
    {
      get
      {
        return this._LastModifiedByScreenID;
      }
      set
      {
        this._LastModifiedByScreenID = value;
      }
    }
    #endregion

    #region LastModifiedByID
    public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID>
    {
    }
    protected Guid? _LastModifiedByID;
    [PXDBLastModifiedByID()]
    public virtual Guid? LastModifiedByID
    {
      get
      {
        return this._LastModifiedByID;
      }
      set
      {
        this._LastModifiedByID = value;
      }
    }
    #endregion

    #region tstamp
    public abstract class Tstamp : PX.Data.BQL.BqlByteArray.Field<Tstamp>
    {
    }
    protected Byte[] _tstamp;
    [PXDBTimestamp]
    public virtual Byte[] tstamp
    {
      get
      {
        return this._tstamp;
      }
      set
      {
        this._tstamp = value;
      }
    }
    #endregion

    #region NoteID

    [PXNote()]
    public virtual Guid? Noteid
    {
      get; set;
    }
    public abstract class noteid : PX.Data.BQL.BqlGuid.Field<noteid>
    {
    }

    #endregion

    #endregion

  }
}

