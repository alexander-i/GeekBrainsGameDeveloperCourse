//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Utilities
    {
        public static void CenterAndPrint(string msg, bool newline = false)
        {
            int offset = (Console.WindowWidth + msg.Length) / 2;
            Print(msg, newline, offset);
        }

        public static void Print()
        {
            Console.WriteLine();
        }

        public static void Print(string msg, bool newline=false, int offset = 0)
        {
            Console.WriteLine("{0," + offset + "}", msg);
            if (newline)
            {
                Print();
            }
        }

        public static double ReadDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double PrintAndReadAsDouble(string msg, bool newline=false)
        {
            // не стал пока разбираться с дженериками, т. к. они наверняка будут позже
            Print(msg);
            double res = ReadDouble();
            if (newline)
            {
                Print();
            }
            return res;
        }

        public static string PrintAndReadAsString(string msg, bool newline=false)
        {
            Print(msg);
            string res = Console.ReadLine();
            if (newline)
            {
                Print();
            }
            return res;
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
