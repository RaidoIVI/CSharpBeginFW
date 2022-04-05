using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lession4Task1_2_3_4FW
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // задание 1

            var i = Input.GetConInt("Введите количество пользователей: ");
            for (int j = 0; j < i; j++)
            {
                var Name = new UserName();
                Output.CPrint(Name.GetFullName());
            }

            // задание 2

            var Data = Input.GetCon("Введите числа для сложения (разделителем является пробел): ");
            var Summ = new Mass(Data, ' ');
            Output.CPrint(Convert.ToString(Summ.Summ()));

            // задание 3

            var Month = new Month();
            Output.CPrint(Month.RusName());

            // задание 4

            var Fibonachi = new Fibonachi();
            var Index = Input.GetConInt("Введите порядковый номер члена последовательности Фибоначи: ", 0, 1000);
            Output.CPrint(Convert.ToString(Fibonachi.GetMember(Index)));
            Console.ReadKey();
        }
    }
   
}




