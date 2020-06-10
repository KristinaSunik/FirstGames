namespace GeniiIdiotWinFormsApp1
{
    partial class UserSurnameForm
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
            this.surnameQuestionLabel = new System.Windows.Forms.Label();
            this.UserSurnameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surnameQuestionLabel
            // 
            this.surnameQuestionLabel.AutoSize = true;
            this.surnameQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameQuestionLabel.Location = new System.Drawing.Point(99, 65);
            this.surnameQuestionLabel.Name = "surnameQuestionLabel";
            this.surnameQuestionLabel.Size = new System.Drawing.Size(233, 32);
            this.surnameQuestionLabel.TabIndex = 0;
            this.surnameQuestionLabel.Text = "Ваша фамилия?";
            // 
            // UserSurnameTextBox
            // 
            this.UserSurnameTextBox.Location = new System.Drawing.Point(118, 132);
            this.UserSurnameTextBox.Name = "UserSurnameTextBox";
            this.UserSurnameTextBox.Size = new System.Drawing.Size(198, 26);
            this.UserSurnameTextBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(90, 191);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(105, 38);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(241, 191);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(105, 38);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // UserSurnameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 286);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.UserSurnameTextBox);
            this.Controls.Add(this.surnameQuestionLabel);
            this.Name = "UserSurnameForm";
            this.Text = "UserInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label surnameQuestionLabel;
        public System.Windows.Forms.TextBox UserSurnameTextBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}