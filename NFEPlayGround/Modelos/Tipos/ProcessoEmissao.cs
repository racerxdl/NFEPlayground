using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Processo de emissão utilizado
  /// </summary>
  public enum ProcessoEmissao {
    /// <summary>
    /// Emissão de NF-e com aplicativo do contribuinte
    /// </summary>
    CONTRIBUINTE = 0,
    /// <summary>
    /// Emissão de NF-e Avulsa pelo Fisco
    /// </summary>
    AVULSA_FISCO = 1,
    /// <summary>
    /// Emissão de NF-e avulsa, pelo contribuinte com seu certificado digital, através do site do fisco
    /// </summary>
    AVULSA_CONTRIBUINTE = 2,
    /// <summary>
    /// Emissão de NF-e pelo contribuinte com aplicativo fornecido pelo fisco.
    /// </summary>
    FISCO = 3
  }
}
