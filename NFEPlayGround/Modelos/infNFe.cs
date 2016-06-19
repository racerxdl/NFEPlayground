using NFEPlayGround.Atributos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class InfNFe {
    #region Internos
    private Emitente _emit;
    private Destinatario _dest;
    #endregion
    #region Propriedades do XML
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
    [XmlIgnore]
    public Emitente Emitente {
      get { return _emit; }
      set { _emit = value; }
    }
    #endregion
    #region Construtores
    public InfNFe() {

    }
    #endregion
  }
}
