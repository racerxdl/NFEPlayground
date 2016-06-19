using NFEPlayGround.Atributos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class InfNFe {
    #region Internos
    private IdeNFe _ide;
    private Emitente _emit;
    private Destinatario _dest;
    #endregion
    #region Propriedades do XML
    [XmlElement("ide")]
    public IdeNFe xml_ide {
      get { return _ide; }
      set { _ide = value; }
    }
    [XmlElement("emit")]
    public Emitente xml_Emitente {
      get { return _emit; }
      set { _emit = value; }
    }
    [XmlElement("dest")]
    public Destinatario xml_Destinatario {
      get { return _dest; }
      set { _dest = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Identificação da NF-e
    /// </summary>
    [XmlIgnore]
    public IdeNFe IdeNFe {
      get { return _ide; }
      set { _ide = value; }
    }
    /// <summary>
    /// Identificação do emitente
    /// </summary>
    [XmlIgnore]
    public Emitente Emitente {
      get { return _emit; }
      set { _emit = value; }
    }
    /// <summary>
    /// Identificação do Destinatário
    /// </summary>
    [XmlIgnore]
    public Destinatario Destinatario {
      get { return _dest; }
      set { _dest = value; }
    }
    #endregion
    #region Construtores
    public InfNFe() {

    }
    #endregion
  }
}
