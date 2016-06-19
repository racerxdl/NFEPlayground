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
  public class IdeNFe {
    /*
    	<ide>
				<cUF>35</cUF>
				<cNF>00000397</cNF>
				<natOp>VENDA DE MERCADORIA</natOp>
				<indPag>1</indPag>
				<mod>55</mod>
				<serie>1</serie>
				<nNF>397</nNF>
				<dhEmi>2016-06-17T00:00:00-03:00</dhEmi>
				<dhSaiEnt>2016-06-17T00:00:00-03:00</dhSaiEnt>
				<tpNF>1</tpNF>
				<idDest>1</idDest>
				<cMunFG>3550308</cMunFG>
				<tpImp>1</tpImp>
				<tpEmis>1</tpEmis>
				<cDV>8</cDV>
				<tpAmb>1</tpAmb>
				<finNFe>1</finNFe>
				<indFinal>0</indFinal>
				<indPres>0</indPres>
				<procEmi>0</procEmi>
				<verProc>VERSAO: 3.0.0.1</verProc>
			</ide> 

    */
    #region Internos
    private UnidadeFederativa _UF;
    private int _cNF;
    private string _natOp;
    private IndPag _indPag;
    private ModeloFiscal _mod;
    private int _serie;
    private int _nNF;
    private DateTime _dhEmi;
    private DateTime _dhSaiEnt;
    private TipoNota _tpNF;
    private IdDest _idDest;
    private Municipio _municipio;
    private FormatoDANFE _tpImp;
    private FormaEmissao _tpEmis;
    private int _cDV;
    private TipoAmbiente _tpAmb;
    private Finalidade _finNFe;
    private IndicaOperacao _indFinal;
    private IndicaPresenca _indPres;
    private ProcessoEmissao _procEmi;
    private string _verProc = "VERSAO: 3.0.0.1";

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
