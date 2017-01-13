using System;

/// <summary>
/// Hamming Distance problem
/// </summary>
namespace _461_Hamming_Distance
{
    class Program
    {
        static void Main(string[] args)
        { }
    }

    /// <summary>
    /// Solutions to Hamming Distance problem
    /// </summary>
    public static class HammingDistance_Solutions
    {
        /// <summary>
        /// My first strugle to solve the task of Hamming Distance.
        /// Strangly this method is faster then using XOR, which is pure matematical.
        /// <para>Parameters in any order</para>
        /// </summary>
        /// <param name="x">[0; Int.MaxValue]</param>
        /// <param name="y">[0; Int.MaxValue]</param>
        /// <returns>Hamming distance between two numbers</returns>
        public static int HammingDistanceWithStringManipulations(int x, int y)
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

        /// <summary>
        /// Purely matematical solution created after consulting with web.
        /// <para>Parameters in any order</para>
        /// </summary>
        /// <param name="x">[0; Int.MaxValue]</param>
        /// <param name="y">[0; Int.MaxValue]</param>
        /// <returns>Hamming distance between two numbers</returns>
        public static int HammingDistanceWithXOR(int x, int y)
        {
            return HammingWeight(x^y);
        }

        private static string AddZerosToString(string binary, int numbOfZeros)
        {
            string zeros = "";
            for (int i = 0; i < numbOfZeros; i++)
                zeros += "0";

            return zeros + binary;
        }

        /// <summary>
        /// Equal to Integer.bitCount in Java
        /// </summary>
        /// <param name="value">positive or 0</param>
        /// <returns>Hamming weight of an integer in binary representation</returns>
        private static int HammingWeight(int value)
        {
            int sum = 0;

            while (value > 0)
            {
                sum += value & 0x01;
                value >>= 1;
            }

            return sum;
        }
    }
}
