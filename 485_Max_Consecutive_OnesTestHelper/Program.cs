using _485_Max_Consecutive_OnesTests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _485_Max_Consecutive_OnesTestHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tests = {0, 1, 2, 3, 10, 50, 75, 100, 1000, 9999, 10000, 10001};
            string[] expected = 
            TestCase[] testCases = new TestCase[tests.Length];

            for (int i = 0; i < testCases.Length; i++)
            {
                testCases[i].
            }

            using (var stream = File.Create("TestData.xml"))
            {
                var serializer = new XmlSerializer(typeof(TestCase));
                serializer.Serialize(stream, arrayOfBinaryInts);
            }

        }
    }
}
