using DesignPattern;
using System;
using System.Threading;
using TemplateDesignPattern;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region Simple Factory design pattern

            //Console.ForegroundColor = ConsoleColor.Green;
            //ICustomer customer = SimpleFactory.Create(0);
            //customer.CalculateBill();

            //#endregion

            #region Factory design pattern
            ConsoleColorMethod("Factory design pattern");


            IFactory factory = CreateFactory.GetObject(ObjectType.Customer);
            Console.WriteLine("Get customer object : " + factory.getName());

            factory = CreateFactory.GetObject(ObjectType.Supplier);
            Console.WriteLine("Get supplier object : " + factory.getName());

            #endregion

            #region Template design pattern
            ConsoleColorMethod("Template design pattern");

            TemplateHiringProcess hiringProcess = new CSDepartment();

            Console.WriteLine("*** Hiring CS students");
            hiringProcess.HireFreshers();

            Console.WriteLine(Environment.NewLine);

            hiringProcess = new EEEDepartment();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Hiring EEE students");
            hiringProcess.HireFreshers();

            #endregion

            #region Singleton Design Pattern
            ConsoleColorMethod("Singleton design pattern");

            SingletonDesignPattern s1 = SingletonDesignPattern.getInstance();
            SingletonDesignPattern s2 = SingletonDesignPattern.getInstance();

            s1.myMethod();

            // Test for same instance
            //if (s1 == s2)
            //{
            //    Console.WriteLine("Objects are the same instance");
            //}

            #endregion

            #region Repository Design Pattern

            ConsoleColorMethod("Repository design pattern");

            //IRepoContext<CustomerRepository> repoContext = new DAL<CustomerRepository>();
            //repoContext.Add(new CustomerRepository());
            //repoContext.Save();

            //IRepoContext<SupplierRepository> repoContext1 = new DAL<SupplierRepository>();
            //repoContext1.Add(new SupplierRepository());
            //repoContext1.Save();

            //IRepoContext<CustomerRepository> repoContext = new DALCustomerRepo();
            //repoContext.Add(new CustomerRepository());
            //repoContext.Save();


            IRepoContext<CustomerRepository> repoContext = FactoryRepository<CustomerRepository>.Create();
            repoContext.Add(new CustomerRepository());
            repoContext.Save();

            #endregion

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ConsoleColorMethod(string designPattern)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine + designPattern + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
