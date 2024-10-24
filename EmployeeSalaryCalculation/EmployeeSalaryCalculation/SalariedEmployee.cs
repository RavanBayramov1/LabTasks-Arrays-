using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public class SalariedEmployee : Employee
    {
        public double MonthlySalary;

        public SalariedEmployee(string name, string surname, int age, double monthlySalary) : base(name, surname, age)
        {
            MonthlySalary = monthlySalary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;   
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"{Name} {Surname} {Age} {MonthlySalary}");
        }
    }
}
