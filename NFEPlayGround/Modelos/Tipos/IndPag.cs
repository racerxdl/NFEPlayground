using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Indicador da forma de pagamento
  /// </summary>
  public enum IndPag {
    /// <summary>
    /// Pagamento a Vista
    /// </summary>
    VISTA = 0,
    /// <summary>
    /// Pagamento a Prazo
    /// </summary>
    PRAZO = 1,
    /// <summary>
    /// Outros
    /// </summary>
    OUTROS = 2
  }
}
