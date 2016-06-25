using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Modalidade de determinação da Base de Cálculo
  /// </summary>
  public enum ModBC {
    /// <summary>
    /// Margem Valor Agregado (%)
    /// </summary>
    MARGEM_VALOR_AGREGADO = 0,
    /// <summary>
    /// Pauta (valor)
    /// </summary>
    PAUTA = 1,
    /// <summary>
    /// Preço Tabelado Máximo (valor)
    /// </summary>
    PRECO_TABELADO_MAXIMO = 2,
    /// <summary>
    /// Valor da Operação
    /// </summary>
    VALOR_DA_OPERACAO = 3
  }
}
