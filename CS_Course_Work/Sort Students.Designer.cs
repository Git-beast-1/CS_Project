namespace CS_Course_Work
{
    partial class Sort_Students
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
            this.But_Bubble_Sort = new System.Windows.Forms.Button();
            this.But_Insertion_Sort = new System.Windows.Forms.Button();
            this.But_Binary_Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // But_Bubble_Sort
            // 
            this.But_Bubble_Sort.Location = new System.Drawing.Point(18, 18);
            this.But_Bubble_Sort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Bubble_Sort.Name = "But_Bubble_Sort";
            this.But_Bubble_Sort.Size = new System.Drawing.Size(194, 72);
            this.But_Bubble_Sort.TabIndex = 0;
            this.But_Bubble_Sort.Text = "Bubble Sort";
            this.But_Bubble_Sort.UseVisualStyleBackColor = true;
            this.But_Bubble_Sort.Click += new System.EventHandler(this.But_Bubble_Sort_Click);
            // 
            // But_Insertion_Sort
            // 
            this.But_Insertion_Sort.Location = new System.Drawing.Point(220, 18);
            this.But_Insertion_Sort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Insertion_Sort.Name = "But_Insertion_Sort";
            this.But_Insertion_Sort.Size = new System.Drawing.Size(202, 72);
            this.But_Insertion_Sort.TabIndex = 1;
            this.But_Insertion_Sort.Text = "Insertion Sort";
            this.But_Insertion_Sort.UseVisualStyleBackColor = true;
            // 
            // But_Binary_Search
            // 
            this.But_Binary_Search.Location = new System.Drawing.Point(124, 100);
            this.But_Binary_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Binary_Search.Name = "But_Binary_Search";
            this.But_Binary_Search.Size = new System.Drawing.Size(194, 72);
            this.But_Binary_Search.TabIndex = 2;
            this.But_Binary_Search.Text = "binary search";
            this.But_Binary_Search.UseVisualStyleBackColor = true;
            // 
            // Sort_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 209);
            this.Controls.Add(this.But_Binary_Search);
            this.Controls.Add(this.But_Insertion_Sort);
            this.Controls.Add(this.But_Bubble_Sort);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Sort_Students";
            this.Text = "Sort_Students";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button But_Bubble_Sort;
        private System.Windows.Forms.Button But_Insertion_Sort;
        private System.Windows.Forms.Button But_Binary_Search;
    }
}