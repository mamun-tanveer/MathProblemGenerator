using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProblemGenerator
{
    public interface IProblem
    {
        IEnumerable<string> Display();

        bool CheckAnswer(string answer);
    }
}
