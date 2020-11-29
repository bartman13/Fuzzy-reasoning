using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FuzzyInference
{
    public enum Chance
    {
        [EnumMember(Value = "IMPOSSIBLE")]
        IMPOSSIBLE,
        [EnumMember(Value = "UNLIKELY")]
        UNLIKELY,
        [EnumMember(Value = "LESS_LIKELY")]
        LESS_LIKELY,
        [EnumMember(Value = "LESS_LIKELY")]
        MAYBE,
        [EnumMember(Value = "LESS_LIKELY")]
        LIKELY,
        [EnumMember(Value = "VERY_LIKELY")]
        VERY_LIKELY,
        [EnumMember(Value = "CERTAIN")]
        CERTAIN
    }
}
