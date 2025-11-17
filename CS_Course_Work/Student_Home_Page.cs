using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Course_Work
{
    public partial class F_Student_Home_Page : Form //NEXT UP: Read Quiz Data using the read student Quiz info Data 
    {
        public string Student_ID, Student_Name;
        public List<F_Question_Template.Question_Setup> Available_Question;

        public class Student_Quiz_Info
        {
            public string Quiz_Name;
            public string Teacher_ID;
        }

        public List<Student_Quiz_Info> Quiz_Data = new List<Student_Quiz_Info>();
        public F_Student_Home_Page()
        {
            InitializeComponent();
        }

        private void But_Tester_Click(object sender, EventArgs e)
        {
            List_All_Available_Quizzes();
        }

        public void List_All_Available_Quizzes()
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "Central_Quiz/" + Student_ID+ "/Quizzes.json";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link, Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);

            if (Responsed_Data.IsSuccessStatusCode)
            {
              var Data = JsonConvert.DeserializeObject(Responsed_Data.Content);
                Bug_Test_Test.Text = Data.ToString();
                string Data_To_String = Data.ToString();
                List<string> Q_T = new List<string>();
                string name, quiz;
                int K;
                Q_T.AddRange(Data_To_String.Split('\n'));
                for (int j = 2; j < Q_T.Count; j += 4)
                {
                    K = j + 1;
                    name = Q_T[j];
                    quiz = Q_T[K];

                    MessageBox.Show(name);
                    MessageBox.Show(quiz);

                }
            }
            else
            {
                MessageBox.Show("Couldn't Load the Interface");
            }
        }

        public void Read_Quiz_From_Teacher_Database()
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = " ";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link, Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);
        }
    }
}
