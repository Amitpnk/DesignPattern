﻿//using AdapterDesignPattern;
//using BuilderDesignPattern;
//using FactoryDesignPattern;
//using DecoratorDesignPattern;
//using PrototypeDesignPattern;
//using AggregateRootDesignPattern;
using IteratorDesignPattern;
using System;

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


            //#region Aggregate root design pattern

            //Customer customer = new Customer();

            //customer.Add(new Address { Type = 1 });
            //customer.Add(new Address { Type = 1 });

            //#endregion


            #region Iterator design pattern

            Customer customer = new Customer();

            customer.Add(new Address { Type = 1 });
            customer.Add(new Address { Type = 2 });

            // we can avoid manipulating methods like below in Iterator design pattern
            //customer.addresses.Add(new Address { Type = 3 });



            foreach (var item in customer.GetAddresses())
            {
                Console.WriteLine($"customer address type  : {item.Type}");
            }


            //var x = customer.GetEnumerator();


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