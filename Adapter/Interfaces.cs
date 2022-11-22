using System.Xml;

namespace Adapter
{
    interface ImovilJSONOrigin
    {
        String GetComputadorasXMLSpecifications();
    }
    interface ImovilXMLTarget
    {
        XmlDocument GetComputadorasXMLSpecifications(ImovilJSONOrigin movilJSONAdapter);
    }

    interface ImovilMP3Target
    {
        XmlDocument GetComputadorasXMLSpecifications(ImovilJSONOrigin movilJSONAdapter);
    }

}