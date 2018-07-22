using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemGenerator
{

    public class ProblemFactory
    {

        public static IProblem GetArithmeticProblem<TNumber>(ArithmeticOperations op, int numberCount, int maxNumber, bool includeNegative)
        {
            Operation<TNumber> operation = OperationFactory.GetArithmeticOperation<TNumber>(op);
            return new ArithmeticProblem<TNumber>(operation, generateDecreasingRandomNumbers<TNumber>(numberCount, maxNumber, includeNegative));                      
        }

        private static IEnumerable<TNumber> generateDecreasingRandomNumbers<TNumber>(int count, int max, bool includeNegative)
        {
            var numbers = new List<object>();
            var gen = new Random();
            int newMax = max;
            for(int i=0; i < count; i++)
            {
                dynamic newNumber = 0; 
                
                if(typeof(TNumber) == typeof(int))
                {
                    newNumber = gen.Next(1, newMax);
                    if(includeNegative && gen.NextDouble() > 0.5)
                    {
                        newNumber = -1 * newNumber;
                    }
                }
                else if(typeof(TNumber) == typeof(double))
                {
                    newNumber = gen.NextDouble() * newMax;
                    if (includeNegative && gen.NextDouble() > 0.5)
                    {
                        newNumber = -1 * newNumber;
                    }
                }
                numbers.Add(newNumber);
                newMax = newNumber;
            }

            return numbers.Cast<TNumber>();
        } 
             
    }
}
