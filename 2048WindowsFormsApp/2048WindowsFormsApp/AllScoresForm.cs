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
    public partial class AllScoresForm : Form
    {
        private List<UserScore> allScore;
       
        public AllScoresForm(List<UserScore> allScore)
        {
            InitializeComponent();
        }

        private void UserResultsForm_Load(object sender, EventArgs e)
        {
                for (int i = 0; i < allScore.Count; i++)
                {
                    var allScores = this.allScore[i];
                userResultsDataGridView.Rows.Add(allScores.Name, allScores.Score);
                }
        }
    }
}
