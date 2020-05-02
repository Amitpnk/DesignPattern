using AutoMapper;
using System;

namespace MementoDesignPattern
{

    public interface IEmployee
    {

        string Name { get; set; }
        string Department { get; set; }
        Employee GetClone();
        Employee Revert();

    }


    public interface IMemento
    {
        Employee GetClone();
        Employee Revert();

    }

    public class Employee : IEmployee, IMemento
    {
        private IEmployee employee = null;
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee GetClone()
        {
            // Memberwise clone creates a fresh object rather than point BYREF
            employee = (IEmployee)this.MemberwiseClone();
            return (Employee)employee;
        }

        public Employee Revert()
        {
            // Can implement auto mapper
            this.Name = employee.Name;
            this.Department = employee.Department;
            return this;
        }
    }
}
