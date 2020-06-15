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
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;


namespace EW.PM { 
  public class EWPMPropertyGroupMaint : PXGraph<EWPMPropertyGroupMaint>
  {


    public PXCancel<EWPMPropertyGroup> Cancel;

    public PXSave<EWPMPropertyGroup> Save;

    public PXSelect<EWPMPropertyGroup> PropertyGroup;

    #region Events

    /// <summary>
    /// Before saving the Property Group validating the fields.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected virtual void EWPMPropertyGroup_RowPersisting(PXCache sender, PXRowPersistingEventArgs e)
    {
      EWPMPropertyGroup line = (EWPMPropertyGroup)e.Row;
      if (e.Operation != PXDBOperation.Delete)
      {

      }
    }

    #endregion
  }
}