using NFEPlayGround.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NFEPlayGround.Modelos.Tipos {
  public class XmlConvertible {
    private NFEDataSerializer serializer;
    public XmlDocument toXml() {
      if (serializer == null) {
        serializer = new NFEDataSerializer(this.GetType());
      }

      return serializer.toXml(this);
    }
  }
}
