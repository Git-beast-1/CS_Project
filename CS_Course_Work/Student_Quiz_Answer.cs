using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Course_Work
{
    public partial class F_Student_Quiz_Answer : Form
    {
        public List<F_Student_Home_Page.Retrieved_Question_Set_UP> Current_Questions = new List<F_Student_Home_Page.Retrieved_Question_Set_UP>();
        public int Max_Index,Current_Index;
        public List<string> Student_Answers = new List<string>();
        public List<Button> Option_Buts;
        public F_Student_Quiz_Answer()
        {
            InitializeComponent();
        }

        private void F_Student_Quiz_Answer_Load(object sender, EventArgs e)
        {
            Max_Index = Current_Questions.Count;
            Option_Buts = new List<Button>() { But_Option_A, But_Option_B, But_Option_C, But_Option_D, But_Option_E, But_Option_F };
            Current_Index = 0;
            for(int i = 0; i < Max_Index; i++)
            {
                Student_Answers.Add(string.Empty);
            }

            But_Option_A.Click += Detect_Selected_Answer;
            But_Option_B.Click += Detect_Selected_Answer;
            But_Option_C.Click += Detect_Selected_Answer;
            But_Option_D.Click += Detect_Selected_Answer;
            But_Option_E.Click += Detect_Selected_Answer;
            But_Option_F.Click += Detect_Selected_Answer;

            Preview_Questions();
        }

        private void But_Right_Pan_Click(object sender, EventArgs e)
        {
            Current_Index++;
            if (Current_Index >= Max_Index)
            {
                Current_Index = Max_Index-1;
            }
            else if (Current_Index < Max_Index && Current_Index>0) { 
                Clear_Questions();
                Preview_Questions();
            }
        }

        private void But_Left_Pan_Click(object sender, EventArgs e)
        {
            Current_Index--;
            if (Current_Index == -1) { 
                Current_Index = 0;
            }
            else if (Current_Index >= 0)
            {
                Clear_Questions();
                Preview_Questions();
            }
        }

        public void Clear_Questions()
        {
            for(int i = 0;i < Option_Buts.Count; i++)
            {
                Option_Buts[i].Text = string.Empty;
                Option_Buts[i].Visible = false;
            }
        }
        public void  Preview_Questions()
        {
            T_Question.Text = Current_Questions[Current_Index].Question;

            List<string> List_To_String = new List<string>(Current_Questions[Current_Index].Options.Split(','));
            int Number_of_Buttons = List_To_String.Count;
            for (int i = 0; i < Number_of_Buttons; i++) {
                Option_Buts[i].Visible = true;
                Option_Buts[i].Text = List_To_String[i];
            }

        }

        private void But_Submit_Quiz_Click(object sender, EventArgs e)
        {
            F_Result_Template result_Template = new F_Result_Template();
            for(int i = 0; i < Student_Answers.Count; i++)
            {
                result_Template.All_Chosen_Answers.Add(Student_Answers[i]);
                result_Template.Compare_with_Questions.Add(Current_Questions[i]);

                MessageBox.Show(Student_Answers[i]);
            }

            result_Template.Show();
            this.Hide();
        }

        public void Detect_Selected_Answer(object sender, EventArgs e)
        {
            Button Selected = sender as Button;
            Student_Answers[Current_Index] = Selected.Text;
        }
    }
}
