using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPattern
{
    public interface IHandler
    {
        void Handle();
        IHandler SetNext(IHandler handler);
        int ExecuteQuery();
    }
}
