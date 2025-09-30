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
    public partial class F_Quiz_Info : Form //NEXT UP: write quiz and quiz info to central database, and send the quiz name and quiz info name to student account combo box
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
        public string File_name;
        public F_Quiz_Info()
        {
            InitializeComponent();
        }

        private void But_Create_Quiz_Click_1(object sender, EventArgs e)
        {
            Write_To_Database();
        }



        public void Read_From_Database()
        {

        }
        public void Write_To_Database() {

            
            File_name = T_Quiz_Name.Text + ".txt";

            if (File.Exists(File_name))
            {
                MessageBox.Show("File already exists!!");
            }
            else if (!File.Exists(File_name)) { 
                File.Create(File_name).Close();

                using (StreamWriter Write_to_File = new StreamWriter(File_name)) {
                    for (int i = 0; i < All_Questions.Count; i++) { 
                        Write_to_File.WriteLine(All_Questions[i].Question);
                        Write_to_File.WriteLine(All_Questions[i].Options);
                        Write_to_File.WriteLine(All_Questions[i].Right_Answer);
                    }
                }
                MessageBox.Show(File_name + " has been created !!!");

                Q_Info.Version_no = 1;


            }
        }

        public void Send_Quiz_Data_To_Student_Database()
        {

        }
        private void But_Bug_Tester_Click(object sender, EventArgs e)
        {

            MessageBox.Show("File name : " + File_name);
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
