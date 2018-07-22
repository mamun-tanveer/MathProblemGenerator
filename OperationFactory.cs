using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemGenerator
{
    public enum ArithmeticOperations
    {
        PLUS = 0, 
        MINUS = 1,
        TIMES = 2, 
        DIVIDE = 3
    }

    public class OperationFactory
    {
        public static Operation<TNumber> GetArithmeticOperation<TNumber>(ArithmeticOperations opType)
        {
            Operation<TNumber> returnOp = null;
            switch (opType)
            {
                case ArithmeticOperations.PLUS:
                    returnOp = new Operation<TNumber>("+", addition<TNumber>);
                    break;
                case ArithmeticOperations.MINUS:
                    returnOp = new Operation<TNumber>("-", subtraction<TNumber>);
                    break;
                case ArithmeticOperations.TIMES:
                    returnOp = new Operation<TNumber>("X", multiplication<TNumber>);
                    break;
                case ArithmeticOperations.DIVIDE:
                    returnOp = new Operation<TNumber>("÷", division<TNumber>);
                    break;
                default:
                    throw new NotSupportedException("Operation not supported");               
            }
            return returnOp;
        }

        private static string addition<TNumber>(IEnumerable<TNumber> numbers)
        {
            dynamic answer = default(TNumber); 
            foreach(var number in numbers)
            {
                answer = answer + number;
            }

            return answer.ToString();
        }

        private static string subtraction<TNumber>(IEnumerable<TNumber> numbers)
        {
            bool firstNumber = true;
            dynamic answer = default(TNumber);
            foreach (var number in numbers)
            {
                if (firstNumber) answer = number;
                else answer = answer - number;
                firstNumber = false;
            }

            return answer.ToString();
        }

        private static string multiplication<TNumber>(IEnumerable<TNumber> numbers)
        {
            bool firstNumber = true;
            dynamic answer = default(TNumber);
            foreach (var number in numbers)
            {
                if (firstNumber) answer = number;
                else answer = answer * number;
                firstNumber = false;
            }

            return answer.ToString();
        }

        private static string division<TNumber>(IEnumerable<TNumber> numbers)
        {
            bool firstNumber = true;
            dynamic answer = default(TNumber);
            foreach (var number in numbers)
            {
                if (firstNumber) answer = number;
                else answer = answer / number;
                firstNumber = false;
            }

            return answer.ToString();
        }

    }
}
