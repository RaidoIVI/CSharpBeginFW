using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession6Task1FW
{
    internal static class ProcessUtil
    {
        internal static Process[] GetList()
        {
            
            Process[] process = Process.GetProcesses();
            return process;
        }

        internal static bool KillByID(int Value)
        {
            var valueExit = false;
            foreach (Process process in GetList())
            {
                if (process.Id == Value)
                {
                    process.Kill();
                    valueExit = true;
                }
            }
            return valueExit;
        }
        internal static bool KillByName(string Value)
        {
            var valueExit = false;
            foreach (Process process in GetList())
            {
                if (process.ProcessName == Value)
                {
                    process.Kill();
                    valueExit = true;
                }                
            }
            return valueExit;
        }
        internal static void PrintList()
        {
            
            foreach (Process process in GetList())
            {
                StringBuilder stringBuilder = new StringBuilder(255);
                var id = Convert.ToString(process.Id);
                stringBuilder.AppendFormat("{0,-5} {1,-10} {2,-10} {3,-10}", "ID:", id, "Name:", process.ProcessName);
                Console.WriteLine(stringBuilder.ToString());
            }
        }
        
    }
}
