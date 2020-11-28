using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class Course
    {
        public ExamName ExamName { get; set; }

        public ExamLevel ExamLevel { get; set; }

        public double Multiplier { get; set; }

        public Course(ExamName examName, ExamLevel examLevel, double multiplier)
        {
            ExamName = examName;
            ExamLevel = examLevel;
            Multiplier = multiplier;
        }
    }
}
