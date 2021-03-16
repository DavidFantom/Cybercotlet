using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace AppXML
{
    public class Match
    {
        [XmlElement("team1")]
        public string team1 { get; set; }
        [XmlElement("team2")]
        public string team2 { get; set; }
        [XmlElement("points")]
        public string points { get; set; }
    }
}
