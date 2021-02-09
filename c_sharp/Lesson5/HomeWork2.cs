//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//
//2.Разработать класс Message, содержащий следующие статические методы для обработки текста:
//
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//Продемонстрируйте работу программы на текстовом файле с вашей программой.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Message
    {
        private Message() { }

        private static int CompareWordsByLength(string a, string b)
        {
            if (a == null && b == null) { return 0; }
            else if (a == null) { return -1; }
            else if (b == null) { return 1; }
            else if (a.Length == b.Length) { return 0; }
            else if (a.Length > b.Length) { return 1; }
            else { return -1; }
        }

        public static string FilterByWordLength(string message, int n)
        {
            char[] wordCandidate = new char[n];
            char[] word;
            int m = 0;
            StringBuilder sb = new StringBuilder();

            // Можно было бы сделать через split/join, но выглядит менее эффективным?
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ' || (i == (message.Length - 1)))
                {
                    if (m < n) {
                        word = new char[m];
                        Array.Copy(wordCandidate, word, m);
                        sb.Append(word);
                        sb.Append(' ');
                    }
                    m = 0;
                }
                else if (m >= n) { m++; }
                else if (char.IsLetter(message[i]))
                {
                    wordCandidate[m] = message[i];
                    m++;
                }
            }

            return sb.Remove(sb.Length - 1, 1).ToString();
        }

        public static string FilterByLastChar(string message, char lastChar)
        {
            StringBuilder textBuilder = new StringBuilder();
            StringBuilder wordBuilder = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ' || (i == (message.Length - 1)))
                {
                    if (wordBuilder.Length > 0 && wordBuilder[wordBuilder.Length - 1] != lastChar)
                    { 
                        textBuilder.Append(wordBuilder);
                        textBuilder.Append(' ');
                    }
                    wordBuilder.Clear();
                }
                else if (char.IsLetter(message[i]))
                {
                    wordBuilder.Append(message[i]);
                }
            }

            return textBuilder.Remove(textBuilder.Length - 1, 1).ToString();
        }

        public static string FilterByLongestWord(string message)
        {
            string word = "";
            StringBuilder wordBuilder = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ' || (i == (message.Length - 1)))
                {
                    if (wordBuilder.Length > word.Length)
                    {
                        word = wordBuilder.ToString();
                    }
                    wordBuilder.Clear();
                }
                else if (char.IsLetter(message[i]))
                {
                    wordBuilder.Append(message[i]);
                }
            }

            return word;
        }

        public static string LongestWordsString(string message, int n)
        {
            List<string> words = new List<string>();
            StringBuilder wordBuilder = new StringBuilder();
            StringBuilder resultBuilder = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ' || (i == (message.Length - 1)))
                {
                    words.Add(wordBuilder.ToString());
                    wordBuilder.Clear();
                }
                else if (char.IsLetter(message[i]))
                {
                    wordBuilder.Append(message[i]);
                }
            }


            words.Sort(CompareWordsByLength);
            words.Reverse();

            for (int i = 0; i < Math.Min(n, words.Count); i++)
            {
                resultBuilder.Append(words[i]);
                resultBuilder.Append(' ');
            }

            return resultBuilder.Remove(resultBuilder.Length - 1, 1).ToString();
        }
    }
    class HomeWork2
    {
        public static void Demo()
        {
            string filteredText;
            string text = "It is a truth universally acknowledged, that a single man in possession of a good fortune, must be in want of a wife.";
            int n = 4;
            char lastChar = 'e';
            
            Utilities.Print($"Text is \"{text}\"");
            
            filteredText = Message.FilterByWordLength(text, n);
            Utilities.Print($"Text without words greater than {n}: \"{filteredText}\"");

            filteredText = Message.FilterByLastChar(text, lastChar);
            Utilities.Print($"Text without words ending in {lastChar}: \"{filteredText}\"");

            filteredText = Message.FilterByLongestWord(text);
            Utilities.Print($"The longest word is: \"{filteredText}\"");

            filteredText = Message.LongestWordsString(text, n);
            Utilities.Print($"String from the {n} longest words is: \"{filteredText}\"");
        }
    }
}
