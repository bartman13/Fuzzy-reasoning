using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public class Database
    {
        private List<Fact> Facts;

        public Database()
        {
            Facts = new List<Fact>
            {
                new Fact("Informatyka",Colleges.PW.name,Colleges.PW.prestige,205,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1), 
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Informatyka",Colleges.UW.name,Colleges.UW.prestige,92,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Informatyka",Colleges.AGH.name,Colleges.AGH.prestige,950,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 1)
                    }),
                new Fact("Informatyka",Colleges.UJ.name,Colleges.UJ.prestige,99,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.COMPUTER_SCIENCE, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Matematyka",Colleges.PW.name,Colleges.PW.prestige,182,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Matematyka",Colleges.UW.name,Colleges.UW.prestige,82,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Matematyka",Colleges.AGH.name,Colleges.AGH.prestige,750,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 1)
                    }),
                new Fact("Matematyka",Colleges.UJ.name,Colleges.UJ.prestige,81,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Fizyka",Colleges.PW.name,Colleges.PW.prestige,132,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.PHYSICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Fizyka",Colleges.UW.name,Colleges.UW.prestige,66,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.PHYSICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Fizyka",Colleges.AGH.name,Colleges.AGH.prestige,650,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.PHYSICS, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 1)
                    }),
                new Fact("Fizyka",Colleges.UJ.name,Colleges.UJ.prestige,72,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.PHYSICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Chemia",Colleges.PW.name,Colleges.PW.prestige,114,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.CHEMISTRY, ExamLevel.ADVANCED, 1),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.25)
                    }),
                new Fact("Chemia",Colleges.UW.name,Colleges.UW.prestige,50,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.CHEMISTRY, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    }),
                new Fact("Chemia",Colleges.AGH.name,Colleges.AGH.prestige,350,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.CHEMISTRY, ExamLevel.ADVANCED, 5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 1)
                    }),
                new Fact("Chemia",Colleges.UJ.name,Colleges.UJ.prestige,62,new List<Course>() {
                    new Course(ExamName.MATHEMATICS, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.CHEMISTRY, ExamLevel.ADVANCED, 0.5),
                    new Course(ExamName.ENGLISH, ExamLevel.ADVANCED, 0.1)
                    })
            };
        }

        public void Create(Fact fact)
        {
            Facts.Add(fact);
        }

        public List<Fact> Read()
        {
            return Facts;
        }

        public void Update(Fact oldFact, Fact newFact)
        {
            Facts.Remove(oldFact);
            Facts.Add(newFact);
        }

        public void Delete (Fact fact)
        {
            Facts.Remove(fact);
        }
    }
}
