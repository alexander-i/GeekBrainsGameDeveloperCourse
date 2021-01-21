//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// Написать программу обмена значениями двух переменных:
// а) с использованием третьей переменной;
// б) *без использования третьей переменной.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class SwapNumbers
    {
        public static void Swap()
        {
            double n1, n2, n3;

            n1 = Utilities.PrintAndReadAsDouble("Введите первое число", true);
            n2 = Utilities.PrintAndReadAsDouble("Введите второе число", true);

            Utilities.Print($"Вы ввели: {n1}, {n2}");

            // а) с использованием третьей переменной;
            //n3 = n2;
            //n2 = n1;
            //n1 = n3;

            // б) *без использования третьей переменной.

            n1 += n2;
            n2 = n1 - n2;
            n1 = n1 - n2;

            Utilities.Print($"Наоборот: {n1}, {n2}");

        }
    }
}
