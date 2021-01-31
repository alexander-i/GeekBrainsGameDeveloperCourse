//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 2.а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
// Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
// б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
// При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class HomeWork2
    {
        public static void InputSum()
        {
            int result = 0;
            string tmpString;
            int tmp;
            bool success;

            do
            {
                tmpString = Utilities.PrintAndReadAsString("Введите число: ", newlineAfterMsg: false);
                success = int.TryParse(tmpString, out tmp);
                if (!success)
                {
                    Utilities.Print($"Не удалось перевести \"{tmpString}\" в Int");
                }
                else if (tmp % 2 != 0 && tmp > 0)
                {
                    result += tmp;
                }
            } while (tmp != 0 || !success);

            Utilities.Print($"Сумма нечетных положительных чисел: {result}", newline: true);
        }
    }
}
