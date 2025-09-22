using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_Course_Work // BUGS: if a user goes back to the preceeding question and clicks "New Question", there is 2 duplicates of that question, So check if a question setup already exists 
{                         // if a user clicks a new question and the new question isnt added to the list of question_setup, when you left pan, it assumes it one the current registered question and hence goes 2 question back
    public partial class F_Question_Template : Form
    {
        int I_Is_pair,Q_index,Display_index;// I_is_pair:: for comparing the right and options value 
                              // Q_index :: this holds the index value of the "Complete_Question_setup", it is used for panning around 
                              //Display_index: the number of Questions visible to the teacher 

        public class Question_Setup// this class stores a list of different kind of data needed for the full questions
        {
            public string Question;
            public string Options;
            public string Right_Answer;
        }
        List<Question_Setup> Complete_Question_setup = new List<Question_Setup>();// holds a list of question of type "Question_Setup"
        public List<RichTextBox> Current_Options;// responsible for the current options in the interface 

        bool Is_Update_Click; // returns true if the update button is selected 


        public F_Question_Template()
        {
            InitializeComponent();
        }

        private void F_Question_Template_Load(object sender, EventArgs e)
        {
            Current_Options = new List<RichTextBox>() { T_Op_1, T_Op_2, T_Op_3, T_Op_4, T_Op_5, T_Op_6 };// when the form loads, all the option boxes are assigned to "Current_Options"
            Q_index = -1;// the index starts off at zero for the first question and will progressively increase for each questions 
            Display_no();
            Is_Update_Click = false;
        }

        public void But_New_Question_Click(object sender, EventArgs e)
        {
            if (T_Question.Text == string.Empty || T_Right_Answer.Text == string.Empty) // Checkes if the Question Box has been filled  and returns a message if false; 
            {
                MessageBox.Show("Your Question,Right Answer slot  or Option slot is empty, please fill it,MAKE SURE SPACE ISN'T INCLUDED AT THE END OF YOUR OPTION INPUT ","ERROR !!");
            }
            else if (Current_Options[0].Text == string.Empty) // checks if the first option slot has been filled and returns a message if false 
            {
                MessageBox.Show("Make sure fill in option box, the first option slot should be filled,MAKE SURE SPACE ISN'T INCLUDED AT THE END OF YOUR OPTION INPUT !!! ","ERROR !!");
            }
            else
            {
                for (int i = 0; i < Current_Options.Count; i++)
                {
                    if (Current_Options[i].Text == T_Right_Answer.Text)// Compares all the option values in the option box to the right answer input 
                    {
                        I_Is_pair += 1;
                    }
                }

                if (I_Is_pair == 1) // if one of the options matches the right answer, it saves the question, options and right answer data to a  temporary record structure of the Question setup 
                {
                    Question_Setup Temp_Q_setup = new Question_Setup(); 
                    Temp_Q_setup.Question = T_Question.Text;
                    Temp_Q_setup.Right_Answer = T_Right_Answer.Text;

                    string Compress_to_Line;       
                    List<string> List_to_string = new List<string>();// Takes the text value of the option lists and converts it to a list of strings; 

                    for (int i = 0; i < Current_Options.Count; i++)
                    {
                        if (Current_Options[i].Text == string.Empty)// if one of the option boxes are empty and have no value in it, the "continue" key word skips the current iteration of the loop
                        {                                           //hence not adding it to the list of strings 
                            continue;
                        }
                        List_to_string.Add(Current_Options[i].Text);

                    }
                    Compress_to_Line = string.Join(",", List_to_string);
                    Temp_Q_setup.Options = Compress_to_Line;

                    Add_to_Complete_Question(Temp_Q_setup); // adds the current question setup to the list of Complete_Question_Setup
                    Reset_Question();// resets the Ui values for another question input
                    Update_Indexes();
                }
                else if (I_Is_pair != 1)// if none of the options are thesame with the right answer or more than one of them are thesame, it returns message and doesn't save the data
                {
                    MessageBox.Show("Some of your Options are thesame  OR doesn't match the right answer input ", "ERROR!!");
                }

            }
             I_Is_pair = 0;
        }

        void Update_Indexes()
        {
            if(Is_Update_Click == false)
            {
                    Q_index += 1;
                    Display_index += 1;

                    T_Display_number.Text = Display_index.ToString();
            }
            else if (Is_Update_Click == true) {
                
            }
        }
         void Add_to_Complete_Question(Question_Setup Temp_Data)
        {
            if (Is_Update_Click == false)
            {
                Complete_Question_setup.Add(Temp_Data);
            }
            else if (Is_Update_Click == true) {
                Complete_Question_setup[Q_index] = Temp_Data;
            }
        } 
          void Reset_Question()
         {
            // in the reset functions, all the values are set to empty, to completely wipe all their string values 
            T_Question.Text = string.Empty;
            T_Right_Answer.Text = "Input the correct Answer";
            for(int i = 0;i < Current_Options.Count; i++)
            {
                Current_Options[i].Text = string.Empty;
            }

           }

        void Display_no()
        {
            if(Q_index == -1){
                Display_index = 1;

                T_Display_number.Text = Display_index.ToString();
            }
            else
            {

            Display_index = Q_index + 1;

            T_Display_number.Text = Display_index.ToString();
            }
        }

        private void But_Right_Pan_Click(object sender, EventArgs e)
        {
            Reset_Question();
            Q_index += 1;

            if(Q_index > Complete_Question_setup.Count-1)
            {
                Q_index -=1;
            }

            T_Question.Text = Complete_Question_setup[Q_index].Question;
            T_Right_Answer.Text = Complete_Question_setup[Q_index].Right_Answer;
            List<string> List_To_String = new List<string>(Complete_Question_setup[Q_index].Options.Split(','));// Separates the String options into an array of strings 
            for (int i = 0; i < List_To_String.Count; i++) {
                Current_Options[i].Text = List_To_String[i];
            }
            Display_no();
        }// pans to the next question 

        private void But_Left_Pan_Click(object sender, EventArgs e)
        {
            try
            {
                Reset_Question();
                Q_index -= 1;

                if (Q_index < 0)
                {
                    Q_index = 0;
                }


                T_Question.Text = Complete_Question_setup[Q_index].Question;
                T_Right_Answer.Text = Complete_Question_setup[Q_index].Right_Answer;
                List<string> List_To_String = new List<string>(Complete_Question_setup[Q_index].Options.Split(','));
                for (int i = 0; i < List_To_String.Count; i++)
                {
                    Current_Options[i].Text = List_To_String[i];
                }
                Display_no() ;
            }
            catch (Exception ex) {
                MessageBox.Show("Q_index: " + Q_index  + "C_Q_S: "  + Complete_Question_setup.Count);
            }
            
            }// pans to the precede question

        private void But_Update_Click(object sender, EventArgs e)
        {
            Is_Update_Click = true;
            But_New_Question_Click(sender, e);  // this is recursion that runs the new question function again but this time it updates the question by replacing it 
            Is_Update_Click = false;
        }

        private void But_Tester_Click(object sender, EventArgs e)// a Debugging button
        {
             MessageBox.Show("Q_index : " + Q_index + "Display_index" + Display_index );
        }
    } 
}
