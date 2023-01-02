using System;

namespace _04.InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
    }

    public interface IRepository
    {
        void Add();
        
        
    }

    public interface ICategoryRepository : IRepository
    {
        void GetCategories();
    }
    public interface IProductRepository : IRepository
    {
        void GetProduct();
    }

    public class CategoryRepositoyry : ICategoryRepository
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void GetCategories()
        {
            Console.WriteLine("List of Categories");
        }
    }
    public class ProductRepository : IProductRepository
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public void GetProduct()
        {
            Console.WriteLine("List of Products");
        }
    }
}