using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributção pelo ICMS51 - Diferimento
  /// <para>A exigência do preenchimento das informações do ICMS diferido fica à critério de cada UF</para>
  /// </summary>
  [NFEData, Serializable]
  public class ICMS51 {
    #region Internos
    private Origem _orig;
    private string _CST = "51";
    private ModBC _modBC;
    private decimal _pRedBC; // 3i 2d
    private decimal _vBC; // 13i 2d
    private decimal _pICMS; // 3i 2d
    private decimal _vICMSOp; // 13i 2d
    private decimal _pDif; // 3i 2d
    private decimal _vICMSDif; // 13i 2d
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
    [XmlElement("pRedBC")]
    public string xml_pRedBC {
      get { return TextTools.Dec2Str(_pRedBC, 2); }
      set { _pRedBC = TextTools.Str2Dec(value); }
    }
    [XmlElement("vBC")]
    public string xml_vBC {
      get { return TextTools.Dec2Str(_vBC, 2); }
      set { _vBC = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMSOp")]
    public string xml_vICMSOp {
      get { return TextTools.Dec2Str(_vICMSOp, 2); }
      set { _vICMSOp = TextTools.Str2Dec(value); }
    }
    [XmlElement("pDif")]
    public string xml_pDif {
      get { return TextTools.Dec2Str(_pDif, 2); }
      set { _pDif = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMSDif")]
    public string xml_vICMSDif {
      get { return TextTools.Dec2Str(_vICMSDif, 2); }
      set { _vICMSDif = TextTools.Str2Dec(value); }
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
    /// Código de Substituição Tributária
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
    /// Valor do ICMS da Operação
    /// </summary>
    [XmlIgnore]
    public decimal ValorOperacao {
      get { return _vICMSOp; }
      set { _vICMSOp = value; }
    }
    /// <summary>
    /// Percentual do diferemento
    /// </summary>
    [XmlIgnore]
    public decimal PercentualDiferimento {
      get { return _pDif; }
      set { _pDif = value; }
    }
    /// <summary>
    /// Valor do ICMS da diferido
    /// </summary>
    [XmlIgnore]
    public decimal ValorDiferido {
      get { return _vICMSDif; }
      set { _vICMSDif = value; }
    }
    /// <summary>
    /// Valor do ICMS
    /// </summary>
    [XmlIgnore]
    public decimal Valor {
      get { return _vICMS; }
      set { _vICMS = value; }
    }
    /// <summary>
    /// Percentual de redução da BC
    /// </summary>
    [XmlIgnore]
    public decimal PercentualReducaoBC {
      get { return _pRedBC; }
      set { _pRedBC = value; }
    }
    #endregion
    #region Construtores
    public ICMS51() {

    }
    #endregion
  }
}
