using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Formato de impressão do DANFE
  /// </summary>
  public enum FormatoDANFE {
    /// <summary>
    /// Sem DANFE
    /// </summary>
    SEM_DANFE = 0,
    /// <summary>
    /// DANFE Retrato
    /// </summary>
    DANFE_RETRATO = 1,
    /// <summary>
    /// DANFE Paisagem
    /// </summary>
    DANFE_PAISAGEM = 2,
    /// <summary>
    /// DANFE Simplificado
    /// </summary>
    DANFE_SIMPLIFICADO = 3,
    /// <summary>
    /// DANFE NFC-e
    /// </summary>
    DANFE_NFC = 4,
    /// <summary>
    /// DANFE NFC-e em Mensagem Eletrônica
    /// </summary>
    DANFE_NFC_MENSAGEM_ELETRONICA = 5
  }
}
