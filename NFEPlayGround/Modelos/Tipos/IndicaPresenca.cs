using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Indicador de presença do comprador no estabelecimento comercial no momento da oepração
  /// </summary>
  public enum IndicaPresenca {
    /// <summary>
    /// Não se aplica (ex.: Nota Fiscal complementar ou de ajuste)
    /// </summary>
    NAO_SE_APLICA = 0,
    /// <summary>
    /// Operação Presencial
    /// </summary>
    OPERACAO_PRESENCIAL = 1,
    /// <summary>
    /// Não Presencial - Internet
    /// </summary>
    INTERNET = 2,
    /// <summary>
    /// Não Presencial - Teleatendimento
    /// </summary>
    TELEATENDIMENTO = 3,
    /// <summary>
    /// NFC-e entrega em domicílio
    /// </summary>
    ENTREGA_DOMICILIO = 4,
    /// <summary>
    /// Não Presencial - Outros
    /// </summary>
    OUTROS = 9
  }
}
