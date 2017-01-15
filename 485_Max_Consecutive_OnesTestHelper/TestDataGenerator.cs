using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _485_Max_Consecutive_OnesTests
{
    internal class TestDataGenerator
    {
        public static int[] GenerateBinaryArray(int length)
        {
            int[] arrayOfBinaryInts = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                arrayOfBinaryInts[i] = rand.Next(2);
            }

            return arrayOfBinaryInts;
        }
    }
}
