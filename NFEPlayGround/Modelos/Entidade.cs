using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class Entidade: XmlConvertible {
    #region Internos
    private string _CNPJ;
    private string _CPF;
    private string _xNome;
    private string _xFant;
    private Endereco _end;
    private string _IE;
    private string _IEST;
    private string _IM;
    private string _CNAE;
    private CRT _CRT;
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
    [XmlElement("end")]
    public Endereco xml_end {
      get { return _end; }
      set { _end = value; }
    }
    [XmlElement("IE")]
    public string xml_IE {
      get { return _IE; }
      set { _IE = value; }
    }
    [XmlElement("IEST")]
    public string xml_IEST {
      get { return _IEST; }
      set { _IEST = value; }
    }
    [XmlElement("IM")]
    public string xml_IM {
      get { return _IM; }
      set { _IM = value; }
    }
    [XmlElement("CNAE")]
    public string xml_CNAE {
      get { return _CNAE; }
      set { _CNAE = value; }
    }
    [XmlElement("CRT")]
    public string xml_CRT {
      get { return _CRT.ToString(); }
      set { int x = int.Parse(value); _CRT = (CRT)x; }
    }
    #endregion
    #region Propriedades do usuario
    [XmlIgnore]
    public string CNPJ {
      get { return _CNPJ; }
      set { _CNPJ = value; }
    }
    [XmlIgnore]
    public string CPF {
      get { return _CPF; }
      set { _CPF = value; }
    }
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
    [XmlIgnore]
    public Endereco Endereco {
      get { return _end; }
      set { _end = value; }
    }
    [XmlIgnore]
    public string IE {
      get { return _IE; }
      set { _IE = value; }
    }
    [XmlIgnore]
    public string IEST {
      get { return _IEST; }
      set { _IEST = value; }
    }
    [XmlIgnore]
    public string IM {
      get { return _IM; }
      set { _IM = value; }
    }
    [XmlIgnore]
    public string CNAE {
      get { return _CNAE; }
      set { _CNAE = value; }
    }
    [XmlIgnore]
    public CRT CRT {
      get { return _CRT; }
      set {  _CRT = value; }
    }
    #endregion
    #region Construtores
    public Entidade() {

    }
    #endregion
  }
}
