//
// Александр Иванов (https://geekbrains.ru/users/4631092)
//

//1.а) Добавить в программу «Удвоитель» подсчет количества отданных команд.

//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов.
//в) *Добавить кнопку «Отменить», которая отменяет последние ходы.

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
    public partial class Form1 : Form
    {
        Stack<int> NumberHistory;
        int CurrentValue;
        int NumberOfCommands;
        public Form1()
        {
            InitializeComponent();

            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblNumberText.Text = "Число:";
            lblCommands.Text = "0";
            lblCommandsText.Text = "Отдано команд:";
            lblGoal.Text = "Цель:";
            lblGoalValue.Text = "???";
            undoButton.Text = "Отменить ход";
            this.Text = "Удвоитель";

            NumberHistory = new Stack<int>();
        }

        private void InitGame(int n)
        {
            lblNumber.Text = "0";
            lblCommands.Text = "0";
            NumberHistory.Clear();
            CurrentValue = 0;
            NumberOfCommands = 0;
            lblGoalValue.Text = $"{n}";
        }

        private void UpdateNumberOfCommands()
        {
            lblCommands.Text = (++NumberOfCommands).ToString();
        }

        private void UpdateCurrentValue(int newValue)
        {
            CurrentValue = newValue;
            lblNumber.Text = CurrentValue.ToString();

            if (lblNumber.Text == lblGoalValue.Text)
            {
                MessageBox.Show("Победа!");
            }
        }

        private void RecordCurrentValue()
        {
            NumberHistory.Push(CurrentValue);
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            RecordCurrentValue();
            UpdateCurrentValue(CurrentValue + 1);
            UpdateNumberOfCommands();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            RecordCurrentValue();
            UpdateCurrentValue(CurrentValue * 2);
            UpdateNumberOfCommands();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RecordCurrentValue();
            UpdateCurrentValue(1);
            UpdateNumberOfCommands();
            NumberHistory.Clear();
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int target = r.Next(0, 100);
            InitGame(r.Next(0, 100));
            MessageBox.Show($"Цель: Набрать {target} за минимальное число ходов");

        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            UpdateNumberOfCommands();

            if (NumberHistory.Count() > 0)
            {
                UpdateCurrentValue(NumberHistory.Pop());
            }
        }
    }
}
