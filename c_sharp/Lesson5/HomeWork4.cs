//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//4.Задача ЕГЭ.


//* На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
//школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
//превосходит 100, каждая из следующих N строк имеет следующий формат:
//< Фамилия > < Имя > < оценки >,
//где < Фамилия > — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
//более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
//пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
//Пример входной строки:
//Иванов Петр 4 5 3
//Требуется написать как можно более эффективную программу, которая будет выводить на экран
//фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
//набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
//Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в
//начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
//задач используйте неизменяемые строки (string)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    class Entry
    {
        private static char[] EndChar = { ',' };
        string Name { get; }
        string Surname { get; }
        int[] Marks { get; }

        public Entry(string line)
        {
            string [] splittedLine = line.TrimEnd(EndChar).Split(' ');
            if (splittedLine.Length != 5) { throw new Exception($"Некорректный формат строки: {line}"); }

            Marks = new int[3];
            bool readSuccess;

            Name = splittedLine[0];
            Surname = splittedLine[1];
            
            
            for (int i = 0; i < 3; i++)
            {
                readSuccess = int.TryParse(splittedLine[i + 2], out int mark);
                if (readSuccess) { Marks[i] = mark; }
            }
        }

        public static int Compare(Entry a, Entry b)
        {
            if (a.Average == b.Average) { return 0; }
            else if (a.Average > b.Average) { return 1; }
            else { return -1; }
        }

        public override string ToString()
        {
            return $"{Name} {Surname},\tОценки: [{String.Join(", ", Marks)}],\tСреднее: {this.Average}";
        }

        public double Average
        {
            get { return Marks.Average(); }
        }
    }
    class TestResults
    {
        public Entry[] Entries { get; }

        private TestResults() { }

        public TestResults(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            bool readSuccess = int.TryParse(sr.ReadLine(), out int NumberOfStudents);
            if (!readSuccess) { throw new Exception("Неверно указано число студентов"); }

            Entries = new Entry[NumberOfStudents];
            
            for (int i = 0; i < NumberOfStudents; i++)
            {
                Entries[i] = new Entry(sr.ReadLine());
            }

            sr.Close();

            Array.Sort(Entries, Entry.Compare);
        }

        public Entry[] LastNStudents(int n)
        {
            int min_scores = 0;
            double last_score = 0;
            Entry[] result;

            for (int i = 0; i < Entries.Length; i++)
            {
                if (Entries[i].Average > last_score) { 
                    min_scores++; 
                    if (min_scores == n)
                    {
                        result = new Entry[i+1];
                        Array.Copy(Entries, result, i+1);
                        return result;
                    }
                }
            }

            // не было трех разныъ средних - возвращаем все
            result = new Entry[Entries.Length];
            Array.Copy(Entries, result, Entries.Length);
            return result;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < Entries.Length; i++)
            {
                s.AppendLine($"{Entries[i]}");
            }

            return s.ToString();
        }

        public int Length
        {
            get { return Entries.Length; }
        }

    }
    class HomeWork4
    {
        public static void Demo()
        {
            int n = 3;
            string filename = "../../exam_result.txt";

            TestResults tr = new TestResults(filename);
            Utilities.Print("Считанный файл:");
            Utilities.Print($"{tr}");

            Utilities.Print($"Студенты с {n} худшими средними баллами");
            Entry[] lastStudents = tr.LastNStudents(n);
            for(int i = 0; i < n; i++)
            {
                Utilities.Print($"{lastStudents[i]}");
            }
        }
    }
}
