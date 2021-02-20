
namespace Lesson7
{
    partial class Form1
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
            this.lblNumberText = new System.Windows.Forms.Label();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCommandsText = new System.Windows.Forms.Label();
            this.lblCommands = new System.Windows.Forms.Label();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblGoalValue = new System.Windows.Forms.Label();
            this.undoButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberText
            // 
            this.lblNumberText.AutoSize = true;
            this.lblNumberText.Location = new System.Drawing.Point(56, 80);
            this.lblNumberText.Name = "lblNumberText";
            this.lblNumberText.Size = new System.Drawing.Size(35, 13);
            this.lblNumberText.TabIndex = 0;
            this.lblNumberText.Text = "label1";
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(258, 80);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 1;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(141, 80);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "label2";
            // 
            // lblCommandsText
            // 
            this.lblCommandsText.AutoSize = true;
            this.lblCommandsText.Location = new System.Drawing.Point(56, 150);
            this.lblCommandsText.Name = "lblCommandsText";
            this.lblCommandsText.Size = new System.Drawing.Size(35, 13);
            this.lblCommandsText.TabIndex = 3;
            this.lblCommandsText.Text = "label3";
            // 
            // lblCommands
            // 
            this.lblCommands.AutoSize = true;
            this.lblCommands.Location = new System.Drawing.Point(141, 150);
            this.lblCommands.Name = "lblCommands";
            this.lblCommands.Size = new System.Drawing.Size(35, 13);
            this.lblCommands.TabIndex = 4;
            this.lblCommands.Text = "label4";
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(258, 140);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 5;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(258, 206);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(406, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.playToolStripMenuItem.Text = "Play!";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(56, 211);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(35, 13);
            this.lblGoal.TabIndex = 8;
            this.lblGoal.Text = "label3";
            // 
            // lblGoalValue
            // 
            this.lblGoalValue.AutoSize = true;
            this.lblGoalValue.Location = new System.Drawing.Point(141, 211);
            this.lblGoalValue.Name = "lblGoalValue";
            this.lblGoalValue.Size = new System.Drawing.Size(35, 13);
            this.lblGoalValue.TabIndex = 9;
            this.lblGoalValue.Text = "label3";
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(258, 265);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 10;
            this.undoButton.Text = "button3";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 351);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.lblGoalValue);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.lblCommands);
            this.Controls.Add(this.lblCommandsText);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblNumberText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberText;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCommandsText;
        private System.Windows.Forms.Label lblCommands;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblGoalValue;
        private System.Windows.Forms.Button undoButton;
    }
}

