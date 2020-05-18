using System;
using System.Collections.Generic;

namespace CleanCode
{
    public class Class1
    {
        decimal CleanCodeNamingMatters()
        {
            List<decimal> p = new List<decimal>() { 5.50m, 1.48m };
            decimal t = 0;
            foreach (var i in p)
            {
                t += i;
            }
            return t;
        }
    }
}
