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
            this.Combo_Quiz_Menu = new System.Windows.Forms.ComboBox();
            this.T_Teacher_Account = new System.Windows.Forms.RichTextBox();
            this.T_Teacher_Name = new System.Windows.Forms.RichTextBox();
            this.T_All_Student_Results = new System.Windows.Forms.RichTextBox();
            this.But_Add_Quiz = new System.Windows.Forms.Button();
            this.But_Remove_Quiz = new System.Windows.Forms.Button();
            this.T_Selected_Quiz_Name = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Combo_Quiz_Menu
            // 
            this.Combo_Quiz_Menu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Combo_Quiz_Menu.FormattingEnabled = true;
            this.Combo_Quiz_Menu.Location = new System.Drawing.Point(657, 18);
            this.Combo_Quiz_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Combo_Quiz_Menu.Name = "Combo_Quiz_Menu";
            this.Combo_Quiz_Menu.Size = new System.Drawing.Size(433, 28);
            this.Combo_Quiz_Menu.TabIndex = 0;
            this.Combo_Quiz_Menu.Text = "Quizzes";
            this.Combo_Quiz_Menu.SelectedIndexChanged += new System.EventHandler(this.Quizzes_SelectedIndexChanged);
            // 
            // T_Teacher_Account
            // 
            this.T_Teacher_Account.Location = new System.Drawing.Point(18, 65);
            this.T_Teacher_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Teacher_Account.Name = "T_Teacher_Account";
            this.T_Teacher_Account.Size = new System.Drawing.Size(148, 35);
            this.T_Teacher_Account.TabIndex = 5;
            this.T_Teacher_Account.Text = "Account";
            // 
            // T_Teacher_Name
            // 
            this.T_Teacher_Name.Location = new System.Drawing.Point(18, 18);
            this.T_Teacher_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Teacher_Name.Name = "T_Teacher_Name";
            this.T_Teacher_Name.Size = new System.Drawing.Size(148, 35);
            this.T_Teacher_Name.TabIndex = 4;
            this.T_Teacher_Name.Text = "Name";
            this.T_Teacher_Name.TextChanged += new System.EventHandler(this.T_Teacher_Name_TextChanged);
            // 
            // T_All_Student_Results
            // 
            this.T_All_Student_Results.Location = new System.Drawing.Point(273, 65);
            this.T_All_Student_Results.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_All_Student_Results.Name = "T_All_Student_Results";
            this.T_All_Student_Results.Size = new System.Drawing.Size(373, 584);
            this.T_All_Student_Results.TabIndex = 6;
            this.T_All_Student_Results.Text = "";
            this.T_All_Student_Results.TextChanged += new System.EventHandler(this.T_All_Student_Results_TextChanged);
            // 
            // But_Add_Quiz
            // 
            this.But_Add_Quiz.Location = new System.Drawing.Point(1101, 20);
            this.But_Add_Quiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Add_Quiz.Name = "But_Add_Quiz";
            this.But_Add_Quiz.Size = new System.Drawing.Size(40, 35);
            this.But_Add_Quiz.TabIndex = 20;
            this.But_Add_Quiz.Text = "A";
            this.But_Add_Quiz.UseVisualStyleBackColor = true;
            this.But_Add_Quiz.Click += new System.EventHandler(this.But_Add_Quiz_Click);
            // 
            // But_Remove_Quiz
            // 
            this.But_Remove_Quiz.Location = new System.Drawing.Point(1150, 20);
            this.But_Remove_Quiz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Remove_Quiz.Name = "But_Remove_Quiz";
            this.But_Remove_Quiz.Size = new System.Drawing.Size(40, 35);
            this.But_Remove_Quiz.TabIndex = 21;
            this.But_Remove_Quiz.Text = "R";
            this.But_Remove_Quiz.UseVisualStyleBackColor = true;
            // 
            // T_Selected_Quiz_Name
            // 
            this.T_Selected_Quiz_Name.Enabled = false;
            this.T_Selected_Quiz_Name.Location = new System.Drawing.Point(273, 18);
            this.T_Selected_Quiz_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Selected_Quiz_Name.Name = "T_Selected_Quiz_Name";
            this.T_Selected_Quiz_Name.Size = new System.Drawing.Size(210, 35);
            this.T_Selected_Quiz_Name.TabIndex = 22;
            this.T_Selected_Quiz_Name.Text = "";
            // 
            // F_Teacher_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.T_Selected_Quiz_Name);
            this.Controls.Add(this.But_Remove_Quiz);
            this.Controls.Add(this.But_Add_Quiz);
            this.Controls.Add(this.T_All_Student_Results);
            this.Controls.Add(this.T_Teacher_Account);
            this.Controls.Add(this.T_Teacher_Name);
            this.Controls.Add(this.Combo_Quiz_Menu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Teacher_Home_Page";
            this.Text = "Teacher_Home_Page";
            this.Load += new System.EventHandler(this.F_Teacher_Home_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Quiz_Menu;
        private System.Windows.Forms.RichTextBox T_Teacher_Account;
        private System.Windows.Forms.RichTextBox T_Teacher_Name;
        private System.Windows.Forms.RichTextBox T_All_Student_Results;
        private System.Windows.Forms.Button But_Add_Quiz;
        private System.Windows.Forms.Button But_Remove_Quiz;
        private System.Windows.Forms.RichTextBox T_Selected_Quiz_Name;
    }
}