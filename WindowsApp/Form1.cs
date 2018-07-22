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
            _CurrentProblem = ProblemFactory.GetArithmeticProblem<int>(ArithmeticOperations.MINUS, 2, 100, false);
            string[] lines = _CurrentProblem.Display().ToArray();
            if (lines.Length > 0) lines[0] = lines.First().Remove(0, 1); //remove the first symbol
            ProblemBox.Lines = lines;
            AnswerBox.Text = string.Empty;
            _Timer.Restart();
        }
    }
}
