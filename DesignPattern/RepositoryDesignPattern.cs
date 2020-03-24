using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    public interface IRepoContext<T> where T : class
    {
        bool Add(T obj); // in memory
        void Save(); // save to DB
    }

    public class CustomerRepository
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }

    }

    public class SupplierRepository
    {
        public string SupplierCode { get; set; }
    }

    public class DAL<T> : IRepoContext<T> where T : class
    {
        List<T> listObj = new List<T>();

        // In memory
        public bool Add(T obj)
        {
            //var x = obj is CustomerRepository;


            Console.WriteLine($"Add {obj.GetType().Name} to DB");
            this.listObj.Add(obj);
            return true;
        }



        public void Save()
        {
            Console.WriteLine($"Save changes to DB");
        }
    }


    public abstract class TemplateDAL<T> : IRepoContext<T> where T : class
    {
        List<T> listObj = new List<T>();

        // In memory
        public bool Add(T obj)
        {
            Console.WriteLine($"Add {obj.GetType().Name} to DB");
            this.listObj.Add(obj);
            return true;
        }

        public abstract void Execute(T obj);

        public void Save()
        {
            foreach (var item in listObj)
            {
                Execute(item);
            }

            Console.WriteLine($"Save changes to DB");
        }
    }

    public class DALCustomerRepo : TemplateDAL<CustomerRepository>
    {
        public override void Execute(CustomerRepository obj)
        {
            Console.WriteLine("Execute to DB");
        }
    }


    // Factory in repository
    public static class FactoryRepository<T> where T : class
    {
        public static IRepoContext<T> Create()
        {
            return (IRepoContext<T>)new DALCustomerRepo();
        }
    }
}
