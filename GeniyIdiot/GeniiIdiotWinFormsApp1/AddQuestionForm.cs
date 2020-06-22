using GeniyIdiotCommon;
using System;
using System.Windows.Forms;


namespace GeniiIdiotWinFormsApp1
{
    public partial class AddQuestionForm : Form
    {
        private Game game;

        public AddQuestionForm(Game game)
        {
            InitializeComponent();
            this.game = game;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsUserDataValid(questionTextBox.Text, answerTextBox.Text))
            {
                var newQuestion = new Question(questionTextBox.Text, Convert.ToInt32(answerTextBox.Text));
                game.AddNewQuestion(newQuestion);
                Close();
            }
        }

        private bool IsUserDataValid(string questionTextBox, string answerTextBox)
        {

            if (String.IsNullOrWhiteSpace(questionTextBox) ||
                String.IsNullOrWhiteSpace(answerTextBox))
            {
                MessageBox.Show("Заполните все поля!!!!", "ВНИМАНИЕ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
