
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

        public GeniiIdiotWinFormsApp()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var userSurnameForm = new UserSurnameForm();
            if (userSurnameForm.ShowDialog(this) == DialogResult.OK)
            {
                var userSurname = userSurnameForm.UserSurnameTextBox.Text;
                var userNameForm = new UserNameForm();
                if (userNameForm.ShowDialog(this) == DialogResult.OK)
                {
                    var userName = userNameForm.userNameTextBox.Text;
                    user = new User(userName, userSurname);
                    game = new Game(user);
                    PrintNextQuestion();
                }
                else Close();
            }
            else Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
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
                user.Diagnose = Diagnose.Calculate(user);
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
