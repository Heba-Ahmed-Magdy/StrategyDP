using StrategyDP.Stategies;
using System.Collections.Generic;

namespace StrategyDP.Entities
{
    public static class SalaryStrategyBasedOnTitle
    {

        private static readonly Dictionary<JobTitles, ISalaryStrategy> keyValuePairs = new Dictionary<JobTitles, ISalaryStrategy>
        {
            { JobTitles.Junior, new JuniorSalaryStrategy()},
            { JobTitles.Senior, new SeniorSalaryStrategy()}
        };

        public static Dictionary<JobTitles, ISalaryStrategy> KeyValuePairs { get => keyValuePairs; }
    }
}
