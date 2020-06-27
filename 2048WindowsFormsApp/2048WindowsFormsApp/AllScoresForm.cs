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
        public List<UserScore> allScores;

        public AllScoresForm(List<UserScore> allScores)
        {
            InitializeComponent();
        }

        private void AllScoresForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < allScores.Count; i++)
                {
                    var allScores = this.allScores[i];
                userResultsDataGridView.Rows.Add(allScores.Name, allScores.Score);
                }
        }
    }
}
