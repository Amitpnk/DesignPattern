# DesignPattern

Few important design pattern

## What are design patterns?

Design patterns are documented tried and tested solutions for recurring problems in a given context

## Which are the three main categories of design patterns?

- Creational
- Structural
- Behavioral 

According to GOF design pattern

| Creational  | Strucural  | Behavioral | 
| ------------- | ------------- | ------------- |
| Abstract Factory  | [Adapter](Adapter)  | Chain of Resposibility | 
| [Builder](Builder) | Bridge  | Command |
| [Factory](Factory) | Composite  | Interpreter |
| [Prototype](Prototype) | [Decorator](Decorator)  | [Iterator](Iterator) |
| [Singleton](Singleton) | Facade  | [Mediator](Mediator) |
| - | Flyweight  | [Memento](Memento) |
| - | Proxy  | Observer |
| - | -  | State |
| - | -  | Strategy |
| - | -  | [Template method](Templatemethod) |
| - | -  | Visitor |

## Table of Contents

- [Sending Feedback](#sending-feedback)
- Factory
- Repository
- Template
- Singleton

## Sending Feedback

For feedback can drop mail to my email address amit.naik8103@gmail.com or you can create [issue](https://github.com/Amitpnk/angular-application/issues/new)

## Sample application with each labs

## Factory Patterns

```C#
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
```

```C#
    IFactory factory = CreateFactory.GetObject(ObjectType.Customer);
        Console.WriteLine("Get customer object : " + factory.getName());
```

## Repository Patterns

```C#
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

```

```C#
      IRepoContext<CustomerRepository> repoContext = FactoryRepository<CustomerRepository>.Create();
            repoContext.Add(new CustomerRepository());
            repoContext.Save();
```
