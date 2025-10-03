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
    public partial class F_Sign_up : Form
    {//NEXT UP: sign up with teacher and student interface
        public F_Sign_up()
        {
            InitializeComponent();
        }

        private void But_Create_Account_Click(object sender, EventArgs e)
        {
            Sign_Up();
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
                MessageBox.Show("Account successfully created");
            }
            else
            {
                MessageBox.Show("Error:" + Response_As_String);
            }
        }
    }
}
