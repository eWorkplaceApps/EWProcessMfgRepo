/* Copyright © 2020 eWorkplace Apps (https://www.eworkplaceapps.com/). All Rights Reserved.
* Unauthorized copying of this file, via any medium is strictly prohibited
* Proprietary and confidential
*
* Author: Asha Sharda/Amit Mundra
* Date: 1 June 2020
*
*Last Updated By :
*Last Updated Date:
*
*Reviewed By :
*Review Date
*/

using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;
using System.Linq;
using PX.Objects.IN;

namespace EW.PM {
    public class EWPMSetupMaint:PXGraph<EWPMSetupMaint> {

        #region Data Views

        public PXSelect<EWPMSetup> Setup;
        public PXSave<EWPMSetup> Save;
        public PXCancel<EWPMSetup> Cancel;

        #endregion Data Views

        #region Constructor

        public EWPMSetupMaint() {

        }

        #endregion Constructor

        #region Event

        /// <summary>
        /// Event will execute on changed the value of a volume.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void _(Events.FieldUpdated<EWPMSetup, EWPMSetup.systemWeightUnit> e) {
            EWPMSetup setup = e.Row;
            setup.SystemVolumeUnit = string.Empty;
        }

        /// <summary>
        /// Event will execute on changed the value of a volume.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void _(Events.FieldVerifying<EWPMSetup, EWPMSetup.systemVolumeUnit> e) {
            EWPMSetup setup = e.Row;
            string volume = Convert.ToString(e.NewValue);
            if(!string.IsNullOrEmpty(setup.SystemWeightUnit) && !string.IsNullOrEmpty(volume)) {
                if(string.Compare(setup.SystemWeightUnit, volume, true) == 0) {
                    e.Cache.RaiseExceptionHandling<EWPMSetup.systemVolumeUnit>(e.Row, e.NewValue, new PXSetPropertyException("Weight and volume both can not be same.", PXErrorLevel.RowError));
                }
            }
            else if(!string.IsNullOrEmpty(setup.SystemWeightUnit) && string.IsNullOrEmpty(volume)) {
                e.Cache.RaiseExceptionHandling<EWPMSetup.systemVolumeUnit>(e.Row, volume, new PXSetPropertyException("Volume can not be empty.", PXErrorLevel.RowError));
            }
        }

        /// <summary>
        /// Event  will execute before commiting the data.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void _(Events.RowPersisting<EWPMSetup> e) {
            if(e.Operation != PXDBOperation.Delete) {
                Validate(e.Cache, e.Row);
            }
        }

        #endregion Event

        #region Validation

        protected virtual void Validate(PXCache cache, EWPMSetup row) {
            EWPMSetup setup = row;
            if(!string.IsNullOrEmpty(setup.SystemWeightUnit) && !string.IsNullOrEmpty(setup.SystemVolumeUnit)) {
                if(string.Compare(setup.SystemWeightUnit, setup.SystemVolumeUnit, true) == 0) {
                    cache.RaiseExceptionHandling<EWPMSetup.systemVolumeUnit>(row, row.SystemVolumeUnit, new PXSetPropertyException("Weight and volume both can not be same.", PXErrorLevel.RowError));
                }
            }
            else if(!string.IsNullOrEmpty(setup.SystemWeightUnit) && string.IsNullOrEmpty(setup.SystemVolumeUnit)) {
                cache.RaiseExceptionHandling<EWPMSetup.systemVolumeUnit>(row, row.SystemVolumeUnit, new PXSetPropertyException("Volume can not be empty.", PXErrorLevel.RowError));
            }
        }

        #endregion Validation

    }
}