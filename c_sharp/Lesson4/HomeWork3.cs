//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 3. Решить задачу с логинами из предыдущего урока, только логины и 
// пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4
{
    struct Account
    {
        string login;
        string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }

    class Accounts
    {
        private List<Account> accounts = new List<Account>(); // Dictionary, кажется, эффективнее решает задачу
        private Dictionary<String, String> accountsDict = new Dictionary<string, string>();

        public Accounts(StreamReader sr)
        {
            string line;
            string[] splittedString;

            while (true)
            {
                line = sr.ReadLine();
                if (line is null) { break; }
                else
                {
                    splittedString = line.Split(':');
                    accountsDict.Add(splittedString[0], splittedString[1]);
                    accounts.Add(new Account(splittedString[0], splittedString[1]));
                }
            }
        }

        public bool CheckPassword(string login, string password)
        {
            if (!accountsDict.ContainsKey(login)) { return false; }
            else if (accountsDict[login] == password) { return true; }
            else { return false; }
        }
    }

    class HomeWork3
    {
        public static void Test(Accounts accounts, string login, string password)
        {
            Utilities.Print($"Пробую логин {login}, пароль {password}: ", newlineAfterMsg: false);
            if(accounts.CheckPassword(login, password)) { Utilities.Print("Успех!"); }
            else { Utilities.Print("Ошибка."); }
        }

        public static void Demo()
        {
            var filename = "../../accounts.txt";
            try
            {
                StreamReader sr = new StreamReader(filename);
                Accounts accounts = new Accounts(sr);
                sr.Close();

                Test(accounts, "admin", "admin");
                Test(accounts, "neo", "knockknock");
                Test(accounts, "neo", "KnockKnock");

            }
            catch (FileNotFoundException)
            {
                Utilities.Print($"Не удалось найти файл {filename}");
            }
        }
    }
}
