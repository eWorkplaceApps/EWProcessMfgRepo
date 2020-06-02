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

    public EWPMSetupMaint() {
   
    }

   
  }
}