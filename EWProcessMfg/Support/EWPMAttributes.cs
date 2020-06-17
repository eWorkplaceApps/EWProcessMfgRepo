using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Objects.GL;

namespace EW.PM {
  public class EWPMAttributes {
  }

  public class EWPMStatus {
    public const string Active = "A";
    public const string Inactive = "I";
    public class StatusInactive:Constant<string> {
      public StatusInactive() : base(Inactive) { }
    }
    public class StatusActive:Constant<string> {
      public StatusActive() : base(Active) { }
    }

    public class UI {
      public const string Active = "Active";
      public const string Inactive = "On Hold";
    }

    public class ListAttribute:PXStringListAttribute {
      public ListAttribute() : base(
        new[]
        {
          Pair(Active, UI.Active),
          Pair(Inactive, UI.Inactive),
        }) {
      }
    }
  }


  public class FormulaStatus {

    public const string Development = "D";
    public const string InProgress = "I";
    public const string Approved = "V";
    public const string Active = "A";
    public const string Obselete = "O";
    public const string OnHold = "H";


    public class UI {
      public const string Development = "Development";
      public const string InProgress = "InProgress";
      public const string Approved = "Approved";
      public const string Active = "Active";
      public const string Obselete = "Obselete";
      public const string OnHold = "OnHold";

    }


    public class FormulaStatusDevelopment:Constant<string> {
      public FormulaStatusDevelopment() : base("D") { }
    }
    public class FormulaStatusInProgress:Constant<string> {
      public FormulaStatusInProgress() : base("I") { }
    }
    public class FormulaStatusApproved:Constant<string> {
      public FormulaStatusApproved() : base("V") { }
    }
    public class FormulaStatusActive:Constant<string> {
      public FormulaStatusActive() : base("A") { }
    }
    public class FormulaStatusObselete:Constant<string> {
      public FormulaStatusObselete() : base("O") { }
    }
    public class FormulaStatusOnHold:PX.Data.BQL.BqlString.Constant<FormulaStatusOnHold> {
      public FormulaStatusOnHold() : base("H") { }
    }


    public class ListAttribute:PXStringListAttribute {
      public ListAttribute() : base(
        new[]
        {
          Pair(Development, UI.Development),
          Pair(InProgress, UI.InProgress),
          Pair(Approved, UI.Approved ),
          Pair(Active, UI.Active),
          Pair(Obselete, UI.Obselete),
          Pair(OnHold, UI.OnHold),
          Pair(InProgress, UI.InProgress),
        }) {
      }
    }
  }

    /// <summary>
    /// Standard Formula ID field attribute
    /// </summary>
    [PXDBString(15, IsUnicode = true, InputMask = ">CCCCCCCCCCCCCCC")]
    [PXUIField(DisplayName = "Formula ID", Visibility = PXUIVisibility.SelectorVisible)]

    public class IDAttribute:AcctSubAttribute {

    }


    /// <summary>
    /// Standard Formula ID field attribute
    /// </summary>
    [PXDBString(10, IsUnicode = true, InputMask = ">CCCCCCCCCC")]
    // [PXDBInt]
    [PXUIField(DisplayName = "Revision No.", Visibility = PXUIVisibility.SelectorVisible)]
    public class RevisionAttribute:AcctSubAttribute {

    }

  [PXDBInt]
  [PXUIField(DisplayName = "Operation ID")]
  public class OperationIDFieldAttribute:AcctSubAttribute {

  }
}

