using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    class IcompuJSONAdapter : ImovilJSONOrigin
    {
        public string GetComputadorasXMLSpecifications()
        {
            List<Compu> computadoras = new List<Compu>();
            computadoras.Add(new Compu
            {
                modelo = "Windows",
                costo = 345.00
            });
            computadoras.Add(new Compu
            {
                modelo = "Apple",
                costo = 345.00
            });
            dynamic collectionComputadoras = new { Apple = computadoras };
            return JsonConvert.SerializeObject(collectionComputadoras);

        }
    }
    class ImovilXMLAdapter : ImovilXMLTarget
    {
        public XmlDocument GetComputadorasXMLSpecifications(ImovilJSONOrigin movilJSONAdapter)
        {
            string jsonMovil = movilJSONAdapter.GetComputadorasXMLSpecifications();
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonMovil, "Computadoras", true);
            return doc;
        }
    }
}