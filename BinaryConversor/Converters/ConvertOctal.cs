using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.Converters
{
    internal class ConvertOctal
    {
        private static int Result;
        private static string oResult;

        public static void ConvertionHandler(int outputType, string num)
        {

            switch (outputType)
            {
                case 1:
                    Console.WriteLine($"Input: {num}\nResult: {ToDecimal(num)}");
                    break;
                case 2:
                    Console.WriteLine($"Input: {num}\nResult: {ToBinary(num)}");
                    break;
                case 4:
                    Console.WriteLine($"Input: {num}\nResult: {ToHexadecimal(num)}");
                    break;
            }
        }

        public static string ToDecimal(string num)
        {
            Result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != '0')
                {
                    Result += Convert.ToInt32(num[i].ToString()) * Convert.ToInt32(Math.Pow(8, num.Length - 1 - i));
                }
                else continue;
            }
            return Result.ToString();
        }

        public static string ToBinary(string num)
        {
            oResult = "";
            foreach (char c in num)
            {
                oResult += BinaryConvertions.BinaryConv[c.ToString()].Remove(0);
            }
            return oResult;
        }

        public static string ToHexadecimal(string num)
        {
            string binaryV = ToBinary(num);
            oResult = ConvertBinary.ToHexadecimal(binaryV);
            return oResult;
        }
    }
}
