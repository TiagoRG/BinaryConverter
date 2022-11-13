using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.Converters
{
    internal class ConvertDecimal
    {
        private static string oResult;
        private static string oResult2;
        private static int IntNum;
        private static decimal DecNum;

        public static void ConvertionHandler(int outputType, string num)
        {
            switch (outputType)
            {
                case 2:
                    Console.WriteLine($"Input: {num}\nResult: {ToBinary(num)}");
                    break;
                case 3:
                    Console.WriteLine($"Input: {num}\nResult: {ToOctal(num)}");
                    break;
                case 4:
                    Console.WriteLine($"Input: {num}\nResult: {ToHexadecimal(num)}");
                    break;
            }
        }

        public static string ToBinary(string num)
        {
            oResult = "";
            oResult2 = "";
            IntNum = 0;
            DecNum = 0;

            if (!num.Any(x => x == '.'))
            {
                IntNum = Convert.ToInt32(num);
                while (IntNum > 0)
                {
                    if (IntNum % 2 == 1)
                        oResult += "1";
                    else
                        oResult += "0";
                    IntNum = Convert.ToInt32(Math.Truncate(Convert.ToDecimal(IntNum / 2)));
                }
                oResult.Reverse();
                return oResult;
            }
            else
            {
                string[] nums = num.Split('.');
                IntNum = Convert.ToInt32(nums[0]);
                DecNum = Convert.ToDecimal("0." + nums[1]);

                while (IntNum > 0)
                {
                    if (IntNum % 2 == 1)
                        oResult += "1";
                    else
                        oResult += "0";
                    IntNum = Convert.ToInt32(Math.Truncate(Convert.ToDecimal(IntNum / 2)));
                }
                oResult.Reverse();

                int times = 0;
                while (DecNum > 0 && times < 25)
                {
                    DecNum *= 2;
                    if (DecNum > 1)
                    {
                        DecNum = Convert.ToDecimal("0." + DecNum.ToString().Substring(2));
                        oResult2 += "1";
                    }
                    else
                        oResult2 += "0";

                    times++;
                }

                return oResult + "." + oResult2.Substring(0, 10);
            }
        }

        public static string ToOctal(string num)
        {
            string binaryV = ToBinary(num);
            oResult = ConvertBinary.ToOctal(binaryV);
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
