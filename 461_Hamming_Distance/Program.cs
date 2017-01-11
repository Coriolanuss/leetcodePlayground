using System;

// TODO Add description
namespace _461_Hamming_Distance
{
    class Program
    {
        // TODO Add unit-tests
        static void Main(string[] args)
        {
            int x = 1, y = 4; // test inputs

            Console.WriteLine(VelosipedSolution.HammingDistance(x, y));
            // TODO Add GOOD realization
            
        }
    }

    // TODO Add description
    public static class VelosipedSolution
    {
        public static int HammingDistance(int x, int y)
        {
            // convert input to binary
            string binaryX = Convert.ToString(x, 2), binaryY = Convert.ToString(y, 2);
            int counter = 0;

            // Hamming distance of equal numbers = 0
            if (x == y)
                return counter;

            // equate length of binary notation of the strings (add zeros to the beginning)
            if (x > y)
                binaryY = AddZerosToString(binaryY, binaryX.Length - binaryY.Length);
            else
                binaryX = AddZerosToString(binaryX, binaryY.Length - binaryX.Length);

            for (int i = 0; i < binaryX.Length; i++)
            {
                if (binaryX[i] != binaryY[i])
                    counter++;
            }

            return counter;
        }

        private static string AddZerosToString(string binary, int numbOfZeros)
        {
            string zeros = "";
            for (int i = 0; i < numbOfZeros; i++)
                zeros += "0";

            return zeros + binary;
        }
    }
}
