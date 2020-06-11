
using GeniyIdiotCommon;
using System;
using System.Windows.Forms;

namespace GeniiIdiotWinFormsApp1
{
    public partial class GeniiIdiotWinFormsApp : Form
    {
        private User user;
        private Game game;
        int numberOfQuestions = 0;

        public GeniiIdiotWinFormsApp()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var userInfoForm = new UserInfoForm();
            if (userInfoForm.ShowDialog(this) == DialogResult.OK)
            {
                while(String.IsNullOrWhiteSpace(userInfoForm.userSurnameTextBox.Text) ||
                    String.IsNullOrWhiteSpace(userInfoForm.userNameTextBox.Text))
                {
                    MessageBox.Show("Введите все данные!!");
                    userInfoForm.ShowDialog(this);

                }
               
                    var userSurname = userInfoForm.userSurnameTextBox.Text;

                    var userName = userInfoForm.userNameTextBox.Text;
                    user = new User(userName, userSurname);
                    game = new Game(user);
                    numberOfQuestions = game.GetNumberOfQuestions();
                    PrintNextQuestion();
                
            }
            else Close();
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (!int.TryParse(userAnswerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Введите число!");
                userAnswerTextBox.Clear();
                userAnswerTextBox.Focus();
            }
            else
            {
                game.AcceptUserAnswer(userAnswer);
                PrintNextQuestion();
            }
        }



        private void PrintNextQuestion()
        {
            if (game.IsEnd())
            {
                game.CalculateDiagnose(numberOfQuestions);
                game.SaveResult();
                MessageBox.Show(user.Diagnose);
            }
            else
            {
                userAnswerTextBox.Focus();
                questionTextLabel.Text = game.PopRandomeQuestion().Text;
                questionNumberLabel.Text = game.GetCurrentQuestionNumberInfo();
                userAnswerTextBox.Clear();
            }
        }

        private void посмотретьПредыдущиеРезультатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResults = game.GetUserResults();
            var userResultsForm = new UserResultsForm(userResults);
            userResultsForm.Show();
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
