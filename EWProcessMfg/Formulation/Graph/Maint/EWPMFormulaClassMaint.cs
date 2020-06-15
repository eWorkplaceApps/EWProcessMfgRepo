using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;


namespace EW.PM
{
  public class EWPMFormulaClassMaint : PXGraph<EWPMFormulaClassMaint>
  {

    public EWPMFormulaClassMaint()
    {
        
    }

    public PXSave<EWPMFormulaClass> Save;
    public PXCancel<EWPMFormulaClass> Cancel;

    public PXSelect<EWPMFormulaClass> FormulaClasses;

    
    //protected virtual void _(Events.FieldVerifying<EWPMFormulaClass, EWPMFormulaClass.description> e)
    //{
    //  if (string.IsNullOrEmpty(Convert.ToString( e.NewValue))){
    //    e.Cache.RaiseExceptionHandling<EWPMFormulaClass.description>(e.Row, e.NewValue, new PXSetPropertyException("Filed is required", PXErrorLevel.Error));
    //  }
    //}

    protected virtual void _(Events.RowPersisting<EWPMFormulaClass> e)
    {

      if (e.Operation != PXDBOperation.Delete)
      {
        if (string.IsNullOrEmpty(Convert.ToString(e.Row.Description)))
        {
          var errorMessage = string.Format(ErrorMessages.FieldIsEmpty, UIMessages.TestFormulaClassDescFieldName);        
          throw new PXRowPersistingException("Description", e.Row.Description, errorMessage);
        }

        if (string.IsNullOrEmpty(Convert.ToString(e.Row.FormulaClassCD)))
        {

          var errorMessage = string.Format(ErrorMessages.FieldIsEmpty, UIMessages.TestFormulaClassCD);
          throw new PXRowPersistingException("FormulaClassCD", e.Row.FormulaClassCD, errorMessage);

        }

      }    
    }

  }
}