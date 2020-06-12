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

    public class EWPMBiolerplateGroupMaint:PXGraph<EWPMBiolerplateGroupMaint> {

        public PXCancel<EWPMBoilerplateGroup> Cancel;

        public PXSave<EWPMBoilerplateGroup> Save;

        public PXSelect<EWPMBoilerplateGroup> BoilerplateGroup;

        #region Events

        /// <summary>
        /// Before saving the Biolerplate Group validating the fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void EWPMBoilerplateGroup_RowPersisting(PXCache sender, PXRowPersistingEventArgs e) {
            EWPMBoilerplateGroup line = (EWPMBoilerplateGroup)e.Row;
            if(e.Operation != PXDBOperation.Delete) {
                if(string.IsNullOrEmpty(line.Name)) {
                    throw new PXRowPersistingException("Name",
                            null,
                            ErrorMessages.FieldIsEmpty,
                            "Boilerplate Group");
                }
            }
        }

        #endregion

    }
}