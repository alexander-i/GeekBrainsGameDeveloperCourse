//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
// Написать метод, возвращающий минимальное из трёх чисел.
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork1
    {
        public static int MinOfN(params int[] a)
        {
            int result = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                result = result > a[i] ? a[i] : result;
            }

            return result;
        }
        public static int MinOfThree(int a, int b, int c)
        {
            return MinOfN(a, b, c);
        }
    }
}
