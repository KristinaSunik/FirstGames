using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallsWindowsFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            var graphics = CreateGraphics();
            var rectangle = new Rectangle(50, 50, 70, 70);
            var brush = Brushes.DarkGreen;
            graphics.FillEllipse(brush, rectangle);
        }
    }
}
