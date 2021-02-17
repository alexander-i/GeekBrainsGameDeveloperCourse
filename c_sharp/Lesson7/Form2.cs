//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//

// 2. Используя Windows Forms, разработать игру «Угадай число». 
// Компьютер загадывает число от 1 до 100, а человек пытается его угадать 
// за минимальное число попыток. Для ввода данных от человека используется элемент TextBox.
// Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form2 : Form
    {
        int Secret;
        Random R;
        int Boundary1;
        int Boundary2;
        int Attempts;
        public Form2()
        {
            InitializeComponent();

            Boundary1 = 0;
            Boundary2 = 100;
            initGame();
        }

        private void initGame()
        {
            Attempts = 0;
            R = new Random();
            Secret = R.Next(Boundary1, Boundary2);
            hintLabel.Text = $"Загадано число от {Boundary1} до {Boundary2}";
            attemptsLabel.Text = $"{Attempts}";
        }

        private void attemptButton_Click(object sender, EventArgs e)
        {
            int value;
            bool success = int.TryParse(attempTextBox.Text, out value);

            attemptsLabel.Text = $"{++Attempts}";

            if (!success)
            {
                MessageBox.Show($"{attempTextBox.Text} - не целое число. Введите целое число.");
            }
            else if (value == Secret)
            {
                MessageBox.Show($"Ура, вы угадали! Ответ: {Secret}. Загадано новое число");
                initGame();
            }
            else if (value < Secret)
            {
                hintLabel.Text = $"{value} - маловато. Попробуйте число побольше.";
            }
            else
            {
                hintLabel.Text = $"{value} - большое. Попробуйте число поменьше.";
            }
        }
    }
}
