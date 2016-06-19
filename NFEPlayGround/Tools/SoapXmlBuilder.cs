using NFEPlayGround.Modelos.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NFEPlayGround.Tools {
  public static class SoapXmlBuilder {
    /*
     *         <nfeCabecMsg xmlns=""http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2"">
          <cUF>35</cUF>
          <versaoDados>3.10</versaoDados>
        </nfeCabecMsg>
        */
    /*
     *           <nfeDadosMsg xmlns=""http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2"">
        {0}
      </nfeDadosMsg>
      */
    private static readonly string soapTemplate = @"<?xml version=""1.0"" encoding=""utf-8"" ?><soap12:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap12=""http://www.w3.org/2003/05/soap-envelope""><soap12:Header></soap12:Header><soap12:Body></soap12:Body></soap12:Envelope>";

    public static XmlDocument buildSoapXml(string opxmlns, UnidadeFederativa uf, string versao, XmlDocument bodyData) {
      XmlDocument doc = new XmlDocument();
      doc.LoadXml(soapTemplate);
      XmlNode header = doc.GetElementsByTagName("soap12:Header")[0];
      XmlNode body = doc.GetElementsByTagName("soap12:Body")[0];

      // Criar Header
      var nfeCabecMsg = doc.CreateElement("nfeCabecMsg", opxmlns);

      var cUFElement = doc.CreateElement("cUF", nfeCabecMsg.NamespaceURI);
      cUFElement.InnerText = uf.cUF.ToString();
      nfeCabecMsg.AppendChild(cUFElement);
      var versaoElement = doc.CreateElement("versaoDados", nfeCabecMsg.NamespaceURI);
      versaoElement.InnerText = versao;
      nfeCabecMsg.AppendChild(versaoElement);

      header.AppendChild(nfeCabecMsg);

      // Criar Corpo
      var nfeDadosMsg = doc.CreateElement("nfeDadosMsg", opxmlns);
      nfeDadosMsg.AppendChild(doc.ImportNode(bodyData.FirstChild, true));
      body.AppendChild(nfeDadosMsg);

      return doc;
    }
  }
}
