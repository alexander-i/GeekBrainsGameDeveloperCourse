//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.CenterAndPrint("--- Задание 1 ---", true);
            HomeWork1.Demo();

            Utilities.CenterAndPrint("--- Задание 2 ---", true);
            HomeWork2.Demo();

            Utilities.CenterAndPrint("--- Задание 3 ---", true);
            HomeWork3.Demo();

            Utilities.CenterAndPrint("--- Задание 4 ---", true);
            HomeWork4.Demo();

            Utilities.CenterAndPrint("--- Задание 5 ---", true);
            HomeWork5.Demo();

            Utilities.Pause();
        }
    }
}
