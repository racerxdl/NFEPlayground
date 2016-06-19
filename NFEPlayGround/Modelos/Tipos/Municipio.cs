using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  public class Municipio {

    #region Constantes
    public static readonly Municipio SaoPaulo = new Municipio("SAO PAULO", "3550308");

    public static readonly List<Municipio> Municipios = new List<Municipio>() { SaoPaulo };
    #endregion
    #region Internos
    private string _nome;
    private string _codigo;
    #endregion
    #region Construtores
    public Municipio(string nome, string codigo) {
      _nome = nome;
      _codigo = codigo;
    }
    #endregion
    #region Propriedades do Usuário
    public string Nome {
      get { return _nome; }
      set { _nome = value; }
    }

    public string Codigo {
      get { return _codigo; }
      set { _codigo = value; }
    }
    #endregion
    #region Métodos
    /// <summary>
    /// Procura um Municipio usando o seu código
    /// <para>Ex: Municipio.fromNome("São Paulo"); // Retorna Municipio.SaoPaulo</para>
    /// </summary>
    /// <param name="nome">Nome do Municipio</param>
    /// <returns>Municipio</returns>
    /// <exception cref="MunicipioNotFound"></exception>
    public static Municipio fromNome(string nome) {
      string fNome = TextTools.RemoveAcentos(nome).Trim();
      foreach (var p in Municipios) {
        if (p.Nome.CompareTo(fNome) == 0) {
          return p;
        }
      }
      throw new MunicipioNotFoundException("Municipio de nome " + nome + " não foi encontrado!");
    }

    /// <summary>
    /// Procura um Municipio usando o seu código
    /// <para>Ex: Municipio.fromCodigo("3550308"); // Retorna Municipio.Brasil</para>
    /// </summary>
    /// <param name="codigo">Código do Municipio</param>
    /// <returns>Municipio</returns>
    /// <exception cref="MunicipioNotFound"></exception>
    public static Municipio fromCodigo(string codigo) {
      foreach (var p in Municipios) {
        if (p.Codigo.CompareTo(codigo) == 0) {
          return p;
        }
      }
      throw new MunicipioNotFoundException("Municipio de código " + codigo + " não foi encontrado!");
    }
    #endregion
    #region Exceptions
    public class MunicipioNotFoundException : Exception {
      public MunicipioNotFoundException(string message) : base(message) { }
    }
    #endregion
  }
}
