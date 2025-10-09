namespace CS_Course_Work
{
    partial class F_Sign_up
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.T_Sign_Up_Password = new System.Windows.Forms.RichTextBox();
            this.T_Sign_Up_Email = new System.Windows.Forms.RichTextBox();
            this.Combo_Account_Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.But_Create_Account = new System.Windows.Forms.Button();
            this.T_User_Name = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email :";
            // 
            // T_Sign_Up_Password
            // 
            this.T_Sign_Up_Password.Location = new System.Drawing.Point(150, 119);
            this.T_Sign_Up_Password.Name = "T_Sign_Up_Password";
            this.T_Sign_Up_Password.Size = new System.Drawing.Size(186, 29);
            this.T_Sign_Up_Password.TabIndex = 5;
            this.T_Sign_Up_Password.Text = "";
            // 
            // T_Sign_Up_Email
            // 
            this.T_Sign_Up_Email.Location = new System.Drawing.Point(150, 70);
            this.T_Sign_Up_Email.Name = "T_Sign_Up_Email";
            this.T_Sign_Up_Email.Size = new System.Drawing.Size(186, 29);
            this.T_Sign_Up_Email.TabIndex = 4;
            this.T_Sign_Up_Email.Text = "";
            // 
            // Combo_Account_Type
            // 
            this.Combo_Account_Type.FormattingEnabled = true;
            this.Combo_Account_Type.Location = new System.Drawing.Point(150, 161);
            this.Combo_Account_Type.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Combo_Account_Type.Name = "Combo_Account_Type";
            this.Combo_Account_Type.Size = new System.Drawing.Size(186, 21);
            this.Combo_Account_Type.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account Type:";
            // 
            // But_Create_Account
            // 
            this.But_Create_Account.Location = new System.Drawing.Point(150, 202);
            this.But_Create_Account.Name = "But_Create_Account";
            this.But_Create_Account.Size = new System.Drawing.Size(124, 38);
            this.But_Create_Account.TabIndex = 10;
            this.But_Create_Account.Text = "Create Account";
            this.But_Create_Account.UseVisualStyleBackColor = true;
            this.But_Create_Account.Click += new System.EventHandler(this.But_Create_Account_Click);
            // 
            // T_User_Name
            // 
            this.T_User_Name.Location = new System.Drawing.Point(150, 35);
            this.T_User_Name.Name = "T_User_Name";
            this.T_User_Name.Size = new System.Drawing.Size(186, 29);
            this.T_User_Name.TabIndex = 11;
            this.T_User_Name.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name:";
            // 
            // F_Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.T_User_Name);
            this.Controls.Add(this.But_Create_Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Account_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Sign_Up_Password);
            this.Controls.Add(this.T_Sign_Up_Email);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_Sign_up";
            this.Text = "Sign_up";
            this.Load += new System.EventHandler(this.F_Sign_up_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox T_Sign_Up_Password;
        private System.Windows.Forms.RichTextBox T_Sign_Up_Email;
        private System.Windows.Forms.ComboBox Combo_Account_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button But_Create_Account;
        private System.Windows.Forms.RichTextBox T_User_Name;
        private System.Windows.Forms.Label label4;
    }
}