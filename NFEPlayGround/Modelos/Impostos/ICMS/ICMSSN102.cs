using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos.Impostos.ICMS {
  /// <summary>
  /// Tributação do ICMS pelo SIMPLES NACIONAL e CSOSN=102, 103, 300 ou 400 (v.2.0))
  /// </summary>
  [NFEData, Serializable]
  public class ICMSSN102 {
    #region Internos
    private Origem _orig;
    private string _CSOSN = "102";
    #endregion
    #region Propriedades do XML
    [XmlElement("orig")]
    public int xml_orig {
      get { return (int)_orig; }
      set { _orig = (Origem)value; }
    }
    [XmlElement("CSOSN")]
    public string xml_CSOSN {
      get { return _CSOSN; }
      set { _CSOSN = value; }
    }
    #endregion
    #region Propriedades do usuario
    /// <summary>
    /// Origem da Mercadoria
    /// </summary>
    [XmlIgnore]
    public Origem Origem {
      get { return _orig; }
      set { _orig = value; }
    }
    /// <summary>
    /// <para>102- Tributada pelo Simples Nacional sem permissão de crédito.</summary>para>
    /// <para>103 – Isenção do ICMS no Simples Nacional para faixa de receita bruta.</para>
    /// <para>300 – Imune.</para>
    /// <para>400 – Não tributada pelo Simples Nacional</para>
    /// </summary>
    [XmlIgnore]
    public string CSOSN {
      get { return _CSOSN; }
      set { _CSOSN = value; }
    }
    #endregion
    #region Construtores
    public ICMSSN102() {

    }
    #endregion
  }
}
