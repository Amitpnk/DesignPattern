using System;
using System.Threading;

namespace FacadeDesignPattern
{
    interface IAadhar
    {
        void Capture();
        void Validate();
    }

    class BiometricInfo : IAadhar
    {
        public void Capture()
        {
            Console.WriteLine("Biometric Info is captured.");
        }

        public void Validate()
        {
            Console.WriteLine("Biometric Info is verified.");
        }
    }

    class DemographicInfo : IAadhar
    {
        public void Capture()
        {
            Console.WriteLine("Demographic Info is captured.");
        }

        public void Validate()
        {
            Console.WriteLine("Demographic Info is verified.");
        }
    }

    public class AadharFacade
    {
        DemographicInfo demographicInfo;
        BiometricInfo biometricInfo;

        public AadharFacade()
        {
            demographicInfo = new DemographicInfo();
            biometricInfo = new BiometricInfo();
        }

        public void CreateAadhar()
        {
            Console.WriteLine("*****Creating Aadhar*****");

            Thread.Sleep(2000);
            demographicInfo.Capture();

            Thread.Sleep(2000);
            demographicInfo.Validate();

            Thread.Sleep(2000);
            biometricInfo.Capture();

            Thread.Sleep(2000);
            biometricInfo.Validate();

            Thread.Sleep(2000);
            Console.WriteLine("*****Aadhar Creation Done*****");
        }
    }
}
