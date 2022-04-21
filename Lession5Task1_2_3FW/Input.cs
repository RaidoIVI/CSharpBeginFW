using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5Task1_2_3FW
{
    internal static class Input
    {
        public static string GetString ()
        {
            Console.Write("Введите строку: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public static byte[] GetByte()
        {
            List<byte> sb = new List<byte>();
            string tmp;
            do
            {
                Console.Write("Ведите чисело (0..255) или -1 для выхода:");
                tmp = Console.ReadLine();
                if (byte.TryParse(tmp, out var value))
                {
                    sb.Add(value);
                }
            }
            while (!(tmp == "-1"));
            return sb.ToArray();
        }
    }
}
