//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Survey
    {
        public static void Start()
        {            

            string[] questions, answers;

            questions = new string[5] { "Ваше имя", "Ваша фамилия", "Ваш возраст", "Ваш рост", "Ваш вес" };
            answers = new string[5];

            Utilities.Print("Введите данные ниже", true);
            for (int i = 0; i < questions.Length; i++)
            {
                answers[i] = Utilities.PrintAndReadAsString(questions[i], true);
            }

            // а) используя склеивание;
            Utilities.Print(
                questions[0] + ": " + answers[0] + "\n" +
                questions[1] + ": " + answers[1] + "\n" +
                questions[2] + ": " + answers[2] + "\n" +
                questions[3] + ": " + answers[3] + "\n" +
                questions[4] + ": " + answers[4],
                true
            );

            // б) используя форматированный вывод;
            Utilities.Print(
                String.Format("Ваше имя: {0}\nВаша фамилия: {1}\nВаш возраст: {2}\nВаш рост: {3}\nВаш вес: {4}\n", answers), 
                true
            );

            // в) используя вывод со знаком $.
            Utilities.Print(
                $"{questions[0]}: {answers[0]}\n{questions[1]}: {answers[1]}\n{questions[2]}: {answers[2]}\n{questions[3]}: {answers[3]}\n{questions[4]}: {answers[4]}",
                true
            );

        }
    }
}
