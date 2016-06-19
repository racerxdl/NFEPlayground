using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class Destinatario : Entidade {
    #region Internos
    private IndIEDest _indIEDest;
    private string _ISUF;
    private string _email;
    protected string _idEstrangeiro;
    #endregion
    #region Propriedades do XML
    [XmlElement("enderDest")]
    public Endereco xml_end {
      get { return _end; }
      set { _end = value; }
    }
    [XmlElement("indIEDest")]
    public string xml_indIEDest {
      get { return _indIEDest.ToString(); }
      set { _indIEDest = (IndIEDest) int.Parse(value); }
    }
    [XmlElement("idEstrangeiro")]
    public string xml_idEstrangeiro {
      get { return _idEstrangeiro; }
      set { _idEstrangeiro = value; }
    }
    [XmlElement("ISUF")]
    public string xml_ISUF {
      get { return _ISUF; }
      set { _ISUF = value; }
    }
    [XmlElement("email")]
    public string xml_email {
      get { return xml_email; }
      set { _email = value; }
    }
    #endregion
    #region Propriedades do Usuário
    [XmlIgnore]
    public IndIEDest IndIeDest {
      get { return _indIEDest; }
      set { _indIEDest = value; }
    }
    /// <summary>
    /// Inscrição na SUFRAMA (Obrigatório nas operações com as áreas com benefícios de incentivos fiscais sob controle da SUFRAMA) PL_005d - 11/08/09 - alterado para aceitar 8 ou 9 dígitos
    /// </summary>
    [XmlIgnore]
    public string ISUF {
      get { return _ISUF; }
      set { _ISUF = value; }
    }
    /// <summary>
    /// Identificador do destinatário, em caso de comprador estrangeiro
    /// </summary>
    [XmlIgnore]
    public string IdEstrangeiro {
      get { return _idEstrangeiro; }
      set { _idEstrangeiro = value; }
    }
    /// <summary>
    /// Informar o e-mail do destinatário. O campo pode ser utilizado para informar o e-mail de recepção da NF-e indicada pelo destinatário
    /// </summary>
    [XmlIgnore]
    public string Email {
      get { return _email; }
      set { _email = value; }
    }
    #endregion
  }
}
