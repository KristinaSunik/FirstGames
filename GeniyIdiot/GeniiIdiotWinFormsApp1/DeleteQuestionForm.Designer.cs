namespace GeniiIdiotWinFormsApp1
{
    partial class DeleteQuestionForm
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
            this.ListOfQuestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfQuestionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfQuestionsDataGridView
            // 
            this.ListOfQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfQuestionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.Answer});
            this.ListOfQuestionsDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListOfQuestionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ListOfQuestionsDataGridView.Name = "ListOfQuestionsDataGridView";
            this.ListOfQuestionsDataGridView.RowHeadersWidth = 62;
            this.ListOfQuestionsDataGridView.RowTemplate.Height = 28;
            this.ListOfQuestionsDataGridView.Size = new System.Drawing.Size(775, 363);
            this.ListOfQuestionsDataGridView.TabIndex = 0;
            // 
            // Question
            // 
            this.Question.DataPropertyName = "questions.Question";
            this.Question.HeaderText = "Вопрос";
            this.Question.MinimumWidth = 8;
            this.Question.Name = "Question";
            this.Question.Width = 150;
            // 
            // Answer
            // 
            this.Answer.DataPropertyName = "questions.Answer";
            this.Answer.HeaderText = "Ответ";
            this.Answer.MinimumWidth = 8;
            this.Answer.Name = "Answer";
            this.Answer.Width = 150;
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListOfQuestionsDataGridView);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            this.Load += new System.EventHandler(this.DeleteQuestionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListOfQuestionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfQuestionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}