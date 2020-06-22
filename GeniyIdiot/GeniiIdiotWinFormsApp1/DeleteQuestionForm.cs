using GeniyIdiotCommon;
using System;
using System.IO;
using System.Windows.Forms;

namespace GeniiIdiotWinFormsApp1
{
    public partial class DeleteQuestionForm : Form
    {
        private static string questionsPath = "questions.json";

        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        public void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            if (!FileProvider.IsExists(questionsPath))
            {
                QuestionStorage.CreateFileIfNotExists();
            }
                var questions = QuestionStorage.GetQuestionsFromFile();
            for (int i = 0; i < questions.Count; i++)
            {
                var question = questions[i];
                ListOfQuestionsDataGridView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void ListOfQuestionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var questions = QuestionStorage.GetQuestionsFromFile();
            int i =ListOfQuestionsDataGridView.CurrentRow.Index;
            questions.RemoveAt(i);
            ListOfQuestionsDataGridView.Refresh();
            QuestionStorage.SaveQuestions(questions);


        }
    }
}
