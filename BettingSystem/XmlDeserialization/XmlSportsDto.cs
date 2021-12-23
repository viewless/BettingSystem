using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XmlDeserialization
{
    [XmlType("XmlSports")]
    public class XmlSportsDto
    {
        [XmlAttribute("CreateDate")]
        public DateTime CreateDate { get; set; }

        [XmlElement("Sport")]
        public SportDto[] SportDto { get; set; }
    }
}
