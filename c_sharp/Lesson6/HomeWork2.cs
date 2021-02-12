//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.

// а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
// б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
// в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
// возвращает минимум через параметр.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson6
{
    public delegate double F(double x);
    class HomeWork2
    {

        public static void SaveFunc(string fileName, F fun, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(fun(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }
        public static double[] Load(string fileName, out double min_value)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[] values = new double[fs.Length / sizeof(double)];
            min_value = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                values[i] = d;
                if (d < min_value) min_value = d;
            }
            bw.Close();
            fs.Close();
            return values;
        }
        public static void Demo()
        {
            Dictionary<string, F> delegateDict = new Dictionary<string, F>();
            delegateDict.Add("x * x - 50 * x + 10", delegate (double x) { return x * x - 50 * x + 10; });
            delegateDict.Add("x * x * x - 10 + 5", delegate (double x) { return x * x * x - 10 + 5; });
            delegateDict.Add("Math.Log(x * x) + 12", delegate (double x) { return Math.Log(x * x + 1) + 12; });
            delegateDict.Add("Math.Log(x * x * 2) + 12", delegate (double x) { return Math.Log(x * x * 2 + 1) + 12; });
            delegateDict.Add("Math.Exp(3 * x)", delegate (double x) { return Math.Exp(3 * x); });

            // костыль для получения номера элемента далее в диалоге
            string[] delegateKeysArray = delegateDict.Keys.ToArray<string>();

            Utilities.Print("Выберите функцию для нахождения минимума:");
            for (int i = 0; i < delegateKeysArray.Length; i++)
            {
                Utilities.Print($"{i}) {delegateKeysArray[i]}");
            }

            int selection = -1;
            while (selection < 0 || selection > delegateKeysArray.Length - 1)
            {
                selection = Utilities.PrintAndReadAsInt32("Введите индекс функции: ", newlineAfterMsg: false);
            }

            int a = Utilities.PrintAndReadAsInt32("Введите начальное значение x: ", newlineAfterMsg: false);
            int b = Utilities.PrintAndReadAsInt32("Введите конечное значение x: ", newlineAfterMsg: false);
            double step = Utilities.PrintAndReadAsDouble("Введите шаг: ", newlineAfterMsg: false);

            SaveFunc("data.bin", delegateDict[delegateKeysArray[selection]], a, b, step);
            double[] data = Load("data.bin", out double min_value);
            Utilities.Print($"Минимум: {min_value}");
            Utilities.Print($"Данные:");
            Utilities.Print(String.Join(" ", data));
        }
    }

}
