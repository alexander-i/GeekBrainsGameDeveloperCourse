//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:

//а) с использованием методов C#;
//б) *разработав собственный алгоритм.
//Например:
//badc являются перестановкой abcd.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class HomeWork3
    {
        public static bool IsRecombination(string a, string b)
        {
            if (a == null || b == null) { return false; }
            
            char[] aSorted = a.ToCharArray();
            char[] bSorted = b.ToCharArray();
            Array.Sort(aSorted);
            Array.Sort(bSorted);
            return Array.Equals(String.Concat(aSorted), String.Concat(bSorted));
        }

        private static int Partition(char[] a, int l, int h)
        {
            char pivot = a[h];
            int i = l;
            char m;

            for (int j = l; j <= h; j++)
            {
                if (a[j].CompareTo(pivot) > 0)
                {
                    m = a[i];
                    a[i] = a[j];
                    a[j] = m;
                    i++;
                }
            }

            m = a[i];
            a[i] = a[h];
            a[h] = m;

            return i;
        }

        private static char[] MyQuickSortImpl(char[] a, int l, int h)
        {
            if (l < h)
            {
                int p = Partition(a, l, h);
                if (p > 0) { MyQuickSortImpl(a, l, p - 1); }
                MyQuickSortImpl(a, p + 1, h);
            }

            return a;
        }

        public static char[] MyQuickSort(string a)
        {
            if (a != null)
            {

                return MyQuickSortImpl(a.ToCharArray(), 0, a.Length - 1);
            } 
            else
            {
                return new char[0];
            }
        }

        public static bool IsRecombinationAlgo(string a, string b)
        {
            if (a == null || b == null) { return false; }
            else if (a.Length != b.Length) { return false; }
            else
            {

                char[] a_sorted = MyQuickSort(a);
                char[] b_sorted = MyQuickSort(b);

                for (int i = 0; i < a.Length; i++)
                {
                    if (a_sorted[i] != b_sorted[i]) { return false; }
                }

                return true;
            }
            
        }

        public static void Demo()
        {
            string a = "looped";
            string b = "poodle";

            Utilities.Print($"Слова {a} и {b}: {IsRecombination(a, b)}");
            Utilities.Print($"Слова {a} и {b}: {IsRecombinationAlgo(a, b)}");
        }
    }
}
