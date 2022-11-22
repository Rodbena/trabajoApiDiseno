using System.Xml;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclient cliente = new Myclient(new ImovilXMLAdapter(), new IcompuJSONAdapter());
            XmlDocument xml = cliente.GetCompuData();

            XmlNodeList lista = xml.GetElementsByTagName("Computadoras");
            XmlNodeList moviles = ((XmlElement)lista[0]).GetElementsByTagName("Apple");

            foreach (System.Xml.XmlElement xEle in moviles)
            {
                Console.WriteLine(xEle.OuterXml);
            }
        }
    }
}