using System.Xml.Serialization;

namespace XmlDeserialization
{
    [XmlType("Event")]
    public class EventDto
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("IsLive")]
        public bool IsLive { get; set; }

        [XmlAttribute("CategoryID")]
        public int CategoryID { get; set; }

        [XmlElement("Match")]
        public MatchDto[] MatchDto { get; set; }
    }
}
