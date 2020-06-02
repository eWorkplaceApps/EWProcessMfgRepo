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
using JAMS.AM;

namespace EW.PM {

  public class EWPMFormulaMaint:PXRevisionableGraph<EWPMFormulaMaint, EWPMFormula, EWPMFormula.formulaCD, EWPMFormula.revisionNo> {
    //public class PlanMaint:PXGraph<PlanMaint, EWQCPlan> {
    #region selects
    public PXSelect<EWPMSetup> EwPMSetup;
    public PXSelect<EWPMFormula> Formula;

    #endregion

    public EWPMFormulaMaint() {
      EWPMSetup setup = EwPMSetup.Current;

    }


    #region Override code
    public override bool CanCreateNewRevision(EWPMFormulaMaint fromGraph, EWPMFormulaMaint toGraph, string keyValue,
                string revisionValue, out string error) {

      // Always returns true as new revisions can be created at any time
      error = string.Empty;
      return true;
    }

    public override void CopyRevision(EWPMFormulaMaint fromGraph, EWPMFormulaMaint toGraph, string keyValue, string revisionValue) {

      toGraph.Documents.Cache.SetDefaultExt<EWPMFormula.hold>(toGraph.Documents.Current);
      toGraph.Documents.Cache.SetDefaultExt<EWPMFormula.status>(toGraph.Documents.Current);
      toGraph.Documents.Cache.SetDefaultExt<EWPMFormula.formulaID>(toGraph.Documents.Current);
     
      if(SkipAutoCreateNewRevision()) {
        return;
      }

      //  PXTrace.WriteInformation($"Copy BOM {fromGraph.Documents.Current?.BOMID} revision {fromGraph.Documents.Current?.RevisionID} to BOM {keyValue} revision {revisionValue}");
    //  CreateNewRevision(toGraph, fromGraph.Documents.Current, keyValue, revisionValue);
    }

  

    #endregion
  }
}