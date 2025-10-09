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
            this.Hide();
        }

        private void F_Teacher_Home_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
