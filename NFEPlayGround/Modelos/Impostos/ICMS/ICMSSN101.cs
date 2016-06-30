using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=101 (v.2.0)
  /// </summary>
  [NFEData, Serializable]
  public class ICMSSN101 {
    #region Internos
    private Origem _orig;
    private string _CSOSN = "101";
    private decimal _pCredSN; // 3i 2d
    private decimal _vCredICMSSN; // 13i 2d
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
    [XmlElement("pCredSN")]
    public string xml_pCredSN {
      get { return TextTools.Dec2Str(_pCredSN, 2); }
      set { _pCredSN = TextTools.Str2Dec(value); }
    }
    [XmlElement("vCredICMSSN")]
    public string xml_vCredICMSSN {
      get { return TextTools.Dec2Str(_vCredICMSSN, 2); }
      set { _vCredICMSSN= TextTools.Str2Dec(value); }
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
    /// Alíquota aplicável de cálculo do crédito (Simples Nacional). (v2.0)
    /// </summary>
    [XmlIgnore]
    public decimal Aliquota {
      get { return _pCredSN; }
      set { _pCredSN = value; }
    }
    /// <summary>
    /// Valor crédito do ICMS que pode ser aproveitado nos termos do art. 23 da LC 123 (Simples Nacional) (v2.0)
    /// </summary>
    [XmlIgnore]
    public decimal Valor {
      get { return _vCredICMSSN; }
      set { _vCredICMSSN = value; }
    }
    #endregion
    #region Construtores
    public ICMSSN101() {

    }
    #endregion
  }
}
