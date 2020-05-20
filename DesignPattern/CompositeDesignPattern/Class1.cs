using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    public interface IEmployeeCDP
    {
        void GetDetails(int indentation);
    }

    public class EmployeeCDP : IEmployeeCDP
    {
        public EmployeeCDP(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
        }

        public string Name { get; set; }
        public string Department { get; set; }

        public void GetDetails(int indentation)
        {
            Console.WriteLine(string.Format("{0}- Name:{1}, Dept:{2} (Leaf) ",
                new String('-', indentation), this.Name.ToString(),
                this.Department));

        }
    }

    public class ManagerCDP : IEmployeeCDP
    {
        public List<IEmployeeCDP> SubOrdinates;
        public ManagerCDP(string name, string dept)
        {
            this.Name = name;
            this.Department = dept;
            SubOrdinates = new List<IEmployeeCDP>();
        }
        public string Name { get; set; }
        public string Department { get; set; }
        public void GetDetails(int indentation)
        {
            Console.WriteLine();
            Console.WriteLine(string.Format("{0}+ Name:{1}, " +
                "Dept:{2} - Manager(Composite)",
                new String('-', indentation), this.Name.ToString(),
                this.Department));
            foreach (IEmployeeCDP component in SubOrdinates)
            {
                component.GetDetails(indentation + 1);
            }
        }
    }
}
