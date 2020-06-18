namespace GeniiIdiotWinFormsApp1
{
    partial class UserInfoForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.questionNameLabel = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.userSurnameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(130, 187);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 41);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(385, 187);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 42);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(302, 63);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(205, 26);
            this.userNameTextBox.TabIndex = 2;
            // 
            // questionNameLabel
            // 
            this.questionNameLabel.AutoSize = true;
            this.questionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNameLabel.Location = new System.Drawing.Point(147, 63);
            this.questionNameLabel.Name = "questionNameLabel";
            this.questionNameLabel.Size = new System.Drawing.Size(127, 26);
            this.questionNameLabel.TabIndex = 3;
            this.questionNameLabel.Text = "Ваше имя?";
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(91, 118);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(183, 26);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Ваша фамилия?";
            // 
            // userSurnameTextBox
            // 
            this.userSurnameTextBox.Location = new System.Drawing.Point(302, 118);
            this.userSurnameTextBox.Name = "userSurnameTextBox";
            this.userSurnameTextBox.Size = new System.Drawing.Size(205, 26);
            this.userSurnameTextBox.TabIndex = 5;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 293);
            this.Controls.Add(this.userSurnameTextBox);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.questionNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "UserInfoForm";
            this.Text = "UserInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        public System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label questionNameLabel;
        private System.Windows.Forms.Label QuestionLabel;
        public System.Windows.Forms.TextBox userSurnameTextBox;
    }
}