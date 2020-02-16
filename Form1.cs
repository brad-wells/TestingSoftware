// Brad Wells                            
// CIS 129.7785
// 12/9/18
// Fall 2018
// Student ID# W0476000
// Final Project
// This program is a testing application. An administrator will sign in and then enter quetions and answers. A student 
// will then sign in and take the test. A summary of correct/incorrect answers along with the grade will be displayed.
// The program will allow multiple students to take the test and accumilate averages. 

// The program works by enabling buttons after the correct steps have been followed.
// Proceed to line 622 to uncomment 3 test questions/answers so you do not need to enter any for testing purposes. 
// I have also included a walk-through in the zip file with instrucitons if you need/want them. 

//***********************************************************************************************************************


using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;


namespace Final
{
    public partial class Form1 : Form
    {

        ArrayList testlist = new ArrayList();

        // these lists will be used to store Admin login credentials
        List<String> AdminPasswordList = new List<String>();
        List<String> AdminNameList = new List<String>();

        // these lists will be used to store questions and answers that are submitted by the Admin
        ArrayList Questions = new ArrayList();
                   // String q = @"C:\Users\bradw\Documents\school\Fall2018\c#\Final\Questions.txt";
        ArrayList Answers = new ArrayList();
        ArrayList Number = new ArrayList();

        


        // this flag will be set to true after the first test is graded, allowing a quick review of 
        // averages to be displayed
        bool qd = false;

        // these lists will be used to store Students credentials
        List<Object> StudentList = new List<Object>();
        ArrayList StudentNames = new ArrayList();
        ArrayList StudentAnswer = new ArrayList();
        List<int> AllScores = new List<int>();
        List<double> AllPercents = new List<double>();

        //***********************************************************************************************************************

        public Form1()
        {
            InitializeComponent();

            AdminNameList.Add("Admin");
            AdminPasswordList.Add("Password1");



        }

        //***********************************************************************************************************************


        private void groupBoxOne_Enter(object sender, EventArgs e)
        {

        }

        // this button creates a new Admin account
        public  void submitAdminButton_Click(object sender, EventArgs e)
        {
            String AdminName = AdminNameTextBox.Text;
            String AdminPass = AdminPasswordTextBox.Text;
            bool AdminNameSet = false;
            bool AdminPassSet = false;

            try
            {
                
                if (AdminName.Equals(""))
                {
                    throw new Exception("Username is empty.");
                }
                else
                {
                    AdminNameSet = true;
                }
               
                if (AdminPass.Equals(""))
                {
                    throw new Exception("Password is empty.");
                }
                
            
                    else if (AdminPass.Length < 8)
                    {
                        throw new Exception("Password must be 8 characters long.");
                    }

                    else if (!AdminPass.Any(c => char.IsLetter(c)))
                    {
                        throw new Exception("Password must contain at least one letter.");
                    }

                    else if (!AdminPass.Any(c => char.IsNumber(c)))
                    {
                        throw new Exception("Password must contain at least one number.");
                    }
                    else
                    {
                      AdminPassSet = true;
                    
                    }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"\nPlease try again");
            }

            // when all requirements are met, create a new Admin and add credentials to the lists
            if (AdminNameSet && AdminPassSet)
            {
                try
                {
                    Admin Admin = new Admin(AdminName, AdminPass);
                   // MessageBox.Show("New Admin successfully created!");
                    AdminNameList.Add(AdminName);
                    AdminPasswordList.Add(AdminPass);
                    testlist.Add(AdminName);
                    
                    AdminNameTextBox.Text = "";
                    AdminPasswordTextBox.Text = "";
                    MessageBox.Show("New user created: Your info:\n" +
                        "Name: " + AdminName + "\nPassword: " + AdminPass);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
        } // end submit button

        //***********************************************************************************************************************

        // when the form loads, display Admin login page
        private void Form1_Load(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(titlePanel);
            //MainPanel.Controls.Add(AdminNameLabel);
            //MainPanel.Controls.Add(AdminNameTextBox);
            //MainPanel.Controls.Add(AdminPasswordLabel);
            //MainPanel.Controls.Add(AdminPasswordTextBox);
            //MainPanel.Controls.Add(SubmitAdminButton);
            //MainPanel.Controls.Add(CreateAdminButton);
            MainPanel.Controls.Add(groupBoxOne);
            groupBoxOne.Controls.Remove(TypeGroupBox);
            MainPanel.Controls.Add(instLabel);

            File.ReadAllText(@"C:\Users\bradw\Documents\school\Fall2018\c#\Final\textFile.txt");

            //startup
            AdminNameLabel.Visible = true;
            AdminNameTextBox.Visible = true;
            AdminPasswordLabel.Visible = true;
            AdminPasswordTextBox.Visible = true;
            instLabel.Text = "Administrator, enter your username and password to continue.\n" +
                "If you do not have an account, fill out the form and click Create.";



        } // end FormLoad

        //***********************************************************************************************************************

        // this button allows an Admin to login after credintals have been tested
        private void SubmitAdminButton_Click_1(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(instLabel);
            TakeTestButton.Enabled = false;
            ResultsButton.Enabled = false;
            AdministerTestButton.Enabled = true;

            instLabel.Text = "Click Administer Test button to enter your test questions and answers.";
            

            String Name = AdminNameTextBox.Text;
            String Pass = AdminPasswordTextBox.Text;
            bool foundName = false;
            bool foundPass = false;




            //Make sure admin name/password has been added to the list of approved Admins
            try
            {


               if(AdminNameList.Contains(Name))
                {
                  //  MessageBox.Show("Name validated");
                    foundName = true;
                }

                else
                    {
                    foundName = false;
                    throw new Exception("name has not been registered");
                    }

                if (AdminPasswordList.Contains(Pass))
                {
                 //   MessageBox.Show("Password validated");
                    foundPass = true;
                }
                else
                {
                    foundPass = false;
                    throw new Exception("Password has not been registered");
                }

            }
            catch(Exception l)
            {
                MessageBox.Show(l.Message);
            }

            //If the Admin has been found, clear login info and display Admin options
            if (foundName && foundPass)
            {
                Admin Admin = new Admin(Name, Pass);
                groupBoxOne.Controls.Clear();
                MainPanel.Controls.Add(buttonPanel);
            }
            
        }// end SubmitAdminButton

        //***********************************************************************************************************************

        // this button allows the user to exit the program. 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to exit. Your information will" +
                " not be saved","Exit",MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                DirectoryInfo Directory = new DirectoryInfo(@"C: \Users\bradw\Documents\school\Fall2018\c#\Final");
                String QuestionFilePath = @"C:\Users\bradw\Documents\school\Fall2018\c#\Final\Questions.txt";
                File.WriteAllText(QuestionFilePath, Questions.ToString());
                String AnswerFilePath = @"C:\Users\bradw\Documents\school\Fall2018\c#\Final\Answers.txt";
                File.WriteAllText(AnswerFilePath, Answers.ToString());
               // File.WriteAllText(textFilePath, Answers.ToString());
               // File.WriteAllText(textFilePath, StudentNames.ToString());
               // File.WriteAllText(textFilePath, StudentAnswer.ToString());


                //foreach(String q in Questions)
                //{
                //    File.WriteAllLines(textFilePath, q);
                //}

                //for(int i=0; i<Questions.Count;i++)
                //{
                //    File.WriteAllLines(textFilePath, i);
                //}



                this.Close();
            }
        } // end Exit Button

        //***********************************************************************************************************************

        // this button shows a lits of Admins that have logged in
        public void ViewAdminsButton_Click(object sender, EventArgs e)
        {
            String names="";

                foreach (string x in AdminNameList)
                {
                  names += x;
                  names += "\n";
                }
                MessageBox.Show(names);
          
        } // end ViewAdmin Button

        //***********************************************************************************************************************

        // this button displays the testing program where the user can submit questions and answers
        private void AdmisisterTestButton_Click(object sender, EventArgs e)
        {

            instLabel.Text = "Select which Type of question from the options on the left. Enter your" +
                " question and answer on the right. Click enter after each question and answer is entered."+
                "Click done when all questions have been entered";

            groupBoxOne.Controls.Add(TypeGroupBox);
            groupBoxOne.Controls.Add(EnterQuestionPanel);
            EnterQuestionPanel.Controls.Add(TFRadioButtonGroupBox);

            EnterQuestionPanel.Visible = true;
            

            AnswerTrueRadioButton.Enabled = false;
            AnswerFalseRadioButton.Enabled = false;

            AnswerLabel.Enabled = false;
            blankTextBox.Enabled = false;
            ARadioButton.Enabled = false;
            BRadioButton.Enabled = false;
            CRadioButton.Enabled = false;

            TFRadioButtonGroupBox.Controls.Remove(SubmitButton);
            TFRadioButtonGroupBox.Controls.Add(EnterButton);
            TFRadioButtonGroupBox.Controls.Add(DoneButton);



        } // end AdministerTestButton

        //***********************************************************************************************************************

        // these methods will enable/disable radio buttons depending on which type is selected
        private void TFRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOne.Controls.Add(EnterQuestionPanel);
            EnterQuestionPanel.Controls.Add(TFRadioButtonGroupBox);


            AnswerTrueRadioButton.Enabled = true;
            AnswerFalseRadioButton.Enabled = true;

            AnswerLabel.Enabled = false;
            blankTextBox.Enabled = false;
            ARadioButton.Enabled = false;
            BRadioButton.Enabled = false;
            CRadioButton.Enabled = false;



            EnterQuestionPanel.Visible = true;

        } // end TFRAdioButton

        private void MultipleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOne.Controls.Add(EnterQuestionPanel);
            //EnterQuestionPanel.Visible = true;

            AnswerTrueRadioButton.Enabled = false;
            AnswerFalseRadioButton.Enabled = false;
            blankTextBox.Enabled = false;
            AnswerLabel.Enabled = false;


            ARadioButton.Enabled = true;
            BRadioButton.Enabled = true;
            CRadioButton.Enabled = true;

        } // end MultipleRadioButton

        private void FillRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxOne.Controls.Add(EnterQuestionPanel);

            AnswerTrueRadioButton.Enabled = false;
            AnswerFalseRadioButton.Enabled = false;
            ARadioButton.Enabled = false;
            BRadioButton.Enabled = false;
            CRadioButton.Enabled = false;

            blankTextBox.Enabled = true;
            AnswerLabel.Enabled = true;

        } // end FillRadioButton

        //***********************************************************************************************************************

        // this button allows the Admin to logout *Not currently using but may be implemented by making visible
        private void logoutButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(titlePanel);
           // MainPanel.Controls.Add(buttonPanel);
            MainPanel.Controls.Add(groupBoxOne);
            groupBoxOne.Controls.Remove(TypeGroupBox);
            groupBoxOne.Controls.Remove(questionGroupBox);
            groupBoxOne.Controls.Remove(EnterQuestionPanel);
            groupBoxOne.Controls.Remove(AnswerListBox);


            MainPanel.Controls.Add(instLabel);
            groupBoxOne.Controls.Add(AdminNameLabel);
            groupBoxOne.Controls.Add(AdminNameTextBox);
            groupBoxOne.Controls.Add(AdminPasswordLabel);
            groupBoxOne.Controls.Add(AdminPasswordTextBox);
            groupBoxOne.Controls.Add(SubmitAdminButton);
            groupBoxOne.Controls.Add(CreateAdminButton);
            

            AdminNameLabel.Visible = true;
            AdminNameTextBox.Visible = true;
            AdminPasswordLabel.Visible = true;
            AdminPasswordTextBox.Visible = true;
            instLabel.Text = "Administrator, enter your username and password to continue.\n" +
                "if you do not have an account, fill out the form and click create";

        } // end Logout Button
        //***********************************************************************************************************************

        // this button adds the question number, question, and answer to the appropriate lists and displays a snapshot
        private void EnterButton_Click(object sender, EventArgs e)
        {
            String num = NumComboBox.Text;
            String question = QuestionRTextBox.Text;
            String answer = FindAnswer();

            if (num.Equals(""))
            {
                MessageBox.Show("You must enter the number.");
            }
            //else
            //{
            //    Number.Add(num);
            //}
            if (question.Equals(""))
            {
                MessageBox.Show("You must enter the question.");
            }
            //else
            //{
            //    Questions.Add(question);
            //}
            if (FindAnswer() == "no answer provided")
            {
                MessageBox.Show("You must enter the answer.");
            }
            //else
            //{
            //    Answers.Add(answer);
            //}

            if ( (!num.Equals("")) && (!question.Equals("")) && (FindAnswer()!="no answer provided") )
                {
                if (Number.Contains(num))
                {
                    MessageBox.Show("A question was already entered for this number. ");
                }
                else
                {


                    Number.Add(num);
                    Questions.Add(question);
                    answer = FindAnswer();
                    Answers.Add(answer);
                    MessageBox.Show(num + "\n" + question + "\n" + answer);

                    //MessageBox.Show("Number.count: " + Number.Count + " Questions.count " + Questions.Count + "Answers.count" + Answers.Count);
                    NumComboBox.SelectedIndex += 1;
                }

            }

            blankTextBox.Text = "";

        } // end EnterButton



        private void StoreQA(String question, String answer,int num)
        {
            String q = num + question;
            String a = num + answer;
            Questions.Add(q);
            Answers.Add(a);
        }

        // this method is called from the EnterButton to find the answer to the entered question/answer to store in the list
        private String FindAnswer()
        {

            if ( TFRadioButton.Checked &&  AnswerTrueRadioButton.Checked)
            {
                return "True";
            }
            else if ( TFRadioButton.Checked && AnswerFalseRadioButton.Checked)
            {
                return "False";
            }
            else if ( MultipleRadioButton.Checked && ARadioButton.Checked)
            {
                return "A";
            }
            else if (MultipleRadioButton.Checked && BRadioButton.Checked)
            {
                return "B";
            }
            else if (MultipleRadioButton.Checked && CRadioButton.Checked)
            {
                return "C";
            }
            else if(FillRadioButton.Checked && !blankTextBox.Text.Equals(""))
            {
                return blankTextBox.Text.ToLower();
            }
            else
            {
                return "no answer provided";
            }


        } // end FindAnswer method

        // this button ends the question/answer form and displays the new options for the application
        private void DoneButton_Click(object sender, EventArgs e)
        {
            int Num;
            try
            {
                 Num = Convert.ToInt32(NumComboBox.Text);
                if (Questions.Count>=1 && Answers.Count >=1)
                {
                    MainPanel.Controls.Clear();
                    MainPanel.Controls.Add(titlePanel);
                    MainPanel.Controls.Add(buttonPanel);

                    AdministerTestButton.Enabled = false;
                    TakeTestButton.Enabled = true;
                    ResultsButton.Enabled = false;

                    MainPanel.Controls.Add(instLabel);
                    instLabel.Text = "Click Take Test to take the test." +
                        "Click Exit to end program.";
                }
                else
                {
                    throw new Exception("You must enter at least one question and answer and save by clicking enter.");
                }
            }
            catch(Exception n)
            {
                MessageBox.Show(n.Message);
            }


        } // end DoneButton

        //***********************************************************************************************************************

        // this method displays the Student Login textboxes and buttons
        public void StudentLogin()
        {
            //add login for students to take test

            MainPanel.Controls.Add(groupBoxOne);
            groupBoxOne.Controls.Add(AdminNameTextBox);
            AdminNameTextBox.Text = "";
            groupBoxOne.Controls.Add(AdminPasswordTextBox);
            AdminPasswordTextBox.Text = "";
            groupBoxOne.Controls.Add(AdminNameLabel);
            groupBoxOne.Controls.Add(AdminPasswordLabel);
            groupBoxOne.Controls.Add(IDLabel);
            groupBoxOne.Controls.Add(IDTextBox);
            IDLabel.Visible = true;
            IDTextBox.Visible = true;

            groupBoxOne.Controls.Remove(TypeGroupBox);
            groupBoxOne.Controls.Remove(EnterQuestionPanel);

            groupBoxOne.Controls.Add(StudentLogButton);
            StudentLogButton.Visible = true;
            groupBoxOne.Controls.Remove(SubmitButton);
            groupBoxOne.Controls.Remove(CreateAdminButton);


        } // end StudentLogin

        //***********************************************************************************************************************


        public void CheckAttempts()
        {
            
        }




        // this button allows the student to take the test by calling the StudentLogin method, and then displaying each test
        // question. 
        private void TakeTestButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(buttonPanel);
            MainPanel.Controls.Add(titlePanel);
            MainPanel.Controls.Add(instLabel);
            instLabel.Text = "Sign in with your Student Name, Password, and ID";
            groupBoxOne.Controls.Remove(AnswerListBox);
            
            StudentLogin();


            //*************************************************************************************************************
            //********************************************************************************************
            //*********************************************************************
            //Uncomment these to add 3 questions to the test. You will need to click submit, Administer Test Button, and 
            // then Done button on the test form. Click the Take Test button and these will display for the student to take
            // the test.

            //Number.Add("1");
            //Number.Add("2");
            //Number.Add("3");
            //Questions.Add("Cats have 4 legs");
            //Questions.Add("How many eyes do cats have? A: 8   B: 4   C:2   ");
            //Questions.Add("If you own a cat, you will probably spend a lot of money on _____ rollers");
            //Answers.Add("True");
            //Answers.Add("C");
            //Answers.Add("lint");
           
            //***********************************************************************
            //*********************************************************************************************
            //**************************************************************************************************************



            //Enter first quesiton info on screen. Depending on the type of question, it will display the correct answer
            // options

            for (int i=0; i<1; i++)
            {
                NumComboBox.Text = Number[i].ToString();
                QuestionRTextBox.Text = Questions[i].ToString();
                  if(Answers[i].ToString().Equals("True") || Answers[i].ToString().Equals("False"))
                  {
                    AnswerTrueRadioButton.Enabled = true;
                    AnswerFalseRadioButton.Enabled = true;
                    ARadioButton.Enabled = false;
                    BRadioButton.Enabled = false;
                    CRadioButton.Enabled = false;
                    FillRadioButton.Enabled = false;
                    blankTextBox.Enabled = false;

                  }
                  else if(Answers[i].ToString().Equals("A") || Answers[i].ToString().Equals("B")
                    || Answers[i].ToString().Equals("C"))
                  {
                    AnswerTrueRadioButton.Enabled = false;
                    AnswerFalseRadioButton.Enabled = false;
                    ARadioButton.Enabled = true;
                    BRadioButton.Enabled = true;
                    CRadioButton.Enabled = true;
                    FillRadioButton.Enabled = false;
                    blankTextBox.Enabled = false;
                  }
                 else if(!Answers[i].ToString().Equals("True") && !Answers[i].ToString().Equals("False")
                    && !Answers[i].ToString().Equals("A") && !Answers[i].ToString().Equals("B") 
                    && !Answers[i].ToString().Equals("C"))
                  {
                    AnswerTrueRadioButton.Enabled = false;
                    AnswerFalseRadioButton.Enabled = false;
                    ARadioButton.Enabled = false;
                    BRadioButton.Enabled = false;
                    CRadioButton.Enabled = false;
                    FillRadioButton.Enabled = true;
                    blankTextBox.Enabled = true;
                  }
            } // end for

        } // end TakeTestButton

        //each time submit is clicked, it will display the next quesiton until all questions have been answered. It will 
        // also store each answer in the answer list.
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            
            try
            {


                if (Convert.ToInt32(NumComboBox.Text) >= Number.Count)
                {
                    throw new Exception("End of Questions");
                    
                    
                }
                
                for (int i = Convert.ToInt32(NumComboBox.Text); i < Number.Count ; i++)
                {


                    NumComboBox.Text = Number[i].ToString();
                    QuestionRTextBox.Text = Questions[i].ToString();
                    if (Answers[i].ToString().Equals("True") || Answers[i].ToString().Equals("False"))
                    {
                        AnswerTrueRadioButton.Enabled = true;
                        AnswerFalseRadioButton.Enabled = true;
                        ARadioButton.Enabled = false;
                        BRadioButton.Enabled = false;
                        CRadioButton.Enabled = false;
                        FillRadioButton.Enabled = false;
                        blankTextBox.Enabled = false;

                    }
                    else if (Answers[i].ToString().Equals("A") || Answers[i].ToString().Equals("B")
                      || Answers[i].ToString().Equals("C"))
                    {
                        AnswerTrueRadioButton.Enabled = false;
                        AnswerFalseRadioButton.Enabled = false;
                        ARadioButton.Enabled = true;
                        BRadioButton.Enabled = true;
                        CRadioButton.Enabled = true;
                        FillRadioButton.Enabled = false;
                        blankTextBox.Enabled = false;
                    }
                    else if (!Answers[i].ToString().Equals("True") && !Answers[i].ToString().Equals("False")
                       && !Answers[i].ToString().Equals("A") && !Answers[i].ToString().Equals("B")
                       && !Answers[i].ToString().Equals("C"))
                    {
                        AnswerTrueRadioButton.Enabled = false;
                        AnswerFalseRadioButton.Enabled = false;
                        ARadioButton.Enabled = false;
                        BRadioButton.Enabled = false;
                        CRadioButton.Enabled = false;
                        FillRadioButton.Enabled = true;
                        blankTextBox.Enabled = true;
                    }
                    break;
                }
            }catch(Exception s)
            {
                MessageBox.Show(s.Message);
                MainPanel.Controls.Clear();
                MainPanel.Controls.Add(buttonPanel);
                ResultsButton.Enabled = true;
                MainPanel.Controls.Add(instLabel);
                instLabel.Text = "Click Results to view current test results. Click Exit to exit the program.";
            }
            if (AnswerTrueRadioButton.Checked == true)
            {
                StudentAnswer.Add("True");
            }
            else if (AnswerFalseRadioButton.Checked == true)
            {
                StudentAnswer.Add("False");
            }
            else if (ARadioButton.Checked == true)
            {
                StudentAnswer.Add("A");
            }
            else if (BRadioButton.Checked == true)
            {
                StudentAnswer.Add("B");
            }
            else if (CRadioButton.Checked == true)
            {
                StudentAnswer.Add("C");
            }
            else if (blankTextBox.Enabled == true)
            {
                StudentAnswer.Add(blankTextBox.Text.ToLower());
            }

            AnswerTrueRadioButton.Checked = false;
            AnswerFalseRadioButton.Checked = false;
            ARadioButton.Checked = false;
            BRadioButton.Checked = false;
            CRadioButton.Checked = false;
            blankTextBox.Text = "";
            
        } // End SubmitButton
          //***********************************************************************************************************************
        
        // this method calculates the total correct questions and adds the results to the summary pages. 
        public void Total()
        {
            double percent;
            int ctr = 0;

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(buttonPanel);
            MainPanel.Controls.Add(groupBoxOne);
            groupBoxOne.Controls.Remove(TypeGroupBox);
            groupBoxOne.Controls.Remove(AdminNameLabel);
            groupBoxOne.Controls.Remove(AdminNameTextBox);
            groupBoxOne.Controls.Remove(AdminPasswordLabel);
            groupBoxOne.Controls.Remove(AdminPasswordTextBox);
            groupBoxOne.Controls.Remove(IDLabel);
            groupBoxOne.Controls.Remove(IDTextBox);
            groupBoxOne.Controls.Remove(StudentLogButton);
            groupBoxOne.Controls.Add(AnswerListBox);
           // groupBoxOne.Controls.Add(AverageListBox);

            groupBoxOne.Controls.Add(EnterQuestionPanel);
            EnterQuestionPanel.Controls.Remove(questionGroupBox);
            EnterQuestionPanel.Controls.Remove(TFRadioButtonGroupBox);
            EnterQuestionPanel.Controls.Add(AverageListBox);
            AverageListBox.Visible = true;

            AnswerListBox.Visible = true;


            MainPanel.Controls.Add(instLabel);
            instLabel.Text = "Click Take Test button to take test again. Click Exit to end Program. ";
            MainPanel.Controls.Add(titlePanel);

            //total the correct answers by matching student answer to the stored answer
            for (int i=0; i<Answers.Count && i<StudentAnswer.Count; i++)
            {
                if (Answers[i].ToString().Equals(StudentAnswer[i].ToString()))
                {
                    ctr++;
                }

                //AnswerListBox.Items.Add(Answers[i].ToString());
                //AnswerListBox.Items.Add(StudentAnswer[i].ToString());
            }

            // print results into the summary (AnswerListBox)
            for(int i=0; i<Answers.Count && i<StudentAnswer.Count && i<Questions.Count && i<Number.Count; i++)
            {
                
                AnswerListBox.Items.Add("Question "+Number[i].ToString());
                AnswerListBox.Items.Add(Questions[i].ToString());
                AnswerListBox.Items.Add("Student Answer: " + StudentAnswer[i].ToString());
                AnswerListBox.Items.Add("Correct Answer: " + Answers[i].ToString());
                if (Answers[i].ToString().Equals(StudentAnswer[i].ToString()))
                {
                    AnswerListBox.Items.Add("\t\t\t+1");
                }
                else
                {
                    AnswerListBox.Items.Add("\t\t\t+0");
                }
                AnswerListBox.Items.Add("----------------------------------------------");
            }
            AnswerListBox.Items.Add("\t\t\tTotal Points: " + ctr + "/"+Number.Count);
            percent = (double)ctr / Number.Count * 100;
            percent = System.Math.Round(percent);
            AnswerListBox.Items.Add("\t\t\t\t     "+percent+"%");
                MessageBox.Show("Number of correct quesitons: " + ctr);

            //Add score and percent to arraylists
            AllScores.Add(ctr);
            AllPercents.Add(percent);

        } // end Total
          //***********************************************************************************************************************

        // This button displays the summary list boxes(AnswerListBox and AverageListBox)
        private void ResultsButton_Click(object sender, EventArgs e)
        {
            //groupBoxOne.Controls.Add(EnterQuestionPanel);
            ResultsButton.Enabled = false;


            Total();
            qd = true; //flag is set for quick results button to be enabled


            //create Averages and display into AverageListBox
            double total = 0;

            for (int i = 0; i < AllScores.Count; i++)
            {
                total += AllScores[i];
            }
            AverageListBox.Items.Clear();
            AverageListBox.Items.Add("Number of students: " + StudentList.Count);
            AverageListBox.Items.Add("Number of questions on the test: " + Questions.Count);
            AverageListBox.Items.Add("Total correct points: " + Convert.ToString(total));
            double avg = System.Math.Round(total / StudentList.Count);         //not really sure what avg it is asking for

            AverageListBox.Items.Add("Average correct points: " + Convert.ToString(avg));
            AverageListBox.Items.Add(" ");
            AverageListBox.Items.Add(" ");

            AverageListBox.Items.Add("Student Names: ");
            for(int i=0; i<StudentNames.Count && i<AllPercents.Count;i++)
            {
                AverageListBox.Items.Add(StudentNames[i] + "-   Score: "+AllPercents[i]+ "%");
            }

            //groupBoxOne.Controls.Add(AverageListBox);
           // AverageListBox.Visible = true;

            
        } // end ResultsButton
          //***********************************************************************************************************************

        //This button allows the Student to Login, making sure the password and ID have been entered
        // as well as making sure the student has only taken the test one time.
        private void StudentLogButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(instLabel);
            instLabel.Text = "Select your answer and click submit. You will be notified when you have" +
                " reached the end.";


            String StudentName = AdminNameTextBox.Text;
            String StudentPassword = AdminPasswordTextBox.Text;
            String StudentID = IDTextBox.Text;

            Student Student = new Student(StudentName);

            try
            {
                if (StudentPassword.Equals(""))
                {
                    throw new Exception("You must enter your password");
                }
                else
                { 
                Student.StudentPassword = StudentPassword;
                }
                if (StudentID.Equals(""))
                {
                    throw new Exception("You must enter your ID");
                }
                else
                {
                    Student.StudentID = StudentID;
                }
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
            
            
               
            

                if (StudentNames.Contains(Student.StudentName))
                {
                    MessageBox.Show("Student already took test");
                }

               else if(!StudentPassword.Equals("") && !StudentID.Equals(""))
               {
                    //***trying to clear for each student here
                    StudentAnswer.Clear();
                    AnswerListBox.Items.Clear();

                    // Add the new student to the StudentList, StudentName list, and AnswerListBox for summary
                    StudentList.Add((Student)(Student));
                    StudentNames.Add(Student.StudentName);
                    AnswerListBox.Items.Add("Name: " + Student.StudentName);

                //    MessageBox.Show("Student added " + Student.StudentName);
               //     foreach (object s in StudentList)
               //     {
               //         MessageBox.Show(s.ToString());
               //     }


                    // Display test on screen
                    AdministerTestButton.Enabled = false;

                    groupBoxOne.Controls.Remove(AdminNameLabel);
                    groupBoxOne.Controls.Remove(AdminNameTextBox);
                    groupBoxOne.Controls.Remove(AdminPasswordLabel);
                    groupBoxOne.Controls.Remove(AdminPasswordTextBox);
                    groupBoxOne.Controls.Remove(StudentLogButton);
                    groupBoxOne.Controls.Remove(IDLabel);
                    groupBoxOne.Controls.Remove(IDTextBox);
                    groupBoxOne.Controls.Remove(AnswerListBox);
                    EnterQuestionPanel.Controls.Remove(AverageListBox);




                    MainPanel.Controls.Add(groupBoxOne);
                    groupBoxOne.Controls.Add(EnterQuestionPanel);
                    groupBoxOne.Controls.Remove(TypeGroupBox);
                    EnterQuestionPanel.Controls.Add(questionGroupBox);
                    EnterQuestionPanel.Controls.Add(TFRadioButtonGroupBox);



                    NumComboBox.Enabled = false;
                    TFRadioButtonGroupBox.Controls.Add(SubmitButton);
                    TFRadioButtonGroupBox.Controls.Remove(EnterButton);
                    TFRadioButtonGroupBox.Controls.Remove(DoneButton);

                }

        } // end StudentLogButton
          //***********************************************************************************************************************


        private void AverageScoresButton_Click(object sender, EventArgs e)
        {
            double total=0;

            for(int i=0; i<AllScores.Count;i++)
            {
                total += AllScores[i];
            }

            MessageBox.Show("Number of students: " + StudentList.Count);
            MessageBox.Show("Number of questions on the test: " + Questions.Count);
            MessageBox.Show("Total correct points: "+Convert.ToString(total));
            double avg = System.Math.Round(total*StudentList.Count / (Questions.Count*StudentList.Count)) ;         //not really sure what avg it is asking for
            MessageBox.Show("Average correct points: "+Convert.ToString(avg));
        }

        private void instLabel_Click(object sender, EventArgs e)
        {

        }

        private void AnswerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //this button allows you to view the stuends that have logged in
        private void ViewStudentInfo_Click(object sender, EventArgs e)
        {
            String display="";

            for (int i=0; i<StudentList.Count;i++)
            {
                display += StudentList[i].ToString();
            }
            MessageBox.Show(display);
        } 

        //this button allows you to view a quick average of all tests that bave been taken
        // including the names of students, their scores, and averages. Will only be available after the first
        // test has been graded.
        private void QuickAverageButton_Click(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < AllScores.Count; i++)
            {
                total += AllScores[i];
            }
            String QuickDisplay = "";
            QuickDisplay+=("Number of students: " + StudentList.Count);
            QuickDisplay+=("\nNumber of questions on the test: " + Questions.Count);
            QuickDisplay+=("\nTotal correct points: " + Convert.ToString(total));
            double avg = System.Math.Round(total / StudentList.Count);         //not really sure what avg it is asking for

            QuickDisplay+=("\nAverage correct points: " + Convert.ToString(avg));
            QuickDisplay+=("\n ");
            QuickDisplay+=("\n ");

            QuickDisplay+=("\nStudent Names: ");
            for (int i = 0; i < StudentNames.Count && i < AllPercents.Count; i++)
            {
                QuickDisplay+=("\n"+StudentNames[i] + "-   Score: " + AllPercents[i] + "%");
            }

            if (qd==false)
            {
                MessageBox.Show("No grades have been calculated yet!");
            }
            else
            {
                MessageBox.Show(QuickDisplay);
            }


        } // end QuickAverageButton

        private void TFPopupButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ex. Cats have four legs?");
        }

        private void MCPopupButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ex. How many eyes to cats have? A: 8 , B: 4 , C: 2 ");
        }

        private void TFPopUpLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ex. Cats have four legs?");
        }

        private void MCPopUpButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(" ex. How many eyes to cats have? A: 8 , B: 4 , C: 2 ");
        }

        private void FillPopUpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" ex. You will need to invest in multiple ________ rollers if you own a cat. ");
        }
    } // end Form class

    //*******************************************************************************************************

    public class Admin
    {


        public Admin(String name, String password)
        {
            this.Name = name;
            this.Password = password;
            MessageBox.Show("New Admin Created");
        } // end Constructor

        private String name;
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                value = name;
            }
        }
        

        private String password;
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length < 8)
                {
                    throw new Exception("Password must be 8 characters long.");
                }

                else if (!value.Any(c => char.IsLetter(c)))
                {
                    throw new Exception("Password must contain at least one letter.");
                }

                else if (!value.Any(c => char.IsNumber(c)))
                {
                    throw new Exception("Password must contain at least one number.");
                }
                else
                {
                    value = password;
                    
                }
            }
        
        
        } // end Password

    } // end admin
      //***********************************************************************************************************************


    public class Student
    {

        public Student(String StudentName)
        {
            this.StudentName = StudentName;
        }

        public Student(String StudentName, String StudentPassword, String StudentID)
        {
            this.StudentName = StudentName;
            this.StudentPassword = StudentPassword;
            this.StudentID = StudentID;
        }

        public String StudentName{get;set;}
        private String studentPassword;
        public String StudentPassword { get; set; }
        //{
        //    get
        //    {
        //        return studentPassword;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            throw new Exception("You must enter a password.");
        //        }
        //        else
        //        {
        //            value = studentPassword;
        //        }
        //    }
        //}
        private String studentID;
        public String StudentID { get; set; }
        //{
        //    get
        //    {
        //        return studentID;
        //    }
        //    set
        //    {
        //        if (value == "")
        //        {
        //            throw new Exception("You must enter your ID");
        //        }
        //        else
        //        {
        //            value = studentID;
        //        }
        //    }
        //}

        public override string ToString()
        {
            return ("Name: " + StudentName +" Password: "+StudentPassword+" ID: "+StudentID+"\n");
        }

    }// end class Student

} // end Namespace Final


