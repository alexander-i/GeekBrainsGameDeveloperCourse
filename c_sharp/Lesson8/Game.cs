using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class Game : Form
    {
        TrueFalse database;
        Random r;
        int currentQuestion;
        int correctAnswers;
        public Game()
        {
            InitializeComponent();
            r = new Random();
        }

        private void StartGame()
        {
            if (database == null || database.Count == 0) {
                MessageBox.Show("База данных не загружена или пуста.");
                return; 
            }
            else
            {
                currentQuestion = 0;
                correctAnswers = 0;
                questionTextBox.Text = database[currentQuestion].text;
                currentQuestionLabel.Text = $"{currentQuestion + 1} / {database.Count}";
                correctAnswersLabel.Text = "0";
                trueButton.Enabled = true;
                notTrueButton.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadQuestions()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                StartGame();
            }
        }

        private void loadQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadQuestions();
        }

        private void checkAnswer(bool answer)
        {
            if (database[currentQuestion].trueFalse == answer)
            {
                MessageBox.Show("Ответ верный");
                correctAnswersLabel.Text = $"{++correctAnswers}";
            }
            else
            {
                MessageBox.Show("Ответ неверный");
            }

            if (currentQuestion + 1 < database.Count)
            {
                currentQuestion++;
                questionTextBox.Text = database[currentQuestion].text;
                currentQuestionLabel.Text = $"{currentQuestion + 1} / {database.Count}";
            }
            else
            {
                MessageBox.Show("Игра окончена!");
                trueButton.Enabled = false;
                notTrueButton.Enabled = false;
            }
        }

        private void trueButton_Click(object sender, EventArgs e)
        {
            checkAnswer(true);
        }

        private void notTrueButton_Click(object sender, EventArgs e)
        {
            checkAnswer(false);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                loadQuestions();
            }
            StartGame();
        }
    }
}
