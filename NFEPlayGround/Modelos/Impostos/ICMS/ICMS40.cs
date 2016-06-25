using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação pelo ICMS40 - Isenta
  /// </summary>
  [NFEData, Serializable]
  public class ICMS40 {
    #region Internos
    private Origem _orig;
    private string _CST = "40";
    private decimal _vICMSDeson; // 13i 2d
    private MotDesICMS _motDesICMS;
    #endregion
    #region Propriedades do XML
    [XmlElement("orig")]
    public int xml_orig {
      get { return (int)_orig; }
      set { _orig = (Origem)value; }
    }
    [XmlElement("CST")]
    public string xml_CST {
      get { return _CST; }
      set { _CST = value; }
    }
    [XmlElement("vICMSDeson")]
    public string xml_vICMSDeson {
      get { return TextTools.Dec2Str(_vICMSDeson, 2); }
      set { _vICMSDeson = TextTools.Str2Dec(value); }
    }
    [XmlElement("motDesICMS")]
    public MotDesICMS xml_motDesICMS {
      get { return _motDesICMS; }
      set { _motDesICMS = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Origem da Mercadoria
    /// </summary>
    [XmlIgnore]
    public Origem Origem {
      get { return _orig; }
      set { _orig = value; }
    }
    /// <summary>
    /// Código de Substituição Tributária
    /// </summary>
    [XmlIgnore]
    public string CST {
      get { return _CST; }
      set { _CST = value; }
    }
    /// <summary>
    /// Valor do ICMS de desoneração
    /// </summary>
    [XmlIgnore]
    public decimal ValorDesoneracao {
      get { return _vICMSDeson; }
      set { _vICMSDeson = value; }
    }
    /// <summary>
    /// Motivo da desoneração do ICMS
    /// </summary>
    [XmlIgnore]
    public MotDesICMS MotivoDesoneracao {
      get { return _motDesICMS; }
      set { _motDesICMS = value; }
    }
    #endregion
    #region Construtores
    public ICMS40() {

    }
    #endregion
  }
}
