using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;

namespace NFEPlayGround.Modelos.Tipos {
  [Serializable]
  public class UnidadeFederativa {

    #region Região Norte
    public static readonly UnidadeFederativa Rondonia = new UnidadeFederativa("Rondônia", "RO", 11);
    public static readonly UnidadeFederativa Acre = new UnidadeFederativa("Acre", "AC", 12);
    public static readonly UnidadeFederativa Amazonas = new UnidadeFederativa("Amazonas", "AM", 13);
    public static readonly UnidadeFederativa Roraima = new UnidadeFederativa("Roraima", "RR", 14);
    public static readonly UnidadeFederativa Para = new UnidadeFederativa("Pará", "PA", 15);
    public static readonly UnidadeFederativa Amapa = new UnidadeFederativa("Amapá", "AP", 16);
    public static readonly UnidadeFederativa Tocantins = new UnidadeFederativa("Tocantins", "TO", 17);

    /// <summary>
    /// Lista das Unidades Federativas do Norte
    /// </summary>
    public static List<UnidadeFederativa> Norte = new List<UnidadeFederativa>() { Rondonia, Acre, Amazonas, Roraima, Para, Amapa, Tocantins };
    #endregion
    #region Região Nordeste
    public static readonly UnidadeFederativa Maranhao = new UnidadeFederativa("Maranhão", "MA", 21);
    public static readonly UnidadeFederativa Piaui = new UnidadeFederativa("Piauí", "PI", 22);
    public static readonly UnidadeFederativa Ceara = new UnidadeFederativa("Ceará", "CE", 23);
    public static readonly UnidadeFederativa RioGrandedoNorte = new UnidadeFederativa("Rio Grande do Norte", "RN", 24);
    public static readonly UnidadeFederativa Paraiba = new UnidadeFederativa("Paraíba", "PB", 25);
    public static readonly UnidadeFederativa Pernambuco = new UnidadeFederativa("Pernambuco", "PE", 26);
    public static readonly UnidadeFederativa Alagoas = new UnidadeFederativa("Alagoas", "AL", 27);
    public static readonly UnidadeFederativa Sergipe = new UnidadeFederativa("Sergipe", "SE", 28);
    public static readonly UnidadeFederativa Bahia = new UnidadeFederativa("Bahia", "BA", 29);

    /// <summary>
    /// Lista das Unidades Federativas do Nordeste
    /// </summary>
    public static List<UnidadeFederativa> Nordeste = new List<UnidadeFederativa>() { Maranhao, Piaui, Ceara, RioGrandedoNorte, Paraiba, Pernambuco, Alagoas, Sergipe, Bahia };
    #endregion
    #region Região Sudeste
    public static readonly UnidadeFederativa MinasGerais = new UnidadeFederativa("Minas Gerais", "MG", 31);
    public static readonly UnidadeFederativa EspiritoSanto = new UnidadeFederativa("Espirito Santo", "ES", 32);
    public static readonly UnidadeFederativa RioDeJaneiro = new UnidadeFederativa("Rio de Janeiro", "RJ", 33);
    public static readonly UnidadeFederativa SaoPaulo = new UnidadeFederativa("São Paulo", "SP", 35);

    /// <summary>
    /// Lista das Unidades Federativas do Sudeste
    /// </summary>
    public static List<UnidadeFederativa> Sudeste = new List<UnidadeFederativa>() { MinasGerais, EspiritoSanto, RioDeJaneiro, SaoPaulo };
    #endregion
    #region Região Sul
    public static readonly UnidadeFederativa Parana = new UnidadeFederativa("Paraná", "PR", 41);
    public static readonly UnidadeFederativa SantaCatarina = new UnidadeFederativa("Santa Catarina", "SC", 42);
    public static readonly UnidadeFederativa RioGrandeDoSul = new UnidadeFederativa("Rio Grande do Sul", "RS", 43);

    /// <summary>
    /// Lista das Unidades Federativas do Sul
    /// </summary>
    public static List<UnidadeFederativa> Sul = new List<UnidadeFederativa>() { Parana, SantaCatarina, RioGrandeDoSul };
    #endregion
    #region Região Centro-Oeste
    public static readonly UnidadeFederativa MatoGrossoDoSul = new UnidadeFederativa("Mato Grosso do Sul", "MS", 50);
    public static readonly UnidadeFederativa MatoGrosso = new UnidadeFederativa("Mato Grosso", "MT", 51);
    public static readonly UnidadeFederativa Goias = new UnidadeFederativa("Goiás", "GO", 52);
    public static readonly UnidadeFederativa DistritoFederal = new UnidadeFederativa("Distrito Federal", "DF", 53);

    /// <summary>
    /// Lista das Unidades Federativas do Centro Oeste
    /// </summary>
    public static List<UnidadeFederativa> CentroOeste = new List<UnidadeFederativa>() { MatoGrossoDoSul, MatoGrosso, Goias, DistritoFederal };
    #endregion

    /// <summary>
    /// Lista de todas as unidades federativas do Brasil
    /// </summary>
    public static readonly List<UnidadeFederativa> UnidadesFederativas = new List<UnidadeFederativa>() {
      Rondonia, Acre, Amazonas, Roraima, Para, Amapa, Tocantins,
      Maranhao, Piaui, Ceara, RioGrandedoNorte, Paraiba, Pernambuco, Alagoas, Sergipe, Bahia,
      MinasGerais, EspiritoSanto, RioDeJaneiro, SaoPaulo,
      Parana, SantaCatarina, RioGrandeDoSul,
      MatoGrossoDoSul, MatoGrosso, Goias, DistritoFederal
    };

    private string nome;
    private string uf;
    private int _cUF;

    private UnidadeFederativa(string nome, string uf, int cUF) {
      this.nome = nome;
      this.uf = uf;
      this._cUF = cUF;
    }

    private UnidadeFederativa() {

    }
    /// <summary>
    /// Nome da Unidade Federativa
    /// <para>Ex: São Paulo</para>
    /// </summary>
    public string Nome {
      get { return nome; }
    }
    /// <summary>
    /// Sigla da Unidade Federativa.
    /// <para>Ex: SP</para>
    /// </summary>
    public string UF {
      get { return uf; }
    }
    /// <summary>
    /// Código da Unidade Federativa
    /// <para>Ex: 35</para>
    /// </summary>
    public int cUF {
      get { return _cUF; }
    }

    /// <summary>
    /// Procura uma Unidade Federativa pela abreviatura
    /// <para>Ex: UnidadeFederativa.fromUF("SP"); // Retorna UnidadeFederativa.SaoPaulo</para>
    /// </summary>
    /// <param name="uf">Abreviatura do nome da Unidade Federal</param>
    /// <returns>Unidade Federativa</returns>
    /// <exception cref="UnidadeFederativaNotFound"></exception>
    public static UnidadeFederativa fromUF(string uf) {
      foreach (var v in UnidadesFederativas) {
        if (string.Compare(v.uf, uf.Trim(), true) == 0) {
          return v;
        }
      }
      throw new UnidadeFederativaNotFound("Unidade Federativa com UF \"" + uf + "\" não encontrada!");
    }

    /// <summary>
    /// Procura uma Unidade Federativa pelo nome. Ignora acentos.
    /// <para>Ex: UnidadeFederativa.fromNome("São Paulo"); // Retorna UnidadeFederativa.SaoPaulo</para>
    /// </summary>
    /// <param name="nome">Nome da Unidade federativa</param>
    /// <returns>Unidade Federativa</returns>
    /// <exception cref="UnidadeFederativaNotFound"></exception>
    public static UnidadeFederativa fromNome(string nome) {
      string fNome = TextTools.RemoveAcentos(nome).Trim();
      foreach (var v in UnidadesFederativas) {
        if (string.Compare(v.nome, fNome, true) == 0) {
          return v;
        }
      }
      throw new UnidadeFederativaNotFound("Unidade Federativa com nome \"" + nome + "\" não encontrada!");
    }

    /// <summary>
    /// Procura uma Unidade Federativa usando cUF
    /// <para>Ex: UnidadeFederativa.fromCUF(35); // Retorna UnidadeFederativa.SaoPaulo</para>
    /// </summary>
    /// <param name="cUF">cUF da Unidade Federativa</param>
    /// <returns>Unidade Federativa</returns>
    /// <exception cref="UnidadeFederativaNotFound"></exception>
    public static UnidadeFederativa fromCUF(int cUF) {
      foreach (var v in UnidadesFederativas) {
        if (v.cUF == cUF) {
          return v;
        }
      }
      throw new UnidadeFederativaNotFound("Unidade Federativa com cUF \"" + cUF + "\" não encontrada!");
    }

    /// <summary>
    /// Procura uma Unidade Federativa usando uma string cUF
    /// <para>Ex: UnidadeFederativa.fromCUF("35"); // Retorna UnidadeFederativa.SaoPaulo</para>
    /// </summary>
    /// <param name="cUF">cUF da Unidade Federativa</param>
    /// <returns>Unidade Federativa</returns>
    /// <exception cref="UnidadeFederativaNotFound"></exception>
    /// <exception cref="FormatException"></exception>
    public static UnidadeFederativa fromCUF(string cUF) {
      int icUF = int.Parse(cUF);
      return fromCUF(icUF);
    }

    public class UnidadeFederativaNotFound : Exception {
      public UnidadeFederativaNotFound(string message) : base(message) { }
    }
  }
}
