using NFEPlayGround.Modelos;
using NFEPlayGround.Tools;
using System;
using System.ComponentModel;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using static NFEPlayGround.Tools.NFESoapWebRequest;

namespace NFEPlayGround.Servicos {
  public class NFEConsulta {
    private static readonly string urlServico = @"https://nfe.fazenda.sp.gov.br/ws/nfeconsulta2.asmx?op=nfeConsultaNF2";
    private static readonly string xmlnsServico = @"http://www.portalfiscal.inf.br/nfe/wsdl/NfeConsulta2";
    private static readonly string versaoServico = "3.10";

    private NFESoapWebRequest request;
    private Action<XmlDocument> currentCallback;

    public NFEConsulta(ISynchronizeInvoke target, X509Certificate certificado) {
      request = new NFESoapWebRequest(target, urlServico, certificado);
      request.OnResponse += new EventHandler<SoapWebRequestResponseEventArgs>(onResponseCallback);
    }

    public void getNFe(string codigoNfe, Action<XmlDocument> callback) {
      ConsSitNFe c = new ConsSitNFe(Global.TipoAmbiente, codigoNfe);
      currentCallback = callback;
      request.run(xmlnsServico, Global.UFServidor, versaoServico, c.toXml());
    }

    private void onResponseCallback(object sender, SoapWebRequestResponseEventArgs e) {
      if (e.StatusCode == HttpStatusCode.OK) {
        var bodyData = e.Response.GetElementsByTagName("retConsSitNFe")[0];
        if (currentCallback != null) {
          XmlDocument doc = new XmlDocument();
          doc.AppendChild(doc.ImportNode(bodyData, true));
          currentCallback(doc);
        }
      } else {
        if (currentCallback != null) {
          currentCallback(null);
        }
      }
    }
  }
}
