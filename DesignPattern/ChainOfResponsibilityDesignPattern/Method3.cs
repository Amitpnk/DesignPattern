using System;

namespace ChainOfResponsibilityDesignPattern
{
    public class Method3 : IHandler
    {
        private IHandler _next;

        public bool HasValue { get; set; }

        public int ExecuteQuery()
        {
            return 0;
        }

        public void Handle()
        {
            if (ExecuteQuery() > 0)
            {
                Console.WriteLine("Method 3");
            }
            else
            {
                this.HasValue = true;

            }
        }

        public IHandler SetNext(IHandler handler)
        {
            _next = handler;
            return _next;
        }
    }
}
