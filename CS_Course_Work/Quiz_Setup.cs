using Newtonsoft.Json;
using RestSharp;
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
    public partial class F_Quiz_Info : Form // 
    {
        public static Dictionary<string, string> Student_And_Student_ID = new Dictionary<string, string>();

        public string ID_Location;
        public List<F_Question_Template.Question_Setup> All_Questions = new List<F_Question_Template.Question_Setup> ();

    public string User_ID;
        public class Student_Quiz_Info {
            public string Quiz_Name;
            public string Teacher_ID;
        }
        public Student_Quiz_Info Student_Quiz_Data;

        public F_Quiz_Info()
        {
            InitializeComponent();
        }

        private void But_Create_Quiz_Click_1(object sender, EventArgs e)
        {
            Write_To_Database();// Store Quiz to data base
            Student_ID_Access();// Access All student IDs via dictionary
            Send_Quiz_Data_To_Student_Database();// sends Teachers ID and quiz name to student Ids
                                                //hence, when student logs in, the quiz is retrieved from teachers ID with the right quiz name 
        }


        public void Student_ID_Access()
        {

        string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "All_Members/STUDENT_ACCESS_ID/.json";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link, Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);

            if (Responsed_Data.IsSuccessStatusCode)
            {
                var Data = JsonConvert.DeserializeObject<Dictionary<string, string>>(Responsed_Data.Content);


                List<string> Splitted = new List<string>();
                List<string> Account_Data = new List<string>(Data.Values);
                for (int i = 0; i < Account_Data.Count; i++)
                {
                    Splitted.AddRange(Account_Data[i].Split('/'));
                }
                MessageBox.Show("Splitted :" + Splitted.Count);

                for (int i = 0; i < Splitted.Count; i += 2)
                {
                    Student_And_Student_ID.Add(Splitted[i], Splitted[i + 1]);
                }
            }
            else
            {
                MessageBox.Show("Couldn't Load the Interface");
            }
        }
        public void Read_From_Database()
        {

        }
        public void Write_To_Database()
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "Central_Quiz/"+ID_Location+"/" +T_Quiz_Name.Text+".json"; 

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
            Student_Quiz_Data = new Student_Quiz_Info();

            for (int i = 0; i < Combo_Student_Accounts.Items.Count; i++)
            {
                string Student_ID = Combo_Student_Accounts.Items[i].ToString();
                Student_Quiz_Data.Teacher_ID = ID_Location;
                Student_Quiz_Data.Quiz_Name = T_Quiz_Name.Text;

                string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
                string Location = "Central_Quiz/" + Student_And_Student_ID[Student_ID] +"/Quizzes/"+T_Quiz_Name.Text+".json";

                string Link = Database_URL + Location;
                string Data_As_Json = JsonConvert.SerializeObject(Student_Quiz_Data);
                var Json_Wrapped = new StringContent(Data_As_Json, Encoding.UTF8, "application/json");

                var Sender_client = new HttpClient();
                var To_Database = Sender_client.PutAsync(Link, Json_Wrapped).Result;

                if (To_Database.IsSuccessStatusCode)
                {
                  MessageBox.Show("Send Successful!!");
                }
                else
                {
                    string errorDetails = To_Database.Content.ReadAsStringAsync().Result;
                   MessageBox.Show(errorDetails);
                }
            }
            MessageBox.Show("Quiz sent to all listed students!!!");

        }
        private void But_Bug_Tester_Click(object sender, EventArgs e)
        {

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

        private void F_Quiz_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
