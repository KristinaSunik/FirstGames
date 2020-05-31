namespace GeniiIdiotWinFormsApp1
{
    partial class GeniiIdiotWinFormsApp
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
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.UserAnswerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(41, 83);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(153, 27);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "текст вопроса";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(40, 24);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(164, 32);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос№1";
            this.questionNumberLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Location = new System.Drawing.Point(405, 114);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(181, 83);
            this.nextQuestionButton.TabIndex = 2;
            this.nextQuestionButton.Text = "далее";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // UserAnswerTextBox
            // 
            this.UserAnswerTextBox.Location = new System.Drawing.Point(46, 142);
            this.UserAnswerTextBox.Name = "UserAnswerTextBox";
            this.UserAnswerTextBox.Size = new System.Drawing.Size(327, 26);
            this.UserAnswerTextBox.TabIndex = 3;
            // 
            // GeniiIdiotWinFormsApp
            // 
            this.ClientSize = new System.Drawing.Size(610, 224);
            this.Controls.Add(this.UserAnswerTextBox);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Name = "GeniiIdiotWinFormsApp";
            this.Text = "тест Гений-Идиот";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Button nextQuestionButton;
        private System.Windows.Forms.TextBox UserAnswerTextBox;
    }
}

