
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
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.answerTextLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(54, 58);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(230, 25);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Введите текст вопроса";
            // 
            // answerTextLabel
            // 
            this.answerTextLabel.AutoSize = true;
            this.answerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerTextLabel.Location = new System.Drawing.Point(53, 199);
            this.answerTextLabel.Name = "answerTextLabel";
            this.answerTextLabel.Size = new System.Drawing.Size(247, 25);
            this.answerTextLabel.TabIndex = 1;
            this.answerTextLabel.Text = "Введите ответ на вопрос";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(59, 116);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(413, 26);
            this.questionTextBox.TabIndex = 2;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(58, 262);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(414, 26);
            this.answerTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(302, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 60);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.answerTextLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label answerTextLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}