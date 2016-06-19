using NFEPlayGround.Modelos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static NFEPlayGround.Tools.NFESoapWebRequest;

namespace NFEPlayGround.Servicos {
  public class NFEStatus {
    private static readonly string urlServico = @"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico2.asmx?op=nfeStatusServicoNF2";
    private static readonly string xmlnsServico = @"http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2";
    private static readonly string versaoServico = "3.10";

    private NFESoapWebRequest request;
    private Action<Status> currentCallback;

    public NFEStatus(ISynchronizeInvoke target, X509Certificate certificado) {
      request = new NFESoapWebRequest(target, urlServico, certificado);
      request.OnResponse += new EventHandler<SoapWebRequestResponseEventArgs>(onResponseCallback);
    }

    public void checkStatus(Action<Status> callback) {
      ConsStatServ c = new ConsStatServ(Global.TipoAmbiente, Global.UFServidor);
      currentCallback = callback;
      request.run(xmlnsServico, Global.UFServidor, versaoServico, c.toXml());
    }

    private void onResponseCallback(object sender, SoapWebRequestResponseEventArgs e) {
      if (e.StatusCode == HttpStatusCode.OK) {
        var bodyData = e.Response.GetElementsByTagName("cStat")[0];
        if (currentCallback != null) {
          int cStat = int.Parse(bodyData.InnerText);
          switch (cStat) {
            case (int)CStat.OK:
              currentCallback(Status.ONLINE);
              break;
            default:
              currentCallback(Status.OFFLINE);
              break;
          }
        }
      } else {
        if (currentCallback != null) {
          currentCallback(Status.OFFLINE);
        }
      }
    }

    public enum Status {
      OFFLINE,
      ONLINE
    }
  }
}
