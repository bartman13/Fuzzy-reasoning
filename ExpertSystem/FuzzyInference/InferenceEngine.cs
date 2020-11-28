using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class InferenceEngine
    {
        List<Rule> rules = new List<Rule>();

        public void Run(List<ExamResult> results)
        {
            List<FuzzifiedExamResult> fuzzifiedResults = Fuzzify(results);
        }

        public List<FuzzifiedExamResult> Fuzzify(List<ExamResult> results)
        {
            List<FuzzifiedExamResult> list = new List<FuzzifiedExamResult>();
            foreach (ExamResult result in results)
                list.Add(new FuzzifiedExamResult(result));
            return list;
        }
    }

    public class Rule
    {

    }
}
