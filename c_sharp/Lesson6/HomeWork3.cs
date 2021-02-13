//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 3. Переделать программу «Пример использования коллекций» для решения следующих задач:

// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
// в) отсортировать список по возрасту студента;
// г) *отсортировать список по курсу и возрасту студента;
// д) разработать единый метод подсчета количества студентов по различным параметрам
// выбора с помощью делегата и методов предикатов.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Lesson6
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int course, int age, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }

    class HomeWork3
    {
        public delegate bool F(Student s);

        static int MyDelegate(Student st1, Student st2)
        {
            return String.Compare(st1.firstName, st2.firstName);
        }

        static int MyDelegateAge(Student st1, Student st2)
        {
            if (st1.age > st2.age) { return 1; }
            else if (st1.age == st2.age) { return 0; }
            else { return -1; }
        }

        static int MyDelegateCourse(Student st1, Student st2)
        {
            if (st1.course > st2.course) { return 1; }
            else if (st1.course  == st2.course) { return 0; }
            else { return -1; }
        }

        static int CountStudents(F fun, List<Student> list)
        {
            int i = 0;

            foreach(Student s in list)
            {
                if (fun(s)) { i++; }
            }

            return i;
        }

        static void SortByCourseAge(List<Student> l)
        {
            l.Sort(MyDelegateCourse);

            int indx = 0;
            int currentCourse = l[0].course;
            List<Student> partialList = new List<Student>();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].course == currentCourse)
                {
                    partialList.Add(l[i]);
                }
                else
                {
                    partialList.Sort(MyDelegateAge);
                    for (int j = indx; j < partialList.Count; j++) 
                    {
                        l[j] = partialList[j - indx]; 
                    }
                    indx = i;
                    currentCourse = l[i].course;
                    partialList.Clear();

                }
            }
        }

        public static void Demo()
        {
            int bakalavr = 0;
            int magistr = 0;
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("../../students.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    if (int.Parse(s[5]) < 5) bakalavr++; else magistr++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();
            list.Sort(new Comparison<Student>(MyDelegate));
            Console.WriteLine("Всего студентов:" + CountStudents(delegate (Student s) { return true; }, list));
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);

            Console.WriteLine();

            int[,] freqArray = new int[,] {
                {18,0}, {19,0}, {20,0}
            };

            foreach(Student s in list)
            {
                if (s.age == 18) { freqArray[0, 1]++; }
                if (s.age == 19) { freqArray[1, 1]++; }
                if (s.age == 20) { freqArray[2, 1]++; }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Студентов возраста {freqArray[i, 0]}: {freqArray[i, 1]}");
            }

            Console.WriteLine();
            foreach (var v in list) Console.WriteLine($"{v.firstName}, {v.age}, {v.course}");

            Console.WriteLine();
            list.Sort(new Comparison<Student>(MyDelegateAge));
            Console.WriteLine("Сортированный по возрасту список:");
            foreach (var v in list) Console.WriteLine($"{v.firstName}, {v.age}, {v.course}");

            Console.WriteLine();
            SortByCourseAge(list);
            Console.WriteLine("Сортированный по возрасту и курсу список:");
            foreach (var v in list) Console.WriteLine($"{v.firstName}, {v.age}, {v.course}");

            Console.WriteLine();
            Console.WriteLine("Пример подсчета методом с делегатами-предикатами:");
            Console.WriteLine("Всего студентов старше 20:" + CountStudents(delegate (Student s) { return s.age > 20; }, list));

            Console.WriteLine();
            Console.WriteLine(DateTime.Now - dt);

        }
    }
}
