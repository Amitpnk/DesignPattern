using System;
using System.Collections.Generic;

namespace AggregateRootDesignPattern
{
    // Aggregate root is aggregation relationship contained referenced via the root and not directly
    // Aggregate root is complicated so beware of your root logic becoming complex



    public class Customer
    {

        private List<Address> addresses = new List<Address>();

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
