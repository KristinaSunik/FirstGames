using GeniyIdiotCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (IsUserDataValid())
            {
                var newQuestion = new Question(questionTextBox.Text, Convert.ToInt32(answerTextBox.Text));
                game.AddNewQuestion(newQuestion);
                Close();
            }
        }

        private bool IsUserDataValid()
        {
            return true;
        }
    }
}
