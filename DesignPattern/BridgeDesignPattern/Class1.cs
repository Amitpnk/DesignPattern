using System;

namespace BridgeDesignPattern
{
    // Implementor interface
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }

    //ConcreteImplementor 
    public class CitiPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank gateway for  " + paymentSystem);
        }
    }

    public class ICICIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank gateway for  " + paymentSystem);
        }
    }

    // Abstraction
    public abstract class Payment
    {
        public IPaymentSystem IPaymentSystem;
        public abstract void MakePayment();
    }

    //RefinedAbstraction
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            IPaymentSystem.ProcessPayment("Card Payment");
        }
    }

    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            IPaymentSystem.ProcessPayment("NetBanking Payment");
        }
    }
}
