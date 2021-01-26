//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork3
    {
        public static void InputSum()
        {
            int result = 0;
            int tmp;

            do
            {
                tmp = Utilities.PrintAndReadAsInt32("Введите число: ", newlineAfterMsg: false);
                 if (tmp % 2 != 0 && tmp > 0)
                {
                    result += tmp;
                }
            } while (tmp != 0);

            Utilities.Print($"Сумма нечетных положительных чисел: {result}", newline: true);
        }
    }
}
