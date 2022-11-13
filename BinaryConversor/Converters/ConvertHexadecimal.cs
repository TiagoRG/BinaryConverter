using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.Converters
{
    internal class ConvertHexadecimal
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
                case 3:
                    Console.WriteLine($"Input: {num}\nResult: {ToOctal(num)}");
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
                    switch (num[i])
                    {
                        case 'A':
                            Result += 10 * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                        case 'B':
                            Result += 11 * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                        case 'C':
                            Result += 12 * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                        case 'D':
                            Result += 13 * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                        case 'E':
                            Result += 14 * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                        case 'F':
                            Result += 15 * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                        default:
                            Result += Convert.ToInt32(num[i].ToString()) * Convert.ToInt32(Math.Pow(16, num.Length - 1 - i));
                            break;
                    }
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
                oResult += BinaryConvertions.BinaryConv[c.ToString()];
            }
            return oResult;
        }

        public static string ToOctal(string num)
        {
            string binaryV = ToBinary(num);
            oResult = ConvertBinary.ToOctal(binaryV);
            return oResult;
        }
    }
}
