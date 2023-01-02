using System;

namespace _01.SingleResponsibility

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    //Single Responsibility
    class Customer
    {
        public string Name { get; set; }
        //public bool ValidateName(string name)
        //{
        //    return !string.IsNullOrEmpty(name);
        //}
        //public void SayHello(string name)
        //{
        //    Console.WriteLine("Hello "+name);
        //}
    }

    class CustomerManager
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

    }

    class CustomerValidator
    {
        public bool ValidateName(string name)
        {
            return !string.IsNullOrEmpty(name);
        }
    }
}