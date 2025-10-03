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
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email :";
            // 
            // T_Sign_Up_Password
            // 
            this.T_Sign_Up_Password.Location = new System.Drawing.Point(194, 97);
            this.T_Sign_Up_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Sign_Up_Password.Name = "T_Sign_Up_Password";
            this.T_Sign_Up_Password.Size = new System.Drawing.Size(277, 42);
            this.T_Sign_Up_Password.TabIndex = 5;
            this.T_Sign_Up_Password.Text = "";
            // 
            // T_Sign_Up_Email
            // 
            this.T_Sign_Up_Email.Location = new System.Drawing.Point(194, 21);
            this.T_Sign_Up_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T_Sign_Up_Email.Name = "T_Sign_Up_Email";
            this.T_Sign_Up_Email.Size = new System.Drawing.Size(277, 42);
            this.T_Sign_Up_Email.TabIndex = 4;
            this.T_Sign_Up_Email.Text = "";
            // 
            // Combo_Account_Type
            // 
            this.Combo_Account_Type.FormattingEnabled = true;
            this.Combo_Account_Type.Location = new System.Drawing.Point(194, 161);
            this.Combo_Account_Type.Name = "Combo_Account_Type";
            this.Combo_Account_Type.Size = new System.Drawing.Size(277, 28);
            this.Combo_Account_Type.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Account Type:";
            // 
            // But_Create_Account
            // 
            this.But_Create_Account.Location = new System.Drawing.Point(194, 224);
            this.But_Create_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.But_Create_Account.Name = "But_Create_Account";
            this.But_Create_Account.Size = new System.Drawing.Size(186, 59);
            this.But_Create_Account.TabIndex = 10;
            this.But_Create_Account.Text = "Create Account";
            this.But_Create_Account.UseVisualStyleBackColor = true;
            this.But_Create_Account.Click += new System.EventHandler(this.But_Create_Account_Click);
            // 
            // F_Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.But_Create_Account);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Combo_Account_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Sign_Up_Password);
            this.Controls.Add(this.T_Sign_Up_Email);
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
    }
}