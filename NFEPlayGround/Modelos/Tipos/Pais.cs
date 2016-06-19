using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Modelos.Tipos {
  public class Pais {

    #region Constantes
    private static readonly Pais Brasil = new Pais("Brasil", "1058");

    private static readonly List<Pais> Paises = new List<Pais>() { Brasil };
    #endregion
    #region Internos
    private string nome;
    private string codigo;
    #endregion
    #region Construtores
    public Pais(string nome, string codigo) {
      this.nome = nome;
      this.codigo = codigo;
    }
    #endregion
    #region Propriedades do Usuário
    public string Nome {
      get { return nome; }
      set { nome = value; }
    }

    public string Codigo {
      get { return codigo; }
      set { codigo = value; }
    }
    #region
    #region Métodos
    /// <summary>
    /// Procura um País usando o seu nome
    /// <para>Ex: Pais.fromNome("Brasil"); // Retorna Pais.Brasil</para>
    /// </summary>
    /// <param name="nome">Nome do País</param>
    /// <returns>Pais</returns>
    /// <exception cref="PaisNotFound"></exception>
    public static Pais fromNome(string nome) {
      string fNome = TextTools.RemoveAcentos(nome).Trim();
      foreach (var p in Paises) {
        if (p.Nome.CompareTo(fNome) == 0) {
          return p;
        }
      }
      throw new PaisNotFoundException("País de nome " + nome + " não foi encontrado!");
    }

    /// <summary>
    /// Procura um País usando o seu código
    /// <para>Ex: Pais.fromCodigo("1058"); // Retorna Pais.Brasil</para>
    /// </summary>
    /// <param name="codigo">Código do País</param>
    /// <returns>Pais</returns>
    /// <exception cref="PaisNotFound"></exception>
    public static Pais fromCodigo(string codigo) {
      foreach (var p in Paises) {
        if (p.Codigo.CompareTo(codigo) == 0) {
          return p;
        }
      }
      throw new PaisNotFoundException("País de código " + codigo + " não foi encontrado!");
    }
    #endregion
    #region Exceptions
    public class PaisNotFoundException : Exception {
      public PaisNotFoundException(string message) : base(message) {}
    }
    #endregion
  }
}
