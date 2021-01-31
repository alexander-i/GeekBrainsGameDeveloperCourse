//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{

    struct StructComplex
    {
        public double im;
        public double re;

        public StructComplex Plus(StructComplex x)
        {
            StructComplex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public StructComplex Minus(StructComplex x)
        {
            StructComplex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public StructComplex Multi(StructComplex x)
        {
            StructComplex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        override public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Complex
    {
        double im;
        double re;

        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double re, double im)
        {
            this.im = im;
            this.re = re;
        }

        public static Complex operator +(Complex a, Complex b) 
        {
            return new Complex(a.re + b.re, a.im + b.im);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.re - b.re, a.im - b.im);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            double realPart = a.re * b.re - a.im * b.im;
            double imaginaryPart = a.re * b.im + a.im * b.re;
            
            return new Complex(realPart, imaginaryPart);
        }

        public static Complex operator /(Complex a, Complex b)
        {
            double denominator = (Math.Pow(a.re, 2) + Math.Pow(b.re, 2));
            double realPart = (a.re * b.re + a.im * b.im) / denominator;
            double imaginaryPart = (a.im * b.re - a.re * b.im) / denominator;

            return new Complex(realPart, imaginaryPart);
        }

        public double Re
        {
            get { return re; }
            set { re = value; }
        }
        public double Im
        {
            get { return im; }
            set { im = value; }
        }
        
        override public string ToString()
        {
            return re + (im >= 0 ? "+" : "-") + Math.Abs(im) + "i";
        }
    }

    class HomeWork1
    {
        public static void Demo()
        {
            Complex c1, c2;
            StructComplex sc1, sc2;

            c1 = new Complex(12, 2);
            c2 = new Complex(2, 3);

            sc1.re = 12;
            sc1.im = 2;

            sc2.re = 2;
            sc2.im = 3;

            Utilities.Print($"Структура StructComplex (вычитание {sc1} - {sc2}): {sc1.Minus(sc2)}", newline: true);
            Utilities.Print($"Класс Complex (вычитание {c1} - {c2}): {c1 - c2}", newline: true);
            Utilities.Print($"Класс Complex (произведение {c1} и {c2}): {c1 * c2}", newline: true);
            Utilities.Print($"Класс Complex (деление {c1} и {c2}): {c1 / c2}", newline: true);
        }
    }

}
