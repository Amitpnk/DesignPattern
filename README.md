# DesignPattern

Few important design pattern

## What are design patterns?

Design patterns are documented tried and tested solutions for recurring problems in a given context

## Main categories of design patterns

| Creational  | Strucural  | Behavioral |  Other design pattern |
| --- | --- | --- | --- |
| [Abstract Factory](#abstract-factory)  | [Adapter](#adapter)  |  Chain of Resposibility | [Repository design pattern](Repository-design-pattern) |
| [Builder](Builder) | [Bridge](Bridge)  | Command | UOW |
| [Factory](#factory-pattern) | [Composite](Composite)  | Interpreter | CQRS |
| [Prototype](Prototype) | [Decorator](Decorator)  | [Iterator](Iterator) | [Inversion Of Control and Dependency Injection](IOC-DI) |
| [Singleton](#singleton) | [Facade](Facade)  | [Mediator](Mediator) | [Lazy Loading](lazy-loading) |
| - | Flyweight  | [Memento](Memento) |
| - | Proxy  | Observer |
| - | -  | State |
| - | -  | Strategy |
| - | -  | [Template method](Templatemethod) |
| - | -  | Visitor |

## Sending Feedback

For feedback can drop mail to my email address amit.naik8103@gmail.com or you can create [issue](https://github.com/Amitpnk/DesignPattern/issues/new)

## Design Principle

1. SOLID
2. YAGNI
3. KIS
4. DRY

## Design Pattern

### Singleton

In this pattern, only one single instance can be created throughout the lifetime of the application. From the starting point of the application to the end of the application execution, only one instance takes care of achieving the functionalities.

Example: 

1. Configuration Management

In case if you need to do configuration at starting of application and throughtout life of application. 

2. Logging

Logging is one of the common requirements of the application, where the single logger instance would be available at the start of the application. When we use Log4Net or NLog for logging, a single logger instance will take care of logging

### Factory pattern

In Factory pattern, the factory class wants to decide which subclass will be used to create the objects .This object creation is determined dynamically depending on the situation or condition.

1. Different types of reports

In the application, we have to create different types of reports, like excel, pdf, crystal report etc. Based on the user selection report type, we can create the instance of different report class type.

2. Different types of accounts in a banking system

The banking system has different types of accounts for customers, like Checking account, Saving account, or Loan account. Based on the different types of accounts, being passed from the customer, the specific account instance will be created and the required action will be called from that object

### Abstract Factory

Abstract factory design pattern creates a factory of related or group of objects without explicitly specifying their classes

### Adapter

Adapter pattern is a pattern which is used to match two incompatible interfaces. When we have two different interfaces which do not match, the adapter classes work as a wrapper to match it.

Example

Consider we have a third party tool which does not have proper interface or code to fit into our application. To match it, we need to extend the third party code as a wrapper

### Observer

It is the pattern which communicates to the subscribed objects when there is a change in the subject. 

Example

Customers get notified by email, message in the mobile, hard copy of letter in postal address when the loan application is approved by the bank.

### Facade

When we design a system, we call different services, external service calls, database calls which altogether makes the system complex. Actually, exposing internal calls is not important to the clients. Only client needs to call some code that internally can communicate to the different systems or different services involved in it.

Façade design pattern is used when a system is very complex or difficult to understand how it is working internally.

Example

Different Bank ATM cards Working process in a single ATM Machine. When withdrawing money from an ATM we are not aware of how the transaction happens internally from the same bank or a different bank

### Template

The same business rule applies for the entire client with some variation. The method skeleton can be put in an abstract class and different client implementation can be put in the derived class.

Example

In a report generation module, customer requirement is to generate different type of reports either HTMLReport, PDF report , excel report or in a flat file report where the report header , logo and footer keep constant 

### Chain of Responsibility

In this pattern we have chains of objects which keep on passing on different chains.

Loan or Leave approval process where a request passes between multiple stages. We apply for a loan it goes to validation, verification, approval process. In each process there should be a set of rules where they can approve a certain stage or pass the request chain to next immediate chain flow.

Another example to understand the chain of responsibility is the clarification on the requirement in an agile team.
Development team gets a defect which has a complex algorithm

Development team reached to QA team, QA team tried to answer the questions but is unable to answer. QA team emailed the questions to product owner. The product owner finally passed the question to stakeholder. The Email chain keeps increasing from developer to QA then Product owner and finally the stakeholder. If any of the chain can know the perfect answer the chain stops there

### Decorator

Decorator pattern attaches additional responsibilities to an object dynamically and transparently. Decorators provide a flexible alternative to sub classing for extending functionality.
 
In any organization we see lot of projects, many variety of skill sets depending upon the customer projects.

 
In a MS.NET team different teams are there, but the base skill sets are ASP.NET, C#, SQL Server.

The new requirement 1 will keep on asking give me candidates with additional skill sets of WCF, WEB API as a top up skills

The new requirement 2 will keep on asking give me candidates with additional skill sets of WCF, ANGULAR JS as a top up skills

The new requirement 3 will keep on asking give me candidates with additional skill sets of WEB API, ANGULAR, WCF and ASP.NET MVC top up skills

On this example, the Base Skill set object gets appended to different skill sets dynamically, based on the project need.


## Credits

* [C-sharpcorner GOF](https://www.c-sharpcorner.com/article/understanding-gof-design-pattern-with-simple-example/)
