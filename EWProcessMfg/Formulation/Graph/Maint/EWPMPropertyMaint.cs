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


namespace EW.PM
{
  public class EWPMPropertyMaint : PXGraph<EWPMPropertyMaint>
  {

    public PXCancel<EWPMProperty> Cancel;

    public PXSave<EWPMProperty> Save;

    public PXSelect<EWPMProperty> Property;

    #region Events

    /// <summary>
    /// Before saving the Property  validating the fields.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected virtual void EWPMProperty_RowPersisting(PXCache sender, PXRowPersistingEventArgs e)
    {
      EWPMProperty line = (EWPMProperty)e.Row;
      if (e.Operation != PXDBOperation.Delete)
      {
        if (string.IsNullOrEmpty(line.SequenceNo))
        {
          throw new PXRowPersistingException(UIMessages.PropertyGroupClassSeqNoFieldName,
                  null,
                  ErrorMessages.FieldIsEmpty,
                  UIMessages.PropertyGroupClassSeqNoFieldDisplayName);
        }

        if (string.IsNullOrEmpty(line.Group))
        {
          throw new PXRowPersistingException(UIMessages.PropertyGroupClassGrpCodeFieldName,
                  null,
                  ErrorMessages.FieldIsEmpty,
                  UIMessages.PropertyGroupClassGrpCodeDisplayName);
        }
      }
    }

    #endregion

  }
}