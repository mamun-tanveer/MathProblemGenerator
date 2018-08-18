using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathProblemGenerator;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        private IProblem _CurrentProblem;
        private System.Diagnostics.Stopwatch _Timer = new System.Diagnostics.Stopwatch(); 


        public Form1()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            bool continueFlag = false;

            //check the current problem
            if (_CurrentProblem == null) continueFlag = true;
            else 
            {
                string answer = AnswerBox.Text;
                if (answer.StartsWith("test"))
                {
                    displayNextProblem();
                    AnswerBox.Text = "test = " + ((ITestProblem)_CurrentProblem).GetExpectedAnswer(); 
                    
                }
                else if(_CurrentProblem.CheckAnswer(answer))
                {
                    
                    continueFlag = true;
                    TimeValueLabel.Text = _Timer.Elapsed.ToString();
                    logCorrect();
                }
                else
                {
                    continueFlag = false;
                    TimeValueLabel.Text = "WRONG";                    
                }
            }

            if(continueFlag)
            {
                displayNextProblem();
            }
            
        }

        private void displayNextProblem()
        {
            //get the next problem
            _CurrentProblem = ProblemFactory.GetArithmeticProblem<int>(getNextOperation(), 2, 20, false);
            string[] lines = _CurrentProblem.Display().ToArray();
            if (lines.Length > 0) lines[0] = lines.First().Remove(0, 1); //remove the first symbol
            ProblemBox.Lines = lines;
            AnswerBox.Text = string.Empty;
            AnswerBox.Focus();
            _Timer.Restart();
        }

        private ArithmeticOperations getNextOperation()
        {
            ArithmeticOperations returnValue = default(ArithmeticOperations);
            if(OpListBox.CheckedIndices.Count == 0)
            {
                OpListBox.SetItemChecked(0, true);
            }

            int randomIndex = DateTime.Now.Millisecond % OpListBox.CheckedIndices.Count;
            int i = 0; 
            foreach(string item in OpListBox.CheckedItems)
            {
                if (i == randomIndex)
                { 
                    returnValue = (ArithmeticOperations) Enum.Parse(typeof(ArithmeticOperations), item);
                }
                i++;
            }

            return returnValue;
        } 

        private void logCorrect()
        {
            int correctCount = Properties.Settings.Default.CorrectCount;
            DateTime lastRun = Properties.Settings.Default.LastRunDate; 
            if(DateTime.Now.Day - lastRun.Day > 0)
            {
                //new day
                correctCount = 1;
                lastRun = DateTime.Now;
            }
            else
            {
                correctCount++;
            }

            Properties.Settings.Default.CorrectCount = correctCount;
            Properties.Settings.Default.LastRunDate = lastRun;

            AnswerCountBox.Text = correctCount.ToString();                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayNextProblem();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
