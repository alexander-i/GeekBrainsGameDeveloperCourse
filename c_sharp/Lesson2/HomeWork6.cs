//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//
// *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
// «Хорошим» называется число, которое делится на сумму своих цифр. 
// Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class HomeWork6
    {
        public static int SumOfDigits(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }

            return result;
        }

        public static void CountGoodNumbers()
        {
            Console.WriteLine("Считаю хорошие номера...");

            int counter = 0;
            DateTime start = DateTime.Now;
            int max_val = (int)(Math.Pow(10, 9));

            for (int i = 1; i <= max_val; i++)
            {
                if (i % SumOfDigits(i) == 0) { counter++; }
            }

            Console.WriteLine($"Время выполнения функции подсчета \"хороших\" чисел: {DateTime.Now - start} секунд. Хороших чисел: {counter}");
        }
    }
}