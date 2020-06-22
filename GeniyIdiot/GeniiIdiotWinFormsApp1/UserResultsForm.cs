using GeniyIdiotCommon;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniiIdiotWinFormsApp1
{
    public partial class UserResultsForm : Form
    {
        private List<UserResult> userResults;
        public UserResultsForm(List<UserResult> userResults)
        {
            InitializeComponent();
            this.userResults = userResults;
        }

        private void UserResultsForm_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < userResults.Count; i++)
            {
                var userResult = userResults[i];
                userResultsDataGridView.Rows.Add(userResult.Name, userResult.Surname,
                    userResult.CountRightAnswers, userResult.Diagnose);
            }
        }

    }
}
