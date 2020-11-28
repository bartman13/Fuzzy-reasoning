using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class Database
    {
        public List<Fact> Facts { get; set; }

        public Database()
        {
            Facts = new List<Fact>
            {
                new Fact("Informatyka",Colleges.PW.name,Colleges.PW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1), 
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Informatyka",Colleges.UW.name,Colleges.UW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Informatyka",Colleges.AGH.name,Colleges.AGH.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Informatyka",Colleges.UJ.name,Colleges.UJ.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Matematyka",Colleges.PW.name,Colleges.PW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Matematyka",Colleges.UW.name,Colleges.UW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Matematyka",Colleges.AGH.name,Colleges.AGH.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Matematyka",Colleges.UJ.name,Colleges.UJ.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Fizyka",Colleges.PW.name,Colleges.PW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Fizyka",Colleges.UW.name,Colleges.UW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Fizyka",Colleges.AGH.name,Colleges.AGH.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Fizyka",Colleges.UJ.name,Colleges.UJ.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Chemia",Colleges.PW.name,Colleges.PW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Chemia",Colleges.UW.name,Colleges.UW.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Chemia",Colleges.AGH.name,Colleges.AGH.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Chemia",Colleges.UJ.name,Colleges.UJ.prestige,193,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    })
            };
        }
    }
}
