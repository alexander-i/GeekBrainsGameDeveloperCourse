
namespace Lesson8
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trueButton = new System.Windows.Forms.Button();
            this.notTrueButton = new System.Windows.Forms.Button();
            this.currentQuestionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correctAnswersLabel = new System.Windows.Forms.Label();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadQuestionsToolStripMenuItem,
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadQuestionsToolStripMenuItem
            // 
            this.loadQuestionsToolStripMenuItem.Name = "loadQuestionsToolStripMenuItem";
            this.loadQuestionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadQuestionsToolStripMenuItem.Text = "Load Questions";
            this.loadQuestionsToolStripMenuItem.Click += new System.EventHandler(this.loadQuestionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(12, 65);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionTextBox.Size = new System.Drawing.Size(776, 309);
            this.questionTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вопрос";
            // 
            // trueButton
            // 
            this.trueButton.Location = new System.Drawing.Point(275, 405);
            this.trueButton.Name = "trueButton";
            this.trueButton.Size = new System.Drawing.Size(75, 23);
            this.trueButton.TabIndex = 3;
            this.trueButton.Text = "Верю";
            this.trueButton.UseVisualStyleBackColor = true;
            this.trueButton.Click += new System.EventHandler(this.trueButton_Click);
            // 
            // notTrueButton
            // 
            this.notTrueButton.Location = new System.Drawing.Point(450, 405);
            this.notTrueButton.Name = "notTrueButton";
            this.notTrueButton.Size = new System.Drawing.Size(75, 23);
            this.notTrueButton.TabIndex = 4;
            this.notTrueButton.Text = "Не верю";
            this.notTrueButton.UseVisualStyleBackColor = true;
            this.notTrueButton.Click += new System.EventHandler(this.notTrueButton_Click);
            // 
            // currentQuestionLabel
            // 
            this.currentQuestionLabel.AutoSize = true;
            this.currentQuestionLabel.Location = new System.Drawing.Point(63, 49);
            this.currentQuestionLabel.Name = "currentQuestionLabel";
            this.currentQuestionLabel.Size = new System.Drawing.Size(0, 13);
            this.currentQuestionLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Верных ответов:";
            // 
            // correctAnswersLabel
            // 
            this.correctAnswersLabel.AutoSize = true;
            this.correctAnswersLabel.Location = new System.Drawing.Point(748, 49);
            this.correctAnswersLabel.Name = "correctAnswersLabel";
            this.correctAnswersLabel.Size = new System.Drawing.Size(0, 13);
            this.correctAnswersLabel.TabIndex = 7;
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.correctAnswersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentQuestionLabel);
            this.Controls.Add(this.notTrueButton);
            this.Controls.Add(this.trueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = "Game";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadQuestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button trueButton;
        private System.Windows.Forms.Button notTrueButton;
        private System.Windows.Forms.Label currentQuestionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label correctAnswersLabel;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}