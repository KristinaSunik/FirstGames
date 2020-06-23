using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private const int margin = 6;
        private int mapSize = 4;
        private Label[,] map;
        private int score = 0;
        private int bestScore;
        private string bestScorePath = "BestScore.txt";
        private string allScoresPath = "AllScores.txt";



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitMap();
            GenerateNumber();
            ShowScore();
            ShowBestScore();
        }

        private int GetBestScoreFromFile()
        {
            if (FileProvider.IsExists(bestScorePath))
            {
                bestScore = Convert.ToInt32(FileProvider.Get(bestScorePath));
                return bestScore;
            }
            else
            {
                return 0;
            }
        }

        private void ShowBestScore()
        {
            bestScore = GetBestScoreFromFile();
            BestScoreLabel.Text = bestScore.ToString();
        }

        private void ShowScore()
        {
            ScoreLabel.Text = score.ToString();
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameIsEnd())
            {
                MessageBox.Show("ВЫ ПРОИГРАЛИ!", "Сожалеем, но ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FileProvider.Add(allScoresPath, Convert.ToString(score));
            }
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[i, k].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[i, k].Text = string.Empty;
                                        score += number * 2;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    if (map[i, k].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[i, k].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[i, k].Text = string.Empty;
                                        score += number * 2;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (map[i, k].Text != string.Empty)
                                {
                                    map[i, j].Text = map[i, k].Text;
                                    map[i, k].Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (map[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[k, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[k, j].Text = string.Empty;
                                        score += number * 2;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (map[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (map[k, j].Text != string.Empty)
                                {
                                    map[i, j].Text = map[k, j].Text;
                                    map[k, j].Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (map[i, j].Text != String.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != String.Empty)
                                {
                                    if (map[k, j].Text == map[i, j].Text)
                                    {
                                        var number = Convert.ToInt32(map[k, j].Text);
                                        map[i, j].Text = (number * 2).ToString();
                                        map[k, j].Text = string.Empty;
                                        score += number * 2;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (map[i, j].Text == String.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (map[k, j].Text != String.Empty)
                                {
                                    map[i, j].Text = map[k, j].Text;
                                    map[k, j].Text = string.Empty;
                                }
                            }
                        }
                    }
                }
            }
            GenerateNumber();
            ShowScore();
            if (bestScore < score)
            {
                SaveNewBestScore(bestScorePath);
            }
            ShowBestScore();

        }

        private bool GameIsEnd()
        {
            int count = 0;
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (map[j, i].Text != String.Empty)
                    {
                        count++;
                        if (count == mapSize * mapSize)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            return false;
        }

        private void SaveNewBestScore(string path)
        {
            var file = new StreamWriter(path);
            file.Write(score);
            file.Close();
            bestScore = score;
        }
    }
}
