using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lession5Task1_2_3FW
{
    internal static class StartUp
    {
        
        private const string _fileName = @"StartUp.txt";

        public static void Start ()
        {
            var date = Convert.ToString( DateTime.Now);
            File.AppendAllText( Path.Combine(Directory.GetCurrentDirectory(), _fileName ), date + "\n");
        }
    }
}
