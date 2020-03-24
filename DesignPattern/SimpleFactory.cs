using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{

    public interface ICustomer
    {
        void CalculateBill();
    }

    public class GoldCustomer : ICustomer
    {
        public void CalculateBill()
        {
            Console.WriteLine("Gold customer - calculate bill");
        }
    }

    public class SilverCustomer : ICustomer
    {
        public void CalculateBill()
        {
            Console.WriteLine("Silver customer - calculate bill");
        }
    }


    public static class SimpleFactory
    {
        public static ICustomer Create(int i)
        {
            if (i == 0)
            {
                return new GoldCustomer();
            }
            else
            {
                return new SilverCustomer();
            }
        }
    }
}
