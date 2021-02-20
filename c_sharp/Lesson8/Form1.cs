using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lesson8
{
    public partial class Form1 : Form
    {
        TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = 1;
                numericUpDownNumber.Value = 1;
            };

        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database != null)
            {
                textBoxQuestion.Text = database[(int)numericUpDownNumber.Value - 1].text;
                checkBoxTrue.Checked = database[(int)numericUpDownNumber.Value - 1].trueFalse;
            }
            else
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
            }
            else
            {
                database.Add((database.Count + 1).ToString(), true);
                numericUpDownNumber.Maximum = database.Count;
                numericUpDownNumber.Value = database.Count;
            }

        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить вопрос?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            if (numericUpDownNumber.Maximum == 1 || database == null) return;
            database.Remove((int)numericUpDownNumber.Value);
            numericUpDownNumber.Maximum--;
            if (numericUpDownNumber.Value > 1) numericUpDownNumber.Value = numericUpDownNumber.Value;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                numericUpDownNumber.Minimum = 1;
                numericUpDownNumber.Maximum = database.Count;
                numericUpDownNumber.Value = 1;
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[(int)numericUpDownNumber.Value - 1].text = textBoxQuestion.Text;
                database[(int)numericUpDownNumber.Value - 1].trueFalse = checkBoxTrue.Checked;
            }
            else
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
            }
        }
         
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Авторы: GeekBrains, Alex Ivanov\nВерсия: 0.1\nАвторские права: BSD";
            MessageBox.Show(msg, "О программе");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "db files (*.db)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database.FileName = sfd.FileName;
                if (database != null) database.Save();
                else MessageBox.Show("База данных не создана");
            }
        }
    }
}