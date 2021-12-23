using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlDeserialization
{
    [XmlType("Bet")]
    public class BetDto
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("ID")]
        public int ID { get; set; }

        [XmlAttribute("IsLive")]
        public bool IsLive { get; set; }

        [XmlElement("Odd")]
        public OddDto OddDto { get; set; }
    }
}
