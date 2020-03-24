using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{


    public enum ObjectType
    {
        Customer,
        Supplier
    }

    class CreateFactory
    {
        public static IFactory GetObject(ObjectType type)
        {
            IFactory factory = null;

            switch (type)
            {
                case ObjectType.Customer:
                    factory = new CustomerFactory();
                    break;

                case ObjectType.Supplier:
                    factory = new SupplierFactory();
                    break;

                default:
                    throw new NotSupportedException();
                    
            }

            return factory;
        }
    }

    interface IFactory
    {
        string getName();
    }

    class CustomerFactory : IFactory
    {
       
        public string getName()
        {
            return "Customer name";
        }
    }

    class SupplierFactory : IFactory
    {
       

        public string getName()
        {
            return "Supplier name";
        }
    }
}
