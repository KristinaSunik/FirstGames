using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private const int margin = 6;
        private int mapSize = 4;
        private Label[,] map;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
        }

        private void InitMap()
        {
            map = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    map[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            var random = new Random();

            while (true)
            {
                var rowIndex = random.Next(mapSize);
                var columnIndex = random.Next(mapSize);
                if (map[columnIndex, rowIndex].Text == String.Empty)
                {
                    map[columnIndex, rowIndex].Text = "2";
                    break;
                }
            }
        }


        private Label CreateLabel(int rowIndex, int columnIndex)
        {
            var label = new Label();
            label.BackColor = SystemColors.ActiveCaption;
            label.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)(204));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;

            var x = 10 + columnIndex * (70 + margin);
            var y = 70 + rowIndex * (70 + margin);
            label.Location = new Point(x, y);
            return label;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MessageBox.Show("Right");
            }
            if (e.KeyCode == Keys.Left)
            {
                MessageBox.Show("Left");
            }
            if (e.KeyCode == Keys.Up)
            {
                MessageBox.Show("Up");
            }
            if (e.KeyCode == Keys.Down)
            {
                MessageBox.Show("Down");
            }
        }
    }
}
