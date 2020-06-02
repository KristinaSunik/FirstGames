
using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniiIdiotWinFormsApp1
{
    public partial class GeniiIdiotWinFormsApp : Form
    {
        public static List<Question> Questions;
        public int RandomQuestionIndex;
        public User User;
        Random random = new Random();

        public GeniiIdiotWinFormsApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User = new User();
         
            Questions = QuestionStorage.Get();
            PrintNextQuestion();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            int userAnswer;
            if (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                MessageBox.Show("Введите число!");
            }
            
                var rightAnswer = Questions[RandomQuestionIndex].Answer;
                if (userAnswer == rightAnswer)
                {
                    User.AcceptRightAnswer();
                }
                Questions.RemoveAt(RandomQuestionIndex);

                PrintNextQuestion();
        }

        private void PrintNextQuestion()
        {
            if (Questions.Count == 0)
            {
                var numberOfDiagnose = Diagnose.CalculateNumberOfDiagnose(User);
                var diagnoses = Diagnose.Get();
                User.Diagnose = diagnoses[numberOfDiagnose];
                MessageBox.Show(User.Diagnose);
            }
            else
            {
                RandomQuestionIndex = random.Next(0, Questions.Count);
                questionTextLabel.Text = Questions[RandomQuestionIndex].Text;
            }
        }
    }
}
