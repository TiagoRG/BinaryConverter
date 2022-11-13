using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BinaryConverter.Converters;

namespace BinaryConverter
{
    internal class Input
    {
        private static int ValidCharsN;

        public static Dictionary<int, string> OutputId = new Dictionary<int, string>();

        public static int GetInputType()
        {
            Console.Clear();
            while (true)
            {
                Console.Write($"Choose the INPUT type:\n\n1 > Decimal\n2 > Binary\n3 > Octal\n4 > Hexadecimal\n\n>>> ");
                string inputTypeStr = Console.ReadLine();
                try
                {
                    int inputTypeT = Convert.ToInt32(inputTypeStr);
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                int inputType = Convert.ToInt32(inputTypeStr);
                if (inputType > 4 || inputType < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                return inputType;
            }
        }

        public static int GetOutputType()
        {
            Console.Clear();
            while (true)
            {
                Console.Write($"Choose the OUTPUT type:\n\n1 > Decimal\n2 > Binary\n3 > Octal\n4 > Hexadecimal\n\n>>> ");
                string outputTypeStr = Console.ReadLine();
                try
                {
                    int inputTypeT = Convert.ToInt32(outputTypeStr);
                }
                catch (FormatException e)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                int outputType = Convert.ToInt32(outputTypeStr);
                if (outputType > 4 || outputType < 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                return outputType;
            }
        }

        public static Dictionary<string, string> GetInputNum(int inputType, int outputType)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            Console.Write("What's the number you want converted? (Enter 'Q' to quit)\n\n>>> ");
            string numStr = Console.ReadLine();
            if (numStr.ToLower() == "q")
            {
                GetInputType();
                return null;
            }
            int numLenght = numStr.Length;
            ValidCharsN = 0;
            switch (inputType)
            {
                case 1:
                    List<char> roadMap1 = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };
                    foreach (char c in roadMap1)
                    {
                        ValidCharsN += numStr.Count(inputChars => inputChars == c);
                    }
                    if (numLenght > ValidCharsN)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid decimal number!\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        GetInputNum(inputType, outputType);
                        return null;
                    }
                    else
                    {
                        result.Add("title", $"Converting from Decimal to {OutputId[outputType]}\n");
                        result.Add("numStr", numStr);
                        return result;
                    }
                case 2:
                    List<char> roadMap2 = new List<char>() {'0', '1'};
                    foreach(char c in roadMap2)
                    {
                        ValidCharsN += numStr.Count(inputChars => inputChars == c);
                    }
                    if (numLenght > ValidCharsN)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid binary number!\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        GetInputNum(inputType, outputType);
                        return null;
                    }
                    else
                    {
                        result.Add("title", $"Converting from Binary to {OutputId[outputType]}\n");
                        result.Add("numStr", numStr);
                        return result;
                    }
                case 3:
                    List<char> roadMap3 = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7' };
                    foreach (char c in roadMap3)
                    {
                        ValidCharsN += numStr.Count(inputChars => inputChars == c);
                    }
                    if (numLenght > ValidCharsN)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid octal number!\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        GetInputNum(inputType, outputType);
                        return null;
                    }
                    else
                    {
                        result.Add("title", $"Converting from Octal to {OutputId[outputType]}\n");
                        result.Add("numStr", numStr);
                        return result;
                    }
                case 4:
                    List<char> roadMap4 = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
                    foreach (char c in roadMap4)
                    {
                        ValidCharsN += numStr.Count(inputChars => inputChars == c);
                    }
                    if (numLenght > ValidCharsN)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid hexadecimal number!\n\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        GetInputNum(inputType, outputType);
                        return null;
                    }
                    else
                    {
                        result.Add("title", $"Converting from Hexadecimal to {OutputId[outputType]}\n");
                        result.Add("numStr", numStr);
                        return result;
                    }
                default:
                    return null;
            }
        }
    }
}
