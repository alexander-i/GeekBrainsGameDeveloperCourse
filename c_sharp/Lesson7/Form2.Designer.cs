
namespace Lesson7
{
    partial class Form2
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
            this.attempTextBox = new System.Windows.Forms.TextBox();
            this.attemptButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // attempTextBox
            // 
            this.attempTextBox.Location = new System.Drawing.Point(144, 107);
            this.attempTextBox.Name = "attempTextBox";
            this.attempTextBox.Size = new System.Drawing.Size(219, 20);
            this.attempTextBox.TabIndex = 0;
            // 
            // attemptButton
            // 
            this.attemptButton.Location = new System.Drawing.Point(144, 142);
            this.attemptButton.Name = "attemptButton";
            this.attemptButton.Size = new System.Drawing.Size(219, 23);
            this.attemptButton.TabIndex = 1;
            this.attemptButton.Text = "Попытать счастья!";
            this.attemptButton.UseVisualStyleBackColor = true;
            this.attemptButton.Click += new System.EventHandler(this.attemptButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Загаданное число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ваш вариант:";
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(141, 33);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(35, 13);
            this.hintLabel.TabIndex = 4;
            this.hintLabel.Text = "label3";
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(141, 72);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(13, 13);
            this.attemptsLabel.TabIndex = 6;
            this.attemptsLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Число попыток:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 271);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attemptButton);
            this.Controls.Add(this.attempTextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox attempTextBox;
        private System.Windows.Forms.Button attemptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label label5;
    }
}