﻿using GeniyIdiot;
using System;

using System.Windows.Forms;

namespace GeniiIdiotWinFormsApp1
{
    public partial class GeniiIdiotWinFormsApp : Form
    {
        public GeniiIdiotWinFormsApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var questions = QuestionStorage.Get();
            questionTextLabel.Text = questions[0].Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
