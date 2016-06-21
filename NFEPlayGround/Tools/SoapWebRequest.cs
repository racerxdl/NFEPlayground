using NFEPlayGround.Modelos.Tipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NFEPlayGround.Tools {
  public class NFESoapWebRequest {
    private HttpWebRequest webRequest;
    private ISynchronizeInvoke target;
    public event EventHandler<SoapWebRequestResponseEventArgs> OnResponse;

    public NFESoapWebRequest(ISynchronizeInvoke target, string url, X509Certificate clientCertificate) {
      webRequest = (HttpWebRequest)WebRequest.Create(url);
      webRequest.ContentType = "text/xml;charset=\"utf-8\"";
      webRequest.Accept = "text/xml";
      webRequest.Method = "POST";
      webRequest.ClientCertificates.Add(clientCertificate);
      this.target = target;
    }

    public void run(string xmlns, UnidadeFederativa uf, string versao, XmlDocument body) {
      BackgroundWorker bw = new BackgroundWorker();
      bw.DoWork += new DoWorkEventHandler(
        delegate (object o, DoWorkEventArgs args) {
          XmlDocument soapEnvelopeXml = SoapXmlBuilder.buildSoapXml(xmlns, uf, versao, body);
          StringBuilder sb = new StringBuilder();
          XmlWriter tw = XmlWriter.Create(sb, new XmlWriterSettings() { Indent = true });
          soapEnvelopeXml.Save(tw);
          Console.WriteLine("Sending: " + sb.ToString());

          using (Stream stream = webRequest.GetRequestStream()) {
            XmlTextWriter wr = new XmlTextWriter(stream, Encoding.UTF8);
            soapEnvelopeXml.Save(wr);
            wr.Close();
          }

          try {
            using (HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse()) {
              using (StreamReader rd = new StreamReader(response.GetResponseStream())) {
                string soapResult = rd.ReadToEnd();
                XmlDocument document = new XmlDocument();
                document.LoadXml(soapResult);
                onResponse(response.StatusCode, document);
                Console.WriteLine("onResponse({0}): {1}", response.StatusCode.ToString(), soapResult);
              }
            }
          } catch (WebException e) {
            Console.WriteLine("WebException: " + e.Message);
            using (StreamReader rd = new StreamReader(e.Response.GetResponseStream())) {
              if (e.Response.ContentType.Equals("text/xml")) {
                string soapResult = rd.ReadToEnd();
                XmlDocument document = new XmlDocument();
                document.LoadXml(soapResult);
                onResponse(((HttpWebResponse)e.Response).StatusCode, document);
              }
            }
          }
        }
      );

      bw.RunWorkerAsync();
    }

    private void onResponse(HttpStatusCode statusCode, XmlDocument response) {
      if (OnResponse != null) {
        var eventListeners = OnResponse.GetInvocationList();
        for (int index = 0; index < eventListeners.Count(); index++) {
          var methodToInvoke = (EventHandler<SoapWebRequestResponseEventArgs>)eventListeners[index];
          if (target.InvokeRequired) {
            target.Invoke(new callMethodDelegate(callMethod), new object[] { methodToInvoke, new SoapWebRequestResponseEventArgs(statusCode, response) });
          } else {
            callMethod(methodToInvoke, new SoapWebRequestResponseEventArgs(statusCode, response));
          }
        }
      }
    }

    private delegate void callMethodDelegate(EventHandler<SoapWebRequestResponseEventArgs> eventHandler, SoapWebRequestResponseEventArgs eventArgs);

    private void callMethod(EventHandler<SoapWebRequestResponseEventArgs> eventHandler, SoapWebRequestResponseEventArgs eventArgs) {
      eventHandler.Invoke(eventHandler, eventArgs);
    }

    private void EndAsyncEvent(IAsyncResult iar) {
      var ar = (System.Runtime.Remoting.Messaging.AsyncResult)iar;
      var invokedMethod = (EventHandler<SoapWebRequestResponseEventArgs>)ar.AsyncDelegate;

      try {
        invokedMethod.EndInvoke(iar);
      } catch (Exception e) {
        Console.WriteLine("Error handling callback OnResponse: " + e.Message);
      }
    }

    public class SoapWebRequestResponseEventArgs : EventArgs {
      private readonly XmlDocument _response;
      private readonly HttpStatusCode _statusCode;

      public SoapWebRequestResponseEventArgs(HttpStatusCode statusCode, XmlDocument response) {
        _response = response;
        _statusCode = statusCode;
      }

      public XmlDocument Response {
        get { return _response; }
      }

      public HttpStatusCode StatusCode {
        get { return _statusCode; }
      }
    }

  }
}
