using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession8
{
    internal class IO
    {
        public static void ConPrint(string value)
        {
            Console.WriteLine (value);
        }
        public static string ConRead(string value)
        {
            Console.Write (value);
            return Console.ReadLine();
        }
    }
}
