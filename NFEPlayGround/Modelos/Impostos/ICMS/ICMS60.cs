using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação pelo ICMS60 - ICMS cobrado anteriormente por substituição tributária
  /// </summary>
  [NFEData, Serializable]
  public class ICMS60 {
    #region Internos
    private Origem _orig;
    private string _CST = "60";
    private decimal _vBCSTRet; // 13i 2d
    private decimal _vICMSSTRet; // 13i 2d
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
    [XmlElement("vBCSTRet")]
    public string xml_vBCSTRet {
      get { return TextTools.Dec2Str(_vBCSTRet, 2); }
      set { _vBCSTRet = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMSSTRet")]
    public string xml_vICMSOp {
      get { return TextTools.Dec2Str(_vICMSSTRet, 2); }
      set { _vICMSSTRet = TextTools.Str2Dec(value); }
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
    /// Valor da BC do ICMS ST retido anteriormente
    /// </summary>
    [XmlIgnore]
    public decimal ValorBaseCalculoSTRetido {
      get { return _vBCSTRet; }
      set { _vBCSTRet = value; }
    }
    /// <summary>
    /// Valor do ICMS ST retido anteriormente
    /// </summary>
    [XmlIgnore]
    public decimal ValorSTRetido {
      get { return _vICMSSTRet; }
      set { _vICMSSTRet = value; }
    }
    #endregion
    #region Construtores
    public ICMS60() {

    }
    #endregion
  }
}
