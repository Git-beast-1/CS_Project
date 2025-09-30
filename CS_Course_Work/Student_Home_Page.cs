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
    public partial class Student_Home_Page : Form //NEXT UP: read the quiz and quiz info of the selected quiz from the central database
    {
        public List<F_Question_Template.Question_Setup> Available_Question;
        public F_Quiz_Info.Q_Information Availabel_Quiz_Info;
        public Student_Home_Page()
        {
            InitializeComponent();
        }

        private void Student_Home_Page_Load(object sender, EventArgs e)
        {

        }

        private void Combo_Quiz_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Read_From_Selected_Name()
        {

        }
    }
}
