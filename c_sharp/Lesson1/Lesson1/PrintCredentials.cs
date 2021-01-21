//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) *Сделать задание, только вывод организовать в центре экрана.
// в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class PrintCredentials
    {
        // Перенес в Utilities
        //
        //static void CenterAndPrint(string message)
        //{
        //    int offset = (Console.WindowWidth + message.Length) / 2;
        //    Console.WriteLine("{0," + offset + "}", message);
        //} 

        public static void Start()
        {
            string name = "Александр";
            string surname = "Иванов";
            string city = "Москва";

            Utilities.CenterAndPrint(String.Format("{0} {1}", name, surname));
            Utilities.CenterAndPrint(String.Format("{0}", city));
        }
    }
}
