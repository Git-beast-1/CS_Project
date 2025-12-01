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
    public partial class F_Result_Template : Form
    {
        public List<string> All_Chosen_Answers = new List<string>(); 
        public F_Result_Template()
        {
            InitializeComponent();
        }

        private void F_Result_Template_Load(object sender, EventArgs e)
        {
           
        }

        private void But_Redo_Click(object sender, EventArgs e)
        {
        for (int i = 0; i < All_Chosen_Answers.Count; i++) {
                MessageBox.Show(All_Chosen_Answers[i]);
            }
        }
    }
}
