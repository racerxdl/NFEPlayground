using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class ProdNFe {
    #region Internos
    private string _cProd;
    private string _cEAN;
    private string _xProd;
    private int _ncm;
    private string _nve;
    private string _extipi;
    private int _cfop;
    private string _uCom;
    private decimal _qCom;    //11i, 4d
    private decimal _vUnCom;  //11i, 10d
    private decimal _vProd;    //13i, 2d
    private string _cEANTrib;
    private string _uTrib;
    private decimal _qTrib;   // 11i, 4d
    private decimal _vUnTrib; // 11i, 10d
    private decimal _vFrete;  // 13i, 2d
    private decimal _vSeg;    // 13i, 2d
    private decimal _vDesc;   // 13i, 2d
    private decimal _vOutro;  // 13i, 2d
    private IndTot _indTot;
    private DINFe _nDi;               //TODO
    private DetExportNFe _detExport;  //TODO
    private string _xPed;
    private int _nItemPed;
    #endregion
    #region Propriedades do XML
    [XmlElement("cProd")]
    public string xml_cProd {
      get { return _cProd; }
      set { _cProd = value; }
    }
    [XmlElement("cEAN")]
    public string xml_cEAN {
      get { return _cEAN; }
      set { _cEAN = value; }
    }
    [XmlElement("xProd")]
    public string xml_xProd {
      get { return _xProd; }
      set { _xProd = value; }
    }
    [XmlElement("ncm")]
    public string xml_ncm {
      get { return _ncm == 0 ? _ncm.ToString("00") : _ncm.ToString("00000000"); }
      set { _ncm = int.Parse(value); }
    }
    [XmlElement("nve")]
    public string xml_nve {
      get { return _nve; }
      set { _nve = value; }
    }
    [XmlElement("extipi")]
    public string xml_extipi {
      get { return _extipi; }
      set { _extipi = value; }
    }
    [XmlElement("cfop")]
    public int xml_cfop {
      get { return _cfop; }
      set { _cfop = value; }
    }
    [XmlElement("uCom")]
    public string xml_uCom {
      get { return _uCom; }
      set { _uCom = value; }
    }
    [XmlElement("qCom")]
    public string xml_qCom {
      get { return TextTools.Dec2Str(_qCom, 4); }
      set { _qCom = TextTools.Str2Dec(value); }
    }
    [XmlElement("vUnCom")]
    public string xml_vUnCom {
      get { return TextTools.Dec2Str(_vUnCom, 10); }
      set { _vUnCom = TextTools.Str2Dec(value); }
    }
    [XmlElement("vProd")]
    public string xml_vProd {
      get { return TextTools.Dec2Str(_vProd, 2); }
      set { _vProd = TextTools.Str2Dec(value); }
    }
    [XmlElement("cEANTrib")]
    public string xml_cEANTrib {
      get { return _cEANTrib; }
      set { _cEANTrib = value; }
    }
    [XmlElement("uTrib")]
    public string xml_uTrib {
      get { return _uTrib; }
      set { _uTrib = value; }
    }
    [XmlElement("qTrib")]
    public string xml_qTrib {
      get { return TextTools.Dec2Str(_qTrib, 4); }
      set { _qTrib = TextTools.Str2Dec(value); }
    }
    [XmlElement("vUnTrib")]
    public string xml_vUnTrib {
      get { return TextTools.Dec2Str(_vUnTrib, 10); }
      set { _vUnTrib = TextTools.Str2Dec(value); }
    }
    [XmlElement("vFrete")]
    public string xml_vFrete {
      get { return TextTools.Dec2Str(_vFrete, 2); }
      set { _vFrete= TextTools.Str2Dec(value); }
    }
    [XmlElement("vSeg")]
    public string xml_vSeg {
      get { return TextTools.Dec2Str(_vSeg, 2); }
      set { _vSeg = TextTools.Str2Dec(value); }
    }
    [XmlElement("vDesc")]
    public string xml_vDesc {
      get { return TextTools.Dec2Str(_vDesc, 2); }
      set { _vDesc = TextTools.Str2Dec(value); }
    }
    [XmlElement("vOutro")]
    public string xml_vOutro {
      get { return TextTools.Dec2Str(_vOutro, 2); }
      set { _vOutro = TextTools.Str2Dec(value); }
    }
    [XmlElement("indTot")]
    public int xml_indTot {
      get { return (int)_indTot; }
      set { _indTot = (IndTot)(value); }
    }
    [XmlElement("nDI")]
    public DINFe xml_nDI {
      get { return _nDi; }
      set { _nDi = value; }
    }
    [XmlElement("detExport")]
    public DetExportNFe xml_detExport {
      get { return _detExport; }
      set { _detExport = value; }
    }
    [XmlElement("xPed")]
    public string xml_xPed {
      get { return _xPed; }
      set { _xPed = value; }
    }
    [XmlElement("nItemPed")]
    public int xml_nItemPed {
      get { return _nItemPed; }
      set { _nItemPed = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Código do produto ou serviço. Preencher com CFOP caso se trate de itens não relacionados com mercadorias/produto e que o contribuinte não possua codificação própria Formato  "CFOP9999"
    /// </summary>
    [XmlIgnore]
    public string CodigoProduto {
      get { return _cProd; }
      set { _cProd = value; }
    }
    /// <summary>
    /// GTIN (Global Trade Item Number) do produto, antigo código EAN ou código de barras
    /// </summary>
    [XmlIgnore]
    public string CodigoEAN {
      get { return _cEAN; }
      set { _cEAN = value; }
    }
    /// <summary>
    /// Descrição do produto ou serviço
    /// </summary>
    [XmlIgnore]
    public string DescricaoProduto {
      get { return _xProd; }
      set { _xProd = value; }
    }
    /// <summary>
    /// Código NCM (8 posições), será permitida a informação do gênero (posição do capítulo do NCM) quando a operação não for de comércio exterior (importação/exportação) ou o produto não seja tributado pelo IPI. Em caso de item de serviço ou item que não tenham produto (Ex. transferência de crédito, crédito do ativo imobilizado, etc.), informar o código 00 (zeros) (v2.0)
    /// </summary>
    [XmlIgnore]
    public int NCM {
      get { return _ncm; }
      set { _ncm = value; }
    }
    /// <summary>
    /// Nomenclatura de Valor aduaneio e Estatístico
    /// </summary>
    [XmlIgnore]
    public string NVE {
      get { return _nve; }
      set { _nve = value; }
    }
    /// <summary>
    /// Código EX TIPI (3 posições)
    /// </summary>
    [XmlIgnore]
    public string EXTIPI {
      get { return _extipi; }
      set { _extipi = value; }
    }
    /// <summary>
    /// Código Fiscal de Operações e Prestações
    /// </summary>
    [XmlIgnore]
    public int CFOP {
      get { return _cfop; }
      set { _cfop = value; }
    }
    /// <summary>
    /// Unidade comercial
    /// </summary>
    [XmlIgnore]
    public string UnidadeComercial {
      get { return _uCom; }
      set { _uCom = value; }
    }
    /// <summary>
    /// Quantidade Comercial  do produto, alterado para aceitar de 0 a 4 casas decimais e 11 inteiros.
    /// </summary>
    [XmlIgnore]
    public decimal QuantidadeComercial {
      get { return _qCom; }
      set { _qCom = value; }
    }
    /// <summary>
    /// Valor unitário de comercialização  - alterado para aceitar 0 a 10 casas decimais e 11 inteiros
    /// </summary>
    [XmlIgnore]
    public decimal ValorUnitarioComercial {
      get { return _vUnCom; }
      set { _vUnCom = value; }
    }
    /// <summary>
    /// Valor bruto do produto ou serviço.
    /// </summary>
    [XmlIgnore]
    public decimal Valor {
      get { return _vProd; }
      set { _vProd = value; }
    }
    /// <summary>
    /// GTIN (Global Trade Item Number) da unidade tributável, antigo código EAN ou código de barras
    /// </summary>
    [XmlIgnore]
    public string EANTributavel {
      get { return _cEANTrib; }
      set { _cEANTrib = value; }
    }
    /// <summary>
    /// Unidade Tributável
    /// </summary>
    [XmlIgnore]
    public string UnidadeTributavel {
      get { return _uTrib; }
      set { _uTrib = value; }
    }
    /// <summary>
    /// Quantidade Tributável - alterado para aceitar de 0 a 4 casas decimais e 11 inteiros
    /// </summary>
    [XmlIgnore]
    public decimal QuantidadeTributavel {
      get { return _qTrib; }
      set { _qTrib = value; }
    }
    /// <summary>
    /// Valor unitário de tributação - - alterado para aceitar 0 a 10 casas decimais e 11 inteiros
    /// </summary>
    [XmlIgnore]
    public decimal ValorUnitarioTributavel {
      get { return _vUnTrib; }
      set { _vUnTrib = value; }
    }
    /// <summary>
    /// Valor Total do Frete
    /// </summary>
    [XmlIgnore]
    public decimal ValorFrete {
      get { return _vFrete; }
      set { _vFrete = value; }
    }
    /// <summary>
    /// Valor Total do Seguro
    /// </summary>
    [XmlIgnore]
    public decimal ValorSeguro {
      get { return _vSeg; }
      set { _vSeg = value; }
    }
    /// <summary>
    /// Valor do Desconto
    /// </summary>
    [XmlIgnore]
    public decimal ValorDesconto {
      get { return _vDesc; }
      set { _vDesc = value; }
    }
    /// <summary>
    /// Outras despesas acessórias
    /// </summary>
    [XmlIgnore]
    public decimal ValorOutros {
      get { return _vOutro; }
      set { _vOutro = value; }
    }
    /// <summary>
    /// Se o valor deste item compoe o valor total da nota.
    /// </summary>
    [XmlIgnore]
    public IndTot CompoeValor {
      get { return _indTot; }
      set { _indTot = value; }
    }
    /// <summary>
    /// Declaração de Importação (NT 2011/004)
    /// </summary>
    [XmlIgnore]
    public DINFe DeclaracaoImportacao {
      get { return _nDi; }
      set { _nDi = value; }
    }
    /// <summary>
    /// Detalhe da exportação
    /// </summary>
    [XmlIgnore]
    public DetExportNFe DetalheExportacao {
      get { return _detExport; }
      set { _detExport = value; }
    }
    /// <summary>
    /// Pedido de compra - Informação de interesse do emissor para controle do B2B.
    /// </summary>
    [XmlIgnore]
    public string PedidoCompra {
      get { return _xPed; }
      set { _xPed = value; }
    }
    /// <summary>
    /// Número do Item do Pedido de Compra - Identificação do número do item do pedido de Compra
    /// </summary>
    [XmlIgnore]
    public int NumeroItemPedidoCompra {
      get { return _nItemPed; }
      set { _nItemPed = value; }
    }
    #endregion
    #region Construtores
    public ProdNFe() {

    }
    #endregion
  }
}
