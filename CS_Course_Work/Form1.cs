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
        Question_Setup Transfer_Q_to_List = new Question_Setup();
        List<Question_Setup> Complete_Question_setup = new List<Question_Setup>();

        public List<RichTextBox> Current_Options;


        public F_Question_Template()
        {
            InitializeComponent();
        }

        private void F_Question_Template_Load(object sender, EventArgs e)
        {
           Current_Options = new List<RichTextBox> (){T_Op_1,T_Op_2,T_Op_3,T_Op_4,T_Op_5,T_Op_6};
        }

        private void But_New_Question_Click(object sender, EventArgs e)
        {
            if (T_Question.Text == string.Empty || T_Right_Answer.Text == string.Empty)
            {
                MessageBox.Show("Your Question or Option slot is empty, please fill it ");
            }
            else if (Current_Options[0].Text == string.Empty)
            {
                MessageBox.Show("Make sure fill in option box, the first option slot should be filled ");
            }
            else
            {
                for (int i = 0; i < Current_Options.Count; i++)
                {
                    if (Current_Options[i].Text == T_Right_Answer.Text)
                    {
                        I_Is_pair += 1;
                    }
                }

                if (I_Is_pair == 1)
                {
                    string Convert_List_to_String;

                    Transfer_Q_to_List.Question = T_Question.Text;
                    Transfer_Q_to_List.Right_Answer= T_Right_Answer.Text;

                    //Up next Saving Options to Structure

                }
                else if (I_Is_pair !=  1)
                {
                    MessageBox.Show("Some of your Options are thesame  OR dont match the right answer input ");
                }

            }
            I_Is_pair = 0;
        }
        public void Outer_the_Way()
        {
       
        }
    }
}
