using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4Task1_2_3_4FW
{
    internal class Fibonachi
    {
        private List<int > _fibonachi;

        public Fibonachi()
        {
            _fibonachi = new List<int>();
            _fibonachi.Add(0);
            _fibonachi.Add(1);
            _fibonachi.Add(1);
        }
        public int GetMember (int Index) 
        {
            if ( _fibonachi.Count >= Index+1 )
            {
                return _fibonachi[Index];
                
            }
            _fibonachi.Add( GetMember (Index-1) + GetMember (Index-2) );
            return _fibonachi[Index];
        }
    }
}
