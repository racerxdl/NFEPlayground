using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  /// <summary>
  /// Identificação do Destinatário
  /// </summary>
  [Serializable]
  [XmlInclude(typeof(Emitente))]
  [XmlInclude(typeof(Destinatario))]
  public class Entidade: XmlConvertible {
    #region Internos
    protected string _CNPJ;
    protected string _CPF;
    protected string _xNome;
    protected string _xFant;
    protected Endereco _end;
    protected string _IE;
    protected string _IM;
    #endregion
    #region Propriedades do XML
    [XmlElement("CNPJ")]
    public string xml_CNPJ {
      get { return _CNPJ; }
      set { _CNPJ = value; }
    }
    [XmlElement("CPF")]
    public string xml_CPF {
      get { return _CPF; }
      set { _CPF = value; }
    }
    [XmlElement("xNome")]
    public string xml_xNome {
      get { return _xNome; }
      set { _xNome = value; }
    }
    [XmlElement("xFant")]
    public string xml_xFant {
      get { return _xFant; }
      set { _xFant = value; }
    }
    [XmlElement("IE")]
    public string xml_IE {
      get { return _IE; }
      set { _IE = value; }
    }
    [XmlElement("IM")]
    public string xml_IM {
      get { return _IM; }
      set { _IM = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Número do CNPJ
    /// </summary>
    [XmlIgnore]
    public string CNPJ {
      get { return _CNPJ; }
      set { _CNPJ = value; }
    }
    /// <summary>
    /// Número do CPF
    /// </summary>
    [XmlIgnore]
    public string CPF {
      get { return _CPF; }
      set { _CPF = value; }
    }
    /// <summary>
    /// Razão Social ou nome do destinatário
    /// </summary>
    [XmlIgnore]
    public string Nome {
      get { return _xNome; }
      set { _xNome = value; }
    }
    [XmlIgnore]
    public string NomeFantasia {
      get { return _xFant; }
      set { _xFant = value; }
    }
    /// <summary>
    /// Dados do endereço
    /// </summary>
    [XmlIgnore]
    public Endereco Endereco {
      get { return _end; }
      set { _end = value; }
    }
    /// <summary>
    /// Inscrição Estadual (obrigatório nas operações com contribuintes do ICMS)
    /// </summary>
    [XmlIgnore]
    public string IE {
      get { return _IE; }
      set { _IE = value; }
    }
    /// <summary>
    /// Inscrição Municipal
    /// </summary>
    [XmlIgnore]
    public string IM {
      get { return _IM; }
      set { _IM = value; }
    }
    #endregion
    #region Construtores
    public Entidade() {

    }
    #endregion
  }
}
