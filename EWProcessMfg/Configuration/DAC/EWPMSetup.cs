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
using PX.Data;
using PX.Objects.CS;
using PX.Objects.IN;

namespace EW.PM {


    [System.SerializableAttribute()]
    [PXPrimaryGraph(typeof(EWPMSetupMaint))]
    public class EWPMSetup:PX.Data.IBqlTable {




        public abstract class formulaNumberSequenceID:PX.Data.IBqlField {
        }

        [PXDBString(10, IsUnicode = true)]
        [PXSelector(typeof(Numbering.numberingID), DescriptionField = typeof(Numbering.descr))]
        [PXUIField(DisplayName = "Formula Numbering Sequence")]
        public virtual string FormulaNumberSequenceID {
            get;
            set;
        }

        public abstract class systemWeightUnit:PX.Data.IBqlField {
        }
        [PXDBString(10, IsUnicode = true)]

        // [PXSelector(typeof(Numbering.numberingID), DescriptionField = typeof(Numbering.descr))]
        [PXUIField(DisplayName = "System Weight")]
        [PXSelector(typeof(Search4<INUnit.fromUnit, Aggregate<GroupBy<INUnit.fromUnit>>>), typeof(INUnit.fromUnit), SubstituteKey = typeof(INUnit.fromUnit))]
        public virtual string SystemWeightUnit {
            get;
            set;
        }

        public abstract class systemVolumeUnit:PX.Data.IBqlField {
        }
        [PXDBString(10, IsUnicode = true)]
        [PXUIField(DisplayName = "System Volumn")]
        [PXSelector(typeof(Search4<INUnit.toUnit, Where<INUnit.fromUnit, Equal<Current<systemWeightUnit>>>, Aggregate<GroupBy<INUnit.toUnit>>>), typeof(INUnit.toUnit), SubstituteKey = typeof(INUnit.toUnit))]
        public virtual string SystemVolumeUnit {
            get;
            set;
        }

        #region NoteID

        //[PXNote()]
        //public virtual Guid? Noteid {
        //    get; set;
        //}
        //public abstract class noteid:PX.Data.BQL.BqlGuid.Field<noteid> {
        //}

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
    }
}
