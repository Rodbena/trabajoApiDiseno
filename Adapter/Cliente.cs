using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    class Myclient
    {
        private ImovilXMLTarget _compuXmlTarget;
        private ImovilJSONOrigin _compuJSONOrigin;

        public Myclient(ImovilXMLTarget compuXmlTarget, ImovilJSONOrigin movilJSONOrigin)
        {
            _compuXmlTarget = movilXmlTarget;
            _compuJSONOrigin = movilJSONOrigin;
        }

        public XmlDocument GetCompuData()
        {
            return _compuXmlTarget.GetComputadorasXMLSpecifications(_compuJSONOrigin);
        }
    }
}