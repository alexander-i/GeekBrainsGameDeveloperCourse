//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий массив 
// заданной размерности и заполняющий массив числами от начального значения с заданным шагом. 
// Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, 
// меняющий знаки у всех элементов массива, метод Multi, умножающий каждый элемент массива на 
// определенное число, свойство MaxCount, возвращающее количество максимальных элементов. 
// В Main продемонстрировать работу класса.
//
// б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4
{
    class MyArray
    {
        int[] a;

        private MyArray()
        {
            /* чтобы решить проблему наличия конструкторов с одинаковыми параметрами, делаем фабрику */
        }

        public static MyArray WithNandElement(int n, int el)
        {
            MyArray arr = new MyArray();
            arr.a = new int[n];
            for (int i = 0; i < n; i++)
                arr.a[i] = el;

            return arr;
        }

        public static MyArray WithNStartStep(int n, int startValue, int step)
        {
            MyArray arr = new MyArray(); 
            arr.a = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr.a[i] = startValue + i * step;
            }

            return arr;
        }

        public static MyArray WithNMinMax(int n, int min, int max)
        {
            MyArray arr = new MyArray();
            arr.a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                arr.a[i] = rnd.Next(min, max);

            return arr;
        }

        public static MyArray WithFilename(string filename)
        {
            MyArray arr = new MyArray();
            if (File.Exists(filename))
            {
                StreamReader reader = new StreamReader(filename);
                int[] a = new int[int.Parse(reader.ReadLine())];

                for (int i = 0; i < a.Length; i++)
                {
                    if (int.TryParse(reader.ReadLine(), out int e)) { a[i] = e; }
                    else { a[i] = 0; }
                }

                reader.Close();
                arr.a = a;
            }
            else
            {
                //throw new Exception("Файл не найден.");
                throw new FileNotFoundException();
            }

            return arr;
        }

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }

        public int Sum
        {
            get
            {
                return this.a.Sum();
            }
        }


        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int MaxCount
        {
            get
            {
                if (a.Length < 2) { return a.Length; }
                else
                {
                    int count = 1;
                    int maxNum = a[0];

                    for (int i = 1; i < a.Length; i++)
                    {
                        if (a[i] == maxNum) { count++; }
                        else if (a[i] > maxNum)
                        {
                            count = 1;
                            maxNum = a[i];
                        }
                    }

                    return count;
                }
            }
        }

        public void Multi(int k)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= k;
            }
        }

        public void Inverse()
        {
            Multi(-1);
        }

        public void ToFile(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);

            sw.WriteLine(a.Length);

            foreach (int e in a)
            {
                sw.WriteLine(e);
            }

            sw.Close();
        }

        public void FromFile(string filename)
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(filename);
                int[] a = new int[int.Parse(sr.ReadLine())];

                for (int i = 0; i < a.Length; i++)
                {
                    if (int.TryParse(sr.ReadLine(), out int e)) { a[i] = e; }
                    else { a[i] = 0; }
                }

                sr.Close();
                this.a = a;
            }
            catch (FileNotFoundException e)
            {
                Utilities.Print($"Файла {filename} не существует.");
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }

    class HomeWork2
    {
        public static void Demo()
        {
            string filename = "array.txt";

            Utilities.Print($"Создаем массив в 12 элементов, начиная с 2 и шагом 4");
            MyArray myArray = MyArray.WithNStartStep(12, 2, 4);
            Utilities.Print($"{myArray}");

            Utilities.Print($"Умножаем на 2");
            myArray.Multi(2);
            Utilities.Print($"{myArray}");

            Utilities.Print($"Инвертируем");
            myArray.Inverse();
            Utilities.Print($"{myArray}");

            Utilities.Print($"Пишем массив в {filename}");
            myArray.ToFile(filename);
            Utilities.Print($"{myArray}");

            Utilities.Print($"Пробуем прочитать {filename + "sdsf"}");
            myArray.FromFile(filename + "sdsf");

            Utilities.Print($"Создаем массив в 12 элементов равных 12");
            myArray = MyArray.WithNandElement(12, 12);
            Utilities.Print($"{myArray}");
            Utilities.Print($"Максимальных элементов: {myArray.MaxCount}.");

            Utilities.Print($"Читаем массив из {filename}");
            myArray.FromFile(filename);
            Utilities.Print($"{myArray}");





        }
    }
}
