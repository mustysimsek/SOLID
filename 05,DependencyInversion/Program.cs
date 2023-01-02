using System;
using System.ComponentModel.Design;

namespace _05.DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeIndex();
            CategoryIndex();
            CategoryIndex2();
        }

        static void HomeIndex()
        {
            //CategoryRepositoryEf ef = new CategoryRepositoryEf();
            //ef.GetCategories();

            Container container = new Container();
            container.GetInstance().GetCategories();
        }

        static void CategoryIndex()
        {
            //CategoryRepositoryEf ef = new CategoryRepositoryEf();
            //ef.GetCategories();

            Container container = new Container();
            container.GetInstance().GetCategories();
        }

        static void CategoryIndex2()
        {
            //CategoryRepositoryEf ef = new CategoryRepositoryEf();
            //ef.GetCategories();

            Container container = new Container();
            container.GetInstance().GetCategories();
        }
    }

    class Container
    {
        public ICategoryRepository GetInstance()
        {
            return new CategoryRepositoryDp();
        }
    }

    interface ICategoryRepository
    {
        void GetCategories();
    }

    class CategoryRepositoryEf : ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("Ef");
        }
    }

    class CategoryRepositoryDp : ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("Dp");
        }
    }
}