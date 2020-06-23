using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class UserResultsForm : Form
    {
        private List<UserResult> userResults;
       
        public UserResultsForm()
        {
            InitializeComponent();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
                for (int i = 0; i < userResults.Count; i++)
                {
                    var userResult = userResults[i];
                    userResultsDataGridView.Rows.Add(userResult.Name, userResult.Score);
                }
        }
    }
}
