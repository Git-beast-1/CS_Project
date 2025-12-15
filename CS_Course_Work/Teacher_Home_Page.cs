using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CS_Course_Work.F_Student_Home_Page;

namespace CS_Course_Work
{
    public partial class F_Teacher_Home_Page : Form
    {
        public string Teacher_ID,Teacher_Name;
        public List<F_Result_Template.Student_Results> Student_Results = new List<F_Result_Template.Student_Results> ();
        public F_Teacher_Home_Page()
        {
            InitializeComponent();
        }


        private void But_Add_Quiz_Click(object sender, EventArgs e)
        {
            F_Question_Template Quiz_Interface = new F_Question_Template();
            Quiz_Interface.Show();
            Quiz_Interface.ID_Location = Teacher_ID;
            this.Hide();
        }

        public void Read_Student_Results()
        {
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "Central_Quiz/" + Teacher_ID + "/Student_Results/.json";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link, Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);

            if (Responsed_Data.IsSuccessStatusCode)
            {
                List<F_Result_Template.Student_Results> data = JsonConvert.DeserializeObject<List<F_Result_Template.Student_Results>>(Responsed_Data.Content);

                foreach (var item in data)
                {
                    F_Result_Template.Student_Results Temp_Holder = new F_Result_Template.Student_Results();
                    Temp_Holder.Quiz_Name = item.Quiz_Name;
                    Temp_Holder.Right_Answers = item.Right_Answers;
                    Temp_Holder.Wrong_Answers= item.Wrong_Answers;
                    Temp_Holder.Grade = item.Grade;
                    Student_Results.Add(Temp_Holder);
                }

               for(int i = 0;i< Student_Results.Count; i++)
                {
                    MessageBox.Show(Student_Results[i].Quiz_Name + "\n" + Student_Results[i].Right_Answers + "\n" + Student_Results[i].Wrong_Answers + "\n" + Student_Results[i].Grade);
                }
            }
            else
            {
                // NO ACTION Required
            }
        }

        private void But_Bug_Tester_Click(object sender, EventArgs e)
        {
            Read_Student_Results();
        }

        private void F_Teacher_Home_Page_Load(object sender, EventArgs e)
        {
            T_Teacher_Name.Text = Teacher_Name;
        }
    }
}
