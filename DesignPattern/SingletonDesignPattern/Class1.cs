using System;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = null;

        private Singleton()
        {

        }


        public static Singleton getInstance()
        {

            if (instance == null)
            {
                return new Singleton();
            }
            return instance;

        }


        public void myMethod()
        {
            Console.WriteLine("This is my singleton method");
        }

    }
}
