using System;

namespace ChainOfResponsibilityDesignPattern
{
    public class Method1 : ICheck
    {
        private ICheck _check;

        public bool HasValue { get; set; }

        public int ExcuteQuery()
        {
            return 1;
        }

        public void Process()
        {
            if (ExcuteQuery() > 0)
            {
                Console.WriteLine("Method 1");
                _check.Process();
            }
            else
            {
                this.HasValue = true;

            }
        }

        public void SetNext(ICheck check)
        {
            _check = check;
        }
    }
}
