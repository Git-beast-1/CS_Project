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
        public class Retrieved_Question_Set_UP// this class stores a list of different kind of data needed for the full questions
        {
            public string Options { get; set; }
            public string Question {  get; set; }

            public string Right_Answer {  get; set; }
        }
        public string Student_ID, Student_Name;
        public List<Retrieved_Question_Set_UP> Available_Question;
        List<string> quizStrings = new List<string>();
        List<string> Each_Questions = new List<string>();
        public class Student_Quiz_Info
        {
            public string Quiz_Name { get; set; }
            public string Teacher_ID { get; set; }
        }

        public List<Student_Quiz_Info> Quiz_Data = new List<Student_Quiz_Info>();
        public F_Student_Home_Page()
        {
            InitializeComponent();
        }     

        private void F_Student_Home_Page_Load(object sender, EventArgs e)
        {
            List_All_Available_Quizzes();
        }
        private void But_Tester_Click(object sender, EventArgs e)
        {
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
                var quizzes = JsonConvert.DeserializeObject<Dictionary<string, Student_Quiz_Info>>(Responsed_Data.Content);

                foreach (var q in quizzes.Values)
                {
                    quizStrings.Add(q.Quiz_Name);
                    quizStrings.Add(q.Teacher_ID);
                }

                for (int i = 0; i < quizStrings.Count; i += 2)
                {
                    int breaking_range = quizStrings.Count - i;
                    if (breaking_range == 1)
                    {
                        break;
                    }
                    else
                    {
                        Combo_Quiz_Name.Items.Add(quizStrings[i]);
                    }
                }

            }
            else
            {
                MessageBox.Show("Couldn't Load the Interface");
            }
        }

        private void But_Start_Quiz_Click(object sender, EventArgs e)
        {
                for (int i = 0; i < quizStrings.Count; i+=2) {
                if (quizStrings[i] == Combo_Quiz_Name.Text)
                {
                    int j = i + 1;
                   Read_Quiz_From_Teacher_Database(quizStrings[j], quizStrings[i]);
                    break;
                }
            }
        }

        public void Read_Quiz_From_Teacher_Database(string Teacher_ID, string Quiz_Name)
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "Central_Quiz/"+Teacher_ID+"/"+Quiz_Name+".json";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link, Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);

            if (Responsed_Data.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<Dictionary<string,Retrieved_Question_Set_UP>>(Responsed_Data.Content);
                MessageBox.Show(data.ToString());

                foreach (var q in data.Values)
                {
                    Each_Questions.Add(q.Question);
                    Each_Questions.Add(q.Options);
                    Each_Questions.Add(q.Right_Answer);
                }
                for (int i = 0; i < Each_Questions.Count; i++)
                {
                    MessageBox.Show(Each_Questions[i]);
                }
            }
            else
            {
                MessageBox.Show("THIS QUIZ DOESN'T EXISTS!!");
            }
        }
    }
}
