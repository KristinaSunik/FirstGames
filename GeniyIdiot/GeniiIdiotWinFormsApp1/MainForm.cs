﻿using GeniyIdiot;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniiIdiotWinFormsApp1
{
    public partial class GeniiIdiotWinFormsApp : Form
    {
        public List<Question> Questions;
        public int RandomQuestionIndex;
        public User User;

        public GeniiIdiotWinFormsApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User = new User();
            Questions = QuestionStorage.Get();
            System.Random random = new System.Random();
            RandomQuestionIndex = random.Next(0, Questions.Count);
            questionTextLabel.Text = Questions[RandomQuestionIndex].Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            var rightAnswer = Questions[RandomQuestionIndex].Answer;
            if (userAnswer == rightAnswer)
            {
                User.AcceptRightAnswer();
            }
            Questions.RemoveAt(RandomQuestionIndex);
        }
    }
}
