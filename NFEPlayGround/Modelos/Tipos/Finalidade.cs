using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Finalidade da emissão da NF-e
  /// </summary>
  public enum Finalidade {
    /// <summary>
    /// NFe Normal
    /// </summary>
    NFE_NORMAL = 1,
    /// <summary>
    /// NFe Complementar
    /// </summary>
    NFE_COMPLEMENTAR = 2,
    /// <summary>
    /// NFe de Ajuste
    /// </summary>
    NFE_DE_AJUSTE = 3,
    /// <summary>
    /// NFe de Devolução
    /// </summary>
    DEVOLUCAO = 4
  }
}
