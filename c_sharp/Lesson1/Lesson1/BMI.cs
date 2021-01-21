//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
// где m — масса тела в килограммах, h — рост в метрах.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class BMI
    {
        public static void Calculate()
        {
            double height = Utilities.PrintAndReadAsDouble("Введите свой рост (в метрах):", true);
            double weight = Utilities.PrintAndReadAsDouble("Введите свой вес (в килограммах):", true);

            Utilities.Print($"Ваш ИМТ: {weight / Math.Pow(height, 2)} (Нормальный ИМТ находится в пределах 18.5 - 24.9)");
        }
    }
}
