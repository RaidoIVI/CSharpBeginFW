using System;

namespace Lession3Task123FW
{
    internal partial class Program
    {
        class Get 
        {
            internal static string String (string value)
            {
                Console.Write(value);
                string tmp = Console.ReadLine();
                return tmp;
            }
            internal static string [,] PhoneBook (int value)
            {
                string [,]  tmp = new string [value,2];
                for (int i = 0; i < tmp.GetLength (0) ; i++) 
                {
                    tmp[i,0] = Get.String("Введите имя: ");
                    tmp[i, 1] = Get.String("Ведите номер телефона/e-mail: ");
                }
                return tmp;
            }
            internal static int[,] Array (int value) 
            {
                Random rnd = new Random();
                int[,] tmp = new int [value,value];
                for (var i = 0; i < tmp.GetLength(0) ; i++) 
                {
                    for (var j = 0; j < tmp.GetLength(1) ; j++) 
                    {
                        tmp[i, j] = rnd.Next(10);
                    }
                }
                return tmp;
            }
            

        }


    }
}
