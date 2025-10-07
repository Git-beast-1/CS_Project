using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using RestSharp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace CS_Course_Work
{
    public partial class F_Log_In : Form // Next up: Delete database with deleted account 
    {
        string ID_Token,User_ID;
        public F_Log_In()
        {
            InitializeComponent();
        }

        private void But_Sign_Up_Click(object sender, EventArgs e)
        {
            F_Sign_up sign_Up = new F_Sign_up();
            sign_Up.Show();
        }

        private void But_Log_IN_Click(object sender, EventArgs e)
        {
            string API_Key = "AIzaSyDftLhFU_RCp5227yeoj9wR9FtG91JUTI8";// to access firebase
            string URl_for_Account_Log_IN = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key=" + API_Key;

            var Log_IN_Data = new
            {
                email = T_Log_In_Email.Text,
                password = T_Log_In_Password.Text,
                returnSecureToken = true
            };


            string Convert_To_Json = Newtonsoft.Json.JsonConvert.SerializeObject(Log_IN_Data);
            var Organise_Json = new System.Net.Http.StringContent(Convert_To_Json, Encoding.UTF8, "application/json");
            var HTTP_Client = new System.Net.Http.HttpClient();// a payload to send json data for account creation
            var Data_Response = HTTP_Client.PostAsync(URl_for_Account_Log_IN, Organise_Json).Result;// creates the actual account
            string Response_As_String = Data_Response.Content.ReadAsStringAsync().Result;
            if (Data_Response.IsSuccessStatusCode)
            {
                dynamic Login_Result = Newtonsoft.Json.JsonConvert.DeserializeObject(Response_As_String);
                ID_Token = Login_Result.idToken;
                User_ID = Login_Result.localId;
                Read_Account_Type();
            }
            else
            {
                MessageBox.Show("Invalid credentials OR enable your wifi");
            }
        }

        public void Read_Account_Type()
        {

            string Database_URL = "https://cs-dual-system-9ec28-default-rtdb.firebaseio.com/";
            string Location = "All_Members/" + User_ID + "/Account_Type.json";
            string Link = Database_URL + Location;
            var Connect_to_Firebase = new RestClient(Link);
            var Get_Request_for_Data = new RestRequest(Link,Method.Get);
            RestResponse Responsed_Data = Connect_to_Firebase.Execute(Get_Request_for_Data);

            if (Responsed_Data.IsSuccessStatusCode)
            {
                string Account_Type = JsonConvert.DeserializeObject<dynamic>(Responsed_Data.Content);

                if(Account_Type == "Student")
                {
                    F_Student_Home_Page New_Student = new F_Student_Home_Page();
                    F_Log_In Current_Log_in = new F_Log_In();
                    Current_Log_in.Hide();
                    New_Student.Show();

                }
                else if(Account_Type == "Teacher")
                {
                    F_Teacher_Home_Page New_Teacher = new F_Teacher_Home_Page();
                    F_Log_In Current_Log_in = new F_Log_In();
                    Current_Log_in.Hide();
                    New_Teacher.Show();
                }
            }
            else
            {
                MessageBox.Show("Couldn't Load the Interface");
            }
        }
        public void Load_Interface()
        {

        }

        private void T_Reset_Password_Click(object sender, EventArgs e)
        {
            if(T_Log_In_Email.Text == string.Empty)
            {
                MessageBox.Show("Enter your email");
            }
            
            else {
            string API_Key = "AIzaSyDftLhFU_RCp5227yeoj9wR9FtG91JUTI8";
            string URL_for_Reset = "https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key=" + API_Key;

            var Reset_Data = new
            {
                requestType = "PASSWORD_RESET",
                email = T_Log_In_Email.Text // Your textbox for email input
            };

                string Convert_To_Json = Newtonsoft.Json.JsonConvert.SerializeObject(Reset_Data);
            var Organise_Json = new System.Net.Http.StringContent(Convert_To_Json, Encoding.UTF8, "application/json");
            var HTTP_Client = new System.Net.Http.HttpClient();
            var Data_Response = HTTP_Client.PostAsync(URL_for_Reset, Organise_Json).Result;
            string Response_As_String = Data_Response.Content.ReadAsStringAsync().Result;

            if (Data_Response.IsSuccessStatusCode)
            {
                MessageBox.Show("Password reset email sent successfully.");
            }
            else
            {
                MessageBox.Show("Error:\n" + Response_As_String);
            }
            }

        }

        private void But_Delete_Account_Click(object sender, EventArgs e)
        {
            Delete_Account(ID_Token);
        }

        private void But_Bypass_Login_Click(object sender, EventArgs e)
        {
            Read_Account_Type();
        }

        public void Delete_Account(string idToken)
        {
            string API_Key = "AIzaSyDftLhFU_RCp5227yeoj9wR9FtG91JUTI8";
            string URL_for_Deletion = "https://identitytoolkit.googleapis.com/v1/accounts:delete?key=" + API_Key;

            var Delete_Data = new
            {
                idToken = idToken
            };

            string Convert_To_Json = JsonConvert.SerializeObject(Delete_Data);
            var Organise_Json = new System.Net.Http.StringContent(Convert_To_Json, Encoding.UTF8, "application/json");
            var HTTP_Client = new System.Net.Http.HttpClient();
            var Data_Response = HTTP_Client.PostAsync(URL_for_Deletion, Organise_Json).Result;
            string Response_As_String = Data_Response.Content.ReadAsStringAsync().Result;

            if (Data_Response.IsSuccessStatusCode)
            {
                MessageBox.Show("Account deleted successfully.");
            }
            else
            {
                MessageBox.Show("Error deleting account:\n" + Response_As_String);
            }
        }

    }
}
