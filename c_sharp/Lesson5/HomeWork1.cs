//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка 
// от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
// при этом цифра не может быть первой:
// а) без использования регулярных выражений;
// б) с использованием регулярных выражений.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lesson5
{
    class HomeWork1
    {
        public static bool LoginCheck(string login)
        {
            if (login.Length >= 2 && login.Length <= 10)
            {
                foreach (char c in login)
                {
                    if (!(char.IsDigit(c) || (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))) { return false; }
                }

                return true;
            }

            return false;
        }

        public static bool RegexpLoginCheck(string login)
        {
            Regex myReg = new Regex(@"^[A-z\d]{2,10}$");
            return myReg.IsMatch(login);
        }

        public static void Demo()
        {
            string[] logins = { "MyLogin12", "MyLogin$$" };

            foreach (string login in logins)
            {
                Utilities.Print($"Тестирую логин {login}");

                Utilities.Print($"Обычная проверка: ", newlineAfterMsg: false);
                if (LoginCheck(login)) { Utilities.Print("пройдена"); }
                else { Utilities.Print("не пройдена"); }
                Utilities.Print($"Проверка через регулярные выражения: ", newlineAfterMsg: false);
                if (RegexpLoginCheck(login)) { Utilities.Print("пройдена"); }
                else { Utilities.Print("не пройдена"); }
                Utilities.Print();
            }
        }
    }
}
