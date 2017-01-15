using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _485_Max_Consecutive_OnesTestHelper
{
    public class TestCase
    {
        [XmlElement]
        public int Expected { get; set; }

        [XmlArrayItem("int")]
        public int[] Numbers { get; set; }
    }
}
