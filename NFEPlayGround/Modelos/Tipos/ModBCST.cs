namespace NFEPlayGround.Modelos.Tipos {
  /// <summary>
  /// Modalidade de determinação da Base de Cálculo do ICMS de Substituição Tributária
  /// </summary>
  public enum ModBCST {
    /// <summary>
    /// Preço tabelado ou Máximo  sugerido
    /// </summary>
    TABELADO_OU_MAXIMO = 0,
    /// <summary>
    /// Lista Negativa (valor)
    /// </summary>
    LISTA_NEGATIVA = 1,
    /// <summary>
    /// Lista Positiva (valor)
    /// </summary>
    LISTA_POSITIVA = 2,
    /// <summary>
    /// Lista Neutra (valor)
    /// </summary>
    LISTA_NEUTRA = 3,
    /// <summary>
    /// Margem Valor Agregado (%)
    /// </summary>
    MARGEM_VALOR_AGREGADO = 4,
    /// <summary>
    /// Pauta (valor)
    /// </summary>
    PAUTA = 5
  }
}
