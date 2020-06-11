namespace GeniiIdiotWinFormsApp1
{
    partial class UserResultsForm
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
            this.userResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userResultsDataGridView
            // 
            this.userResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.userSurname,
            this.CountRightAnswers,
            this.diagnose});
            this.userResultsDataGridView.Location = new System.Drawing.Point(-3, 1);
            this.userResultsDataGridView.Name = "userResultsDataGridView";
            this.userResultsDataGridView.RowHeadersWidth = 62;
            this.userResultsDataGridView.RowTemplate.Height = 28;
            this.userResultsDataGridView.Size = new System.Drawing.Size(964, 515);
            this.userResultsDataGridView.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.HeaderText = "Имя";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.Width = 150;
            // 
            // userSurname
            // 
            this.userSurname.HeaderText = "Фамилия";
            this.userSurname.MinimumWidth = 8;
            this.userSurname.Name = "userSurname";
            this.userSurname.Width = 150;
            // 
            // CountRightAnswers
            // 
            this.CountRightAnswers.HeaderText = "Количество правильных ответов";
            this.CountRightAnswers.MinimumWidth = 8;
            this.CountRightAnswers.Name = "CountRightAnswers";
            this.CountRightAnswers.Width = 150;
            // 
            // diagnose
            // 
            this.diagnose.HeaderText = "Диагноз";
            this.diagnose.MinimumWidth = 8;
            this.diagnose.Name = "diagnose";
            this.diagnose.Width = 150;
            // 
            // UserResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 514);
            this.Controls.Add(this.userResultsDataGridView);
            this.Name = "UserResultsForm";
            this.Text = "UserResultsForm";
            this.Load += new System.EventHandler(this.UserResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnose;
    }
}