using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class InferenceResult
    {
        public List<(Fact, Chance)> Result { get; set; }

        public InferenceResult(List<(Fact, Chance)> _result)
        {
            Result = _result;
        }
    }
}
