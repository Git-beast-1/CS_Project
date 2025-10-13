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
            this.T_Student_Name = new System.Windows.Forms.RichTextBox();
            this.d = new System.ComponentModel.BackgroundWorker();
            this.But_Tester = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Combo_Quiz_Name
            // 
            this.Combo_Quiz_Name.FormattingEnabled = true;
            this.Combo_Quiz_Name.Location = new System.Drawing.Point(496, 15);
            this.Combo_Quiz_Name.Name = "Combo_Quiz_Name";
            this.Combo_Quiz_Name.Size = new System.Drawing.Size(307, 21);
            this.Combo_Quiz_Name.TabIndex = 0;
            // 
            // T_Student_Name
            // 
            this.T_Student_Name.Location = new System.Drawing.Point(12, 12);
            this.T_Student_Name.Name = "T_Student_Name";
            this.T_Student_Name.Size = new System.Drawing.Size(100, 24);
            this.T_Student_Name.TabIndex = 2;
            this.T_Student_Name.Text = "Name";
            // 
            // But_Tester
            // 
            this.But_Tester.Location = new System.Drawing.Point(204, 338);
            this.But_Tester.Margin = new System.Windows.Forms.Padding(2);
            this.But_Tester.Name = "But_Tester";
            this.But_Tester.Size = new System.Drawing.Size(118, 58);
            this.But_Tester.TabIndex = 17;
            this.But_Tester.Text = "Bug_Tester";
            this.But_Tester.UseVisualStyleBackColor = true;
            this.But_Tester.Click += new System.EventHandler(this.But_Tester_Click);
            // 
            // F_Student_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 485);
            this.Controls.Add(this.But_Tester);
            this.Controls.Add(this.T_Student_Name);
            this.Controls.Add(this.Combo_Quiz_Name);
            this.Name = "F_Student_Home_Page";
            this.Text = "Student_Home_Page";
            this.Load += new System.EventHandler(this.F_Student_Home_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_Quiz_Name;
        private System.Windows.Forms.RichTextBox T_Student_Name;
        private System.ComponentModel.BackgroundWorker d;
        private System.Windows.Forms.Button But_Tester;
    }
}