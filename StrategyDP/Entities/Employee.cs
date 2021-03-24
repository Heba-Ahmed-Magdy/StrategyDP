using StrategyDP.Stategies;
using System;

namespace StrategyDP.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FNamed { get; set; }
        public string LNamed { get; set; }
        public JobTitles Title { get; set; }
        public int WorkingDayies { get; set; }
        public int DayCost { get; set; }

        private ISalaryStrategy isalaryStrategy;

        public int GetSalary()
        {
            #region MyRegion
            /*
             * The problem with this piece of code that mehod behaviour changes with the employee's title.
             * So if I add new title, I'll come to this method and add a way to calc his salary
             */

            //int Salary = 0;
            //if (Title == JobTitles.Junior)
            //{
            //    Salary = WorkingDayies * HoureCost;
            //}
            //if (Title == JobTitles.Senior)
            //{
            //    Salary = WorkingDayies * HoureCost * 2;
            //}
            //return Salary;

            #endregion

            if (!(Enum.IsDefined(typeof(JobTitles), Title) && WorkingDayies > 0 && DayCost > 0))
                return 0;
            if (isalaryStrategy == null)
                isalaryStrategy = SalaryStrategyBasedOnTitle.KeyValuePairs[Title];
            return isalaryStrategy.GetSalary(this);
        }
    }
}