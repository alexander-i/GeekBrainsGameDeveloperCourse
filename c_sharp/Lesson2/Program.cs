using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10012333;

            Utilities.CenterAndPrint("--- Задание 1 ---", true);
            Utilities.Print($"Min of (10, -8, 2) is {HomeWork1.MinOfThree(10, -8, 2)}", newline: true);

            Utilities.CenterAndPrint("--- Задание 2 ---", true);
            Utilities.Print($"Number of digits in {number} is {HomeWork2.CountDigits(number)}", newline: true);

            Utilities.CenterAndPrint("--- Задание 3 ---", true);
            HomeWork3.InputSum();

            Utilities.CenterAndPrint("--- Задание 4 ---", true);
            HomeWork4.PasswordCheck();

            Utilities.CenterAndPrint("--- Задание 5 ---", true);
            HomeWork5.Start();

            Utilities.CenterAndPrint("--- Задание 6 ---", true);
            HomeWork6.CountGoodNumbers();

            Utilities.CenterAndPrint("--- Задание 7 ---", true);
            HomeWork7.Start();

            Utilities.Pause();
        }
    }
}
