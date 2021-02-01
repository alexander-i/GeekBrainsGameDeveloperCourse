//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. 
// Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
// демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи. Все программы сделать в одном решении.
//
// **Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
// ArgumentException("Знаменатель не может быть равен 0");
// Добавить упрощение дробей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Fraction
    {
        int numerator;
        int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0) { throw new ArgumentException("Знаменатель не может быть равен 0"); }

            int gcd = GCD(numerator, denominator);

            if (numerator > 0 && denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;
        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
                {
                    denominator = value;
                }
            }
        }

        ///<summary>
        /// Reuturns greatest common divisor calculated by Euclidian algorithm
        /// </summary>
        public static int GCD(int a, int b)
        {
            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        ///<summary>
        /// Сумма дробей. Возвращает дробь с минимальным общим знаменателем
        /// </summary>
        public static Fraction operator +(Fraction a, Fraction b)
        {

            int numerator = a.numerator * b.denominator + b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;


            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {

            int numerator = a.numerator * b.denominator - b.numerator * a.denominator;
            int denominator = a.denominator * b.denominator;


            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.numerator * b.numerator;
            int denominator = a.denominator * b.denominator;


            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, int b)
        {
            int numerator = a.numerator * b;


            return new Fraction(numerator, a.denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.numerator * b.denominator;
            int denominator = a.denominator * b.numerator;


            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, int b)
        {
            int denominator = a.denominator * b;


            return new Fraction(a.numerator, denominator);
        }

        override public string ToString()
        {
            if (numerator == 0)
            {
                return "0";
            }
            else if (denominator == 1)
            {
                return $"{numerator}";
            }
            return $"{numerator} / {denominator}";
        }
    }

    class HomeWork3
    {
        public static void Demo()
        {
            int numerator_a = Utilities.PrintAndReadAsInt32("Введите числитель дроби 1: ", newlineAfterMsg: false);
            int denominator_a = Utilities.PrintAndReadAsInt32("Введите знаменатель дроби 1: ", newlineAfterMsg: false);

            int numerator_b = Utilities.PrintAndReadAsInt32("Введите числитель дроби 2: ", newlineAfterMsg: false);
            int denominator_b = Utilities.PrintAndReadAsInt32("Введите знаменатель дроби 2: ", newlineAfterMsg: false);

            Fraction a = new Fraction(numerator_a, denominator_a);
            Fraction b = new Fraction(numerator_b, denominator_b);

            Utilities.Print($"{a} + {b} = {a + b}");
            Utilities.Print($"{a} - {b} = {a - b}");
            Utilities.Print($"{a} * {b} = {a * b}");
            Utilities.Print($"{a} : {b} = {a / b}");
        }
    }
}
