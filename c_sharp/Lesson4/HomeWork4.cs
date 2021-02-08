//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 4. *а) Реализовать класс для работы с двумерным массивом. Реализовать конструктор, заполняющий массив случайными числами. 
// Создать методы, которые возвращают сумму всех элементов массива, сумму всех элементов массива больше заданного, 
// свойство, возвращающее минимальный элемент массива, свойство, возвращающее максимальный элемент массива, метод, 
// возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out)

// *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
// Дополнительные задачи
// в) Обработать возможные исключительные ситуации при работе с файлами.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson4
{
    class Array2d
    {
        int[,] arr;
        
        public int N { get; }
        public int M { get; }

        private Array2d(int n, int m) { 
            arr = new int[n, m];
            N = n;
            M = m;
        }

        public static Array2d WithRandomNumbers(int n, int m)
        {
            Array2d a2d = new Array2d(n, m);
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a2d.arr[i, j] = rnd.Next(-100, 100);
                }
            }

            return a2d;
        }

        public static bool TryWithFile(string filename, ref Array2d a2d)
        {
            return a2d.LoadFromFile(filename);
        }

        public int this[int i, int j]
        {
            get { return arr[i, j]; }
            set { arr[i, j] = value; }
        }

        public bool LoadFromFile(string filename)
        {
            try
            {
                StreamReader sr = new StreamReader(filename);

                bool success_n = int.TryParse(sr.ReadLine(), out int n);
                bool success_m = int.TryParse(sr.ReadLine(), out int m);

                if (!(success_m && success_n))
                {
                    throw (new Exception("Wrong File Format"));
                }

                arr = new int[n, m];

                string[] splittedLine = new string[m];

                for (int i = 0; i < n; i++)
                {
                    splittedLine = sr.ReadLine().Split(' ');

                    for (int j = 0; j < splittedLine.Length; j++)
                    {
                        if (int.TryParse(splittedLine[j], out int e)) { arr[i, j] = e; }
                        else { arr[i, j] = 0; }
                    }
                }

                sr.Close();

                return true;
            }
            catch (FileNotFoundException)
            {
                Utilities.Print($"Не удалось найти файл {filename}");
            }

            return false;
        }

        public bool TryWriteToFile(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);

                sw.WriteLine(N);
                sw.WriteLine(M);
                string[] line = new string[M];
                for (int i = 0; i < N; i++)
                {

                    for (int j = 0; j < M; j++)
                    {
                        line[j] = $"{arr[i, j]}";
                    }

                    sw.WriteLine(String.Join(" ", line));
                }

                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                Utilities.Print($"Не удалось сделать запись в файл. Причина: {e.Message}");
            }

            return false;
        }

        public int SumGreaterThanN(int n)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (arr[i, j] > n) { sum += arr[i, j]; }
                }
            }

            return sum;
        }

        public void MaxElementIndex(out int i, out int j)
        {
            
            i = 0;
            j = 0;
            
            int max_element = arr[i, j];

            for (int _i = 0; _i < N; _i++)
            {
                for (int _j = 1; _j < M; _j++)
                {
                    if (arr[_i, _j] > max_element) 
                    {
                        max_element = arr[_i, _j];
                        i = _i;
                        j = _j;
                    }
                }
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        sum += arr[i, j];
                    }
                }

                return sum;
            }
        }

        public int Min
        {
            get
            {
                int min = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (arr[i, j] < min) { min = arr[i, j]; }
                    }
                }

                return min;
            }
        }

        public int Max
        {
            get
            {
                int max = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (arr[i, j] > max) { max = arr[i, j]; }
                    }
                }

                return max;
            }
        }

        override public string ToString()
        {
            string res = "";
            string[] line = new string[M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    line[j] = $"{arr[i, j]}";
                }
                res += String.Join(" ", line);
                res += '\n';
            }

            return res;
        }
    }

    class HomeWork4
    {
        public static void Demo()
        {
            string filename = "array2d.txt";
            int n = 12;
            int m = 10;

            Utilities.Print($"Создаем массив с размером индексов: [{n}, {m}]");
            Array2d array2d = Array2d.WithRandomNumbers(n, m);
            Utilities.Print($"{array2d}");
            Utilities.Print($"Максимальный элемент: {array2d.Max}");
            Utilities.Print($"Минимальный элемент: {array2d.Min}");
            Utilities.Print($"Сумма элементов: {array2d.Sum}");
            Utilities.Print($"Сумма элементов больше 10: {array2d.SumGreaterThanN(10)}");

            array2d.MaxElementIndex(out int max_i, out int max_j);
            Utilities.Print($"Индексы максимального элемента: [{max_i}, {max_j}]");

            bool writeSuccess = array2d.TryWriteToFile(filename);
            if (writeSuccess) { Utilities.Print($"Массив записан в {filename}"); }

            bool readSuccess = Array2d.TryWithFile(filename + "ваы", ref array2d);
            if (readSuccess) { Utilities.Print($"Массив успешно прочитан из {filename}"); }

            readSuccess = Array2d.TryWithFile(filename, ref array2d);
            if (readSuccess) { Utilities.Print($"Массив успешно прочитан из {filename}"); }
            Utilities.Print($"{array2d}");

        }
    }
}
