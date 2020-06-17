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
  public class EWPMProperty : PX.Data.IBqlTable
  {

    #region ProprtyID
    public abstract class proprtyID : PX.Data.BQL.BqlInt.Field<proprtyID>
    {
    }
    protected int? _ProprtyID;
    [PXDBIdentity()]
    [PXReferentialIntegrityCheck]
    public virtual int? ProprtyID {
      get {
        return this._ProprtyID;
      }
      set {
        this._ProprtyID = value;
      }
    }

    #endregion

    #region SequenceNo
    public abstract class sequenceNo : PX.Data.BQL.BqlString.Field<sequenceNo>
    {
    }
    protected string _SequenceNo;
    [PXDBString(10, IsKey = true, IsUnicode = true, InputMask = "")]
    [PXDefault()]
    [PXUIField(DisplayName = "Seq. no.")]
    public virtual string SequenceNo {
      get {
        return this._SequenceNo;
      }
      set {
        this._SequenceNo = value;
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
    public virtual string Description {
      get {
        return this._Description;
      }
      set {
        this._Description = value;
      }
    }
    #endregion

    #region Type
    public abstract class type : PX.Data.BQL.BqlString.Field<type>
    {
    }
    protected string _Type;
    [PXDBString(10, IsUnicode = true, InputMask = "")]
    [PXDefault()]
    [PXUIField(DisplayName = "Type")]
    public virtual string Type {
      get {
        return this._Type;
      }
      set {
        this._Type = value;
      }
    }
    #endregion

    #region Factor
    public abstract class factor : PX.Data.IBqlField
    {
    }
    protected int? _Factor;
    [PXDBInt()]
    [PXUIField(DisplayName = "Factor")]
    public virtual int? Factor {
      get {
        return this._Factor;
      }
      set {
        this._Factor = value;
      }
    }
    #endregion

    #region TagName
    public abstract class tagName : PX.Data.IBqlField
    {
    }
    protected string _TagName;
    [PXDBString(254, IsUnicode = true)]
    [PXUIField(DisplayName = "Tag Name")]
    public virtual string TagName {
      get {
        return this._TagName;
      }
      set {
        this._TagName = value;
      }
    }
    #endregion

    #region PropertyUnit
    public abstract class propertyUnit : PX.Data.IBqlField
    {
    }
    protected string _PropertyUnit;
    [PXDBString(100, IsUnicode = true)]
    [PXUIField(DisplayName = " Property Unit")]
    public virtual string PropertyUnit {
      get {
        return this._PropertyUnit;
      }
      set {
        this._PropertyUnit = value;
      }
    }
    #endregion

    #region Group
    public abstract class group : PX.Data.IBqlField
    {
    }
    protected string _Group;
    [PXDBString(10, IsUnicode = true)]
    [PXUIField(DisplayName = "Group")]
    public virtual string Group {
      get {
        return this._Group;
      }
      set {
        this._Group = value;
      }
    }



    #endregion

    #region DisplayPropertyName
    public abstract class displayPropertyName : PX.Data.BQL.BqlString.Field<displayPropertyName>
    {
    }
    [PXString(100, IsUnicode = true)]
    public virtual string DisplayPropertyName {
      get {
        return this._ProprtyID + " - " + this._Description;
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
    public abstract class createdByScreenID : PX.Data.BQL.BqlString.Field<createdByScreenID>
    {
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
    public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID>
    {
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
    public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime>
    {
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
    public abstract class lastModifiedByScreenID : PX.Data.BQL.BqlString.Field<lastModifiedByScreenID>
    {
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
    public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID>
    {
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

    #region tstamp
    public abstract class Tstamp : PX.Data.BQL.BqlByteArray.Field<Tstamp>
    {
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

    #region NoteID    [PXNote()]
    public virtual Guid? Noteid {
      get; set;
    }
    public abstract class noteid : PX.Data.BQL.BqlGuid.Field<noteid>
    {
    }
    #endregion

    #endregion

  }
}
