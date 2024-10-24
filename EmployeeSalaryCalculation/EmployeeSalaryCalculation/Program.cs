namespace EmployeeSalaryCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee a = new HourlyEmployee("Ravan","Bayramov",19,20,12);
            a.CalculateSalary();
        }
    }
}
