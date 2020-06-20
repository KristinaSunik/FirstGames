
using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GeniiIdiotWinFormsApp1
{
    public partial class GeniiIdiotWinFormsApp : Form
    {
        private User user;
        private Game game;
        public List<UserResults> userResults;
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
                while(true)
                {
                    if (string.IsNullOrEmpty(userInfoForm.userSurnameTextBox.Text) ||
                   string.IsNullOrEmpty(userInfoForm.userNameTextBox.Text))
                    {

                        MessageBox.Show("Заполните все поля!!!!", "ВНИМАНИЕ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        userInfoForm.ShowDialog();
                    }
                  else  if (!string.IsNullOrEmpty(userInfoForm.userSurnameTextBox.Text) &&
                   !string.IsNullOrEmpty(userInfoForm.userNameTextBox.Text))
                    {
                        break; 
                    }
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
                MessageBox.Show("Введите число!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var newUserResult = new UserResults(user.Name,user.Surname,user.CountRightAnswers,user.Diagnose);
                game.AddNewUserResult(newUserResult);
                game.SaveResult(userResults);
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

        private void ShowPreviousResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userResults = game.GetUserResults();
            var userResultsForm = new UserResultsForm(userResults);
            userResultsForm.Show();
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm(game);
            addQuestionForm.Show();
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestionForm = new DeleteQuestionForm();
            deleteQuestionForm.Show();
        }
    }
}
