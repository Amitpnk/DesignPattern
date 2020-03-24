using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDesignPattern
{
    public abstract class TemplateHiringProcess
    {
        public void HireFreshers()
        {
            FirstRoundTest();
            GroupDiscussion();
            TechnicalInterview();
            HR_Interview();
        }

        public abstract void FirstRoundTest();

        private void GroupDiscussion()
        {
            Console.WriteLine("Conduct group discussion" );
        }
        public abstract void TechnicalInterview();
        private void HR_Interview()
        {
            Console.WriteLine("Conduct HR Interviews" );
        }

    }

    public class CSDepartment : TemplateHiringProcess
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Conduct CS First round test" );
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Conduct CS Technical round test" );
        }
    }


    public class EEEDepartment : TemplateHiringProcess
    {
        public override void FirstRoundTest()
        {
            Console.WriteLine("Conduct EEE First round test" );
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Conduct EEE Technical round test" );
        }
    }


}
