namespace CS_Course_Work
{
    partial class Teacher_Home_Page
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
            this.Quizzes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Quizzes
            // 
            this.Quizzes.FormattingEnabled = true;
            this.Quizzes.Location = new System.Drawing.Point(591, 12);
            this.Quizzes.Name = "Quizzes";
            this.Quizzes.Size = new System.Drawing.Size(197, 21);
            this.Quizzes.TabIndex = 0;
            this.Quizzes.SelectedIndexChanged += new System.EventHandler(this.Quizzes_SelectedIndexChanged);
            // 
            // Teacher_Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quizzes);
            this.Name = "Teacher_Home_Page";
            this.Text = "Teacher_Home_Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Quizzes;
    }
}