using StrategyDP.Entities;

namespace StrategyDP.Stategies
{
    public class JuniorSalaryStrategy : ISalaryStrategy
    {
        public int GetSalary(Employee employee)
        {
            return employee.WorkingDayies * employee.DayCost;
        }
    }
}
