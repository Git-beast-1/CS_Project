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
        public List<F_Student_Home_Page.Retrieved_Question_Set_UP> Compare_with_Questions = new List<F_Student_Home_Page.Retrieved_Question_Set_UP>();
        public float Number_of_Right_answers, Number_of_wrong_Answers;
        public List<string> right_answers, wrong_answers;
        public F_Result_Template()
        {
            InitializeComponent();
        }

        private void F_Result_Template_Load(object sender, EventArgs e)
        {
            Number_of_Right_answers = 0;
            Number_of_wrong_Answers = 0;
            right_answers = new List<string>();
            wrong_answers = new List<string>();
        }

        private void But_Redo_Click(object sender, EventArgs e)
        {
            Calculate_Quiz_Grade();
        }

        public void Calculate_Quiz_Grade()
        {
            for (int i = 0; i < Compare_with_Questions.Count; i++) {
                if (All_Chosen_Answers[i] == Compare_with_Questions[i].Right_Answer)
                {
                    Number_of_Right_answers +=1 ;
                    right_answers.Add((i + 1).ToString());
                }             
                
                else if (All_Chosen_Answers[i] == string.Empty) { 
                    continue;
                }

                else if (All_Chosen_Answers[i] != Compare_with_Questions[i].Right_Answer)
                {
                    Number_of_wrong_Answers += 1;
                    wrong_answers.Add((i + 1).ToString());
                }

            }

            T_Correct_Questions.Text = string.Join(",", right_answers);
            T_Incorrect_Questions.Text = string.Join (",", wrong_answers);
            float score = (Number_of_Right_answers/All_Chosen_Answers.Count)*100;
            int score_convert = (int)score;
            T_Score_Percentage.Text = score_convert.ToString();
        }
    }
}
