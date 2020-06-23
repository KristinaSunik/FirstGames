namespace _2048WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScoreTextLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.BestScoreTextLabel = new System.Windows.Forms.Label();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreTextLabel
            // 
            this.ScoreTextLabel.AutoSize = true;
            this.ScoreTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreTextLabel.Location = new System.Drawing.Point(20, 20);
            this.ScoreTextLabel.Name = "ScoreTextLabel";
            this.ScoreTextLabel.Size = new System.Drawing.Size(78, 31);
            this.ScoreTextLabel.TabIndex = 0;
            this.ScoreTextLabel.Text = "Счёт:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(118, 20);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(29, 31);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "0";
            // 
            // BestScoreTextLabel
            // 
            this.BestScoreTextLabel.AutoSize = true;
            this.BestScoreTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestScoreTextLabel.Location = new System.Drawing.Point(20, 63);
            this.BestScoreTextLabel.Name = "BestScoreTextLabel";
            this.BestScoreTextLabel.Size = new System.Drawing.Size(253, 31);
            this.BestScoreTextLabel.TabIndex = 2;
            this.BestScoreTextLabel.Text = "Лучший результат:";
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.AutoSize = true;
            this.BestScoreLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestScoreLabel.Location = new System.Drawing.Point(292, 63);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(29, 31);
            this.BestScoreLabel.TabIndex = 3;
            this.BestScoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 629);
            this.Controls.Add(this.BestScoreLabel);
            this.Controls.Add(this.BestScoreTextLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ScoreTextLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreTextLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label BestScoreTextLabel;
        private System.Windows.Forms.Label BestScoreLabel;
    }
}

