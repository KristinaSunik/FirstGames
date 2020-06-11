namespace GeniiIdiotWinFormsApp1
{
    partial class AddQuestionForm
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
            this.QuestionTextLabel = new System.Windows.Forms.Label();
            this.AnswerTextLabel = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionTextLabel
            // 
            this.QuestionTextLabel.AutoSize = true;
            this.QuestionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionTextLabel.Location = new System.Drawing.Point(54, 58);
            this.QuestionTextLabel.Name = "QuestionTextLabel";
            this.QuestionTextLabel.Size = new System.Drawing.Size(230, 25);
            this.QuestionTextLabel.TabIndex = 0;
            this.QuestionTextLabel.Text = "Введите текст вопроса";
            // 
            // AnswerTextLabel
            // 
            this.AnswerTextLabel.AutoSize = true;
            this.AnswerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTextLabel.Location = new System.Drawing.Point(53, 199);
            this.AnswerTextLabel.Name = "AnswerTextLabel";
            this.AnswerTextLabel.Size = new System.Drawing.Size(247, 25);
            this.AnswerTextLabel.TabIndex = 1;
            this.AnswerTextLabel.Text = "Введите ответ на вопрос";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(59, 116);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(205, 26);
            this.QuestionTextBox.TabIndex = 2;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(58, 262);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(205, 26);
            this.AnswerTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(150, 336);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(113, 60);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.AnswerTextLabel);
            this.Controls.Add(this.QuestionTextLabel);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionTextLabel;
        private System.Windows.Forms.Label AnswerTextLabel;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}