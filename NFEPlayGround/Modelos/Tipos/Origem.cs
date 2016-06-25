namespace NFEPlayGround.Modelos.Tipos {
  public enum Origem {
    /// <summary>
    /// Produto Nacional
    /// </summary>
    NACIONAL = 0,
    /// <summary>
    /// Produto Estrangeiro - Importação direta 
    /// </summary>
    ESTRANGEIRA = 1,
    /// <summary>
    /// Produto Estrangeiro - Adquirida no mercado interno 
    /// </summary>
    ESTRANGEIRA_INTERNA = 2
  }
}
