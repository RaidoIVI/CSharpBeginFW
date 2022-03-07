namespace Lession2Task1235
{
    internal partial class Program
    {
        class Calculation 
        {
            internal static double  Mean(double value1, double value2 ) 
            {
                return (value1 + value2) / 2;
            }
            internal static string Month( int value) 
            {
                switch (value) 
                {
                    case 1 : return "Январь"; break;
                    case 2 : return "Февраль"; break ;
                    case 3 : return "Март"; break;
                    case 4 : return "Апрель"; break;
                    case 5 : return "Май"; break;
                    case 6 : return "Июнь"; break;
                    case 7 : return "Июль"; break;
                    case 8 : return "Август"; break;
                    case 9 : return "Сентябрь"; break;
                    case 10 : return "Октябрь"; break;
                    case 11 : return "Ноябрь"; break;
                    case 12 : return "Декабрь"; break;
                        default : return "";
                }
            }
            internal static string Even (int value) 
            {
                if (value % 2 == 0)  { return "Чет"; } else { return "Нечет"; }
            }
            internal static string RainyWinter(double maxTemp, double minTemp, int mouth)
            {
                if ((mouth == 1 || mouth == 2 || mouth == 12) && ((minTemp + maxTemp) / 2 > 0)) { return "Дождливая зима";  }
                else { return ""; }
            }
        }
    }
}
