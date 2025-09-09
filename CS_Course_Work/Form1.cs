using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Course_Work
{
    public partial class F_Question_Template : Form
    {
            int I_Is_pair;
        public class Question_Setup
        {
            public string Question;
            public List<string> Options;
            public string Right_Answer;
            public int Option_Length;
        }
        Question_Setup Question_Ref= new Question_Setup();


        public F_Question_Template()
        {
            InitializeComponent();
        }

        private void F_Question_Template_Load(object sender, EventArgs e)
        {
            Question_Ref.Options = new List<string> (){T_Op_1.Text,T_Op_2.Text,T_Op_3.Text,T_Op_4.Text,T_Op_5.Text,T_Op_6.Text};
            Question_Ref.Right_Answer = T_Right_Answer.Text;
            Question_Ref.Question = T_Question.Text;
        }

        private void But_New_Question_Click(object sender, EventArgs e)
        {
            if (Question_Ref.Options[0] == string.Empty)
            {
                MessageBox.Show("ENTER at least one Option in first option slot  !!!");
            }
            else if (Question_Ref.Question == string.Empty)
            {
                MessageBox.Show("Enter a Question!!!");
            }
            else if (Question_Ref.Right_Answer == string.Empty) {
                MessageBox.Show("Enter a Right Answer!!!");
            }


                for (int i = 0; i < Question_Ref.Options.Count; i++)
                {
                    if (Question_Ref.Options[i] == Question_Ref.Right_Answer)
                    {
                        I_Is_pair += 1;
                    }
                }

            if(I_Is_pair > 0)
            {
                
            }
            else if(I_Is_pair == 0)
            {
                MessageBox.Show("Your Right Answer does not match any of your Options !!!");
            }
        }
    }
}
