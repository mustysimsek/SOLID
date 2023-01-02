using System;

namespace _02.OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator calculator = new SalaryCalculator(new FullTimeEmployee());
            calculator.CalculateSalary();
            Console.WriteLine("Hello");
        }
    }
    interface IEmployee
    {
        void CalculateSalary();
    }

    class FullTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Full");
        }
    }

    class PartTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Part");
        }
    }

    class SalaryCalculator
    {
        //public void CalculateSalary(string employeeType)
        //{
        //    if (employeeType == "Full")
        //        new FullTimeEmployee().CalculateSalary();
        //    else
        //        new PartTimeEmployee().CalculateSalary();
        //}
        private readonly IEmployee employee;

        public SalaryCalculator(IEmployee employee)
        {
            this.employee = employee;
        }

        public void CalculateSalary()
        {
            this.employee.CalculateSalary();
        }
    }
}
