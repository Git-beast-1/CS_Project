using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CS_Course_Work
{
    public partial class F_Quiz_Info : Form //NEXT UP: Check date,Time, Storage Time and account formats, Make Retry and Timer enable and disable,Read and Write to a File
    {                                      

        public List<F_Question_Template.Question_Setup> All_Questions = new List<F_Question_Template.Question_Setup> ();
        public class Q_Information 
        {
           public   int Version_no;
           public string Quiz_Name;
           public string Student_Accounts;// List as a string
           public  char Due_Date;
           public string Links;//List as a string
           public  bool Retry;
           public  string Storage_Time;
           public bool Timer;
           public string Time;
        }
        public Q_Information Q_Info= new Q_Information();
        public F_Quiz_Info()
        {
            InitializeComponent();
        }

        private void But_Create_Quiz_Click_1(object sender, EventArgs e)
        {
            if(T_Quiz_Name.Text == string.Empty || T_Due_Date.Text == string.Empty || T_Storage_Time.Text == string.Empty)
            {
                MessageBox.Show("Please fill the Quiz Name, Due_Date and Storage time slot !!!", "MISSING VALUES");
            }
        }



        public void Read_From_Database()
        {

        }
        public void Write_To_Database() {
            if (File.Exists(T_Quiz_Name.Text))
            {

            }
            
        }
        private void But_Bug_Tester_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < All_Questions.Count; i++)
            {
                MessageBox.Show("Question: " + All_Questions[i].Question);
                MessageBox.Show("Options: " + All_Questions[i].Options);
                MessageBox.Show("Right Answer: " +All_Questions[i].Right_Answer);
            }
        }

        private void But_Add_Student_Account_Click(object sender, EventArgs e)
        {
            Combo_Student_Accounts.Items.Add(Combo_Student_Accounts.Text);
            Combo_Student_Accounts.Text = string.Empty; 
        }

        private void But_Add_Links_Click(object sender, EventArgs e)
        {
            Combo_Links.Items.Add(Combo_Links.Text);
            Combo_Links.Text = string.Empty;   
        }

        private void But_Remove_Student_Account_Click(object sender, EventArgs e)
        {
            Combo_Student_Accounts.Items.Remove(Combo_Student_Accounts.Text);
            Combo_Student_Accounts.Text= string.Empty;
        }

        private void But_Remove_Links_Click(object sender, EventArgs e)
        {
            Combo_Links.Items.Remove(Combo_Links.Text);
            Combo_Links.Text = string.Empty;
        }
    }
}
