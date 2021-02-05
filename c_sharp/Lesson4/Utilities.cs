//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Utilities
    {
        public static void CenterAndPrint(string msg, bool newline = false, bool newlineAfterMsg = true)
        {
            int offset = (Console.WindowWidth + msg.Length) / 2;
            Print(msg, newline, offset, newlineAfterMsg);
        }

        public static void Print()
        {
            Console.WriteLine();
        }

        public static void Print(string msg, bool newline=false, int offset = 0, bool newlineAfterMsg = true)
        {
            string formattedString = String.Format("{0," + offset + "}", msg);
            
            if (newlineAfterMsg)
            {
                Console.WriteLine(formattedString);
            } else
            {
                Console.Write(formattedString);
            }

            if (newline)
            {
                Print();
            }
        }

        public static double ReadDouble()
        {
            bool success;
            double res;
            do
            {
                success = double.TryParse(Console.ReadLine(), out res);
                if (!success) { Print("Ошибка конвертации. Попробуйте еще раз."); }
            } while (!success);

            return res;
        }

        public static int ReadInt32()
        {
            bool success;
            int res;
            do
            {
                success = int.TryParse(Console.ReadLine(), out res);
                if (!success) { Print("Ошибка конвертации. Попробуйте еще раз."); }
            } while (!success);

            return res;
        }

        public static double PrintAndReadAsDouble(string msg, bool newline=false, bool newlineAfterMsg = true)
        {
            // не стал пока разбираться с дженериками, т. к. они наверняка будут позже
            Print(msg, newlineAfterMsg: newlineAfterMsg);
            double res = ReadDouble();
            if (newline)
            {
                Print();
            }
            return res;
        }

        public static int PrintAndReadAsInt32(string msg, bool newline = false, bool newlineAfterMsg = true)
        {
            // не стал пока разбираться с дженериками, т. к. они наверняка будут позже
            Print(msg, newlineAfterMsg: newlineAfterMsg);
            int res = ReadInt32();
            if (newline)
            {
                Print();
            }
            return res;
        }

        public static string PrintAndReadAsString(string msg, bool newline=false, bool newlineAfterMsg = true)
        {
            Print(msg, newlineAfterMsg: newlineAfterMsg);
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
