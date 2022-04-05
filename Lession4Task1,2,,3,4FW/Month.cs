using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lession4Task1_2_3_4FW
{
    

    internal class Month
     {
        private readonly int _month;

        public Month ()
        {
            _month = Input.GetConInt("Введите порядковый номер месяца (число 1-12): ", 1, 12);
        }

        private bool GetName (int Value, out Season Season )
        {
          
            if ( Value == 1 || Value == 2 || Value == 12 )
            {
                Season = Season.Winter ;
                return true;
            }
            if (Value > 2 && Value < 6)
            {
                Season = Season.Spring ;
                return true;
            }
            if (Value > 5 && Value < 9)
            {
                Season = Season.Summer ;
                return true;
            }
            if (Value > 8 && Value < 12)
            {
                Season = Season.Autumn ;
                return true;
            }
            Season = Season.Null;
            return false;
        }
        private static string GetRusName (Season Season)
        {
            switch (Season)
            {
                case Season.Winter: return "Зима";
                case Season.Spring: return "Весна"; 
                case Season.Summer: return "Лето";
                case Season.Autumn: return "Осень";
                default: return "";                        
            }
        }
        public string RusName()
        {
            var season = Season.Null;
            if (GetName (_month, out season))
            {
                return GetRusName (season);
            }
            return "Ошибка определения месяца";
        }




    }
}

