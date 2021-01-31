using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.CenterAndPrint("--- Задание 1 ---", true);
            HomeWork1.Demo();

            Utilities.CenterAndPrint("--- Задание 2 ---", true);
            HomeWork2.InputSum();

            Utilities.CenterAndPrint("--- Задание 3 ---", true);
            HomeWork3.Demo();

            Utilities.Pause();
        }
    }
}
