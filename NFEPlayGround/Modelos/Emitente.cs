using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class Emitente: Entidade {
    #region Internos
    protected string _IEST;
    protected string _CNAE;
    protected CRT _CRT;
    #endregion
    #region Propriedades do XML
    [XmlElement("IEST")]
    public string xml_IEST {
      get { return _IEST; }
      set { _IEST = value; }
    }
    [XmlElement("enderEmit")]
    public Endereco xml_end {
      get { return _end; }
      set { _end = value; }
    }
    [XmlElement("CNAE")]
    public string xml_CNAE {
      get { return _CNAE; }
      set { _CNAE = value; }
    }
    [XmlElement("CRT")]
    public string xml_CRT {
      get { return ((int)_CRT).ToString(); }
      set { _CRT = (CRT)(int.Parse(value)); }
    }
    #endregion
    #region Propriedades do Usuário
    /// <summary>
    /// Inscricao Estadual do Substituto Tributário
    /// </summary>
    [XmlIgnore]
    public string IEST {
      get { return _IEST; }
      set { _IEST = value; }
    }
    /// <summary>
    /// CNAE Fiscal
    /// </summary>
    [XmlIgnore]
    public string CNAE {
      get { return _CNAE; }
      set { _CNAE = value; }
    }
    /// <summary>
    /// Código de Regime Tributário.
    /// </summary>
    [XmlIgnore]
    public CRT CRT {
      get { return _CRT; }
      set { _CRT = value; }
    }
    #endregion
  }
}
