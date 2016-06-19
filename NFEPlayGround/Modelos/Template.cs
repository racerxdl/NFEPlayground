using NFEPlayGround.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  /// <summary>
  /// Template para Modelos NFe
  /// </summary>
  [NFEData, Serializable]
  internal class Template {
    #region Internos
    private string _Prop0;
    #endregion
    #region Propriedades do XML
    [XmlElement("Prop0")]
    public string xml_Prop0 {
      get { return _Prop0; }
      set { _Prop0 = value; }
    }
    #endregion
    #region Propriedades do usuario
    [XmlIgnore]
    public string Prop0 {
      get { return _Prop0; }
      set { _Prop0 = value; }
    }
    #endregion
    #region Construtores
    public Template() {

    }
    #endregion
  }
}
