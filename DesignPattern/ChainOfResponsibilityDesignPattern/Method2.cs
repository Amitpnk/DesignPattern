using System;

namespace ChainOfResponsibilityDesignPattern
{
    public class Method2 : IHandler
    {
        private IHandler _next;

        public bool HasValue { get; set; }

        public int ExecuteQuery()
        {
            return 1;
        }

        public void Handle()
        {
            if (ExecuteQuery() > 0)
            {
                Console.WriteLine("Method 2");
                _next.Handle();
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
