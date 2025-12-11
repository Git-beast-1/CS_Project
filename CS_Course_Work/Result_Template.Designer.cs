namespace CS_Course_Work
{
    partial class F_Result_Template
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
            this.T_Correct_Questions = new System.Windows.Forms.RichTextBox();
            this.T_Incorrect_Questions = new System.Windows.Forms.RichTextBox();
            this.T_Score_Percentage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.But_Redo = new System.Windows.Forms.Button();
            this.But_Submit_Quiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T_Correct_Questions
            // 
            this.T_Correct_Questions.Location = new System.Drawing.Point(212, 9);
            this.T_Correct_Questions.Name = "T_Correct_Questions";
            this.T_Correct_Questions.Size = new System.Drawing.Size(171, 25);
            this.T_Correct_Questions.TabIndex = 1;
            this.T_Correct_Questions.Text = "";
            // 
            // T_Incorrect_Questions
            // 
            this.T_Incorrect_Questions.Location = new System.Drawing.Point(212, 45);
            this.T_Incorrect_Questions.Name = "T_Incorrect_Questions";
            this.T_Incorrect_Questions.Size = new System.Drawing.Size(169, 25);
            this.T_Incorrect_Questions.TabIndex = 2;
            this.T_Incorrect_Questions.Text = "";
            // 
            // T_Score_Percentage
            // 
            this.T_Score_Percentage.Location = new System.Drawing.Point(212, 73);
            this.T_Score_Percentage.Name = "T_Score_Percentage";
            this.T_Score_Percentage.Size = new System.Drawing.Size(171, 144);
            this.T_Score_Percentage.TabIndex = 3;
            this.T_Score_Percentage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correct Questions :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Incorrect Questions :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(117, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score %";
            // 
            // But_Redo
            // 
            this.But_Redo.Location = new System.Drawing.Point(212, 222);
            this.But_Redo.Name = "But_Redo";
            this.But_Redo.Size = new System.Drawing.Size(138, 58);
            this.But_Redo.TabIndex = 13;
            this.But_Redo.Text = "Redo";
            this.But_Redo.UseVisualStyleBackColor = true;
            this.But_Redo.Click += new System.EventHandler(this.But_Redo_Click);
            // 
            // But_Submit_Quiz
            // 
            this.But_Submit_Quiz.Location = new System.Drawing.Point(212, 286);
            this.But_Submit_Quiz.Name = "But_Submit_Quiz";
            this.But_Submit_Quiz.Size = new System.Drawing.Size(138, 58);
            this.But_Submit_Quiz.TabIndex = 14;
            this.But_Submit_Quiz.Text = "submit";
            this.But_Submit_Quiz.UseVisualStyleBackColor = true;
            this.But_Submit_Quiz.Click += new System.EventHandler(this.But_Submit_Quiz_Click);
            // 
            // F_Result_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 357);
            this.Controls.Add(this.But_Submit_Quiz);
            this.Controls.Add(this.But_Redo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.T_Score_Percentage);
            this.Controls.Add(this.T_Incorrect_Questions);
            this.Controls.Add(this.T_Correct_Questions);
            this.Name = "F_Result_Template";
            this.Text = "Result_Template";
            this.Load += new System.EventHandler(this.F_Result_Template_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox T_Correct_Questions;
        private System.Windows.Forms.RichTextBox T_Incorrect_Questions;
        private System.Windows.Forms.RichTextBox T_Score_Percentage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button But_Redo;
        private System.Windows.Forms.Button But_Submit_Quiz;
    }
}