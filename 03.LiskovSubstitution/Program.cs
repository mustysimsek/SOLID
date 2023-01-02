using System;

namespace _03.LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new PartTimeEmployee();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MyProperty { get; set; }
    }

    class PartTimeEmployee : Employee
    {
        public decimal DailyWage { get; set; }
    }
    class FullTimeEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
    }
}