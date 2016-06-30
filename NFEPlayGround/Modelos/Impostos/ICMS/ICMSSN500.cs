using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação do ICMS pelo SIMPLES NACIONAL,CRT=1 – Simples Nacional e CSOSN=500 (v.2.0)
  /// </summary>
  [NFEData, Serializable]
  public class ICMSSN500 {
    #region Internos
    private Origem _orig;
    private string _CSOSN = "500";
    private decimal _vBCSTRet; // 13i 2d
    private decimal _vICMSSTRet; // 13i 2d
    #endregion
    #region Propriedades do XML
    [XmlElement("orig")]
    public int xml_orig {
      get { return (int)_orig; }
      set { _orig = (Origem)value; }
    }
    [XmlElement("CSOSN")]
    public string xml_CSOSN {
      get { return _CSOSN; }
      set { _CSOSN = value; }
    }
    [XmlElement("vBCSTRet")]
    public string xml_vBCSTRet {
      get { return TextTools.Dec2Str(_vBCSTRet, 2); }
      set { _vBCSTRet = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMSSTRet")]
    public string xml_vICMSSTRet {
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
    public ICMSSN500() {

    }
    #endregion
  }
}
