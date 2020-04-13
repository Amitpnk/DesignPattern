using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorDesignPattern
{
    // Iterator pattern helps you loop through a collection in Aggregate root condition
    public class Customer
    {
        // if we keep private then we can achieve aggregate root design pattern
        // if we keep pubilc then we are isolating aggregate root design pattern
        private List<Address> addresses = new List<Address>();

        // Too loop addresses in outside the class then we will implement IEnumerable (Iterator design pattern)

        // IEnumerable is statless iteration and IEnumerator is statefull iteration
        public IEnumerable<Address> GetAddresses()
        {
            // Tolist to create new reference type
            return addresses.ToList<Address>();
        }

        public IEnumerator<Address> GetEnumerator()
        {
            foreach (var val in addresses)
            {
                //Console.WriteLine($"customer address type  : {val.Type}");
                yield return val;
            }
        }


        // Any references from outside the aggregate should only go to the aggreate root
        public void Add(Address o)
        {
            foreach (var x in addresses)
            {
                if (o.Type == x.Type)
                {
                    throw new Exception("Type can not be duplicates");
                }
            }
            addresses.Add(o);
        }
    }

    public class Address
    {
        public int Type { get; set; }
        public string Street { get; set; }
    }
}
