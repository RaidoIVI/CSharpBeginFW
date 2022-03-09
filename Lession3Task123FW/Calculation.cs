using System;
using System.Text;

namespace Lession3Task123FW
{
    internal partial class Program
    {
        class Calculation
        {
            internal static string Mirror(string value)
            {
                if (value == null) { return value; }
                var tmp = new StringBuilder(value.Length);
                for (int i = 0; i < value.Length; i++) { tmp.Append(value[((value.Length - 1) - i)]); }
                return Convert.ToString(tmp);
            }
            internal static string Diagonal (int [,] value1, bool value2) 
            {
                var tmp = new StringBuilder(value1.GetLength(0));
               
                    for (int i = 0; i < value1.GetLength(0) ; i++)
                    {
                        for (int j = 0; j < value1.GetLength(1) ; j++)
                        {
                            if ((i == j) && value2) { tmp.Append(value1[i, j]); }
                            else if ((i+j+1 == value1.GetLength(0) ) && !value2) { tmp.Append(value1[i, j]); }
                        }                 
                    }
               return Convert.ToString(tmp);
            }





        }
    }
}
