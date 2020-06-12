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
  /// Formula Operations
  /// </summary>
  [Serializable]
  [PXCacheName("EWPMFormulaOper")]
  public class EWPMFormulaOper:IBqlTable {

    #region primary key fields

    public abstract class operationID:PX.Data.BQL.BqlInt.Field<operationID> {
    }


    [OperationIDField(IsKey = true, Visible = false, Enabled = false)]
    [PXLineNbr(typeof(EWPMFormula.lineCntrOperation))]
    public virtual int? OperationID {
      get;
      set;
    }

    public abstract class formulaID:PX.Data.BQL.BqlString.Field<formulaID> {
    }

    [ID(IsKey = true, Visible = false, Enabled = false)]
    [PXDBDefault(typeof(EWPMFormula.formulaID))]
    [PXParent(typeof(Select<EWPMFormula, Where<EWPMFormula.formulaID, Equal<Current<formulaID>>, And<EWPMFormula.revisionNo, Equal<Current<revisionNo>>>>>))]
    public virtual string FormulaID {
      get;
      set;
    }
    public abstract class revisionNo:PX.Data.BQL.BqlString.Field<revisionNo> {
    }
    [PXDBDefault(typeof(EWPMFormula.revisionNo))]
    [Revision(IsKey = true, Visibility = PXUIVisibility.SelectorVisible, Visible = false, Enabled = false)]
    public virtual string RevisionNo {
      get;
      set;
    }
    public abstract class operationCD:PX.Data.BQL.BqlString.Field<operationCD> {
    }

    [OperationCDField(Visibility = PXUIVisibility.SelectorVisible)]
    [PXCheckUnique(new[] { typeof(formulaID), typeof(revisionNo) })]
    [PXDefault(PersistingCheck = PXPersistingCheck.NullOrBlank)]
    public virtual string OperationCD {
      get;
      set;
    }

    #endregion

   

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

    public abstract class scrapAction:PX.Data.BQL.BqlInt.Field<scrapAction> {
    }
    [ScrapAction.List]
    [PXDBInt]
    [PXDefault(0)]
    [PXUIField(DisplayName = "Scrap Action")]
    public virtual int? ScrapAction {
      get;
      set;
    }

    public abstract class lineCntrTool:PX.Data.BQL.BqlInt.Field<lineCntrTool> {
    }
    [PXDBInt]
    [PXDefault(0)]
    public virtual int? LineCntrTool {
      get;
      set;
    }

    public abstract class lineCntrStep:PX.Data.BQL.BqlInt.Field<lineCntrStep> {
    }
    [PXDBInt]
    [PXDefault(0)]
    public virtual int? LineCntrStep {
      get;
      set;
    }

    public abstract class lineCntrOvhd:PX.Data.BQL.BqlInt.Field<lineCntrOvhd> {
    }
    [PXDBInt]
    [PXDefault(0)]
    public virtual int? LineCntrOvhd {
      get;
      set;
    }

    public abstract class wcID:PX.Data.BQL.BqlString.Field<wcID> {
    }
    [PXSelector(typeof(Search<AMWC.wcID>))]
    [WorkCenterIDField(Visibility = PXUIVisibility.SelectorVisible)]
    public virtual string WcID {
      get;
      set;
    }

    public abstract class lineCntrMatl:PX.Data.BQL.BqlInt.Field<lineCntrMatl> {
    }
    [PXDBInt]
    [PXDefault(0)]
    public virtual int? LineCntrMatl {
      get;
      set;
    }

    public abstract class runUnitTime:PX.Data.BQL.BqlInt.Field<runUnitTime> {
    }
    [OperationDBTime]
    [PXDefault(TypeCode.Int32, "60")]
    [PXUIField(DisplayName = "Run Time")]
    public virtual int? RunUnitTime {
      get;
      set;
    }

    public abstract class runUnits:PX.Data.BQL.BqlDecimal.Field<runUnits> {
    }
    [PXDBQuantity(MinValue = 0)]
    [PXDefault(TypeCode.Decimal, "0.0")]
    [PXUIField(DisplayName = "Run Units")]
    public virtual decimal? RunUnits {
      get;
      set;
    }

    public abstract class machineUnitTime:PX.Data.BQL.BqlInt.Field<machineUnitTime> {
    }
    [OperationDBTime]
    [PXDefault(TypeCode.Int32, "60")]
    [PXUIField(DisplayName = "Machine Time")]
    public virtual int? MachineUnitTime {
      get;
      set;
    }

    public abstract class machineUnits:PX.Data.BQL.BqlDecimal.Field<machineUnits> {
    }
    [PXDBQuantity(MinValue = 0)]
    [PXDefault(TypeCode.Decimal, "0.0")]
    [PXUIField(DisplayName = "Machine Units")]
    public virtual decimal? MachineUnits {
      get;
      set;
    }

    public abstract class queueTime:PX.Data.BQL.BqlInt.Field<queueTime> {
    }
    [OperationDBTime]
    [PXDefault(TypeCode.Int32, "0")]
    [PXUIField(DisplayName = "Queue Time")]
    public virtual int? QueueTime {
      get;
      set;
    }

    public abstract class bFlush:PX.Data.BQL.BqlBool.Field<bFlush> {
    }
    [PXDBBool]
    [PXDefault(false)]
    [PXUIField(DisplayName = "Backflush Labor")]
    public virtual bool? BFlush {
      get;
      set;
    }

    public abstract class setupTime:PX.Data.BQL.BqlInt.Field<setupTime> {
    }
    [OperationDBTime]
    [PXDefault(TypeCode.Int32, "0")]
    [PXUIField(DisplayName = "Setup Time")]
    public virtual int? SetupTime {
      get;
      set;
    }

    #region Temp
    [PXDBString(100)]
    [PXUIField(DisplayName = "Temp")]
    public virtual string Temp {
      get; set;
    }
    public abstract class temp:PX.Data.BQL.BqlString.Field<temp> {
    }
    #endregion
  }
}

