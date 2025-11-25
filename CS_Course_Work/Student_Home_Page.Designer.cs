namespace CS_Course_Work
{
    partial class F_Student_Home_Page
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
            this.Combo_Quiz_Name = new System.Windows.Forms.ComboBox();
            this.d = new System.ComponentModel.BackgroundWorker();
            this.But_Tester = new System.Windows.Forms.Button();
            this.T_Teacher_Account = new System.Windows.Forms.RichTextBox();
            this.T_Teacher_Name = new System.Windows.Forms.RichTextBox();
            this.But_Submit_Quiz = new System.Windows.Forms.Button();
            this.But_Start_Quiz = new System.Windows.Forms.Button();
            this.But_List_Teachers = new System.Windows.Forms.Button();
            this.But_Quiz_Results = new System.Windows.Forms.Button();
            this.T_Detail_Name = new System.Windows.Forms.RichTextBox();
            this.T_Detail_Display = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Combo_Quiz_Name
            // 
            this.Combo_Quiz_Name.FormattingEnabled = true;
            this.Combo_Quiz_Name.Location = new System.Drawing.Point(475, 9);
            this.Combo_Quiz_Name.Name = "Combo_Quiz_Name";
            this.Combo_Quiz_Name.Size = new System.Drawing.Size(324, 21);
            this.Combo_Quiz_Name.TabIndex = 0;
            // 
            // But_Tester
            // 
            this.But_Tester.Location = new System.Drawing.Point(67, 343);
            this.But_Tester.Margin = new System.Windows.Forms.Padding(2);
            this.But_Tester.Name = "But_Tester";
            this.But_Tester.Size = new System.Drawing.Size(118, 58);
            this.But_Tester.TabIndex = 17;
            this.But_Tester.Text = "Bug_Tester";
            this.But_Tester.UseVisualStyleBackColor = true;
            this.But_Tester.Click += new System.EventHandler(this.But_Tester_Click);
            // 
            // T_Teacher_Account
            // 
            this.T_Teacher_Account.Location = new System.Drawing.Point(9, 40);
            this.T_Teacher_Account.Name = "T_Teacher_Account";
            this.T_Teacher_Account.Size = new System.Drawing.Size(100, 24);
            this.T_Teacher_Account.TabIndex = 20;
            this.T_Teacher_Account.Text = "Account";
            // 
            // T_Teacher_Name
            // 
            this.T_Teacher_Name.Location = new System.Drawing.Point(9, 9);
            this.T_Teacher_Name.Name = "T_Teacher_Name";
            this.T_Teacher_Name.Size = new System.Drawing.Size(100, 24);
            this.T_Teacher_Name.TabIndex = 19;
            this.T_Teacher_Name.Text = "Name";
            // 
            // But_Submit_Quiz
            // 
            this.But_Submit_Quiz.Location = new System.Drawing.Point(639, 309);
            this.But_Submit_Quiz.Name = "But_Submit_Quiz";
            this.But_Submit_Quiz.Size = new System.Drawing.Size(159, 56);
            this.But_Submit_Quiz.TabIndex = 23;
            this.But_Submit_Quiz.Text = "Submit Quiz";
            this.But_Submit_Quiz.UseVisualStyleBackColor = true;
            // 
            // But_Start_Quiz
            // 
            this.But_Start_Quiz.Location = new System.Drawing.Point(475, 309);
            this.But_Start_Quiz.Name = "But_Start_Quiz";
            this.But_Start_Quiz.Size = new System.Drawing.Size(159, 56);
            this.But_Start_Quiz.TabIndex = 22;
            this.But_Start_Quiz.Text = "Start Quiz";
            this.But_Start_Quiz.UseVisualStyleBackColor = true;
            this.But_Start_Quiz.Click += new System.EventHandler(this.But_Start_Quiz_Click);
            // 
            // But_List_Teachers
            // 
            this.But_List_Teachers.Location = new System.Drawing.Point(474, 371);
            this.But_List_Teachers.Name = "But_List_Teachers";
            this.But_List_Teachers.Size = new System.Drawing.Size(159, 56);
            this.But_List_Teachers.TabIndex = 25;
            this.But_List_Teachers.Text = "Teachers";
            this.But_List_Teachers.UseVisualStyleBackColor = true;
            // 
            // But_Quiz_Results
            // 
            this.But_Quiz_Results.Location = new System.Drawing.Point(639, 371);
            this.But_Quiz_Results.Name = "But_Quiz_Results";
            this.But_Quiz_Results.Size = new System.Drawing.Size(159, 56);
            this.But_Quiz_Results.TabIndex = 24;
            this.But_Quiz_Results.Text = "Result";
            this.But_Quiz_Results.UseVisualStyleBackColor = true;
            // 
            // T_Detail_Name
            // 
            this.T_Detail_Name.Location = new System.Drawing.Point(142, 10);
            this.T_Detail_Name.Name = "T_Detail_Name";
            this.T_Detail_Name.Size = new System.Drawing.Size(100, 24);
            this.T_Detail_Name.TabIndex = 28;
            this.T_Detail_Name.Text = "Quiz Details";
            // 
            // T_Detail_Display
            // 
            this.T_Detail_Display.Location = new System.Drawing.Point(142, 31);
            this.T_Detail_Display.Margin = new System.Windows.Forms.Padding(2);
            this.T_Detail_Display.Name = "T_Detail_Display";
            this.T_Detail_Display.Size = new System.Drawing.Size(328, 281);
            this.T_Detail_Display.TabIndex = 27;
            this.T_Detail_Display.Text = "";
            // 
            // F_Student_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 485);
            this.Controls.Add(this.T_Detail_Name);
            this.Controls.Add(this.T_Detail_Display);
            this.Controls.Add(this.But_List_Teachers);
            this.Controls.Add(this.But_Quiz_Results);
            this.Controls.Add(this.But_Submit_Quiz);
            this.Controls.Add(this.But_Start_Quiz);
            this.Controls.Add(this.T_Teacher_Account);
            this.Controls.Add(this.T_Teacher_Name);
            this.Controls.Add(this.But_Tester);
            this.Controls.Add(this.Combo_Quiz_Name);
            this.Name = "F_Student_Home_Page";
            this.Text = "Student_Home_Page";
            this.Load += new System.EventHandler(this.F_Student_Home_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Quiz_Name;
        private System.ComponentModel.BackgroundWorker d;
        private System.Windows.Forms.Button But_Tester;
        private System.Windows.Forms.RichTextBox T_Teacher_Account;
        private System.Windows.Forms.RichTextBox T_Teacher_Name;
        private System.Windows.Forms.Button But_Submit_Quiz;
        private System.Windows.Forms.Button But_Start_Quiz;
        private System.Windows.Forms.Button But_List_Teachers;
        private System.Windows.Forms.Button But_Quiz_Results;
        private System.Windows.Forms.RichTextBox T_Detail_Name;
        private System.Windows.Forms.RichTextBox T_Detail_Display;
    }
}