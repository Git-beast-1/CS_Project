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
using static System.Net.WebRequestMethods;

namespace CS_Course_Work
{
    public partial class F_Sign_up : Form
    {
        string ID_Token, User_ID, T_Account_Type;

        public class Built_In_Info // *RECORD STRUCTURE*
        {
            public string Name;
            public string Account_Type;
        }
        Built_In_Info Preset = new Built_In_Info();

        public F_Sign_up()
        {
            InitializeComponent();
        }

        private void But_Create_Account_Click(object sender, EventArgs e)
        {
            Sign_Up();
        }

        private void F_Sign_up_Load(object sender, EventArgs e)
        {
            Combo_Account_Type.Items.Add("Student");
            Combo_Account_Type.Items.Add("Teacher");
        }

        public void Sign_Up()
        {
            string API_Key = "AIzaSyDftLhFU_RCp5227yeoj9wR9FtG91JUTI8";// to access firebase
            string URl_for_Account_Creation = "https://identitytoolkit.googleapis.com/v1/accounts:signUp?key=" + API_Key;

            var Sign_Up_Data = new
            {
                email = T_Sign_Up_Email.Text,
                password = T_Sign_Up_Password.Text,
                returnSecureToken = true
            };


            string Convert_To_Json = Newtonsoft.Json.JsonConvert.SerializeObject(Sign_Up_Data);
            var Organise_Json = new System.Net.Http.StringContent(Convert_To_Json, Encoding.UTF8, "application/json");
            var HTTP_Client = new System.Net.Http.HttpClient();// a payload to send json data for account creation
            var Data_Response = HTTP_Client.PostAsync(URl_for_Account_Creation, Organise_Json).Result;// creates the actual account
            string Response_As_String = Data_Response.Content.ReadAsStringAsync().Result;
            if (Data_Response.IsSuccessStatusCode)
            {
                dynamic Login_Result = Newtonsoft.Json.JsonConvert.DeserializeObject(Response_As_String);
                ID_Token = Login_Result.idToken;
                User_ID = Login_Result.localId;
                F_Quiz_Info Access_Quiz_Info = new F_Quiz_Info();
                Access_Quiz_Info.User_ID = User_ID;
                Create_User_Database();
            }
            else
            {
                MessageBox.Show("Invalid Credentials or enable wifi");
            }

        }

        public void Create_User_Database()
        {
            Preset.Name = T_User_Name.Text;
            Preset.Account_Type = Combo_Account_Type.Text;

            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "All_Members/" + User_ID + ".json";

            string Link = Database_URL + Location;
            string Data_As_Json = JsonConvert.SerializeObject(Preset);
            var Json_Wrapped = new StringContent(Data_As_Json, Encoding.UTF8, "application/json");

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

            if (Combo_Account_Type.Text == "Student")
            {
                Add_Student_To_Access_Dictionary();
            }
        }
        public void Add_Student_To_Access_Dictionary()
        {
            string Account_Data = T_User_Name.Text+"/" + User_ID;
            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "All_Members/STUDENT_ACCESS_ID/" +T_User_Name.Text+".json";
            
            string Link = Database_URL + Location;
            string Data_As_Json = JsonConvert.SerializeObject(Account_Data);
            var Json_Wrapped = new StringContent(Data_As_Json, Encoding.UTF8, "application/json");

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
    }
}
