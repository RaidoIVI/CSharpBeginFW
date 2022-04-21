using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5Task1_2_3FW
{
    internal class FileOut
    {
        private const string _fileName = @"Out";

        public static void Save (string Value)
        {
            File.WriteAllText(_fileName+".txt", Value);
        }
        public static void Save (byte[] Value)
        {
            File.WriteAllBytes(_fileName + ".bin", Value);
        }
    }
}
