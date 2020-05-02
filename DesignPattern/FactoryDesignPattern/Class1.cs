using System;

namespace FactoryDesignPattern
{

    public enum ObjectType
    {
        Customer,
        Supplier
    }

   public class CreateFactory
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

    public interface IFactory
    {
        string getName();
    }

    public class CustomerFactory : IFactory
    {

        public string getName()
        {
            return "Customer name";
        }
    }

    public class SupplierFactory : IFactory
    {


        public string getName()
        {
            return "Supplier name";
        }
    }
}
