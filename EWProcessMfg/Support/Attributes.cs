using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PX.Data;
using PX.Objects.GL;

namespace EW.PM {
  public class Attributes {
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
  }

