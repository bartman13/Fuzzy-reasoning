using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyInference;

namespace ExpertSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<ExamResult> results = new List<ExamResult>
            {
                new ExamResult { ExamName = ExamName.MATHEMATICS, ExamLevel = ExamLevel.ADVANCED, Result = 90 },
                new ExamResult { ExamName = ExamName.COMPUTER_SCIENCE, ExamLevel = ExamLevel.ADVANCED, Result = 90 },
                new ExamResult { ExamName = ExamName.ENGLISH, ExamLevel = ExamLevel.ADVANCED, Result = 60 }
            };

            InferenceEngine engine = new InferenceEngine();

            InferenceResult result = engine.Run(results);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
