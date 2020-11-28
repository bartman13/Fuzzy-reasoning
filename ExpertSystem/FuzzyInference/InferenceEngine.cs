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

        public InferenceResult Run(List<ExamResult> results)
        {
            Database db = new Database();

            List<Fact> matchedFacts = db.Read().Where(x =>
            {
                foreach (Course c in x.Courses)
                    if (results.Where(y => y.ExamName == c.ExamName && y.ExamLevel == c.ExamLevel).Count() == 0)
                        return false;
                return true;
            }).ToList();

            List<FuzzifiedExamResult> fuzzifiedResults = Fuzzify(results);

            InferenceResult resultList = Infer(fuzzifiedResults, matchedFacts);

            return resultList;
        }

        public List<FuzzifiedExamResult> Fuzzify(List<ExamResult> results)
        {
            List<FuzzifiedExamResult> list = new List<FuzzifiedExamResult>();
            foreach (ExamResult result in results)
                list.Add(new FuzzifiedExamResult(result));
            return list;
        }

        public InferenceResult Infer(List<FuzzifiedExamResult> results, List<Fact> facts)
        {
            List<(Fact, Chance)> eligibleCoursesList = new List<(Fact, Chance)>();
            List<Rule> rules = RuleSet.GetRules();

            foreach(Fact f in facts)
            {
                ExamsGrade examsGrade = EvaluateExams(f, results);
                foreach(Rule rule in rules)
                {
                    if (rule.grade == examsGrade && rule.prestige == CalculatePrestige(f.Prestige))
                    {
                        (Fact, Chance) entry = (f, rule.outcome);
                        eligibleCoursesList.Add(entry);
                    } 
                }
            }

            return new InferenceResult(eligibleCoursesList);
        }

        public ExamsGrade EvaluateExams(Fact fact, List<FuzzifiedExamResult> examsResults)
        {

        }

        public CollegePrestige CalculatePrestige(double prestige)
        {
            if (prestige > 80)
                return CollegePrestige.Prestigious;
            else
                return CollegePrestige.Regular;
        }

        public List<Rule> ActivateRules(List<FuzzifiedExamResult> examResults)
        {
            return new List<Rule>();
        }
    }

    public static class RuleSet
    {
        public static List<Rule> GetRules()
        {
           return new List<Rule>
            {
                new Rule {grade = ExamsGrade.Low, prestige = CollegePrestige.Regular, outcome = Chance.UNLIKELY},
                new Rule {grade = ExamsGrade.Low, prestige = CollegePrestige.Prestigious, outcome = Chance.IMPOSSIBLE},
                new Rule {grade = ExamsGrade.Average, prestige = CollegePrestige.Regular, outcome = Chance.MAYBE},
                new Rule {grade = ExamsGrade.Average, prestige = CollegePrestige.Prestigious, outcome = Chance.LESS_LIKELY},
                new Rule {grade = ExamsGrade.High, prestige = CollegePrestige.Regular, outcome = Chance.CERTAIN},
                new Rule {grade = ExamsGrade.High, prestige = CollegePrestige.Prestigious, outcome = Chance.LIKELY}
            };
        }
    }

    public class Rule
    {
        public ExamsGrade grade { get; set; }
        public CollegePrestige prestige { get; set; }
        public Chance outcome { get; set; }
    }

}
