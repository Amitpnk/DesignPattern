using System;
using System.Collections.Generic;

namespace IteratorDesignPattern
{
    public class Class1
    {
        void method()
        {
            List<string> listOfStrings = new List<string>();

            listOfStrings.Add("one");
            listOfStrings.Add("two");
            listOfStrings.Add("three");
            listOfStrings.Add("four");

            foreach (string s in listOfStrings)
            {
                Console.WriteLine(s);
            }

            IEnumerable<int> list = (IEnumerable<int>)listOfStrings;
            var x = list.GetEnumerator();

            var y = x.Current;

        }

    }
}
