using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryConverter.Converters;

namespace BinaryConverter
{
    internal class Program
    {
        public static string InputNum { get; set; }
        public static Dictionary<string, string> InputDic { get; set; }


        static void Main(string[] args)
        {
            Console.Title = "Binary Converter";
            Input.OutputId.Add(1, "Decimal");
            Input.OutputId.Add(2, "Binary");
            Input.OutputId.Add(3, "Octal");
            Input.OutputId.Add(4, "Hexadecimal");
            BinaryConvertions.BinaryC();
            while (true)
            {
                InputNum = null;
                int inputType = Input.GetInputType();
                int outputType = Input.GetOutputType();
                if (inputType == outputType)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can't convert between the same type!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                while (InputNum == null)
                {
                    Console.Clear();
                    InputDic = Input.GetInputNum(inputType, outputType);
                    InputNum = InputDic["numStr"];
                }
                Console.Clear();
                Console.WriteLine(InputDic["title"]);
                switch (inputType)
                {
                    case 1:
                        ConvertDecimal.ConvertionHandler(outputType, InputNum);
                        break;
                    case 2:
                        ConvertBinary.ConvertionHandler(outputType, InputNum);
                        break;
                    case 3:
                        ConvertOctal.ConvertionHandler(outputType, InputNum);
                        break;
                    case 4:
                        ConvertHexadecimal.ConvertionHandler(outputType, InputNum);
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
