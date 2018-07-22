using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemGenerator
{
    internal class ArithmeticProblem<TNumber> : IProblem, ITestProblem
    {
        private IEnumerable<Tuple<TNumber, Operation<TNumber>>> _Lines;

        public ArithmeticProblem(Operation<TNumber> op, IEnumerable<TNumber> numbers)
        {
            _Lines = numbers.Select(x => new Tuple<TNumber, Operation<TNumber>>(x, op));
        }

        public ArithmeticProblem(IEnumerable<Tuple<TNumber, Operation<TNumber>>> pairs)
        {
            _Lines = pairs;
        }

        public IEnumerable<string> Display()
        {
            return _Lines.Select(x => (x.Item2.Symbol + "\t" + x.Item1.ToString()));
        }

        public bool CheckAnswer(string answer)
        {         
            return compareStrings(answer, GetExpectedAnswer());
        }

        public string GetExpectedAnswer()
        {
            bool firstLine = true;
            TNumber runningAnswer = default(TNumber);
            string expectedAnswer = null;

            foreach (var line in _Lines)
            {
                if (firstLine)
                {
                    //don't do anything for the first line    
                    runningAnswer = line.Item1;
                    firstLine = false;
                }
                else
                {

                    TNumber number = line.Item1;
                    Operation<TNumber> op = line.Item2;
                    IEnumerable<TNumber> args = new TNumber[] { runningAnswer, number };
                    expectedAnswer = op.Operator(args);
                    runningAnswer = getParser()(expectedAnswer);
                }
            }

            return expectedAnswer;
        }


    private bool compareStrings(string answer, string expectedAnswer)
        {
            if (string.IsNullOrEmpty(answer) || string.IsNullOrEmpty(expectedAnswer))  return false;

            return (answer.Trim().ToLower() == expectedAnswer.Trim().ToLower());
        }


        private static Func<string, TNumber> getParser()
        {
            if (typeof(TNumber) == typeof(int)) return (x => (TNumber)(object)int.Parse(x));
            else if (typeof(TNumber) == typeof(long)) return (x => (TNumber)(object)int.Parse(x));
            else if (typeof(TNumber) == typeof(double)) return (x => (TNumber)(object)double.Parse(x));
            else if (typeof(TNumber) == typeof(float)) return (x => (TNumber)(object)float.Parse(x));
            else throw new ArgumentOutOfRangeException("TNumber", typeof(TNumber), "Invalid Type");

        }
    }
}
