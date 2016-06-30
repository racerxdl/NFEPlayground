using NFEPlayGround.Atributos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace NFEPlayGround.Tools {
  public class NFEDataSerializer {
    private string rootName;
    private XmlSerializer serializer;
    private string xmlns;
    private XmlSerializerNamespaces ns;
    //private Type[] includeTypes;

    public NFEDataSerializer(Type dataType) {
      NFEDataAttribute nfeData = (NFEDataAttribute) dataType.GetCustomAttribute(typeof(NFEDataAttribute));
      if (nfeData == null) {
        throw new NotNFEDataType("O tipo " + dataType.Name + " não contém o atributo NFEData!");
      }

      //Type[] includeTypes = ((XmlIncludeAttribute[])dataType.GetCustomAttributes(typeof(XmlIncludeAttribute))).Select(a => a.Type).ToArray();
      //includeTypes = lookForTypes(dataType);
      
      rootName = dataType.Name[0].ToString().ToLower() + dataType.Name.Substring(1);
      xmlns = nfeData.XmlNamespace;

      ns = new XmlSerializerNamespaces();
      ns.Add(string.Empty, xmlns);

      XmlRootAttribute xra = new XmlRootAttribute(rootName);
      xra.Namespace = xmlns;

      serializer = new XmlSerializer(dataType, null, null, xra, xmlns);
    }

    private static Type[] lookForTypes(Type t) {
      List<Type> types = new List<Type>();

      types.AddRange(getXmlIncludeAttributes(t));

      t.GetProperties().Where(a => Attribute.IsDefined(a, typeof(XmlElementAttribute))).ToList().ForEach(p => {
        types.AddRange(lookForTypes(p.GetType()));
      });

      return types.ToArray();
    }

    private static List<Type> getXmlIncludeAttributes(Type t) {
      return ((XmlIncludeAttribute[])t.GetCustomAttributes(typeof(XmlIncludeAttribute))).Select(a => a.Type).ToList();
    }

    public void Serialize(Stream stream, object o) {
      Serialize(stream, o, false);
    }

    public void Serialize(Stream stream, object o, bool indent) {
      XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = indent });
      serializer.Serialize(writer, o, ns);
    }

    public XmlDocument toXml(object o) {
      XmlDocument document = new XmlDocument();
      var nav = document.CreateNavigator();

      if (nav != null) {
        using (XmlWriter writer = nav.AppendChild()) {
          serializer.Serialize(writer, o, ns);
        }
      }

      return document;
    }

    public class NotNFEDataType : Exception {
      public NotNFEDataType(string message) : base(message) {}
    }
  }
}
