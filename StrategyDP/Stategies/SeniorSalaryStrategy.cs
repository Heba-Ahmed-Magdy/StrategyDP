using StrategyDP.Entities;

namespace StrategyDP.Stategies
{
    public class SeniorSalaryStrategy : ISalaryStrategy
    {
        public int GetSalary(Employee employee)
        {
            return employee.WorkingDayies * employee.DayCost * 2;
        }
    }
}
