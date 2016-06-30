using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=202 ou 203 (v.2.0)
  /// </summary>
  [NFEData, Serializable]
  public class ICMSSN202 {
    #region Internos
    private Origem _orig;
    private string _CSOSN = "202";
    private ModBCST _modBCST;
    private decimal _pMVAST; // 3i 2d
    private decimal _pRedBCST; // 3i 2d
    private decimal _vBCST; // 13i 2d
    private decimal _pICMSST; // 3i 2d
    private decimal _vICMSST; // 13i 2d
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
    [XmlElement("modBCST")]
    public int xml_modBCST {
      get { return (int)_modBCST; }
      set { _modBCST = (ModBCST)value; }
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
    #endregion
    #region Construtores
    public ICMSSN202() {

    }
    #endregion
  }
}
