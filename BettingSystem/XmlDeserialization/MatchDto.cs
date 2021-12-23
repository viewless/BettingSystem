using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlDeserialization
{
    [XmlType("Match")]
    public class MatchDto
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("ID")]
        public int Id { get; set; }

        [XmlAttribute("StartDate")]
        public DateTime StartDate { get; set; }

        [XmlAttribute("MatchType")]
        public string MatchType { get; set; }

        [XmlElement("Bet")]
        public BetDto[] BetDto { get; set; }

    }
}
