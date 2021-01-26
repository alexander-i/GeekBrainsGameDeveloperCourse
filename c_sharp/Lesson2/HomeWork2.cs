//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
// Написать метод подсчета количества цифр числа.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork2
    {
        public static int CountDigits(int number)
        {
            int result = 0;

            do
            {
                result += 1;
                number /= 10;
            } while (number > 0);

            return result;
        }
    }
}
