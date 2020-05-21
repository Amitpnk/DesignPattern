using System;

namespace ChainOfResponsibilityDesignPattern
{
    public abstract class NewVehicle
    {
        protected NewVehicle process;

        public void SetProcess(NewVehicle process)
        {
            this.process = process;
        }

        public abstract void Proceed(string request);
    }

    public class SelectVehicle : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Vehicle Selection Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while selecting vehicle.");
                process = null;
            }
        }
    }

    public class MakePayment : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Payment Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while doing payment.");
                process = null;
            }
        }
    }

    public class GenerateServiceBook : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Generating Service Book Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while generating service book.");
                process = null;
            }
        }
    }

    public class Insurance : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Insurance Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while doing insurance.");
                process = null;
            }
        }
    }

    public class Delivery : NewVehicle
    {
        public override void Proceed(string request)
        {
            try
            {
                Console.WriteLine("Delivery Process Started");

                if (process != null)
                {
                    process.Proceed(request);
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Error while delivering vehicle.");
                process = null;
            }
        }
    }
}
