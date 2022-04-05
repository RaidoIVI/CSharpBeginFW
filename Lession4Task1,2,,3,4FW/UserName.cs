using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession4Task1_2_3_4FW
{
    internal class UserName
    {
        private string _firstName;
        private string _lastName;
        private string _patronymic;

        public UserName (string FirstName, string LastName, string Patronomic )
        {
            _firstName = FirstName;
            _lastName = LastName;
            _patronymic = Patronomic;
        }
        public UserName ()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _patronymic = string.Empty;
            UserNameInit ();
        }
        public string GetFullName()
        {
            return _lastName+" "+_firstName+" "+_patronymic;
        }
        private void UserNameInit ()
        {
            _firstName = Input.GetCon ("Введите Имя: ");
            _lastName = Input.GetCon ("Введите Фамилию: ");
            _patronymic = Input.GetCon("Введите Отчество: ");
        }
    }
}
