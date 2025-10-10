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
    public partial class F_Teacher_Home_Page : Form
    {
        public string Teacher_ID,Teacher_Name;
        public F_Teacher_Home_Page()
        {
            InitializeComponent();
        }

        private void Quizzes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void But_Add_Quiz_Click(object sender, EventArgs e)
        {
            F_Question_Template Quiz_Interface = new F_Question_Template();
            Quiz_Interface.Show();
            Quiz_Interface.ID_Location = Teacher_ID;
            this.Hide();
        }

        private void F_Teacher_Home_Page_Load(object sender, EventArgs e)
        {
            T_Teacher_Name.Text = Teacher_Name;
        }

        private void T_Teacher_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_All_Student_Results_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
