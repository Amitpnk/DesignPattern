//using AdapterDesignPattern;
//using BuilderDesignPattern;
//using FactoryDesignPattern;
//using DecoratorDesignPattern;
//using PrototypeDesignPattern;
//using MementoDesignPattern;
//using AggregateRootDesignPattern;
//using IteratorDesignPattern;
using AbstractFactoryDesignPattern;
using BridgeDesignPattern;
using CompositeDesignPattern;
using FacadeDesignPattern;
using IOC_DI_Unity;
using LazyLoading;
using ReplaceIfPolymorphismDesignPattern;
using RepositoryDesignPattern;
using SingletonDesignPattern;
using System;
using TemplateDesignPattern;
using Unity;
using UOWDesignPattern;

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


            #region Generic Repository Design Pattern


            ConsoleColorMethod("Generic Repository design pattern");

            // Generic 
            IGenericRepository<Employee> repository = null;
            repository = new GenericRepository<Employee>();

            try
            {
                var employee = new Employee() { Name = "Amit", Salary = 60000, Gender = "Male", Dept = "IT" };
                repository.Add(employee);
                repository.Save();

                repository = new GenericRepository<Employee>();
                var id = repository.GetById(1);

                repository = new GenericRepository<Employee>();
                var all = repository.GetAll();

                repository = new GenericRepository<Employee>();
                var id1 = repository.GetById(1);

                if (id1 != null)
                {
                    id1.Name = "Amit Naik";
                    repository.Update(id1);
                    repository.Save();

                    repository = new GenericRepository<Employee>();
                    repository.Delete(1);
                    repository.Save();
                }
                else
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error : ID not found");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error :{ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            #endregion

            #region Non Generic Repository Design Pattern

            ConsoleColorMethod("Non Generic Repository design pattern");

            // Generic 
            EmployeeRepository employeeRepository = null;
            employeeRepository = new EmployeeRepository();

            try
            {
                var employee = new Employee() { Name = "Shweta", Salary = 600000, Gender = "Female", Dept = "IT" };
                employeeRepository.Add(employee);
                employeeRepository.Save();

                employeeRepository = new EmployeeRepository();
                var id = employeeRepository.GetById(1);

                employeeRepository = new EmployeeRepository();
                var all = employeeRepository.GetAll();

                employeeRepository = new EmployeeRepository();
                var id1 = employeeRepository.GetById(2);

                if (id1 != null)
                {
                    id1.Name = "Shweta Naik";
                    employeeRepository.Update(id1);
                    employeeRepository.Save();

                    employeeRepository = new EmployeeRepository();
                    employeeRepository.Delete(1);
                    employeeRepository.Save();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error : ID not found");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error :{ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            #endregion

            #region UOW design pattern for Generic Repository

            ConsoleColorMethod("UOW design pattern for Generic Repository");

            UOW_Generic<Employee> uowG = new UOW_Generic<Employee>(new EmployeeDBContext());

            try
            {
                var employee = new Employee() { Name = "Shweta", Salary = 600000, Gender = "Female", Dept = "IT UOW generic" };

                uowG.employeeRepository.Add(employee);
                uowG.Complete();
            }
            catch (Exception ex)
            {

                uowG.Dispose();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error : {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            #endregion

            #region UOW design pattern for Non Generic Repository

            ConsoleColorMethod("UOW design pattern for Non Generic Repository");

            UnitOfWork uow = new UnitOfWork(new EmployeeDBContext());

            try
            {
                var employee = new Employee() { Name = "Shweta", Salary = 600000, Gender = "Female", Dept = "IT UOW non generic" };

                uow.employeeRepository.Add(employee);
                uow.Complete();
            }
            catch (Exception ex)
            {

                uow.Dispose();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error : {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;

            }
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

            ConsoleColorMethod("Replace IF with Polyphormism");

            Console.WriteLine("Enter your skill set for job opening (like JavaScript,c#,Net)");

            //string knowledge = Console.ReadLine();
            string knowledge = "javascript";

            Console.WriteLine(SimpleFactoryRIP.Create(knowledge.ToLower()));
            #endregion

            #region Abstract Factory design pattern

            ConsoleColorMethod("Abstract Factory design pattern");

            var investmentPrivateFactory = InvestmentFactory.CreateFactory("Private");
            string productType = investmentPrivateFactory.GetProduct("ICICI").FD(1000);

            Console.WriteLine(productType);

            Console.WriteLine(InvestmentFactory.CreateFactory("Public").GetProduct("SBI").MF(50000));
            #endregion

            #region IOC DI Unity

            ConsoleColorMethod("IOC DI Unity");

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IRechargeHandler, RechargeJIO>("JIO");
            container.RegisterType<IRechargeHandler, RechargeVodafone>("Vodafone");

            IRechargeHandler recharge = container.Resolve<IRechargeHandler>("JIO");
            recharge.DoRecharge();

            #endregion

            #region Lazy loading

            ConsoleColorMethod("Lazy loading");
            Console.WriteLine("Enter your skill set for job opening (like JavaScript,c#,Net)");

            string knowledgeLazyLoading = "Javascript";

            Console.WriteLine(LazyLoadingFactory.Create(knowledgeLazyLoading.ToLower()));

            // When we call second time, it doesn't add to temp Dictionary in LazyLoadingFactory class file
            Console.WriteLine(LazyLoadingFactory.Create(knowledgeLazyLoading.ToLower()));

            #endregion



            #region Bridge design pattern

            ConsoleColorMethod("Bridge design pattern");
            Payment order = new CardPayment();
            order.IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order.IPaymentSystem = new ICICIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order.IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();
            #endregion


            #region Composite design pattern
            ConsoleColorMethod("Composite design pattern");
            IEmployeeCDP John = new EmployeeCDP("John", "IT");
            IEmployeeCDP Mike = new EmployeeCDP("Mike", "IT");
            IEmployeeCDP Jason = new EmployeeCDP("Jason", "HR");
            IEmployeeCDP Eric = new EmployeeCDP("Eric", "HR");
            IEmployeeCDP Henry = new EmployeeCDP("Henry", "HR");

            IEmployeeCDP James = new ManagerCDP("James", "IT")
            { SubOrdinates = { John, Mike } };
            IEmployeeCDP Philip = new ManagerCDP("Philip", "HR")
            { SubOrdinates = { Jason, Eric, Henry } };

            IEmployeeCDP Bob = new ManagerCDP("Bob", "Head")
            { SubOrdinates = { James, Philip } };
            James.GetDetails(1);
            #endregion


            #region Facade design pattern
            ConsoleColorMethod("Facade design pattern");

            AadharFacade aadharFacade = new AadharFacade();
            aadharFacade.CreateAadhar();
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
