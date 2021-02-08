//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 1.Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
// Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. 
// В данной задаче под парой подразумевается два подряд идущих элемента массива. 
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class HomeWork1
    {
        public static int DetectPairs(int[] arr)
        {
            int pairs = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] % 3 == 0 || arr[i+1] % 3 == 0)
                {
                    pairs++;
                }
            }

            return pairs;
        }
        public static void Demo()
        {
            int[] arr = new int[20];
            int[] example_arr = { 6, 2, 9, -3, 6 };
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10000, 10000);
            }

            Utilities.Print($"Массив: {{{string.Join(", ", example_arr)}}} содержит {DetectPairs(example_arr)} пар(ы) деляшихся на 3.");
            Utilities.Print($"Массив: {{{string.Join(", ", arr)}}} содержит {DetectPairs(arr)} пар(ы) деляшихся на 3.");
        }

    }
}
