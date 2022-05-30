using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession6Task1FW
{
    internal static class WorkToCon
    {
        internal static bool StringByChar (char EnterKey, char ExitKey, string Description, out string Output)
        {
            StringBuilder output = new StringBuilder ();
            char tmp = default;
            Console.Write(Description);
            
            do 
            {
                Console.Write (tmp.ToString());
                output.Append (tmp.ToString());
                tmp = Console.ReadKey(true).KeyChar;               
            }
            while ( ! (tmp == EnterKey || tmp == ExitKey) );
            
            Output = output.ToString (1, output.Length-1 );
            Console.WriteLine();
            
            if (tmp == ExitKey)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal static void Print (string Value)
        {
            Console.WriteLine (Value);
        }
    }
}
