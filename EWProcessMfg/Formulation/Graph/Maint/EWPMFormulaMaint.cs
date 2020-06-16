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

  public class EWPMFormulaMaint:PXRevisionableGraph<EWPMFormulaMaint, EWPMFormula, EWPMFormula.formulaID, EWPMFormula.revisionNo> {
    //public class PlanMaint:PXGraph<PlanMaint, EWQCPlan> {
    #region selects
    public PXSetup<EWPMSetup> Setup;

    public PXSelect<
      EWPMFormulaOper,
      Where<EWPMFormulaOper.formulaID, Equal<Current<EWPMFormula.formulaID>>,
        And<EWPMFormulaOper.revisionNo, Equal<Current<EWPMFormula.revisionNo>>>>,
      OrderBy<
        Asc<EWPMFormulaOper.operationCD>>> 
      FormulaOperations;

    public PXSelect<
      EWPMFormulaMatl, 
      Where<EWPMFormulaMatl.formulaID, Equal<Current<EWPMFormulaOper.formulaID>>, 
        And<EWPMFormulaMatl.revisionNo, Equal<Current<EWPMFormulaOper.revisionNo>>, 
        And<EWPMFormulaMatl.operationID, Equal<Current<EWPMFormulaOper.operationID>>>>>, 
      OrderBy<
        Asc<EWPMFormulaMatl.sortOrder, 
        Asc<EWPMFormulaMatl.lineID>>>> 
      FormulaMaterials;

    public PXSelect<
          EWPMFormulaByProd,
          Where<EWPMFormulaByProd.formulaID, Equal<Current<EWPMFormulaOper.formulaID>>,
            And<EWPMFormulaByProd.revisionNo, Equal<Current<EWPMFormulaOper.revisionNo>>,
            And<EWPMFormulaByProd.operationID, Equal<Current<EWPMFormulaOper.operationID>>>>>,
          OrderBy<
            Asc<EWPMFormulaByProd.sortOrder,
            Asc<EWPMFormulaByProd.lineID>>>>
          FormulaByProducts;

    public PXSelectJoin<
      EWPMFormulaOvhd,
      InnerJoin<AMOverhead, 
        On<EWPMFormulaOvhd.ovhdID, Equal<AMOverhead.ovhdID>>>,
      Where<EWPMFormulaOvhd.formulaID, Equal<Current<EWPMFormulaOper.formulaID>>,
        And<EWPMFormulaOvhd.revisionNo, Equal<Current<EWPMFormulaOper.revisionNo>>,
        And<EWPMFormulaOvhd.operationID, Equal<Current<EWPMFormulaOper.operationID>>>>>>    
      FormulaOverheads;

   
    public PXSelectJoin<
     EWPMFormulaTool, 
      InnerJoin<AMToolMst, 
        On<EWPMFormulaTool.toolID, Equal<AMToolMst.toolID>>>,
       Where<EWPMFormulaTool.formulaID, Equal<Current<EWPMFormulaOper.formulaID>>,
        And<EWPMFormulaTool.revisionNo, Equal<Current<EWPMFormulaOper.revisionNo>>,
        And<EWPMFormulaTool.operationID, Equal<Current<EWPMFormulaOper.operationID>>>>>>
      FormulaTools;

    #endregion

    public EWPMFormulaMaint() {
      EWPMSetup setup = Setup.Current;
    }

    #region Formula Events
    protected virtual void _(Events.FieldUpdated<EWPMFormula, EWPMFormula.hold> e) {
      EWPMFormula formula = (EWPMFormula)e.Row;
      if(formula != null && formula.Hold != null && formula.Hold.Value) {
        formula.Status = EWPMStatus.Inactive;
      }
      else {
        formula.Status = EWPMStatus.Active;
      }
    }
    #endregion

    #region Operation Events
   
    #endregion

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