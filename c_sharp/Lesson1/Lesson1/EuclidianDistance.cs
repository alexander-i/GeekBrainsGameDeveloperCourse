//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
// используя спецификатор формата .2f (с двумя знаками после запятой);
// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class EuclidianDistance
    {
        static double CalculateDistance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static void Calculate()
        {
            double x1 = Utilities.PrintAndReadAsDouble("Введите x1");
            double x2 = Utilities.PrintAndReadAsDouble("Введите x2");
            double y1 = Utilities.PrintAndReadAsDouble("Введите y1");
            double y2 = Utilities.PrintAndReadAsDouble("Введите y2");

            string msg = String.Format("Расстояние между двумя точками ({0}, {1}) и ({2}, {3}): {4:F2}", x1, x2, y1, y2, CalculateDistance(x1, x2, y1, y2));
            Utilities.Print(msg);
        }
    }
}
