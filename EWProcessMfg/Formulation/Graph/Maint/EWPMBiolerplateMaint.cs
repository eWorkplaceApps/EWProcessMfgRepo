/* Copyright © 2020 eWorkplace Apps (https://www.eworkplaceapps.com/). All Rights Reserved.
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
*
* Author: Amit Mundra
* Date: 11 June 2020
*
*Last Updated By : Amit
*Last Updated Date: 11 June 2020
*
*Reviewed By :
*Review Date
*/

using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;


namespace EW.PM {
    public class EWPMBiolerplateMaint:PXGraph<EWPMBiolerplateMaint> {

        public PXCancel<EWPMBiolerplate> Cancel;

        public PXSave<EWPMBiolerplate> Save;

        public PXSelect<EWPMBiolerplate> BoilerplateGroup;

        #region Events

        /// <summary>
        /// Before saving the Biolerplate validating the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void EWPMBiolerplate_RowPersisting(PXCache sender, PXRowPersistingEventArgs e) {
            EWPMBiolerplate line = (EWPMBiolerplate)e.Row;
            if(e.Operation != PXDBOperation.Delete) {
                if(string.IsNullOrEmpty(line.BoilerplateCD)) {
                    throw new PXRowPersistingException(UIMessages.BoilerplateCDFieldName,
                            null,
                            ErrorMessages.FieldIsEmpty,
                            UIMessages.CommonCD);
                }

                if(!line.BoilerplateGroupID.HasValue) {
                    throw new PXRowPersistingException(UIMessages.BoilerplateGroupFieldName,
                            null,
                            ErrorMessages.FieldIsEmpty,
                            UIMessages.BoilerplateGroupFieldDisplayName);
                }
            }
        }

        #endregion

    }
}