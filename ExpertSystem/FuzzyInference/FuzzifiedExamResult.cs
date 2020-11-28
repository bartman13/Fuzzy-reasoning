using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class FuzzifiedExamResult
    {
        public ExamName ExamName { get; set; }
        public ExamLevel ExamLevel { get; set; }

        public double Low { get; set; }
        public double Average { get; set; }
        public double High { get; set; }

        public FuzzifiedExamResult(ExamResult x)
        {
            int percentage = x.Result;
            Average = 1 - Math.Abs(75 - percentage)/35;
            if (percentage > 50)
                High = 1 - Math.Abs(100 - percentage) / 50;
            else
                High = 0;
            if (percentage < 80)
                Low = 1 - (percentage - 30) / 50;
            else
                Low = 0;
            ExamName = x.ExamName;
            ExamLevel = x.ExamLevel;
        }

    }
}
