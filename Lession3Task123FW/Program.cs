using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lession3Task123FW
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Rnd = rnd.Next(10);
            const int NumberOfSbscriber = 6;
            var a = Get.String("Ведите строку: ");
            a = Calculation.Mirror(a);
            Console.WriteLine(a);
            var b = Get.PhoneBook(NumberOfSbscriber);
            var c = Get.Array(Rnd);
            Console.WriteLine();
            Console.WriteLine(Calculation.Diagonal(c, true));
            Console.WriteLine(Calculation.Mirror((Calculation.Diagonal(c, false))));
            
            




            Console.ReadKey();
        }


    }
}
