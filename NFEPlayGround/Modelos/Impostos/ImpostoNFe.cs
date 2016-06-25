using NFEPlayGround.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Imposto {
  [NFEData, Serializable]
  public class ImpostoNFe {
    #region Internos
    private string _Prop0;
    private decimal _vTotTrib;  //  13i 2d
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
    public ImpostoNFe() {

    }
    #endregion
  }
}
