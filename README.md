# DesignPattern

Few important design pattern

## What are design patterns?

Design patterns are documented tried and tested solutions for recurring problems in a given context

## Which are the three main categories of design patterns?

- Creational
- Structural
- Behavioral 

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