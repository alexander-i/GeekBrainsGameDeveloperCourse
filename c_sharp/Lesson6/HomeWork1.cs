//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 1. Изменить программу вывода функции так, чтобы можно было передавать 
// функции типа double (double,double). Продемонстрировать работу на 
// функции с функцией a*x^2 и функцией a*sin(x).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    public delegate double Fun(double x, double a);

    class HomeWork1
    {
        public static void Table(Fun F, double x, double a, double n)
        {
            Console.WriteLine("----- x ----- a -----");
            while (x <= n)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", x, a, F(x, a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        public static void Demo()
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(delegate (double x, double a) { return a * x * x; }, 2, 4, 3);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(delegate (double x, double a) { return a * Math.Sin(x); }, 2, 4, 3);
        }
    }
}
