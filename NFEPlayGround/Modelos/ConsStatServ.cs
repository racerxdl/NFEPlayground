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
  public class ConsStatServ {
    #region Internos
    private TipoAmbiente _tpAmb;
    private UnidadeFederativa _cUF;
    #endregion
    #region Propriedades do XML
    [XmlElement("tpAmb")]
    public int tpAmb {
      get { return (int) _tpAmb; }
      set { _tpAmb = (TipoAmbiente)value; }
    }

    [XmlElement("cUF")]
    public int cUF {
      get { return _cUF.cUF; }
      set { _cUF = UnidadeFederativa.fromCUF(value); }
    }

    [XmlElement("xServ")]
    public string xServ {
      get { return "STATUS"; }
      set { }
    }

    [XmlAttribute("versao")]
    public string versao {
      get { return "3.10";}
      set { string v = value; }
    }
    #endregion
    #region Propriedades do usuário
    [XmlIgnore]
    public TipoAmbiente TipoAmbiente {
      get { return _tpAmb; }
      set { _tpAmb = value; }
    }

    [XmlIgnore]
    public UnidadeFederativa UnidadeFederativa {
      get { return _cUF; }
      set { _cUF = value; }
    }
    #endregion
    #region Construtores
    public ConsStatServ() {
      this._tpAmb = TipoAmbiente.Homologacao;
      this._cUF = UnidadeFederativa.SaoPaulo;
    }

    public ConsStatServ(TipoAmbiente ambiente, UnidadeFederativa cUF) {
      this._tpAmb = ambiente;
      this._cUF = cUF;
    }
    #endregion
  }
}
