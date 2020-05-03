//using AdapterDesignPattern;
//using BuilderDesignPattern;
//using FactoryDesignPattern;
//using DecoratorDesignPattern;
//using PrototypeDesignPattern;
//using MementoDesignPattern;
//using AggregateRootDesignPattern;
//using IteratorDesignPattern;
using ReplaceIfPolymorphismDesignPattern;
using RepositoryDesignPattern;
using SingletonDesignPattern;
using System;
using TemplateDesignPattern;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




            //#region Factory design pattern
            //ConsoleColorMethod("Factory design pattern");


            //IFactory factory = CreateFactory.GetObject(ObjectType.Customer);
            //Console.WriteLine("Get customer object : " + factory.getName());

            //factory = CreateFactory.GetObject(ObjectType.Supplier);
            //Console.WriteLine("Get supplier object : " + factory.getName());
            //#endregion


            //#region Adapter design pattern
            //IExport target = new PDF_Class();
            //target.Export();

            //target = new XLS_Class_ObjectAdapter();
            //target.Export();

            //target = new XLS_Class_ClassAdapter();
            //target.Export();
            //#endregion

            //#region Builder design pattern

            //// Client Code

            //ReportDirector reportDirector = new ReportDirector();

            //ExcelReport excelReport = new ExcelReport();
            //Report report = reportDirector.MakeReport(excelReport);
            ////report.DisplayReport();

            //#endregion

            //#region Decorator design pattern
            ////Component component = new ConcreteDecoratorA(new ConcreteDecoratorB(new ConcreteComponent()));
            ////component.Operation();

            //IWedding wedding = new Jewellery(new Orchestra((new TraditionalWedding())));
            //Console.WriteLine(wedding.Title());
            //Console.WriteLine("Budget:" + wedding.Budget());
            //Console.ReadLine();

            //#endregion

            //#region Prototype Design Pattern

            //Employee emp1 = new Employee();
            //emp1.Name = "Amit Naik";
            //emp1.Department = "IT";
            //Employee emp2 = emp1.GetClone();
            //emp2.Name = "Shwetha";

            //Console.WriteLine("Emplpyee 1: ");
            //Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            //Console.WriteLine("Emplpyee 2: ");
            //Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);


            //#endregion


            //#region Memento Design Pattern

            //Employee emp1 = new Employee();
            //emp1.Name = "Amit Naik";
            //emp1.Department = "IT";
            //Employee emp2 = emp1.GetClone();
            //emp2.Name = "Shwetha";



            //Console.WriteLine("Emplpyee 1: ");
            //Console.WriteLine("Name: " + emp1.Name + ", Department: " + emp1.Department);
            ////Console.WriteLine("Emplpyee 2: ");
            ////Console.WriteLine("Name: " + emp2.Name + ", Department: " + emp2.Department);

            //Employee emp3 = emp1.Revert();
            //Console.WriteLine("Reverting ");
            //Console.WriteLine("Name: " + emp3.Name + ", Department: " + emp3.Department);

            //#endregion


            //#region Aggregate root design pattern

            //Customer customer = new Customer();

            //customer.Add(new Address { Type = 1 });
            //customer.Add(new Address { Type = 1 });

            //#endregion


            //#region Iterator design pattern

            //Customer customer = new Customer();

            //customer.Add(new Address { Type = 1 });
            //customer.Add(new Address { Type = 2 });

            //// we can avoid manipulating methods like below in Iterator design pattern
            ////customer.addresses.Add(new Address { Type = 3 });


            //// Implementing via Ienumerable 
            //foreach (var item in customer.GetAddresses())
            //{
            //    Console.WriteLine($"customer address type  : {item.Type}");
            //}

            //// Implementing via IEnumerator
            //foreach (var item in customer)
            //{
            //    Console.WriteLine($"customer address type  : {item.Type}");

            //}
            ////var x = customer.GetEnumerator();


            //#endregion


            #region Repository Design Pattern


            ConsoleColorMethod("Repository design pattern");



            // repository design pattern (customer class)
            //IRepoContext<CustomerRepository> repoContext = new DAL<CustomerRepository>();
            //repoContext.Add(new CustomerRepository());
            //repoContext.Save();

            // repository design pattern (supplier class)
            //IRepoContext<SupplierRepository> repoContext1 = new DAL<SupplierRepository>();
            //repoContext1.Add(new SupplierRepository());
            //repoContext1.Save();

            // repository design pattern with template design pattern
            //IRepoContext<CustomerRepository> repoContext = new DALCustomerRepo();
            //repoContext.Add(new CustomerRepository());
            //repoContext.Save();

            // repository design pattern with factory and template design pattern
            IRepoContext<CustomerRepository> repoContext = FactoryRepository<CustomerRepository>.Create();
            repoContext.Add(new CustomerRepository());
            repoContext.Save();

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

            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            s1.myMethod();

            // Test for same instance
            //if (s1 == s2)
            //{
            //    Console.WriteLine("Objects are the same instance");
            //}

            #endregion

            #region Replace IF with Polyphormism

            Console.WriteLine("Enter your skill set for job opening (like JavaScript,c#,Net)");

            //string knowledge = Console.ReadLine();
            string knowledge = "javascript";

            Console.WriteLine(SimpleFactoryRIP.Create(knowledge.ToLower()));
            #endregion

        }


        static void ConsoleColorMethod(string designPattern)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine + designPattern + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}
