using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        public UserScore userScore;
        public List<UserScore> allScores;
        public int mapSize = 4;
        public Label[,] map;
        public int score = 0;
        private const int margin = 6;
        private int cubeSize = 70;
        private int frame = 10;
        private int bestScore;
        private string bestScorePath = "BestScore.txt";
        private string allScoresPath = "AllScores.json";
      
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var NameForm = new NameForm();
            NameForm.Show(this);
            AddNewScore(userScore);
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
                    ChangeColourDueDefenition(i, j); ;
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
                    if (random.Next(1, 10) <= 8)
                    {
                        map[columnIndex, rowIndex].Text = "2";
                        ChangeColourDueDefenition(columnIndex, rowIndex);
                        break;
                    }

                    else
                    {
                        map[columnIndex, rowIndex].Text = "4";
                        ChangeColourDueDefenition(columnIndex, rowIndex);
                        break;
                    }
                }
            }
        }


        private Label CreateLabel(int rowIndex, int columnIndex)
        {
            var label = new Label();
            label.BackColor = Color.LightGray;
            label.Font = new Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)(204));
            label.Size = new Size(cubeSize, cubeSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            var x = frame + columnIndex * (cubeSize + margin);
            var y = cubeSize + rowIndex * (cubeSize + margin);
            label.Location = new Point(x, y);
            return label;
        }

        private void ChangeColourDueDefenition(int i, int j)
        {

            if (map[i, j].Text == String.Empty)
            {
                map[i, j].BackColor = Color.LightSlateGray;
            }
            if (map[i, j].Text == "2")
            {
                map[i, j].BackColor = Color.LightGray;
            }
            if (map[i, j].Text == "4")
            {
                map[i, j].BackColor = Color.PeachPuff;
            }
            if (map[i, j].Text == "8")
            {
                map[i, j].BackColor = Color.LightGoldenrodYellow;
            }
            if (map[i, j].Text == "16")
            {
                map[i, j].BackColor = Color.DarkMagenta;
            }
            if (map[i, j].Text == "32")
            {
                map[i, j].BackColor = Color.LightCoral;
            }
            if (map[i, j].Text == "64")
            {
                map[i, j].BackColor = Color.Coral;
            }
            if (map[i, j].Text == "128")
            {
                map[i, j].BackColor = Color.LavenderBlush;
            }
            if (map[i, j].Text == "256")
            {
                map[i, j].BackColor = Color.Red;
            }
            if (map[i, j].Text == "512")
            {
                map[i, j].BackColor = Color.MistyRose;
            }
            if (map[i, j].Text == "1024")
            {
                map[i, j].BackColor = Color.IndianRed;
            }
            if (map[i, j].Text == "2048")
            {
                map[i, j].BackColor = Color.DarkRed;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                MovingRight();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Left)
            {
                MovingLeft();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Up)
            {
                MovingUp();
                GenerateNumber();
            }
            if (e.KeyCode == Keys.Down)
            {
                MovingDown();
                GenerateNumber();
            }
            ShowScore();
            if (bestScore < score)
            {
                FileProvider.Set(bestScorePath, Convert.ToString(score));
                bestScore = score;
            }
            ShowBestScore();

            if (GameIsEnd())
            {
                MessageBox.Show("ВЫ ПРОИГРАЛИ!", "Сожалеем, но ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                AddNewScore(userScore);

            }


        }

        private List<UserScore> GetAllScoresFromFile()
        {
            var serializedAllScores = FileProvider.Get(allScoresPath);
            var results = JsonConvert.DeserializeObject<List<UserScore>>(serializedAllScores);
            return results;
        }

        private void SaveAllScores(List<UserScore> allScores)
        {
            var serialisedAllScores = JsonConvert.SerializeObject(allScores, Formatting.Indented);
            FileProvider.Set(allScoresPath, serialisedAllScores);
        }

        private bool GameIsEnd()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (map[j, i].Text != String.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void MovingDown()
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
                                    ChangeColourDueDefenition(i, j);
                                    map[k, j].Text = string.Empty;
                                    ChangeColourDueDefenition(k, j);
                                    score += number * 2;
                                    ResaveUserScore(userScore);
                                    if (number * 2 == 2048)
                                    {
                                        MessageBox.Show("!!!ВЫ ВЫЙГРАЛИ!!!", "ПОЗДРАВЛЯЕМ ",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
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
                                ChangeColourDueDefenition(i, j);
                                map[k, j].Text = string.Empty;
                                ChangeColourDueDefenition(k, j);
                            }
                        }
                    }
                }
            }
        }

        private void MovingUp()
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
                                    ChangeColourDueDefenition(i, j);
                                    map[k, j].Text = string.Empty;
                                    ChangeColourDueDefenition(k, j);
                                    score += number * 2;
                                    ResaveUserScore(userScore);
                                    if (number * 2 == 2048)
                                    {
                                        MessageBox.Show("!!!ВЫ ВЫЙГРАЛИ!!!", "ПОЗДРАВЛЯЕМ ",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
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
                                ChangeColourDueDefenition(i, j);
                                map[k, j].Text = string.Empty;
                                ChangeColourDueDefenition(k, j);
                            }
                        }
                    }
                }
            }
        }

        private void MovingLeft()
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
                                    ChangeColourDueDefenition(i, j);
                                    map[i, k].Text = string.Empty;
                                    ChangeColourDueDefenition(i, k);
                                    score += number * 2;
                                    ResaveUserScore(userScore);
                                    if (number * 2 == 2048)
                                    {
                                        MessageBox.Show("!!!ВЫ ВЫЙГРАЛИ!!!", "ПОЗДРАВЛЯЕМ ",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
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
                                ChangeColourDueDefenition(i, j);
                                map[i, k].Text = string.Empty;
                                ChangeColourDueDefenition(i, k);
                            }
                        }
                    }
                }
            }
        }

        private void MovingRight()
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
                                    ChangeColourDueDefenition(i, j);
                                    map[i, k].Text = string.Empty;
                                    ChangeColourDueDefenition(i, k);
                                    score += number * 2;
                                    ResaveUserScore(userScore);
                                    if (number * 2 == 2048)
                                    {
                                        MessageBox.Show("!!!ВЫ ВЫЙГРАЛИ!!!", "ПОЗДРАВЛЯЕМ ",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
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
                                ChangeColourDueDefenition(i, j);
                                map[i, k].Text = string.Empty;
                                ChangeColourDueDefenition(i, k);
                            }
                        }
                    }
                }
            }
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ResaveUserScore(UserScore userScore)
        {
            allScores = GetAllScoresFromFile();
            var lastResult = allScores.Count;
            allScores.RemoveAt(lastResult-1);
            AddNewScore(userScore);
        }


       

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddNewScore(UserScore userScore)
        {
            if (!FileProvider.IsExists(allScoresPath))
            {
                var results = new List<UserScore>();
                SaveAllScores(results);
            }
            var allScores = GetAllScoresFromFile();
            allScores.Add(userScore);
            SaveAllScores(allScores);
        }

        private List<UserScore> GetAllScores()
        {
            var allScores = GetAllScoresFromFile();
            return allScores;
        }

        private void RulesOfTheGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var RulesOfTheGameForm = new RulesOfTheGameForm();
            RulesOfTheGameForm.Show(this);
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 4;
            InitMap();
            GenerateNumber();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 5;
            InitMap();
            GenerateNumber();
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 6;
            InitMap();
            GenerateNumber();
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapSize = 8;
            InitMap();
            GenerateNumber();
        }

        private void ShowPreviousResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (!FileProvider.IsExists(allScoresPath))
                {
                    var results = new List<UserScore>();
                    SaveAllScores(results);
                }
                allScores = GetAllScoresFromFile();
                var previousScores = GetAllScores();
                var allScoresForm = new AllScoresForm(previousScores);
                allScoresForm.Show();
        }
    }
}

