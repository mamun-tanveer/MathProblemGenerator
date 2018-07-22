using System;
using System.Collections.Generic;

namespace MathProblemGenerator
{

    public class Operation<T>
    {
        public string Symbol { get; private set; }
        public Func<IEnumerable<T>, string> Operator { get; private set; }

        public bool IsNull
        {
            get
            {
                return (Operator == null);
            }
        }

        public Operation(string symbol, Func<IEnumerable<T>, string> func)
        {
            Symbol = symbol;
            Operator = func;
        }
    }
}
