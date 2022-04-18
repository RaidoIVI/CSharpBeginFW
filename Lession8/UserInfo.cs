using System;


namespace Lession8
{
    internal static class UserInfo
    {
        private static string Get (User user)

        {
            switch (user)
            {
                case User.FirstName :
                    return Lession8.Properties.Settings.Default.FirstName ;
                case User.LastName :
                    return Lession8.Properties.Settings.Default.LastName;
                case User.Patronium :
                    return Lession8.Properties.Settings.Default.Patronium;
                case User.Age :
                    return Lession8.Properties.Settings.Default.Age.ToString();
                case User.Occupation :
                    return Lession8.Properties.Settings.Default.Occupation;
                case User.FullName:
                    return Lession8.Properties.Settings.Default.FirstName + " " + Lession8.Properties.Settings.Default.Patronium 
                        + " " + Lession8.Properties.Settings.Default.LastName;
                default:
                    return String.Empty;
            }
        }

        private static void Init ()
        {
            bool ageRight;
            byte age;
            IO.ConPrint("Вижу вы впервые запустили программу. Введите ваши данные.");
            Lession8.Properties.Settings.Default.FirstName = IO.ConRead("Введите Ваше Имя: ");
            Lession8.Properties.Settings.Default.LastName = IO.ConRead("Введите Вашу Фамилию: ");
            Lession8.Properties.Settings.Default.Patronium = IO.ConRead("Введите Ваше Отчество: ");
            do
            {
                ageRight = Byte.TryParse(IO.ConRead("Введите ваш возраст: "), out age);
                if (!(ageRight && age > 4 && age < 100))
                {
                    IO.ConPrint("Ошибка, повторите ввод.");
                    ageRight = false;
                }
            }
            while (!ageRight);
            Lession8.Properties.Settings.Default.Age = age;
            Lession8.Properties.Settings.Default.Occupation = IO.ConRead("Введите Ваш род занятий: ");
            Lession8.Properties.Settings.Default.FirstRun = false;
            Lession8.Properties.Settings.Default.Save();
        }

        private static void Out()
        {
            IO.ConPrint($"Добрый день {UserInfo.Get(User.FullName)} !");
            IO.ConPrint($"Ваш возраст {UserInfo.Get(User.Age)}, ваш род занятий {UserInfo.Get(User.Occupation)}");
        }

        public static void Start ()
        {
            if (Lession8.Properties.Settings.Default.FirstRun)
            {
                Init();
                Out();
            }
            else
            {
                Out();
            }
        }
    }
}
