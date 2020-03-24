using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    sealed class SingletonDesignPattern
    {
        private static readonly SingletonDesignPattern instance= null;

        private SingletonDesignPattern()
        {

        }

 
        public static SingletonDesignPattern getInstance()
        {

            if (instance == null)
            {
                return new SingletonDesignPattern();
            }
            return instance;

        }


        public void myMethod()
        {
            Console.WriteLine("This is my singleton method");
        }

    }
}
