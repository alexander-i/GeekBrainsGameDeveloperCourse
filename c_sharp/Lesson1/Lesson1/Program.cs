//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// Анкета -> класс Survey
// ИМТ -> класс BMI
// Расстояние -> класс EuclidianDistance
// Обмен значений переменных -> SwapNumbers
// Вывод в центр -> PrintCredentials
// Задание 6 -> Utilities
// 
// Сам программирую на питоне
// 

using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.CenterAndPrint("--- Задание 1 ---", true);
            Survey.Start();

            Utilities.Print();

            Utilities.CenterAndPrint("--- Задание 2 ---", true);
            BMI.Calculate();
            
            Utilities.Print();
            
            Utilities.CenterAndPrint("--- Задание 3 ---", true);
            EuclidianDistance.Calculate();

            Utilities.Print();

            Utilities.CenterAndPrint("--- Задание 4 ---", true);
            SwapNumbers.Swap();

            Utilities.Print();

            Utilities.CenterAndPrint("--- Задание 5 ---", true);
            PrintCredentials.Start();

            Utilities.Pause();

        }
    }
}
