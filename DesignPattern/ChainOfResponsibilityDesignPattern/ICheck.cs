using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public interface ICheck
    {
        void Process();
        void SetNext(ICheck check);
        int ExcuteQuery();
    }
}
