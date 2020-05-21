using System;

namespace StateDesignPattern
{
    public interface IVendingMachineState
    {
        void SelectProductAndInsertMoney(int amount, String productName);
        void DispenseProduct();
    }

    public class NoMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine cannot dispense product because money is not inserted and product is not selected");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine(amount + "Rs has been inserted and " + productName + " has been selected");
        }
    }

    public class HasMoneyState : IVendingMachineState
    {
        public void DispenseProduct()
        {
            Console.WriteLine("Vending Machine  dispensed the product ");
        }
        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            Console.WriteLine("Already Vending machine has money and product selected, So wait till it finish the current dispensing process");
        }
    }

    public class VendingMachine : IVendingMachineState
    {
        //Createing a variable to maintain the internal state
        public IVendingMachineState vendingMachineState { get; set; }
        //Initially the vending machine has NoMoneyState
        public VendingMachine()
        {
            vendingMachineState = new NoMoneyState();
        }

        public void SelectProductAndInsertMoney(int amount, string productName)
        {
            vendingMachineState.SelectProductAndInsertMoney(amount, productName);
            // Money has been inserted so vending Machine internal state 
            // changed to 'hasMoneyState'
            if (vendingMachineState is NoMoneyState)
            {
                vendingMachineState = new HasMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
        public void DispenseProduct()
        {
            vendingMachineState.DispenseProduct();
            // Product has been dispensed so vending Machine changed the
            // internal state to 'NoMoneyState'
            if (vendingMachineState is HasMoneyState)
            {
                vendingMachineState = new NoMoneyState();
                Console.WriteLine("VendingMachine internal state has been moved to : "
                                + vendingMachineState.GetType().Name);
            }
        }
    }
}
