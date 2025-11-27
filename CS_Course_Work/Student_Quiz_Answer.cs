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
    public partial class F_Student_Quiz_Answer : Form
    {
        public List<F_Student_Home_Page.Retrieved_Question_Set_UP> Current_Questions = new List<F_Student_Home_Page.Retrieved_Question_Set_UP>();
        public F_Student_Quiz_Answer()
        {
            InitializeComponent();
        }
    }
}
