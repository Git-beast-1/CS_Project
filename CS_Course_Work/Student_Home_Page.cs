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
        public class Retrieved_Question_Set_UP//*RECORD STRUCTURES*
        {
            public string Options { get; set; }
            public string Question {  get; set; }

            public string Right_Answer {  get; set; }
        }
        public string Student_ID, Student_Name;
        public List<Retrieved_Question_Set_UP> Available_Question = new List<Retrieved_Question_Set_UP>();
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
                   Read_Quiz_From_Teacher_Database(quizStrings[j], quizStrings[i]);// *PARAMETER PASSING TO FUNCTION*
                    break;
                }
            }
        }

        public void Read_Quiz_From_Teacher_Database(string Teacher_ID, string Quiz_Name)// *PARAMETER PASSING TO FUNCTION*
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "Central_Quiz/"+Teacher_ID+"/"+Quiz_Name+".json";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link, Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);

            if (Responsed_Data.IsSuccessStatusCode)
            {
                List<Retrieved_Question_Set_UP> data = JsonConvert.DeserializeObject<List<Retrieved_Question_Set_UP>>(Responsed_Data.Content);

                foreach(var item in data)
                {          
                    Retrieved_Question_Set_UP Temp_Holder = new Retrieved_Question_Set_UP();
                    Temp_Holder.Options = item.Options;
                    Temp_Holder.Question = item.Question;
                    Temp_Holder.Right_Answer = item.Right_Answer;
                    Available_Question.Add(Temp_Holder);   
                }

                F_Student_Quiz_Answer Student_Quiz_Form = new F_Student_Quiz_Answer();
                for(int i=0; i < Available_Question.Count; i++)
                {
                    Student_Quiz_Form.Current_Questions.Add(Available_Question[i]);
                }
                Student_Quiz_Form.Quiz_Name= Quiz_Name;
                Student_Quiz_Form.Teacher_ID = Teacher_ID;
                Student_Quiz_Form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("THIS QUIZ DOESN'T EXIST!!");
            }
        }
    }
}
