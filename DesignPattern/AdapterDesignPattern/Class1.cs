using System;

namespace AdapterDesignPattern
{

    public interface IExport
    {
        void Export();
    }
    public class PDF_Class : IExport
    {
        public void Export()
        {
            Console.WriteLine("Export PDF");
        }

    }

    public class TXT_Class : IExport
    {
        public void Export()
        {
            Console.WriteLine("Export TXT");
        }


    }

    // which we don't have control of code
    public class XLS_ClassThirdParty
    {
        public void ExportThirdParty()
        {
            Console.WriteLine("Export XLS");
        }

    }


    // Objects based Adapter design pattern
    public class XLS_Class_ObjectAdapter : IExport
    {
        XLS_ClassThirdParty thirdParty = new XLS_ClassThirdParty();

        public void Export()
        {
            thirdParty.ExportThirdParty();
        }
    }

    // Class based Adapter design pattern
    public class XLS_Class_ClassAdapter : XLS_ClassThirdParty, IExport
    {
        public void Export()
        {
            ExportThirdParty();
        }

    }

}