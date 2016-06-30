using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Dados do ICMS Normal e ST
  /// <para>Preencher apenas um dos campos de acordo com o CST</para>
  /// </summary>
  [NFEData, Serializable]
  public class ICMS {
    #region Internos
    private ICMS00 _ICMS00;
    private ICMS10 _ICMS10;
    private ICMS20 _ICMS20;
    private ICMS30 _ICMS30;
    private ICMS40 _ICMS40;
    private ICMS51 _ICMS51;
    private ICMS60 _ICMS60;
    private ICMS70 _ICMS70;
    private ICMS90 _ICMS90;
    private ICMSPart _ICMSPart;
    private ICMSST _ICMSST;

    #region Simples Nacional
    private ICMSSN101 _ICMSSN101;
    private ICMSSN102 _ICMSSN102;
    private ICMSSN201 _ICMSSN201;
    private ICMSSN202 _ICMSSN202;
    private ICMSSN500 _ICMSSN500;
    private ICMSSN900 _ICMSSN900;
    #endregion

    #endregion
    #region Propriedades do XML
    [XmlElement("ICMS00")]
    public ICMS00 xml_ICMS00 {
      get { return _ICMS00; }
      set { _ICMS00 = value; }
    }
    [XmlElement("ICMS10")]
    public ICMS10 xml_ICMS10 {
      get { return _ICMS10; }
      set { _ICMS10 = value; }
    }
    [XmlElement("ICMS20")]
    public ICMS20 xml_ICMS20 {
      get { return _ICMS20; }
      set { _ICMS20 = value; }
    }
    [XmlElement("ICMS30")]
    public ICMS30 xml_ICMS30 {
      get { return _ICMS30; }
      set { _ICMS30 = value; }
    }
    [XmlElement("ICMS40")]
    public ICMS40 xml_ICMS40 {
      get { return _ICMS40; }
      set { _ICMS40 = value; }
    }
    [XmlElement("ICMS51")]
    public ICMS51 xml_ICMS51 {
      get { return _ICMS51; }
      set { _ICMS51 = value; }
    }
    [XmlElement("ICMS60")]
    public ICMS60 xml_ICMS60 {
      get { return _ICMS60; }
      set { _ICMS60 = value; }
    }
    [XmlElement("ICMS70")]
    public ICMS70 xml_ICMS70 {
      get { return _ICMS70; }
      set { _ICMS70 = value; }
    }
    [XmlElement("ICMS90")]
    public ICMS90 xml_ICMS90 {
      get { return _ICMS90; }
      set { _ICMS90 = value; }
    }
    [XmlElement("ICMSPart")]
    public ICMSPart xml_ICMSPart {
      get { return _ICMSPart; }
      set { _ICMSPart = value; }
    }
    [XmlElement("ICMSST")]
    public ICMSST xml_ICMSST {
      get { return _ICMSST; }
      set { _ICMSST = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Tributação pelo ICMS00 - Tributada integralmente
    /// </summary>
    [XmlIgnore]
    public ICMS00 ICMS00 {
      get { return _ICMS00; }
      set { _ICMS00 = value; }
    }
    /// <summary>
    /// Tributação pelo ICMS10 - Tributada e com cobrança do ICMS por substituição tributária
    /// </summary>
    [XmlIgnore]
    public ICMS10 ICMS10 {
      get { return _ICMS10; }
      set { _ICMS10 = value; }
    }
    /// <summary>
    /// Tributção pelo ICMS20 - Com redução de base de cálculo
    /// </summary>
    [XmlIgnore]
    public ICMS20 ICMS20 {
      get { return _ICMS20; }
      set { _ICMS20 = value; }
    }
    /// <summary>
    /// Tributação pelo ICMS30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária
    /// </summary>
    [XmlIgnore]
    public ICMS30 ICMS30 {
      get { return _ICMS30; }
      set { _ICMS30 = value; }
    }
    /// <summary>
    /// Tributação pelo ICMS40 - Isenta
    /// </summary>
    [XmlIgnore]
    public ICMS40 ICMS40 {
      get { return _ICMS40; }
      set { _ICMS40 = value; }
    }
    /// <summary>
    /// Tributação pelo ICMS51 - Diferimento
    /// </summary>
    [XmlIgnore]
    public ICMS51 ICMS51 {
      get { return _ICMS51; }
      set { _ICMS51 = value; }
    }
    /// <summary>
    /// Tributação pelo ICMS60 - ICMS cobrado anteriormente por substituição tributária
    /// </summary>
    [XmlIgnore]
    public ICMS60 ICMS60 {
      get { return _ICMS60; }
      set { _ICMS60 = value; }
    }
    /// <summary>
    /// Tributação pelo ICMS70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária
    /// </summary>
    [XmlIgnore]
    public ICMS70 ICMS70 {
      get { return _ICMS70; }
      set { _ICMS70 = value; }
    }
    /// <summary>
    /// Tributação pelo Tributação pelo ICMS90 - Outras
    /// </summary>
    [XmlIgnore]
    public ICMS90 ICMS90 {
      get { return _ICMS90; }
      set { _ICMS90 = value; }
    }
    /// <summary>
    /// Partilha do ICMS entre a UF de origem e UF de destino ou a UF definida na legislação
    /// <para>Operação interestadual para consumidor final com partilha do ICMS devido na 
    /// operação entre a UF de origem e a UF do destinatário ou ou a UF definida na legislação. 
    /// (Ex.UF da concessionária de entrega do  veículos)</para>
    /// </summary>
    [XmlIgnore]
    public ICMSPart ICMSPart {
      get { return _ICMSPart; }
      set { _ICMSPart = value; }
    }
    /// <summary>
    /// Grupo de informação do ICMSST devido para a UF de destino, nas operações interestaduais de produtos que tiveram retenção antecipada de ICMS por ST na UF do remetente. Repasse via Substituto Tributário.
    /// </summary>
    [XmlIgnore]
    public ICMSST ICMSST {
      get { return _ICMSST; }
      set { _ICMSST = value; }
    }
    #endregion
    #region Construtores
    public ICMS() {

    }
    #endregion
  }
}
