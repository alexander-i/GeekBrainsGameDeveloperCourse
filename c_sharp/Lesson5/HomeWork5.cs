//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
// 5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. 
// Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, 
// случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос 
// и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson5
{
    class Question
    {
        public string Text { get; }
        public bool Truth { get; }

        public Question(string text, bool truth)
        {
            Text = text;
            Truth = truth;
        }

        public Question(string line)
        {
            string[] splittedLine = line.Split('\t');
            if (splittedLine.Length != 2) { throw new Exception($"Некорректный формат строки: {line}"); }
            
            Text = splittedLine[0];
            Truth = (splittedLine[1] == "1");
        }

        public override string ToString()
        {
            return $"Вопрос: {Text}.\nОтвет: {(Truth ? "Да" : "Нет")}";
        }
    }

    class QuizSession
    {
        private Question[] Questions { get; }
        private int Successes;

        public QuizSession(Question[] questions)
        {
            this.Questions = questions;
        }

        public void Start()
        {
            Utilities.Print($"Начинаем игру! Вам будет задано {Questions.Length} вопросов. Отвечайте \"Да\" или \"Нет\"");

            foreach (Question q in Questions)
            {
                string answer = Utilities.PrintAndReadAsString(q.Text);
                if ((answer == "Да" && q.Truth == true) || (answer == "Нет" && q.Truth == false))
                {
                    Utilities.Print("Верно!");
                    Successes++;
                }
                else if (answer != "Нет" && answer != "Да")
                {
                    Utilities.Print("Вы ответили не \"Да\" или \"Нет\". Ответ не засчитан");
                }
                else
                {
                    Utilities.Print("Неверно.");
                }
                Utilities.Print();
            }

            Utilities.Print($"Вы ответили верно на {Successes} вопросов из {Questions.Length}");
        }

        public int Length
        {
            get { return Questions.Length; }
        }
    }

    class Quiz
    {
        private Random R;
        public Question[] Questions { get; }

        private Quiz() { }

        public Quiz(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            bool readSuccess = int.TryParse(sr.ReadLine(), out int NumberOfQuestions);
            if (!readSuccess) { throw new Exception("Неверно указано число студентов"); }

            Questions = new Question[NumberOfQuestions];

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Questions[i] = new Question(sr.ReadLine());
            }

            sr.Close();

            R = new Random(); 
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            for (int i = 0; i < Questions.Length; i++)
            {
                s.AppendLine($"{Questions[i]}");
            }

            return s.ToString();
        }

        public int Length
        {
            get { return Questions.Length; }
        }

        public QuizSession Init(int n)
        {
            int qNumber;
            HashSet<int> questionNumbers = new HashSet<int>();
            Question[] sessionQuestions = new Question[n];
            while (questionNumbers.Count() < n)
            {
                qNumber = R.Next(Questions.Length);
                if (!questionNumbers.Contains(qNumber)) {
                    sessionQuestions[questionNumbers.Count()] = Questions[qNumber]; 
                }
                questionNumbers.Add(qNumber);
            }
            QuizSession qs = new QuizSession(sessionQuestions);
            return qs;
        }

    }
    class HomeWork5
    {
        public static void Demo()
        {
            int n = 3;
            string filename = "../../quiz.txt";
            Question question;

            Quiz q = new Quiz(filename);
            Utilities.Print("Считанный файл:");
            Utilities.Print($"{q}");

            // т. к. файла с вопросами в приложении не нашел, делаю 3 вопроса из 4 - по смыслу то же самое

            QuizSession s = q.Init(n);
            s.Start();

        }
    }
}
