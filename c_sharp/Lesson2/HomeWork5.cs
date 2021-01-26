//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork5
    {
        public static double CalculateBMI(double weight, double height)
        {
            return weight / Math.Pow(height / 100, 2);
        }

        public static double[] CalculateBMIBoundaries(double weight, double height)
        {
            double height_part = Math.Pow(height / 100, 2);
            return new double[] { 18.5 * height_part, 24.9 * height_part, weight / height_part };
        }

        public static void Start()
        {
            double height = Utilities.PrintAndReadAsDouble("Введите свой рост (в сантиметрах):", true);
            double weight = Utilities.PrintAndReadAsDouble("Введите свой вес (в килограммах):", true);

            double[] bmi_boundaries = CalculateBMIBoundaries(weight, height);
            string message = String.Format($"Ваш ИМТ: {Math.Round(bmi_boundaries[2], 1)} (Нормальный ИМТ находится в пределах 18.5 .. 24.9).");

            if (weight < bmi_boundaries[0])
            {
                Utilities.Print(message + $" Надо набрать {(int)Math.Round(bmi_boundaries[0] - weight)} кило!");
            } 
            else if (weight > bmi_boundaries[1])
            {
                Utilities.Print(message + $" Пора схуднуть на {(int)Math.Round(weight - bmi_boundaries[1])} кило!");
            }
            else
            {
                Utilities.Print(message + " Все в норме!");
            }
        }
    }
}
