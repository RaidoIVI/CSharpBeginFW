using System;

namespace Lession2Task1235
{
    internal partial class Program
    {
        class Get 
        { 
            internal static  Int32 Month(string text) 
            {
                string tmp = "";
                Int32 value;
                while (!(int.TryParse(tmp, out value) && ((0 < value) && (value < 13 ))))
                {
                    Console.Write(text);
                    tmp = Console.ReadLine();
                }
                return value;
            }
            internal static Double Double(string text)
            {
                string tmp = "";
                double value;
                while (!(double.TryParse(tmp, out value))) 
                {
                    Console.Write(text);
                    tmp= Console.ReadLine();
                }
                return value;
            }
            internal static Int32 Int(string text)
            {
                string tmp = "";
                Int32 value;
                while (!(int.TryParse(tmp, out value)))
                {
                    Console.Write(text);
                    tmp = Console.ReadLine();
                }
                return value;
            }
        }
    }
}
