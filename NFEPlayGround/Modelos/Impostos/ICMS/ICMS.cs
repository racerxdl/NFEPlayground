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
    #endregion
    #region Construtores
    public ICMS() {

    }
    #endregion
  }
}
