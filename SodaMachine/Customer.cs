using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //member variables
        public Wallet wallet;
        public Backpack backpack;
        //public int sodaSelection;
        
        //constructor
        public Customer()
        {
            wallet = new Wallet();
            backpack = new Backpack();  
        }

        //member methods
        public double PaymentProcess()
        {
            List <Coin> paymentList = SelectCoins();
            double totalPayment = Math.DetermineValue(paymentList);
            return totalPayment;
        }

        public List<Coin> SelectCoins() //only adding quarters to the list.
        {
            List<int> selectedCoins = UserInterface.PickCoins();
            List<Coin> moneyPassedIn = new List<Coin>();
            foreach (int choice in selectedCoins)
            {
                if (selectedCoins.Contains(1))
                {
                    moneyPassedIn.Add(wallet.quarter);
                }
                else if (selectedCoins.Contains(2))
                {
                    moneyPassedIn.Add(wallet.dime);
                }
                else if (selectedCoins.Contains(3))
                {
                    moneyPassedIn.Add(wallet.penny);
                }
            }
            return moneyPassedIn;
        }
    }
}
