using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace XmlDeserialization
{
    public static class Deserialization
    {
        public static object Deserialize()
        {
            string URLString = "https://sports.ultraplay.net/sportsxml?clientKey=9C5E796D-4D54-42FD-A535-D7E77906541A&sportId=2357&days=7";


            string xmlStr;
            using (var wc = new WebClient())
            {
                xmlStr = wc.DownloadString(URLString);
            }
            var serializer = new XmlSerializer(typeof(XmlSportsDto), new XmlRootAttribute("XmlSports"));


            return (XmlSportsDto)serializer.Deserialize(new StringReader(xmlStr));
            
           
        }
    }
}
