using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Forma de emissão da NF-e
  /// </summary>
  public enum FormaEmissao {
    /// <summary>
    /// Normal
    /// </summary>
    NORMAL = 1,
    /// <summary>
    /// Contingência FS
    /// </summary>
    CONTINGENCIA_FS = 2,
    /// <summary>
    /// Contingência SCAN
    /// </summary>
    CONTINGENCIA_SCAN = 3,
    /// <summary>
    /// Contingência DPEC
    /// </summary>
    CONTINGENCIA_DPEC = 4,
    /// <summary>
    /// Contingência FSDA
    /// </summary>
    CONTINGENCIA_FSDA = 5,
    /// <summary>
    /// Contingência SVC - AN
    /// </summary>
    CONTINGENCIA_SVC_AN = 6,
    /// <summary>
    /// Contingência SVC - RS
    /// </summary>
    CONTINGENCIA_SVC_RS = 7,
    /// <summary>
    /// Contingência off-line NFC-e
    /// </summary>
    CONTINGENCIA_OFFLINE_NFC = 9
  }
}
