using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFEPlayGround.Atributos {
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class NFEDataAttribute : Attribute {
    private string xmlns = "http://www.portalfiscal.inf.br/nfe";

    public NFEDataAttribute() {
    }

    public NFEDataAttribute(string xmlns) {
      this.xmlns = xmlns;
    }

    public string XmlNamespace {
      get { return xmlns; }
    }
  }
}
