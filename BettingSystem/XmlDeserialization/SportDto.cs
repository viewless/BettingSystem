using System.Xml.Serialization;

namespace XmlDeserialization
{
    [XmlType("Sport")]
    public class SportDto
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlElement("Event")]
        public EventDto[] EventDtos { get; set; }
    }
}
