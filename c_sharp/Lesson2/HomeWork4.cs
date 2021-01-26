//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork4
    {
        static string login = "root";
        static string password = "GeekBrains";

        public static void PasswordCheck()
        {
            string candidateLogin;
            string candidatePassword;
            int counter = 3;

            do
            {
                candidateLogin = Utilities.PrintAndReadAsString("Введите логин: ", newlineAfterMsg: false);
                candidatePassword = Utilities.PrintAndReadAsString("Введите пароль: ", newlineAfterMsg: false);

                if (candidateLogin == login && candidatePassword == password)
                {
                    Utilities.Print("Вы - в системе.", newline: true);
                    return;
                } 
                else
                {
                    Utilities.Print("Неверно.", newline: true);
                }
            } while (--counter > 0);

            Utilities.Print("Доступ запрещен.", newline: true);
        }
    }
}
