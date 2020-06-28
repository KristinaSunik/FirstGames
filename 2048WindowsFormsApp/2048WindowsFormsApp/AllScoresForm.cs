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
        public List<UserScore> previousScores;

        public AllScoresForm(List<UserScore> previousScores)
        {
            InitializeComponent();
            this.previousScores = previousScores;
        }

        private void AllScoresForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < previousScores.Count; i++)
            {
                var allScores = this.previousScores[i];
                userResultsDataGridView.Rows.Add(allScores.Name, allScores.Score);
            }
        }
    }
}
