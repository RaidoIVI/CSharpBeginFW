using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession5Task1_2_3FW
{
    internal class Task
    {
        private readonly string title;
        private bool isDone;
        
        internal Task (string title)
        {
            this.title = title;
            isDone = false;
        }
        internal Task (string title, bool done)
        {
            this.title =title;
            this.isDone = done;
        }

        internal void Done ()
        {
            isDone = true;
        }
    }
}
