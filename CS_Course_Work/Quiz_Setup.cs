using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CS_Course_Work
{
    public partial class F_Quiz_Info : Form 
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
        public string File_name,User_ID;
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
        public void Write_To_Database()
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "Central_Quiz/" +T_Quiz_Name.Text+".json"; 

            string Link = Database_URL + Location;
            string Data_As_Json=JsonConvert.SerializeObject(All_Questions);
            var Json_Wrapped= new StringContent(Data_As_Json, Encoding.UTF8, "application/json");

            var Sender_client = new HttpClient();
            var To_Database = Sender_client.PutAsync(Link, Json_Wrapped).Result;

            if (To_Database.IsSuccessStatusCode)
            {
                MessageBox.Show("Write was successful!!");
            }
            else
            {
                string errorDetails = To_Database.Content.ReadAsStringAsync().Result;
                MessageBox.Show(errorDetails);
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

        private void Combo_Student_Accounts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
