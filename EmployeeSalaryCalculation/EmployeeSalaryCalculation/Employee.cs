using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryCalculation
{
    public abstract class Employee
    {
		public Employee(string name,string surname,int age) 
		{
			Name = name;
			Surname = surname;
			Age = age;
		}
		private static int Counter;
		private int _id;

		public int Id { get ; }
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}
		private string _surname;

		public string Surname
		{
			get { return _surname; }
			set { _surname = value; }
		}
		private int _age;

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}
		public abstract double CalculateSalary();
        public abstract void DisplayDetails();
    }
}
