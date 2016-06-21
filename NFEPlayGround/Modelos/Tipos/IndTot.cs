using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Usado para saber se o valor do item compoe o valor total da NF-e
  /// </summary>
  public enum IndTot {
    /// <summary>
    /// O valor do item (vProd) não compõe o valor total da NF-e (vProd)
    /// </summary>
    NAO_COMPOE_TOTAL_NF = 0,

    /// <summary>
    /// O valor do item (vProd) compõe o valor total da NF-e (vProd)
    /// </summary>
    COMPOE_TOTAL_NF = 1
  }
}
