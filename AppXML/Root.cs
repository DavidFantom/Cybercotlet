using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppXML
{
    [XmlRoot("match_catalog")]
    
    public class Root
    {
        [XmlElement("match")]
        public List<Match> Children { get; set; }
    }
}
