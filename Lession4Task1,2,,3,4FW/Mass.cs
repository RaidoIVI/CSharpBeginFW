using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4Task1_2_3_4FW
{
    internal class Mass
    {
        private readonly List<double> _value;

        public Mass(string Value, char Separator)
        {
            _value = new List<double>();
            var _data = (Value.Split(Separator));

            for (var i = 0; i < _data.Length; i++)
            {
                double _tmp;
                if (Double.TryParse(_data[i], out _tmp)) //Если конвертнулось то добавляем, нет - пропускаем
                {
                    _value.Add(_tmp);
                }
            }
        }
        public double Summ()
        {
            double sum = 0;
            for (var i = 0; i < _value.Count; i++)
            {
                sum += _value[i];
            }
            return sum;
        }

    }
}
