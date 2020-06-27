namespace _2048WindowsFormsApp
{
    partial class RulesOfTheGameForm
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
            this.RulesichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RulesichTextBox
            // 
            this.RulesichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RulesichTextBox.Location = new System.Drawing.Point(-1, 1);
            this.RulesichTextBox.Name = "RulesichTextBox";
            this.RulesichTextBox.Size = new System.Drawing.Size(453, 130);
            this.RulesichTextBox.TabIndex = 0;
            this.RulesichTextBox.Text = "Используйте клавиши ваши стрелками, чтобы переместить плитки. Когда два плитки с " +
    "тем же номером ощупь, они слияния в один!";
            // 
            // RulesOfTheGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 125);
            this.Controls.Add(this.RulesichTextBox);
            this.Name = "RulesOfTheGameForm";
            this.Text = "Правила игры";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RulesichTextBox;
    }
}