using System;

namespace IOC_DI_Unity
{
    public interface IRechargeHandler
    {
        void DoRecharge();

    }
    public class RechargeJIO : IRechargeHandler
    {
        public void DoRecharge()
        {
            Console.WriteLine("Recharge for JIO is done successfully.");
        }
    }

    public class RechargeVodafone : IRechargeHandler
    {
        public void DoRecharge()
        {
            Console.WriteLine("Recharge for Vodafone is done successfully.");
        }
    }
}
