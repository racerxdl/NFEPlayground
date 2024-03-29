﻿using NFEPlayGround.Atributos;
using NFEPlayGround.Modelos.Tipos;
using System;
using System.Xml.Serialization;

namespace NFEPlayGround.Modelos {
  [NFEData, Serializable]
  public class Endereco: XmlConvertible {
    #region Internos
    private string _xLgr;
    private string _nro;
    private string _xBairro;
    private Municipio _municipio;
    private UnidadeFederativa _UF;
    private string _CEP;
    private Pais _pais;
    private string _fone;
    #endregion
    #region Propriedades do XML
    [XmlElement("xLgr")]
    public string xml_xLgr {
      get { return _xLgr; }
      set { _xLgr = value; }
    }
    [XmlElement("nro")]
    public string xml_nro {
      get { return _nro; }
      set { _nro = value; }
    }
    [XmlElement("xBairro")]
    public string xml_xBairro {
      get { return _xBairro; }
      set { _xBairro = value; }
    }
    [XmlElement("cMun")]
    public string xml_cMun {
      get { return _municipio.Codigo; }
      set { _municipio = Municipio.fromCodigo(value); }
    }
    [XmlElement("xMun")]
    public string xml_xMun {
      get { return _municipio.Nome; }
      set { _municipio = Municipio.fromNome(value); }
    }
    [XmlElement("UF")]
    public string xml_UF {
      get { return _UF.UF; }
      set { _UF = UnidadeFederativa.fromUF(value); }
    }
    [XmlElement("CEP")]
    public string xml_CEP {
      get { return _CEP; }
      set { _CEP = value; }
    }
    [XmlElement("cPais")]
    public string xml_cPais {
      get { return _pais.Codigo; }
      set { _pais = Pais.fromCodigo(value); }
    }
    [XmlElement("xPais")]
    public string xml_xPais {
      get { return _pais.Nome; }
      set { _pais = Pais.fromNome(value); }
    }
    [XmlElement("fone")]
    public string xml_fone {
      get { return _fone; }
      set { _fone = value; }
    }
    #endregion
    #region Propriedades do Usuário
    [XmlIgnore]
    public string Logradouro {
      get { return _xLgr; }
      set { _xLgr = value; }
    }
    [XmlIgnore]
    public string Numero {
      get { return _nro; }
      set { _nro = value; }
    }
    [XmlIgnore]
    public string Bairro {
      get { return _xBairro; }
      set { _xBairro = value; }
    }
    [XmlIgnore]
    public Municipio Municipio {
      get { return _municipio; }
      set { _municipio = value; }
    }
    [XmlIgnore]
    public UnidadeFederativa UnidadeFederativa {
      get { return _UF; }
      set { _UF = value; }
    }
    [XmlIgnore]
    public string CEP {
      get { return _CEP; }
      set { _CEP = value; }
    }
    [XmlIgnore]
    public Pais Pais {
      get { return _pais; }
      set { _pais = value; }
    }
    [XmlIgnore]
    public string Telefone {
      get { return _fone; }
      set { _fone = value; }
    }
    #endregion
    #region Construtores
    public Endereco() {

    }
    #endregion
  }
}
