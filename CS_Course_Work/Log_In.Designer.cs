namespace CS_Course_Work
{
    partial class F_Log_In
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
            this.T_Log_In_Email = new System.Windows.Forms.RichTextBox();
            this.T_Log_In_Password = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.But_Bypass_Login = new System.Windows.Forms.Button();
            this.But_Log_IN = new System.Windows.Forms.Button();
            this.But_Sign_Up = new System.Windows.Forms.Button();
            this.But_Delete_Account = new System.Windows.Forms.Button();
            this.T_Reset_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T_Log_In_Email
            // 
            this.T_Log_In_Email.Location = new System.Drawing.Point(180, 115);
            this.T_Log_In_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Log_In_Email.Name = "T_Log_In_Email";
            this.T_Log_In_Email.Size = new System.Drawing.Size(277, 42);
            this.T_Log_In_Email.TabIndex = 0;
            this.T_Log_In_Email.Text = "";
            // 
            // T_Log_In_Password
            // 
            this.T_Log_In_Password.Location = new System.Drawing.Point(180, 191);
            this.T_Log_In_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Log_In_Password.Name = "T_Log_In_Password";
            this.T_Log_In_Password.Size = new System.Drawing.Size(277, 42);
            this.T_Log_In_Password.TabIndex = 1;
            this.T_Log_In_Password.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(68, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // But_Bypass_Login
            // 
            this.But_Bypass_Login.Location = new System.Drawing.Point(5, 422);
            this.But_Bypass_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Bypass_Login.Name = "But_Bypass_Login";
            this.But_Bypass_Login.Size = new System.Drawing.Size(130, 59);
            this.But_Bypass_Login.TabIndex = 4;
            this.But_Bypass_Login.Text = "Bypass";
            this.But_Bypass_Login.UseVisualStyleBackColor = true;
            // 
            // But_Log_IN
            // 
            this.But_Log_IN.Location = new System.Drawing.Point(180, 262);
            this.But_Log_IN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Log_IN.Name = "But_Log_IN";
            this.But_Log_IN.Size = new System.Drawing.Size(186, 59);
            this.But_Log_IN.TabIndex = 5;
            this.But_Log_IN.Text = "Log In";
            this.But_Log_IN.UseVisualStyleBackColor = true;
            this.But_Log_IN.Click += new System.EventHandler(this.But_Log_IN_Click);
            // 
            // But_Sign_Up
            // 
            this.But_Sign_Up.Location = new System.Drawing.Point(180, 331);
            this.But_Sign_Up.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Sign_Up.Name = "But_Sign_Up";
            this.But_Sign_Up.Size = new System.Drawing.Size(186, 59);
            this.But_Sign_Up.TabIndex = 6;
            this.But_Sign_Up.Text = "Sign Up";
            this.But_Sign_Up.UseVisualStyleBackColor = true;
            this.But_Sign_Up.Click += new System.EventHandler(this.But_Sign_Up_Click);
            // 
            // But_Delete_Account
            // 
            this.But_Delete_Account.Location = new System.Drawing.Point(180, 400);
            this.But_Delete_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Delete_Account.Name = "But_Delete_Account";
            this.But_Delete_Account.Size = new System.Drawing.Size(186, 59);
            this.But_Delete_Account.TabIndex = 7;
            this.But_Delete_Account.Text = "Delete Account";
            this.But_Delete_Account.UseVisualStyleBackColor = true;
            // 
            // T_Reset_Password
            // 
            this.T_Reset_Password.Location = new System.Drawing.Point(180, 469);
            this.T_Reset_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Reset_Password.Name = "T_Reset_Password";
            this.T_Reset_Password.Size = new System.Drawing.Size(186, 59);
            this.T_Reset_Password.TabIndex = 8;
            this.T_Reset_Password.Text = "Reset Password";
            this.T_Reset_Password.UseVisualStyleBackColor = true;
            this.T_Reset_Password.Click += new System.EventHandler(this.T_Reset_Password_Click);
            // 
            // F_Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 537);
            this.Controls.Add(this.T_Reset_Password);
            this.Controls.Add(this.But_Delete_Account);
            this.Controls.Add(this.But_Sign_Up);
            this.Controls.Add(this.But_Log_IN);
            this.Controls.Add(this.But_Bypass_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Log_In_Password);
            this.Controls.Add(this.T_Log_In_Email);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "F_Log_In";
            this.Text = "Log_In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox T_Log_In_Email;
        private System.Windows.Forms.RichTextBox T_Log_In_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button But_Bypass_Login;
        private System.Windows.Forms.Button But_Log_IN;
        private System.Windows.Forms.Button But_Sign_Up;
        private System.Windows.Forms.Button But_Delete_Account;
        private System.Windows.Forms.Button T_Reset_Password;
    }
}