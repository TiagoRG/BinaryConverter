using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.Converters

{
    internal class ConvertBinary
    {
        private static int Result;
        private static string oResult;
        private static List<string> Parts = new List<string>();
        private static string Part;
        private static int Counter;
        private static bool IsFirstPart;

        public static void ConvertionHandler(int outputType, string num)
        {
            switch(outputType)
            {
                case 1:
                    Console.WriteLine($"Input: {num}\nResult: {ToDecimal(num)}");
                    break;
                case 3:
                    Console.WriteLine($"Input: {num}\nResult: {ToOctal(num)}");
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
                if (num[i] == '1')
                {
                    Result += Convert.ToInt32(Math.Pow(2, num.Length - 1 - i));
                }
                else continue;
            }
            return Result.ToString();
        }

        public static string ToOctal(string num)
        {
            oResult = "";
            Part = "";
            Parts.Clear();
            Counter = 0;
            int firstPartLenght = num.Length % 3;
            IsFirstPart = true;
            foreach (char c in num)
            {
                if (IsFirstPart && firstPartLenght != 0)
                {
                    if (Counter < firstPartLenght)
                    {
                        Part += c.ToString();
                        Counter++;
                    }
                    if (Counter == firstPartLenght)
                    {
                        Parts.Add(Part);
                        Part = "";
                        IsFirstPart = false;
                        Counter = 0;
                    }
                }
                else
                {
                    if (Counter < 3)
                    {
                        Part += c.ToString();
                        Counter++;
                    }
                    if (Counter == 3)
                    {
                        Parts.Add(Part);
                        Part = "";
                        Counter = 0;
                    }
                }
            }
            foreach (string part in Parts)
            {
                oResult += ToDecimal(part);
            }
            return oResult;
        }

        public static string ToHexadecimal(string num)
        {
            oResult = "";
            Part = "";
            Parts.Clear();
            Counter = 0;
            int firstPartLenght = num.Length % 4;
            IsFirstPart = true;
            foreach (char c in num)
            {
                if (IsFirstPart && firstPartLenght != 0)
                {
                    if (Counter < firstPartLenght)
                    {
                        Part += c.ToString();
                        Counter++;
                    }
                    if (Counter == firstPartLenght)
                    {
                        Parts.Add(Part);
                        Part = "";
                        IsFirstPart = false;
                        Counter = 0;
                    }
                }
                else
                {
                    if (Counter < 4)
                    {
                        Part += c.ToString();
                        Counter++;
                    }
                    if (Counter == 4)
                    {
                        Parts.Add(Part);
                        Part = "";
                        Counter = 0;
                    }
                }
            }
            foreach (string part in Parts)
            {
                string returned = ToDecimal(part);
                switch (returned)
                {
                    case "10":
                        oResult += "A";
                        break;
                    case "11":
                        oResult += "B";
                        break;
                    case "12":
                        oResult += "C";
                        break;
                    case "13":
                        oResult += "D";
                        break;
                    case "14":
                        oResult += "E";
                        break;
                    case "15":
                        oResult += "F";
                        break;
                    default:
                        oResult += ToDecimal(part);
                        break;
                }
            }
            return oResult;
        }
    }
}
