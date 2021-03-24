using StrategyDP.Entities;
using System;

namespace StrategyDP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jEmp = new Employee { FNamed = "Ahmed", Title = JobTitles.Junior, WorkingDayies = 24, DayCost = 50 };
            var sEmp = new Employee { FNamed = "Ahmed2", Title = JobTitles.Senior, WorkingDayies = 24, DayCost = 50 };
            Console.WriteLine($"Salary for junior Emp * {jEmp.GetSalary()}");
            Console.WriteLine($"Salary for senior Emp * {sEmp.GetSalary()}");
        }
    }
}
