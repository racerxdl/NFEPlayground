using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Indicador da IE do destinatário
  /// </summary>
  public enum IndIEDest {
    /// <summary>
    /// Contribuinte ICMSpagamento à vista
    /// </summary>
    ICMS_A_Vista = 1,
    /// <summary>
    /// Contribuinte isento de inscrição
    /// </summary>
    ISENTO = 2,
    /// <summary>
    /// Não Contribuinte
    /// </summary>
    NAO_CONTRIBUINTE = 9
  }
}
