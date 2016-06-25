using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    #endregion
    #region Construtores
    public ICMS() {

    }
    #endregion
  }
}
