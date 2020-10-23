using System;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class NameForm : Form
    {
        public UserScore userScore;
        public UserScore currentUserScore;
        public int score = 0;

        public NameForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var userName = nameTextBox.Text;
            currentUserScore = new UserScore(userName, score);
            Close();
        }
        
    }
}
