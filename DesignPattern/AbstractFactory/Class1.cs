using System;

namespace AbstractFactoryDesignPattern
{
    // Creating Abstract product
    public interface Investment
    {
        string FD(double amount);
        string MF(double amount);
    }

    // Creating Concrete Product
    public class SBI : Investment
    {
        public string FD(double amount)
        {
            return "Fix Deposit of INR " + amount + " is done in SBI";
        }

        public string MF(double amount)
        {
            return "Mutual fund of INR " + amount + " is done in SBI";
        }
    }

    // Creating Concrete Product
    public class ICICI : Investment
    {
        public string FD(double amount)
        {
            return "Fix Deposit of INR " + amount + " is done in ICICI";
        }

        public string MF(double amount)
        {
            return "Mutual fund of INR " + amount + " is done in ICICI";
        }
    }

    public class GovtFund : Investment
    {
        public string FD(double amount)
        {
            return "Fix Deposit of INR " + amount + " is done in GovtFund";
        }

        public string MF(double amount)
        {
            return "Mutual fund of INR " + amount + " is done in GovtFund";
        }
    }

    public class RelianceFund : Investment
    {
        public string FD(double amount)
        {
            return "Fix Deposit of INR " + amount + " is done in RelianceFund";
        }

        public string MF(double amount)
        {
            return "Mutual fund of INR " + amount + " is done in RelianceFund";
        }
    }



    //Creating the Abstract Factory
    public abstract class InvestmentFactory
    {
        public abstract Investment GetProduct(string InvestType);
        public static InvestmentFactory CreateFactory(string InvestType)
        {
            if (InvestType.Equals("Private"))
                return new PrivateSectorFactory();
            else
                return new PublicSectorFactory();
        }
    }


    //Creating Concrete Factory
    public class PrivateSectorFactory : InvestmentFactory
    {
        public override Investment GetProduct(string productType)
        {
            if (productType.Equals("ICICI"))
            {
                return new ICICI();
            }
            else if (productType.Equals("RelianceFund"))
            {
                return new RelianceFund();
            }
            else
                return null;
        }
    }

    public class PublicSectorFactory : InvestmentFactory
    {
        public override Investment GetProduct(string productType)
        {
            if (productType.Equals("SBI"))
            {
                return new SBI();
            }
            else if (productType.Equals("RelianceFund"))
            {
                return new GovtFund();
            }
            else
                return null;
        }
    }



}
