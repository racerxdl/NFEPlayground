using NFEPlayGround.Atributos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class DetNFe {
    #region Internos
    private ProdNFe _prod;
    #endregion
    #region Propriedades do XML
    [XmlElement("prod")]
    public ProdNFe xml_prod {
      get { return _prod; }
      set { _prod = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Dados dos produtos e serviços da NF-e
    /// </summary>
    [XmlIgnore]
    public ProdNFe Produto {
      get { return _prod; }
      set { _prod = value; }
    }
    #endregion
    #region Construtores
    public DetNFe() {

    }
    #endregion
  }
}
