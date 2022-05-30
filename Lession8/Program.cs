using System;

namespace Lession8
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Welcome.Output( Lession8.Properties.Resources.Welcome );
            //if (Lession8.Properties.Settings.Default.FirstRun)
            //{
            //    UserInfo.Init();
            //}
            //else
            //{
            //    UserInfo.Out();
            //}
            UserInfo.Start();


            Console.ReadKey(false);
        }
    }
}
