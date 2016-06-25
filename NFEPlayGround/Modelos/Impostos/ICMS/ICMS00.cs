using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação pelo ICMS00 - Tributada integralmente
  /// </summary>
  [NFEData, Serializable]
  public class ICMS00 {
    #region Internos
    private Origem _orig;
    private string _CST = "00";
    private ModBC _modBC;
    private decimal _vBC; // 13i 2d
    private decimal _pICMS; // 3i 2d
    private decimal _vICMS; // 13i 2d
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
    [XmlElement("modBC")]
    public int xml_modBC {
      get { return (int)_modBC; }
      set { _modBC = (ModBC)value; }
    }
    [XmlElement("vBC")]
    public string xml_vBC {
      get { return TextTools.Dec2Str(_vBC, 2); }
      set { _vBC = TextTools.Str2Dec(value); }
    }
    [XmlElement("pICMS")]
    public string xml_pICMS {
      get { return TextTools.Dec2Str(_pICMS, 2); }
      set { _pICMS = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMS")]
    public string xml_vICMS {
      get { return TextTools.Dec2Str(_vICMS, 2); }
      set { _vICMS = TextTools.Str2Dec(value); }
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
    /// Código de Substituição Tributária - Valor: "00"
    /// </summary>
    [XmlIgnore]
    public string CST {
      get { return _CST; }
      set { _CST = value; }
    }
    /// <summary>
    /// Modalidade de determinação da BC do ICMS
    /// </summary>
    [XmlIgnore]
    public ModBC ModalidadeBaseCalculo {
      get { return _modBC; }
      set { _modBC = value; }
    }
    /// <summary>
    /// Valor da BC do ICMS
    /// </summary>
    [XmlIgnore]
    public decimal ValorBaseCalculo {
      get { return _vBC; }
      set { _vBC = value; }
    }
    /// <summary>
    /// Alíquota do ICMS
    /// </summary>
    [XmlIgnore]
    public decimal Aliquota {
      get { return _pICMS; }
      set { _pICMS = value; }
    }
    /// <summary>
    /// Valor do ICMS
    /// </summary>
    [XmlIgnore]
    public decimal Valor {
      get { return _vICMS; }
      set { _vICMS = value; }
    }
    #endregion
    #region Construtores
    public ICMS00() {

    }
    #endregion
  }
}
