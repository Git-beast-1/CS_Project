namespace CS_Course_Work
{
    partial class F_Teacher_Home_Page
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
            this.T_Teacher_Account = new System.Windows.Forms.RichTextBox();
            this.T_Teacher_Name = new System.Windows.Forms.RichTextBox();
            this.But_Add_Quiz = new System.Windows.Forms.Button();
            this.But_Remove_Quiz = new System.Windows.Forms.Button();
            this.But_Edit_Quiz = new System.Windows.Forms.Button();
            this.But_Sort_Students = new System.Windows.Forms.Button();
            this.Combo_Quizzes = new System.Windows.Forms.ComboBox();
            this.T_Quiz_Details = new System.Windows.Forms.RichTextBox();
            this.T_Quiz_Detail_Name = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // T_Teacher_Account
            // 
            this.T_Teacher_Account.Location = new System.Drawing.Point(12, 42);
            this.T_Teacher_Account.Name = "T_Teacher_Account";
            this.T_Teacher_Account.Size = new System.Drawing.Size(100, 24);
            this.T_Teacher_Account.TabIndex = 5;
            this.T_Teacher_Account.Text = "Account";
            // 
            // T_Teacher_Name
            // 
            this.T_Teacher_Name.Location = new System.Drawing.Point(12, 12);
            this.T_Teacher_Name.Name = "T_Teacher_Name";
            this.T_Teacher_Name.Size = new System.Drawing.Size(100, 24);
            this.T_Teacher_Name.TabIndex = 4;
            this.T_Teacher_Name.Text = "Name";
            // 
            // But_Add_Quiz
            // 
            this.But_Add_Quiz.Location = new System.Drawing.Point(469, 324);
            this.But_Add_Quiz.Name = "But_Add_Quiz";
            this.But_Add_Quiz.Size = new System.Drawing.Size(159, 56);
            this.But_Add_Quiz.TabIndex = 20;
            this.But_Add_Quiz.Text = "Create Quiz";
            this.But_Add_Quiz.UseVisualStyleBackColor = true;
            this.But_Add_Quiz.Click += new System.EventHandler(this.But_Add_Quiz_Click);
            // 
            // But_Remove_Quiz
            // 
            this.But_Remove_Quiz.Location = new System.Drawing.Point(633, 324);
            this.But_Remove_Quiz.Name = "But_Remove_Quiz";
            this.But_Remove_Quiz.Size = new System.Drawing.Size(159, 56);
            this.But_Remove_Quiz.TabIndex = 21;
            this.But_Remove_Quiz.Text = "Delete Quiz";
            this.But_Remove_Quiz.UseVisualStyleBackColor = true;
            // 
            // But_Edit_Quiz
            // 
            this.But_Edit_Quiz.Location = new System.Drawing.Point(633, 385);
            this.But_Edit_Quiz.Name = "But_Edit_Quiz";
            this.But_Edit_Quiz.Size = new System.Drawing.Size(159, 56);
            this.But_Edit_Quiz.TabIndex = 22;
            this.But_Edit_Quiz.Text = "Edit Quiz";
            this.But_Edit_Quiz.UseVisualStyleBackColor = true;
            // 
            // But_Sort_Students
            // 
            this.But_Sort_Students.Location = new System.Drawing.Point(469, 385);
            this.But_Sort_Students.Name = "But_Sort_Students";
            this.But_Sort_Students.Size = new System.Drawing.Size(159, 56);
            this.But_Sort_Students.TabIndex = 23;
            this.But_Sort_Students.Text = "Sort Students";
            this.But_Sort_Students.UseVisualStyleBackColor = true;
            // 
            // Combo_Quizzes
            // 
            this.Combo_Quizzes.FormattingEnabled = true;
            this.Combo_Quizzes.Location = new System.Drawing.Point(469, 16);
            this.Combo_Quizzes.Margin = new System.Windows.Forms.Padding(2);
            this.Combo_Quizzes.Name = "Combo_Quizzes";
            this.Combo_Quizzes.Size = new System.Drawing.Size(324, 21);
            this.Combo_Quizzes.TabIndex = 24;
            // 
            // T_Quiz_Details
            // 
            this.T_Quiz_Details.Location = new System.Drawing.Point(136, 33);
            this.T_Quiz_Details.Margin = new System.Windows.Forms.Padding(2);
            this.T_Quiz_Details.Name = "T_Quiz_Details";
            this.T_Quiz_Details.Size = new System.Drawing.Size(328, 299);
            this.T_Quiz_Details.TabIndex = 25;
            this.T_Quiz_Details.Text = "";
            // 
            // T_Quiz_Detail_Name
            // 
            this.T_Quiz_Detail_Name.Location = new System.Drawing.Point(136, 13);
            this.T_Quiz_Detail_Name.Name = "T_Quiz_Detail_Name";
            this.T_Quiz_Detail_Name.Size = new System.Drawing.Size(100, 24);
            this.T_Quiz_Detail_Name.TabIndex = 26;
            this.T_Quiz_Detail_Name.Text = "Quiz Details";
            // 
            // F_Teacher_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.T_Quiz_Detail_Name);
            this.Controls.Add(this.T_Quiz_Details);
            this.Controls.Add(this.Combo_Quizzes);
            this.Controls.Add(this.But_Sort_Students);
            this.Controls.Add(this.But_Edit_Quiz);
            this.Controls.Add(this.But_Remove_Quiz);
            this.Controls.Add(this.But_Add_Quiz);
            this.Controls.Add(this.T_Teacher_Account);
            this.Controls.Add(this.T_Teacher_Name);
            this.Name = "F_Teacher_Home_Page";
            this.Text = "Teacher_Home_Page";
            this.Load += new System.EventHandler(this.F_Teacher_Home_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox T_Teacher_Account;
        private System.Windows.Forms.RichTextBox T_Teacher_Name;
        private System.Windows.Forms.Button But_Add_Quiz;
        private System.Windows.Forms.Button But_Remove_Quiz;
        private System.Windows.Forms.Button But_Edit_Quiz;
        private System.Windows.Forms.Button But_Sort_Students;
        private System.Windows.Forms.ComboBox Combo_Quizzes;
        private System.Windows.Forms.RichTextBox T_Quiz_Details;
        private System.Windows.Forms.RichTextBox T_Quiz_Detail_Name;
    }
}