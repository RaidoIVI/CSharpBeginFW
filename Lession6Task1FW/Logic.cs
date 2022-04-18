using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession6Task1FW
{
    internal static class Logic
    {
        internal static void TaskKill ()
        {
            const char exit = '\u001b';
            const char enter = '\r';
            const string Description = "Введите List для вывода списка, Name:Имя_процесса или ID:ИД_процесса (для выхода нажмите ESC): ";

            var userEnter = string.Empty;
            var userEnterExit = false;
            var tmp = string.Empty;
            int id;
            var error = false;

            while (!userEnterExit) 
            {
                userEnterExit = WorkToCon.StringByChar(enter, exit, Description, out userEnter);
                if ( userEnter.ToLower() == "list") 
                { 
                    ProcessUtil.PrintList(); 
                    error = false;
                }
                else
                {
                    error = true;
                }

                if ( userEnter.ToLower().Contains ("id:") )
                {
                    tmp = userEnter.Substring(3);
                    if ( Int32.TryParse(tmp,out id ))
                    {
                        error= ! ProcessUtil.KillByID(id);
                    }
                    else
                    {
                        error= true;
                    }
                }
                if ( userEnter.ToLower().Contains("name:") )
                {
                    tmp = userEnter.Substring(5);
                    error = ! ProcessUtil.KillByName(tmp);
                }
                if (error)
                {
                    WorkToCon.Print($"Ошибка, не могу найти процесс {tmp}");
                    error = false;
                }
                else
                {
                    if (!userEnterExit)
                    {
                        WorkToCon.Print("Успешно");
                    }
                }
            }
        }
    }
}
