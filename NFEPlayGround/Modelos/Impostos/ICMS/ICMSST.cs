using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Grupo de informação do ICMSST devido para a UF de destino, nas operações interestaduais de produtos que tiveram retenção antecipada de ICMS por ST na UF do remetente. Repasse via Substituto Tributário.
  /// </summary>
  [NFEData, Serializable]
  public class ICMSST {
    #region Internos
    private Origem _orig;
    private string _CST = "41";
    private decimal _vBCSTRet; // 13i 2d
    private decimal _vICMSSTRet; // 13i 2d
    private decimal _vBCSTDest; // 13i 2d
    private decimal _vICMSSTDest; // 13i 2d
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
    public string xml_vICMSSTRet {
      get { return TextTools.Dec2Str(_vICMSSTRet, 2); }
      set { _vICMSSTRet = TextTools.Str2Dec(value); }
    }
    [XmlElement("vBCSTDest")]
    public string xml_vBCSTDest {
      get { return TextTools.Dec2Str(_vBCSTDest, 2); }
      set { _vBCSTDest = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMSSTDest")]
    public string xml_vICMSSTDest {
      get { return TextTools.Dec2Str(_vICMSSTDest, 2); }
      set { _vICMSSTDest = TextTools.Str2Dec(value); }
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
    /// Informar o valor da BC do ICMS ST retido na UF remetente
    /// </summary>
    [XmlIgnore]
    public decimal ValorBaseCalculoSTRetido {
      get { return _vBCSTRet; }
      set { _vBCSTRet = value; }
    }
    /// <summary>
    /// Informar o valor do ICMS ST retido na UF remetente (iv2.0)
    /// </summary>
    [XmlIgnore]
    public decimal ValorSTRetido {
      get { return _vICMSSTRet; }
      set { _vICMSSTRet = value; }
    }
    /// <summary>
    ///  Informar o valor da BC do ICMS ST da UF destino
    /// </summary>
    [XmlIgnore]
    public decimal ValorBaseCalculoSTDestino {
      get { return _vBCSTDest; }
      set { _vBCSTDest = value; }
    }
    /// <summary>
    /// Informar o valor da BC do ICMS ST da UF destino (v2.0)
    /// </summary>
    [XmlIgnore]
    public decimal ValorSTDestino {
      get { return _vICMSSTDest; }
      set { _vICMSSTDest = value; }
    }
    #endregion
    #region Construtores
    public ICMSST() {

    }
    #endregion
  }
}
