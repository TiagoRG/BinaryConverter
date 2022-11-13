using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter.Converters
{
    internal class BinaryConvertions
    {
        public static Dictionary<string, string> BinaryConv = new Dictionary<string, string>();

        public static void BinaryC()
        {
            BinaryConv.Add("0", "0000");
            BinaryConv.Add("1", "0001");
            BinaryConv.Add("2", "0010");
            BinaryConv.Add("3", "0011");
            BinaryConv.Add("4", "0100");
            BinaryConv.Add("5", "0101");
            BinaryConv.Add("6", "0110");
            BinaryConv.Add("7", "0111");
            BinaryConv.Add("8", "1000");
            BinaryConv.Add("9", "1001");
            BinaryConv.Add("A", "1010");
            BinaryConv.Add("B", "1011");
            BinaryConv.Add("C", "1100");
            BinaryConv.Add("D", "1101");
            BinaryConv.Add("E", "1110");
            BinaryConv.Add("F", "1111");
        }
    }
}
