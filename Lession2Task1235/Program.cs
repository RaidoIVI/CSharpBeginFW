using System;

namespace Lession2Task1235
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            double MaxTemp = Get.Double("Введите максимальную температуру сегодня: ");
            double MinTemp = Get.Double("Введите минимальную температуру сегодня: ");
            int Month = Get.Month("Введите порядковый номер месяца ");
            int Number = Get.Int("Введите число для проверки чет/нечет: ");

            double Mean = Calculation.Mean(MaxTemp, MinTemp);
            string MonthName = Calculation.Month(Month);
            string Even = Calculation.Even(Number);
            string RainyWinter = Calculation.RainyWinter(MaxTemp, MinTemp, Month);
            
            String Description;
            Description = "Средняя температура: " + Mean;
            Send.Con(Description);
            Description = "Месяц: " + MonthName;
            Send.Con(Description);
            Send.Con(RainyWinter);
            Description = "Число " + Even;
            Send.Con(Description);

            Console.ReadKey();
        }
    }
}
