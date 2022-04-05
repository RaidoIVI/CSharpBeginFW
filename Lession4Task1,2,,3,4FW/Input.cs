using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4Task1_2_3_4FW
{
    internal static class Input
    {
        public static string GetCon(string Description)
        {
            Console.Write(Description);
            string value;
            do
            {
                value = Console.ReadLine();
            }
            while (value == null);
            return value;
        }
        public static int GetConInt(string Description)
        {
            int value;
            string tmp;
            do
            {
                tmp = GetCon(Description);
            }
            while (!int.TryParse(tmp, out value));
            return value;
        }
        public static int GetConInt(string Description,int MinValue,int MaxValue)
        {
            int value;
            do
            {
                value = GetConInt(Description);

            }
            while (!(value <= MaxValue && value >= MinValue));
            return value;
        }
        public static double GetConDouble(string Description)
        {
            double value;
            string tmp;
            do
            {
                tmp = GetCon(Description);
            }
            while (double.TryParse(tmp, out value));
            return value;
        }
    }
}
