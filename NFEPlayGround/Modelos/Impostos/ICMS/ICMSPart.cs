using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Partilha do ICMS entre a UF de origem e UF de destino ou a UF definida na legislação
  /// <para>Operação interestadual para consumidor final com partilha do ICMS devido na 
  /// operação entre a UF de origem e a UF do destinatário ou ou a UF definida na legislação. 
  /// (Ex.UF da concessionária de entrega do  veículos)</para>
  /// </summary>
  [NFEData, Serializable]
  public class ICMSPart {
    #region Internos
    private Origem _orig;
    private string _CST = "90";
    private ModBC _modBC;
    private decimal _vBC; // 13i 2d
    private decimal _pRedBC; // 3i 2d
    private decimal _pICMS; // 3i 2d
    private decimal _vICMS; // 13i 2d
    private ModBCST _modBCST;
    private decimal _pMVAST; // 3i 2d
    private decimal _pRedBCST; // 3i 2d
    private decimal _vBCST; // 13i 2d
    private decimal _pICMSST; // 3i 2d
    private decimal _vICMSST; // 13i 2d
    private decimal _pBCOp; // 3i 2d
    private UnidadeFederativa _UFST;
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
    [XmlElement("pRedBC")]
    public string xml_pRedBC {
      get { return TextTools.Dec2Str(_pRedBC, 2); }
      set { _pRedBC = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMS")]
    public string xml_vICMSOp {
      get { return TextTools.Dec2Str(_vICMS, 2); }
      set { _vICMS = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMS")]
    public string xml_vICMS {
      get { return TextTools.Dec2Str(_vICMS, 2); }
      set { _vICMS = TextTools.Str2Dec(value); }
    }
    [XmlElement("modBCST")]
    public int xml_modBCST {
      get { return (int)_modBCST; }
      set { _modBCST = (ModBCST)(value); }
    }
    [XmlElement("pMVAST")]
    public string xml_pMVAST {
      get { return TextTools.Dec2Str(_pMVAST, 2); }
      set { _pMVAST = TextTools.Str2Dec(value); }
    }
    [XmlElement("pRedBCST")]
    public string xml_pRedBCST {
      get { return TextTools.Dec2Str(_pRedBCST, 2); }
      set { _pRedBCST = TextTools.Str2Dec(value); }
    }
    [XmlElement("vBCST")]
    public string xml_vBCST {
      get { return TextTools.Dec2Str(_vBCST, 2); }
      set { _vBCST = TextTools.Str2Dec(value); }
    }
    [XmlElement("pICMSST")]
    public string xml_pICMSST {
      get { return TextTools.Dec2Str(_pICMSST, 2); }
      set { _pICMSST = TextTools.Str2Dec(value); }
    }
    [XmlElement("vICMSST")]
    public string xml_vICMSST {
      get { return TextTools.Dec2Str(_vICMSST, 2); }
      set { _vICMSST = TextTools.Str2Dec(value); }
    }
    [XmlElement("pBCOp")]
    public string xml_vICMSDeson {
      get { return TextTools.Dec2Str(_pBCOp, 2); }
      set { _pBCOp = TextTools.Str2Dec(value); }
    }
    [XmlElement("UFST")]
    public string xml_UFST {
      get { return _UFST.UF; }
      set { _UFST = UnidadeFederativa.fromUF(value); }
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
    /// Percentual de redução da BC
    /// </summary>
    [XmlIgnore]
    public decimal PercentualReducao {
      get { return _pRedBC; }
      set { _pRedBC = value; }
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
    /// <summary>
    /// Modalidade de determinação da BC do ICMS ST
    /// </summary>
    [XmlIgnore]
    public ModBCST ModalidadeBaseCalculoST {
      get { return _modBCST; }
      set { _modBCST = value; }
    }
    /// <summary>
    /// Percentual da Margem de Valor Adicionado ICMS ST
    /// </summary>
    [XmlIgnore]
    public decimal PercentualMargemValorAdicionadoST {
      get { return _pMVAST; }
      set { _pMVAST = value; }
    }
    /// <summary>
    /// Percentual de redução da BC ICMS ST
    /// </summary>
    [XmlIgnore]
    public decimal PercentualReducaoST {
      get { return _pRedBCST; }
      set { _pRedBCST = value; }
    }
    /// <summary>
    /// Valor da BC do ICMS ST
    /// </summary>
    [XmlIgnore]
    public decimal ValorBaseCalculoST {
      get { return _vBCST; }
      set { _vBCST = value; }
    }
    /// <summary>
    /// Alíquota do ICMS ST
    /// </summary>
    [XmlIgnore]
    public decimal AliquotaST {
      get { return _pICMSST; }
      set { _pICMSST = value; }
    }
    /// <summary>
    /// Valor do ICMS ST
    /// </summary>
    [XmlIgnore]
    public decimal ValorST {
      get { return _vICMSST; }
      set { _vICMSST = value; }
    }
    /// <summary>
    /// Percentual para determinação do valor  da Base de Cálculo da operação própria.
    /// </summary>
    [XmlIgnore]
    public decimal PercentualBaseCalculoOperacaoPropria {
      get { return _pBCOp; }
      set { _pBCOp = value; }
    }
    /// <summary>
    /// UF para qual é devido o ICMS ST da operação.
    /// </summary>
    [XmlIgnore]
    public UnidadeFederativa UnidadeFederativa {
      get { return _UFST; }
      set { _UFST = value; }
    }
    #endregion
    #region Construtores
    public ICMS90() {

    }
    #endregion
  }
}
