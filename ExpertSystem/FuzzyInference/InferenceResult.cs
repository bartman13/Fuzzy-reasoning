using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class InferenceResult
    {
        List<(Fact, Chance)> Result { get; set; }
    }
}
