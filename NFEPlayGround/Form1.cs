using NFEPlayGround.Modelos;
using NFEPlayGround.Modelos.Tipos;
using NFEPlayGround.Servicos;
using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NFEPlayGround {
  public partial class Form1 : Form {
    public Form1() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      /*
      XmlReaderSettings nfeSettings = new XmlReaderSettings();
      //nfeSettings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", "schemas/procNFE_v3.10.xsd");
      nfeSettings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", "schemas/consStatServ_v3.10.xsd");
      nfeSettings.ValidationType = ValidationType.Schema;
      nfeSettings.ValidationEventHandler += new ValidationEventHandler(nfeSettingsValidationEventHandler);

      XmlReader nfe = XmlTextReader.Create(new System.IO.StringReader(TestXML.statusServico), nfeSettings);
      //XmlReader nfe = XmlReader.Create("non-valid.xml", nfeSettings);
      while (nfe.Read()) { }
      */
      InfNFe t = new InfNFe();

      FileStream f = new FileStream("x.xml", FileMode.Create);
      NFEDataSerializer s = new NFEDataSerializer(typeof(InfNFe));
      s.Serialize(f, t);
      f.Close();
    }

    private void nfeSettingsValidationEventHandler(object sender, ValidationEventArgs e) {
      if (e.Severity == XmlSeverityType.Warning) {
        Console.Write("WARNING: ");
        Console.WriteLine(e.Message);
      } else if (e.Severity == XmlSeverityType.Error) {
        Console.Write("ERROR: ");
        Console.WriteLine(e.Message);
      }
    }

    private void soapTest() {
      X509Store store = new X509Store("My", StoreLocation.CurrentUser);
      store.Open(OpenFlags.ReadOnly);
      X509Certificate2Collection certificates = store.Certificates.Find(X509FindType.FindBySerialNumber, "79B3C9920D2A6289", true);
      NFEStatus statusService = new NFEStatus(this, certificates[0]);

      statusService.checkStatus((status) => {
        textBox1.AppendText("Status: " + status.ToString() + "\n");
      });
      /*
      NFESoapWebRequest request = new NFESoapWebRequest(this, @"https://homologacao.nfe.fazenda.sp.gov.br/ws/nfestatusservico2.asmx?op=nfeStatusServicoNF2", certificates[0]);

      request.OnResponse += (sender, e) => {
        if (e.StatusCode == HttpStatusCode.OK) {
          var x = e.Response.GetElementsByTagName("soap:Body")[0];
          MemoryStream mStream = new MemoryStream();
          XmlTextWriter writer = new XmlTextWriter(mStream, Encoding.Unicode);
          writer.Formatting = Formatting.Indented;

          x.WriteContentTo(writer);
          writer.Flush();
          mStream.Flush();
          mStream.Position = 0;

          StreamReader sReader = new StreamReader(mStream);
          textBox1.Text = sReader.ReadToEnd();
        }
      };

      ConsStatServ c = new ConsStatServ();
      c.UnidadeFederativa = UnidadeFederativa.SaoPaulo;
      c.TipoAmbiente = TipoAmbiente.Homologacao;

      NFEDataSerializer serializer = new NFEDataSerializer(typeof(ConsStatServ));
      XmlDocument xm = serializer.toXml(c);

      request.run("http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", UnidadeFederativa.SaoPaulo, "3.10", xm);*/
    }

    private void button2_Click(object sender, EventArgs e) {
      soapTest();
    }
  }
}