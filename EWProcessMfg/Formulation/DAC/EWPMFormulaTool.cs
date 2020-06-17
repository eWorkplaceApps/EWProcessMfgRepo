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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMS.AM;
using JAMS.AM.Attributes;
using PX.Data;
using PX.Objects.IN;

namespace EW.PM {
  /// <summary>
  /// Formula Operation Overhead 
  /// </summary>
  [Serializable]
  [PXCacheName("EWPMFormulaTool")]
  public class EWPMFormulaTool:IBqlTable {

    #region primary key fields
    public abstract class operationID:PX.Data.BQL.BqlInt.Field<operationID> {
    }
    [OperationIDField(IsKey = true, Visible = false, Enabled = false)]
    [PXDBDefault(typeof(EWPMFormulaOper.operationID))]
    [PXParent(typeof(Select<EWPMFormulaOper, Where<EWPMFormulaOper.formulaID, Equal<Current<formulaID>>, And<EWPMFormulaOper.revisionNo, Equal<Current<revisionNo>>, And<EWPMFormulaOper.operationID, Equal<Current<operationID>>>>>>))]
    [PXParent(typeof(Select<EWPMFormula, Where<EWPMFormula.formulaID, Equal<Current<formulaID>>, And<EWPMFormula.revisionNo, Equal<Current<revisionNo>>>>>))]
    public virtual int? OperationID {
      get;
      set;
    }

    public abstract class formulaID:PX.Data.BQL.BqlString.Field<formulaID> {
    }

    [ID(IsKey = true, Visible = false, Enabled = false)]
    [PXDBDefault(typeof(EWPMFormulaOper.formulaID))]
    public virtual string FormulaID {
      get;
      set;
    }
    public abstract class revisionNo:PX.Data.BQL.BqlString.Field<revisionNo> {
    }
    [PXDBDefault(typeof(EWPMFormulaOper.revisionNo))]
    [Revision(IsKey = true, Visibility = PXUIVisibility.SelectorVisible, Visible = false, Enabled = false)]
    public virtual string RevisionNo {
      get;
      set;
    }
    public abstract class lineID:PX.Data.BQL.BqlInt.Field<lineID> {
    }
    [PXDBInt(IsKey = true)]
    [PXLineNbr(typeof(EWPMFormulaOper.lineCntrTool))]
    [PXUIField(DisplayName = "Line Nbr.", Visibility = PXUIVisibility.Visible, Visible = false, Enabled = false)]
    public virtual int? LineID {
      get;
      set;
    }
    #endregion

    public abstract class lineNbr:PX.Data.BQL.BqlInt.Field<lineNbr> {
    }
    [PXInt]
    [PXUIField(DisplayName = "Line Nbr. 2", Visibility = PXUIVisibility.Invisible, Visible = false, Enabled = false)]
    public virtual int? LineNbr {
      get;
    }

    //public abstract class sortOrder:PX.Data.BQL.BqlInt.Field<sortOrder> {
    //}
    //[PXDBInt]
    //[PXUIField(DisplayName = "Line Order", Visible = false, Enabled = false)]
    //public virtual int? SortOrder {
    //  get;
    //  set;
    //}


    public abstract class toolID:PX.Data.BQL.BqlString.Field<toolID> {
    }
    [ToolIDField(Visibility = PXUIVisibility.SelectorVisible)]
    [PXDefault]
    [PXSelector(typeof(Search<AMToolMst.toolID>))]
    public virtual string ToolID {
      get;
      set;
    }


    public abstract class rowStatus:PX.Data.BQL.BqlInt.Field<rowStatus> {
    }
    [AMRowStatus.List]
    [PXDBInt]
    [PXUIField(DisplayName = "Change Status", Enabled = false)]
    public virtual int? RowStatus {
      get;
      set;
    }


    public abstract class unitCost:PX.Data.BQL.BqlDecimal.Field<unitCost> {
    }
    [PXDBPriceCost]
    [PXDefault(TypeCode.Decimal, "0.0", typeof(Search<AMToolMst.unitCost, Where<AMToolMst.toolID, Equal<Current<AMToolMst.toolID>>>>))]
    [PXFormula(typeof(Default<toolID>))]
    [PXUIField(DisplayName = "Unit Cost")]
    public virtual decimal? UnitCost {
      get;
      set;
    }
    public abstract class qtyReq:PX.Data.BQL.BqlDecimal.Field<qtyReq> {
    }
    [PXDBQuantity()]
    [PXDefault(TypeCode.Decimal, "1.0")]
    [PXUIField(DisplayName = "Qty Required")]
    public virtual decimal? QtyReq {
      get;
      set;
    }

    public abstract class extendedCost:PX.Data.BQL.BqlDecimal.Field<extendedCost> {
    }
   // [PXDependsOnFields(typeof(unitCost), typeof(qtyReq))]
    [PXFormula(typeof(Mult<unitCost,qtyReq>))]
    [PXUIField(DisplayName = "Extended Cost",Enabled =false)]
    public virtual decimal? ExtendedCost {
      get;set;

    }

    public abstract class description:PX.Data.BQL.BqlString.Field<description> {
    }
    [PXDBString(256, IsUnicode = true)]
    [PXDefault(typeof(Search<AMToolMst.descr, Where<AMToolMst.toolID, Equal<Current<toolID>>>>), PersistingCheck = PXPersistingCheck.Nothing)]
    [PXFormula(typeof(Default<toolID>))]
    [PXUIField(DisplayName = "Description",Enabled =false)]
    public virtual string Descr {
      get;
      set;
    }

    #region SystemFields
    public abstract class lastModifiedDateTime:PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> {
    }
    [PXDBLastModifiedDateTime]
    public virtual DateTime? LastModifiedDateTime {
      get;
      set;
    }

    public abstract class lastModifiedByID:PX.Data.BQL.BqlGuid.Field<lastModifiedByID> {
    }
    [PXDBLastModifiedByID]
    public virtual Guid? LastModifiedByID {
      get;
      set;
    }

    public abstract class Tstamp:PX.Data.BQL.BqlByte.Field<Tstamp> {
    }
    [PXDBTimestamp]
    public virtual byte[] tstamp {
      get;
      set;
    }

    public abstract class createdByID:PX.Data.BQL.BqlGuid.Field<createdByID> {
    }
    [PXDBCreatedByID]
    public virtual Guid? CreatedByID {
      get;
      set;
    }

    public abstract class createdByScreenID:PX.Data.BQL.BqlString.Field<createdByScreenID> {
    }
    [PXDBCreatedByScreenID]
    public virtual string CreatedByScreenID {
      get;
      set;
    }

    public abstract class createdDateTime:PX.Data.BQL.BqlDateTime.Field<createdDateTime> {
    }
    [PXDBCreatedDateTime]
    public virtual DateTime? CreatedDateTime {
      get;
      set;
    }

    public abstract class lastModifiedByScreenID:PX.Data.BQL.BqlString.Field<lastModifiedByScreenID> {
    }
    [PXDBLastModifiedByScreenID]
    public virtual string LastModifiedByScreenID {
      get;
      set;
    }

    #endregion


  }
}
