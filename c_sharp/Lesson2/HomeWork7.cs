//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork7
    {

        public static void RecursiveDisplay(int a, int b)
        {
            
            if (a < b) {
                Console.Write($"{a} ");
                RecursiveDisplay(a + 1, b); 
            }
            else { return; }
        }

        public static int RecursiveSum(int a, int b)
        {
            if (a == b) { return 0; }
            return a + RecursiveSum(a + 1, b);
        }

        public static void Start()
        {
            int a, b;

            a = Utilities.PrintAndReadAsInt32("Введите a: ", newlineAfterMsg: false);
            b = Utilities.PrintAndReadAsInt32("Введите b: ", newlineAfterMsg: false);

            RecursiveDisplay(a, b);
            Utilities.Print();
            Utilities.Print($"Сумма диапазона: {RecursiveSum(a, b)}");
            Utilities.Print();
        }
    }
}
