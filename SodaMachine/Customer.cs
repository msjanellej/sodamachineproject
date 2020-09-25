using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //member variables
        public Wallet wallet;
        public Backpack backpack;
        
        public int sodaSelection;
        List<Coin> totalCoins;

        //constructor
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();
            totalCoins = new List<Coin>();
            
        }

        //member methods

        //public void SelectPayment()
        //{
        //    UserInterface.PickCoins();
            
        //}
        public void RemovePaymentfromWallet()
        {

        }
        // write static method (perhaps own class) that takes in the items from the list and returns value. this method
        // can be used on the soda machine as well. Maybe math class. 


    }
}
