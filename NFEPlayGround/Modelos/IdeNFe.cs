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
    private DateTime _dhCont;
    private string _xJust;
    private string _refNFe;

    #endregion
    #region Propriedades do XML
    [XmlElement("cUF")]
    public int xml_cUF {
      get { return _UF.cUF; }
      set { _UF = UnidadeFederativa.fromCUF(value); }
    }
    [XmlElement("cNF")]
    public string xml_cNF {
      get { return _cNF.ToString("00000000"); }
      set { _cNF = int.Parse(value); }
    }
    [XmlElement("natOp")]
    public string xml_natOp {
      get { return _natOp; }
      set { _natOp = value; }
    }
    [XmlElement("indPag")]
    public int xml_indPag {
      get { return (int)_indPag; }
      set { _indPag = (IndPag)value; }
    }
    [XmlElement("mod")]
    public int xml_mod {
      get { return (int)_mod; }
      set { _mod = (ModeloFiscal)value; }
    }
    [XmlElement("serie")]
    public int xml_serie {
      get { return _serie; }
      set { _serie = value; }
    }
    [XmlElement("nNF")]
    public int xml_nNF {
      get { return _nNF; }
      set { _nNF = value; }
    }
    [XmlElement("dhEmi")]
    public string xml_dhEmi {
      get { return _dhEmi.ToString("o"); }
      set { _dhEmi = DateTime.Parse(value, null, System.Globalization.DateTimeStyles.RoundtripKind); }
    }
    [XmlElement("dhSaiEnt")]
    public string xml_dhSaiEnt {
      get { return _dhSaiEnt.ToString("o"); }
      set { _dhSaiEnt = DateTime.Parse(value, null, System.Globalization.DateTimeStyles.RoundtripKind); }
    }
    [XmlElement("tpNF")]
    public int xml_tpNF {
      get { return (int)_tpNF; }
      set { _tpNF = (TipoNota)value; }
    }
    [XmlElement("idDest")]
    public int xml_idDest {
      get { return (int)_idDest; }
      set { _idDest = (IdDest)value; }
    }
    [XmlElement("cMunFG")]
    public string xml_cMunFG {
      get { return _municipio.Codigo; }
      set { _municipio = Municipio.fromCodigo(value); }
    }
    [XmlElement("tpImp")]
    public int xml_tpImp {
      get { return (int)_tpImp; }
      set { _tpImp = (FormatoDANFE)value; }
    }
    [XmlElement("tpEmis")]
    public int xml_tpEmis {
      get { return (int)_tpEmis; }
      set { _tpEmis = (FormaEmissao)value; }
    }
    [XmlElement("cDV")]
    public int xml_cDV {
      get { return _cDV; }
      set { _cDV = value; }
    }
    [XmlElement("tpAmb")]
    public int xml_tpAmb {
      get { return (int)_tpAmb; }
      set { _tpAmb = (TipoAmbiente)value; }
    }
    [XmlElement("finNFe")]
    public int xml_finNFe {
      get { return (int)_tpAmb; }
      set { _tpAmb = (TipoAmbiente)value; }
    }
    [XmlElement("indFinal")]
    public int xml_indFinal {
      get { return (int)_indFinal; }
      set { _indFinal = (IndicaOperacao)value; }
    }
    [XmlElement("indPres")]
    public int xml_indPres {
      get { return (int)_indPres; }
      set { _indPres = (IndicaPresenca)value; }
    }
    [XmlElement("procEmi")]
    public int xml_procEmi {
      get { return (int)_procEmi; }
      set { _procEmi = (ProcessoEmissao)value; }
    }
    [XmlElement("verProc")]
    public string xml_verProc {
      get { return _verProc; }
      set { _verProc = value; }
    }
    [XmlElement("dhCont")]
    public string xml_dhCont {
      get { return _dhCont.ToString("o"); }
      set { _dhCont = DateTime.Parse(value, null, System.Globalization.DateTimeStyles.RoundtripKind); ; }
    }
    [XmlElement("xJust")]
    public string xml_xJust {
      get { return _xJust; }
      set { _xJust = value; }
    }
    [XmlElement("refNFe")]
    public string xml_refNFe {
      get { return _refNFe; }
      set { _refNFe = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Código da UF do emitente do Documento Fiscal. 
    /// </summary>
    [XmlIgnore]
    public UnidadeFederativa UnidadeFederativa {
      get { return _UF; }
      set { _UF = value; }
    }
    /// <summary>
    /// Código numérico que compõe a Chave de Acesso. Número aleatório gerado pelo emitente para cada NF-e.
    /// </summary>
    [XmlIgnore]
    public int CodigoNF {
      get { return _cNF; }
      set { _cNF = value; }
    }
    /// <summary>
    /// Descrição da Natureza da Operação
    /// </summary>
    [XmlIgnore]
    public string NatOp {
      get { return _natOp; }
      set { _natOp = value; }
    }
    /// <summary>
    /// Indicador da forma de pagamento
    /// </summary>
    [XmlIgnore]
    public IndPag IndPag {
      get { return _indPag; }
      set { _indPag = value; }
    }
    /// <summary>
    /// Código do modelo do Documento Fiscal
    /// </summary>
    [XmlIgnore]
    public ModeloFiscal ModeloFiscal {
      get { return _mod; }
      set { _mod = value; }
    }
    /// <summary>
    /// Série do Documento Fiscal
    /// </summary>
    [XmlIgnore]
    public int Serie {
      get { return _serie; }
      set { _serie = value; }
    }
    /// <summary>
    /// Número do Documento Fiscal
    /// </summary>
    [XmlIgnore]
    public int NumeroNF {
      get { return _nNF; }
      set { _nNF = value; }
    }
    /// <summary>
    /// Data e Hora de emissão do Documento Fiscal
    /// </summary>
    [XmlIgnore]
    public DateTime DataEmissao {
      get { return _dhEmi; }
      set { _dhEmi = value; }
    }
    /// <summary>
    /// Data e Hora da saída ou de entrada da mercadoria
    /// </summary>
    [XmlIgnore]
    public DateTime DataSaidaEntrada {
      get { return _dhSaiEnt; }
      set { _dhSaiEnt = value; }
    }
    /// <summary>
    /// Tipo do Documento
    /// </summary>
    [XmlIgnore]
    public TipoNota TipoNota {
      get { return _tpNF; }
      set { _tpNF = value; }
    }
    /// <summary>
    /// Identificador de Local de destino da Operação
    /// </summary>
    [XmlIgnore]
    public IdDest IdDest {
      get { return _idDest; }
      set { _idDest = value; }
    }
    /// <summary>
    /// Município de Ocorrência do Fato Gerador
    /// </summary>
    [XmlIgnore]
    public Municipio Municipio {
      get { return _municipio; }
      set { _municipio = value; }
    }
    /// <summary>
    /// Formato de impressão do DANFE
    /// </summary>
    [XmlIgnore]
    public FormatoDANFE FormatoDANFE {
      get { return _tpImp; }
      set { _tpImp = value; }
    }
    /// <summary>
    /// Forma de emissão da NF-e
    /// </summary>
    [XmlIgnore]
    public FormaEmissao FormaEmissao {
      get { return _tpEmis; }
      set { _tpEmis = value; }
    }
    /// <summary>
    /// Digito Verificador da Chave de Acesso da NF-e
    /// </summary>
    [XmlIgnore]
    public int DigitoVerificador {
      get { return _cDV; }
      set { _cDV = value; }
    }
    /// <summary>
    /// Identificação do Ambiente
    /// </summary>
    [XmlIgnore]
    public TipoAmbiente TipoAmbiente {
      get { return _tpAmb; }
      set { _tpAmb = value; }
    }
    /// <summary>
    /// Finalidade da emissão da NF-e
    /// </summary>
    [XmlIgnore]
    public Finalidade Finalidade {
      get { return _finNFe; }
      set { _finNFe = value; }
    }
    /// <summary>
    /// Indica operação com consumidor final
    /// </summary>
    [XmlIgnore]
    public IndicaOperacao Operacao {
      get { return _indFinal; }
      set { _indFinal = value; }
    }
    /// <summary>
    /// Indicador de presença do comprador no estabelecimento comercial no momento da operação
    /// </summary>
    [XmlIgnore]
    public IndicaPresenca Presenca {
      get { return _indPres; }
      set { _indPres = value; }
    }
    /// <summary>
    /// Processo de emissão
    /// </summary>
    [XmlIgnore]
    public ProcessoEmissao ProcessoEmissao {
      get { return _procEmi; }
      set { _procEmi = value; }
    }
    /// <summary>
    /// Versão do aplicativo utilizado no processo de emissão
    /// </summary>
    [XmlIgnore]
    public string VersaoDoProcesso {
      get { return _verProc; }
      set { _verProc = value; }
    }
    /// <summary>
    /// Data e hora de entrada em contingência
    /// <para>Obs: Informar apenas para tpEmis diferente de 1</para>
    /// </summary>
    [XmlIgnore]
    public DateTime DataContigencia {
      get { return _dhCont; }
      set { _dhCont = value; }
    }
    /// <summary>
    /// Justificativa da entrada
    /// <para>Obs: Informar apenas para tpEmis diferente de 1</para>
    /// </summary>
    [XmlIgnore]
    public string JustificativaEntrada {
      get { return _xJust; }
      set { _xJust = value; }
    }
    /// <summary>
    /// Chave de acesso das NF-e referenciadas. Chave de acesso compostas por Código da UF (tabela do IBGE) + AAMM da emissão + CNPJ do Emitente + modelo, série e número da NF-e Referenciada + Código Numérico + DV
    /// <para>Obs: Informar apenas para tpEmis diferente de 1</para>
    /// </summary>
    [XmlIgnore]
    public string ReferenciaNFE {
      get { return _refNFe; }
      set { _refNFe = value; }
    }
    #endregion
    #region Construtores
    public IdeNFe() {

    }
    #endregion
  }
}
