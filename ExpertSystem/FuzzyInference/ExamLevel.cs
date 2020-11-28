using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public enum ExamLevel
    {
        [EnumMember(Value = "Basic")]
        BASIC, 
        [EnumMember(Value = "Advanced")]
        ADVANCED
    }
}
