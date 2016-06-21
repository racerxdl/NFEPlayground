using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class ConsSitNFe : XmlConvertible {
    #region Internos
    private TipoAmbiente _tpAmb;
    private string _chNFe;
    #endregion
    #region Propriedades do XML
    [XmlElement("tpAmb")]
    public int tpAmb {
      get { return (int)_tpAmb; }
      set { _tpAmb = (TipoAmbiente)value; }
    }
    [XmlElement("xServ")]
    public string xServ {
      get { return "CONSULTAR"; }
      set { }
    }
    [XmlElement("chNFe")]
    public string xml_chNFe {
      get { return _chNFe; }
      set { _chNFe = value; }
    }
    [XmlAttribute("versao")]
    public string versao {
      get { return "3.10"; }
      set { string v = value; }
    }
    #endregion
    #region Propriedades do Usuário
    [XmlIgnore]
    public TipoAmbiente TipoAmbiente {
      get { return _tpAmb; }
      set { _tpAmb = value; }
    }
    [XmlIgnore]
    public string CodigoNFE {
      get { return _chNFe; }
      set { _chNFe = value; }
    }
    #endregion
    #region Construtores
    public ConsSitNFe() {
      this._tpAmb = TipoAmbiente.Homologacao;
    }
    public ConsSitNFe(TipoAmbiente ambiente, string codigoNFe) {
      this._tpAmb = ambiente;
      this._chNFe = codigoNFe;
    }
    #endregion
  }
}
