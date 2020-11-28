using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class Fact
    {
        public string CourseName {get; set;}
        public string CollegeName { get; set; }
        public double Prestige { get; set; }
        public int LastLimit { get; set; }
        public List<Course> Courses { get; set; }

        public Fact(string courseName, string collegeName, double prestige, int lastLimit, List<Course> courses)
        {
            CourseName = courseName;
            CollegeName = collegeName;
            Prestige = prestige;
            LastLimit = lastLimit;
            Courses = courses;
        }
    }
}
