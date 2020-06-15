/* Copyright © 2020 eWorkplace Apps (https://www.eworkplaceapps.com/). All Rights Reserved.
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
*
* Author: Amit Mundra
* Date: 11 June 2020
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

namespace EW.PM {

    [System.SerializableAttribute()]
    public class EWPMBiolerplate:PX.Data.IBqlTable {

        #region BoilerplateID
        public abstract class boilerplateID:PX.Data.BQL.BqlInt.Field<boilerplateID> {
        }
        protected int? _BoilerplateID;
        [PXDBIdentity()]
        [PXReferentialIntegrityCheck]
        public virtual int? BoilerplateID {
            get {
                return this._BoilerplateID;
            }
            set {
                this._BoilerplateID = value;
            }
        }

        #endregion

        #region BoilerplateCD

        public abstract class boilerplateCD:PX.Data.IBqlField {
        }
        protected string _BoilerplateCD;
        [ID(IsKey = true, Required = true)]
        [PXDefault]
        [PXUIField(DisplayName = "ID")]
        public virtual string BoilerplateCD {
            get {
                return this._BoilerplateCD;
            }
            set {
                this._BoilerplateCD = value;
            }
        }

        #endregion

        #region Description
        public abstract class description:PX.Data.IBqlField {
        }
        protected string _Description;
        [PXDBString(255, IsUnicode = true)]
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

        #region BoilerplateGroupID
        public abstract class boilerplateGroupID:PX.Data.BQL.BqlInt.Field<boilerplateGroupID> {
        }
        protected int? _BoilerplateGroupID;
        [PXDBInt()]
        [PXUIField(DisplayName = "Boilerplate Group")]
        [PXDefault(PersistingCheck = PXPersistingCheck.NullOrBlank)]
        [PXSelector(typeof(Search<EWPMBoilerplateGroup.boilerplateGroupID>), typeof(EWPMBoilerplateGroup.name), typeof(EWPMBoilerplateGroup.description), SubstituteKey = typeof(EWPMBoilerplateGroup.name))]
        [PXForeignReference(typeof(Field<boilerplateGroupID>.IsRelatedTo<EWPMBoilerplateGroup.boilerplateGroupID>))]
        public virtual int? BoilerplateGroupID {
            get {
                return this._BoilerplateGroupID;
            }
            set {
                this._BoilerplateGroupID = value;
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
